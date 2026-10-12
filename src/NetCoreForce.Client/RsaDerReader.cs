using System;
using System.Security.Cryptography;

namespace NetCoreForce.Client
{
    /// <summary>
    /// Reads DER-encoded PKCS#1 and PKCS#8 RSA private keys into <see cref="RSAParameters"/>
    /// <para>.NET Standard 2.0 and .NET Framework have no built-in PKCS#1/PKCS#8 import - newer frameworks use RSA.ImportRSAPrivateKey/ImportPkcs8PrivateKey instead.
    /// Compiled for all frameworks so it can be tested against the built-in import.</para>
    /// </summary>
    internal static class RsaDerReader
    {
        private const byte IntegerTag = 0x02;
        private const byte OctetStringTag = 0x04;
        private const byte ObjectIdentifierTag = 0x06;
        private const byte SequenceTag = 0x30;

        private const string InvalidKeyMessage = "The private key is not a valid DER-encoded RSA private key";

        //rsaEncryption, 1.2.840.113549.1.1.1
        private static readonly byte[] RsaEncryptionOid = { 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01 };

        /// <summary>
        /// Read a PKCS#8 PrivateKeyInfo containing an RSA private key ("BEGIN PRIVATE KEY")
        /// </summary>
        /// <exception cref="ArgumentException">The data is not a valid PKCS#8 RSA private key</exception>
        internal static RSAParameters ReadPkcs8(byte[] der)
        {
            if (der == null) throw new ArgumentNullException(nameof(der));

            //PrivateKeyInfo ::= SEQUENCE { version INTEGER, privateKeyAlgorithm AlgorithmIdentifier, privateKey OCTET STRING, attributes [0] OPTIONAL }
            DerReader privateKeyInfo = new DerReader(der).ReadSequence();
            privateKeyInfo.Read(IntegerTag);

            DerReader algorithm = privateKeyInfo.ReadSequence();
            if (!BytesEqual(algorithm.Read(ObjectIdentifierTag), RsaEncryptionOid))
            {
                throw new ArgumentException("The private key is not an RSA key");
            }

            return ReadPkcs1(privateKeyInfo.Read(OctetStringTag));
        }

        /// <summary>
        /// Read a PKCS#1 RSAPrivateKey ("BEGIN RSA PRIVATE KEY")
        /// </summary>
        /// <exception cref="ArgumentException">The data is not a valid PKCS#1 RSA private key</exception>
        internal static RSAParameters ReadPkcs1(byte[] der)
        {
            if (der == null) throw new ArgumentNullException(nameof(der));

            //RSAPrivateKey ::= SEQUENCE { version, modulus, publicExponent, privateExponent, prime1, prime2, exponent1, exponent2, coefficient }
            DerReader rsaPrivateKey = new DerReader(der).ReadSequence();

            byte[] version = TrimLeadingZeros(rsaPrivateKey.Read(IntegerTag));
            if (version.Length != 0)
            {
                //version 1 is a multi-prime key, which RSAParameters can't represent
                throw new ArgumentException("Multi-prime RSA private keys are not supported");
            }

            byte[] modulus = TrimLeadingZeros(rsaPrivateKey.Read(IntegerTag));
            byte[] exponent = TrimLeadingZeros(rsaPrivateKey.Read(IntegerTag));
            if (modulus.Length == 0 || exponent.Length == 0)
            {
                throw new ArgumentException(InvalidKeyMessage);
            }

            //.NET Framework's ImportParameters requires D to be the modulus length, and the CRT values half of it
            int halfLength = (modulus.Length + 1) / 2;

            return new RSAParameters
            {
                Modulus = modulus,
                Exponent = exponent,
                D = PadToLength(rsaPrivateKey.Read(IntegerTag), modulus.Length),
                P = PadToLength(rsaPrivateKey.Read(IntegerTag), halfLength),
                Q = PadToLength(rsaPrivateKey.Read(IntegerTag), halfLength),
                DP = PadToLength(rsaPrivateKey.Read(IntegerTag), halfLength),
                DQ = PadToLength(rsaPrivateKey.Read(IntegerTag), halfLength),
                InverseQ = PadToLength(rsaPrivateKey.Read(IntegerTag), halfLength)
            };
        }

        /// <summary>
        /// Remove the leading zero bytes - DER integers are signed, so a positive value with the high bit set has a leading 0x00
        /// </summary>
        private static byte[] TrimLeadingZeros(byte[] value)
        {
            int start = 0;
            while (start < value.Length && value[start] == 0)
            {
                start++;
            }

            if (start == 0)
            {
                return value;
            }

            byte[] trimmed = new byte[value.Length - start];
            Buffer.BlockCopy(value, start, trimmed, 0, trimmed.Length);
            Array.Clear(value, 0, value.Length);
            return trimmed;
        }

        /// <summary>
        /// Left-pad an unsigned big-endian value with zeros to the given length
        /// </summary>
        private static byte[] PadToLength(byte[] value, int length)
        {
            byte[] trimmed = TrimLeadingZeros(value);
            if (trimmed.Length > length)
            {
                throw new ArgumentException(InvalidKeyMessage);
            }

            if (trimmed.Length == length)
            {
                return trimmed;
            }

            byte[] padded = new byte[length];
            Buffer.BlockCopy(trimmed, 0, padded, length - trimmed.Length, trimmed.Length);
            Array.Clear(trimmed, 0, trimmed.Length);
            return padded;
        }

        private static bool BytesEqual(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        /// <summary>
        /// Reads DER tag-length-value elements from a range of a byte array, checking every length against the range
        /// </summary>
        private class DerReader
        {
            private readonly byte[] _data;
            private readonly int _end;
            private int _position;

            internal DerReader(byte[] data) : this(data, 0, data.Length) { }

            private DerReader(byte[] data, int start, int end)
            {
                _data = data;
                _position = start;
                _end = end;
            }

            /// <summary>
            /// Read a SEQUENCE, returning a reader over its contents
            /// </summary>
            internal DerReader ReadSequence()
            {
                int length = ReadHeader(SequenceTag);
                DerReader contents = new DerReader(_data, _position, _position + length);
                _position += length;
                return contents;
            }

            /// <summary>
            /// Read an element with the expected tag, returning a copy of its contents
            /// </summary>
            internal byte[] Read(byte tag)
            {
                int length = ReadHeader(tag);
                byte[] contents = new byte[length];
                Buffer.BlockCopy(_data, _position, contents, 0, length);
                _position += length;
                return contents;
            }

            /// <summary>
            /// Read the tag and length, returning the length of the contents
            /// </summary>
            private int ReadHeader(byte tag)
            {
                if (ReadByte() != tag)
                {
                    throw new ArgumentException(InvalidKeyMessage);
                }

                int length = ReadByte();
                if (length >= 0x80)
                {
                    //long form - the low bits are the number of length bytes. 0x80 is the indefinite form, which DER doesn't allow
                    int lengthBytes = length & 0x7F;
                    if (lengthBytes == 0 || lengthBytes > 3)
                    {
                        throw new ArgumentException(InvalidKeyMessage);
                    }

                    length = 0;
                    for (int i = 0; i < lengthBytes; i++)
                    {
                        length = (length << 8) | ReadByte();
                    }
                }

                if (length > _end - _position)
                {
                    throw new ArgumentException(InvalidKeyMessage);
                }

                return length;
            }

            private byte ReadByte()
            {
                if (_position >= _end)
                {
                    throw new ArgumentException(InvalidKeyMessage);
                }

                return _data[_position++];
            }
        }
    }
}
