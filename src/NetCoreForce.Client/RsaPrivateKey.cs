using System;
using System.IO;
using System.Security.Cryptography;

namespace NetCoreForce.Client
{
    /// <summary>
    /// Loads an RSA private key from PEM text, for the JWT Bearer flow (<see cref="AuthenticationClient.JwtBearerAsync"/>)
    /// <para>Supports unencrypted PKCS#8 ("BEGIN PRIVATE KEY") and PKCS#1 ("BEGIN RSA PRIVATE KEY") keys, as created by e.g. openssl, on all supported frameworks.</para>
    /// <para>For an encrypted key, use a .pfx/.p12 file instead: <c>new X509Certificate2(path, password).GetRSAPrivateKey()</c></para>
    /// </summary>
    public static class RsaPrivateKey
    {
        private const string Pkcs8Label = "PRIVATE KEY";
        private const string Pkcs1Label = "RSA PRIVATE KEY";
        private const string EncryptedPkcs8Label = "ENCRYPTED PRIVATE KEY";
        private const string EncryptedKeyMessage = "Encrypted private keys are not supported. Use a .pfx/.p12 file instead, e.g. new X509Certificate2(path, password).GetRSAPrivateKey(), or decrypt the key.";

        /// <summary>
        /// Load an RSA private key from PEM text. The text can contain other blocks (e.g. the certificate) - the first private key is used.
        /// </summary>
        /// <param name="pem">PEM text containing an unencrypted PKCS#8 or PKCS#1 RSA private key</param>
        /// <returns>The RSA key. The caller should dispose it.</returns>
        /// <exception cref="ArgumentException">The text doesn't contain a valid RSA private key</exception>
        /// <exception cref="NotSupportedException">The private key is encrypted</exception>
        public static RSA FromPem(string pem)
        {
            if (string.IsNullOrEmpty(pem)) throw new ArgumentNullException(nameof(pem));

            string otherLabel = null;
            int position = 0;

            while (TryReadBlock(pem, ref position, out string label, out string body))
            {
                if (label == Pkcs8Label || label == Pkcs1Label)
                {
                    //legacy OpenSSL encryption adds headers, e.g. "Proc-Type: 4,ENCRYPTED"
                    if (body.IndexOf(':') >= 0)
                    {
                        throw new NotSupportedException(EncryptedKeyMessage);
                    }

                    return Import(DecodeBase64(body), label == Pkcs8Label);
                }

                if (label == EncryptedPkcs8Label)
                {
                    throw new NotSupportedException(EncryptedKeyMessage);
                }

                otherLabel = otherLabel ?? label;
            }

            if (otherLabel != null)
            {
                throw new ArgumentException($"The PEM text contains no private key, only a \"{otherLabel}\" block. The JWT Bearer flow requires the private key matching the certificate uploaded to the external client app or connected app.", nameof(pem));
            }

            throw new ArgumentException("The PEM text contains no private key", nameof(pem));
        }

        /// <summary>
        /// Load an RSA private key from a PEM file. The file can contain other blocks (e.g. the certificate) - the first private key is used.
        /// </summary>
        /// <param name="path">Path to a PEM file containing an unencrypted PKCS#8 or PKCS#1 RSA private key</param>
        /// <returns>The RSA key. The caller should dispose it.</returns>
        /// <exception cref="ArgumentException">The file doesn't contain a valid RSA private key</exception>
        /// <exception cref="NotSupportedException">The private key is encrypted</exception>
        public static RSA FromPemFile(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));

            return FromPem(File.ReadAllText(path));
        }

        /// <summary>
        /// Read the next "-----BEGIN label-----" ... "-----END label-----" block
        /// </summary>
        private static bool TryReadBlock(string pem, ref int position, out string label, out string body)
        {
            const string BeginMarker = "-----BEGIN ";
            const string MarkerEnd = "-----";

            label = null;
            body = null;

            int begin = pem.IndexOf(BeginMarker, position, StringComparison.Ordinal);
            if (begin < 0) return false;

            int labelStart = begin + BeginMarker.Length;
            int labelEnd = pem.IndexOf(MarkerEnd, labelStart, StringComparison.Ordinal);
            if (labelEnd < 0) return false;

            label = pem.Substring(labelStart, labelEnd - labelStart);

            string endMarker = string.Concat("-----END ", label, MarkerEnd);
            int bodyStart = labelEnd + MarkerEnd.Length;
            int end = pem.IndexOf(endMarker, bodyStart, StringComparison.Ordinal);
            if (end < 0)
            {
                throw new ArgumentException($"The PEM text has no \"{endMarker}\" line", nameof(pem));
            }

            body = pem.Substring(bodyStart, end - bodyStart);
            position = end + endMarker.Length;
            return true;
        }

        private static byte[] DecodeBase64(string body)
        {
            try
            {
                //Convert.FromBase64String ignores whitespace, including line breaks
                return Convert.FromBase64String(body);
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("The PEM private key is not valid base64", "pem", ex);
            }
        }

        private static RSA Import(byte[] der, bool pkcs8)
        {
            RSA rsa = RSA.Create();
            try
            {
#if NETSTANDARD2_1 || NET
                if (pkcs8)
                {
                    rsa.ImportPkcs8PrivateKey(der, out _);
                }
                else
                {
                    rsa.ImportRSAPrivateKey(der, out _);
                }
#else
                RSAParameters parameters = pkcs8 ? RsaDerReader.ReadPkcs8(der) : RsaDerReader.ReadPkcs1(der);
                try
                {
                    rsa.ImportParameters(parameters);
                }
                finally
                {
                    ClearPrivateParameters(parameters);
                }
#endif
                return rsa;
            }
            catch (CryptographicException ex)
            {
                rsa.Dispose();
                throw new ArgumentException("The PEM private key is not a valid RSA private key", "pem", ex);
            }
            catch
            {
                rsa.Dispose();
                throw;
            }
            finally
            {
                Array.Clear(der, 0, der.Length);
            }
        }

#if !(NETSTANDARD2_1 || NET)
        private static void ClearPrivateParameters(RSAParameters parameters)
        {
            foreach (byte[] value in new[] { parameters.D, parameters.P, parameters.Q, parameters.DP, parameters.DQ, parameters.InverseQ })
            {
                if (value != null) Array.Clear(value, 0, value.Length);
            }
        }
#endif
    }
}
