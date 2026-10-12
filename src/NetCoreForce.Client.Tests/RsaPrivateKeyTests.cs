using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// PEM private key loading for the JWT Bearer flow.
    /// On .NET Framework these exercise RsaDerReader, on .NET 8+ the built-in PKCS#1/PKCS#8 import.
    /// </summary>
    public class RsaPrivateKeyTests
    {
        [Theory]
        [InlineData(TestKeys.RsaPkcs1Pem)]
        [InlineData(TestKeys.RsaPkcs8Pem)]
        public void FromPemLoadsKey(string pem)
        {
            using (RSA key = RsaPrivateKey.FromPem(pem))
            {
                AssertIsTestKey(key);
            }
        }

        [Fact]
        public void FromPemSkipsOtherBlocks()
        {
            // e.g. a combined file with the certificate first
            string pem = "-----BEGIN CERTIFICATE-----\nMIIB\n-----END CERTIFICATE-----\n" + TestKeys.RsaPkcs8Pem;

            using (RSA key = RsaPrivateKey.FromPem(pem))
            {
                AssertIsTestKey(key);
            }
        }

        [Fact]
        public void FromPemAcceptsLineEndings()
        {
            string crlf = TestKeys.RsaPkcs1Pem.Replace("\r\n", "\n").Replace("\n", "\r\n");
            string lf = TestKeys.RsaPkcs1Pem.Replace("\r\n", "\n");

            using (RSA crlfKey = RsaPrivateKey.FromPem(crlf))
            using (RSA lfKey = RsaPrivateKey.FromPem(lf))
            {
                AssertIsTestKey(crlfKey);
                AssertIsTestKey(lfKey);
            }
        }

        [Fact]
        public void FromPemFileLoadsKey()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, TestKeys.RsaPkcs8Pem);

                using (RSA key = RsaPrivateKey.FromPemFile(path))
                {
                    AssertIsTestKey(key);
                }
            }
            finally
            {
                File.Delete(path);
            }
        }

        [Fact]
        public void FromPemNullOrEmptyThrows()
        {
            Assert.Throws<ArgumentNullException>(() => RsaPrivateKey.FromPem(null));
            Assert.Throws<ArgumentNullException>(() => RsaPrivateKey.FromPem(""));
            Assert.Throws<ArgumentNullException>(() => RsaPrivateKey.FromPemFile(""));
        }

        [Fact]
        public void FromPemEncryptedKeyThrowsNotSupported()
        {
            string pkcs8 = "-----BEGIN ENCRYPTED PRIVATE KEY-----\nMIIB\n-----END ENCRYPTED PRIVATE KEY-----";
            string legacy = "-----BEGIN RSA PRIVATE KEY-----\nProc-Type: 4,ENCRYPTED\nDEK-Info: AES-128-CBC,00000000000000000000000000000000\n\nMIIB\n-----END RSA PRIVATE KEY-----";

            Assert.Throws<NotSupportedException>(() => RsaPrivateKey.FromPem(pkcs8));
            Assert.Throws<NotSupportedException>(() => RsaPrivateKey.FromPem(legacy));
        }

        [Fact]
        public void FromPemCertificateOnlyThrows()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() =>
                RsaPrivateKey.FromPem("-----BEGIN CERTIFICATE-----\nMIIB\n-----END CERTIFICATE-----"));

            Assert.Contains("CERTIFICATE", ex.Message);
        }

        [Theory]
        [InlineData("not a pem")]
        [InlineData("-----BEGIN PRIVATE KEY-----\nMIIB")]
        [InlineData("-----BEGIN PRIVATE KEY-----\n!!not base64!!\n-----END PRIVATE KEY-----")]
        [InlineData("-----BEGIN PRIVATE KEY-----\nAAAA\n-----END PRIVATE KEY-----")]
        [InlineData("-----BEGIN RSA PRIVATE KEY-----\nAAAA\n-----END RSA PRIVATE KEY-----")]
        public void FromPemInvalidThrows(string pem)
        {
            Assert.Throws<ArgumentException>(() => RsaPrivateKey.FromPem(pem));
        }

        [Fact]
        public void FromPemEcKeyThrows()
        {
            Assert.Throws<ArgumentException>(() => RsaPrivateKey.FromPem(TestKeys.EcPkcs8Pem));
        }

        [Fact]
        public void FromPemTruncatedKeyThrows()
        {
            byte[] der = TestKeys.DecodePem(TestKeys.RsaPkcs1Pem);
            byte[] truncated = new byte[der.Length / 2];
            Array.Copy(der, truncated, truncated.Length);
            string pem = "-----BEGIN RSA PRIVATE KEY-----\n" + Convert.ToBase64String(truncated) + "\n-----END RSA PRIVATE KEY-----";

            Assert.Throws<ArgumentException>(() => RsaPrivateKey.FromPem(pem));
        }

        [Fact]
        public void DerReaderPadsShortValues()
        {
            // the test key's D and DQ are shorter than the modulus/half the modulus
            RSAParameters parameters = RsaDerReader.ReadPkcs1(TestKeys.DecodePem(TestKeys.RsaPkcs1Pem));

            Assert.Equal(128, parameters.Modulus.Length);
            Assert.Equal(128, parameters.D.Length);
            Assert.Equal(0, parameters.D[0]);
            Assert.Equal(64, parameters.P.Length);
            Assert.Equal(64, parameters.Q.Length);
            Assert.Equal(64, parameters.DP.Length);
            Assert.Equal(64, parameters.DQ.Length);
            Assert.Equal(0, parameters.DQ[0]);
            Assert.Equal(64, parameters.InverseQ.Length);
            Assert.Equal(new byte[] { 0x01, 0x00, 0x01 }, parameters.Exponent);
        }

        [Fact]
        public void DerReaderPkcs8MatchesPkcs1()
        {
            RSAParameters pkcs1 = RsaDerReader.ReadPkcs1(TestKeys.DecodePem(TestKeys.RsaPkcs1Pem));
            RSAParameters pkcs8 = RsaDerReader.ReadPkcs8(TestKeys.DecodePem(TestKeys.RsaPkcs8Pem));

            AssertParametersEqual(pkcs1, pkcs8);
        }

        [Fact]
        public void DerReaderImportedKeySigns()
        {
            // the parameters must be accepted by ImportParameters, including .NET Framework's stricter length checks
            using (RSA key = RSA.Create())
            {
                key.ImportParameters(RsaDerReader.ReadPkcs8(TestKeys.DecodePem(TestKeys.RsaPkcs8Pem)));
                AssertIsTestKey(key);
            }
        }

        [Fact]
        public void DerReaderEcKeyThrows()
        {
            Assert.Throws<ArgumentException>(() => RsaDerReader.ReadPkcs8(TestKeys.DecodePem(TestKeys.EcPkcs8Pem)));
        }

        [Fact]
        public void DerReaderTruncatedThrowsArgumentException()
        {
            // every truncation must fail cleanly, never with IndexOutOfRangeException or similar
            byte[] pkcs1 = TestKeys.DecodePem(TestKeys.RsaPkcs1Pem);
            byte[] pkcs8 = TestKeys.DecodePem(TestKeys.RsaPkcs8Pem);

            for (int length = 0; length < pkcs1.Length; length++)
            {
                byte[] truncated = new byte[length];
                Array.Copy(pkcs1, truncated, length);
                Assert.Throws<ArgumentException>(() => RsaDerReader.ReadPkcs1(truncated));
            }

            for (int length = 0; length < pkcs8.Length; length++)
            {
                byte[] truncated = new byte[length];
                Array.Copy(pkcs8, truncated, length);
                Assert.Throws<ArgumentException>(() => RsaDerReader.ReadPkcs8(truncated));
            }
        }

        [Fact]
        public void DerReaderCorruptedThrowsArgumentException()
        {
            // flipping each byte must either still parse or fail with ArgumentException
            byte[] pkcs8 = TestKeys.DecodePem(TestKeys.RsaPkcs8Pem);

            for (int i = 0; i < pkcs8.Length; i++)
            {
                byte[] corrupted = (byte[])pkcs8.Clone();
                corrupted[i] ^= 0xFF;

                try
                {
                    RsaDerReader.ReadPkcs8(corrupted);
                }
                catch (ArgumentException)
                {
                }
            }
        }

#if NET
        [Fact]
        public void DerReaderMatchesBuiltInImport()
        {
            using (RSA key = RSA.Create())
            {
                key.ImportFromPem(TestKeys.RsaPkcs1Pem);
                RSAParameters expected = key.ExportParameters(true);

                AssertParametersEqual(expected, RsaDerReader.ReadPkcs1(TestKeys.DecodePem(TestKeys.RsaPkcs1Pem)));
                AssertParametersEqual(expected, RsaDerReader.ReadPkcs8(TestKeys.DecodePem(TestKeys.RsaPkcs8Pem)));
            }
        }

        [Theory]
        [InlineData(1024)]
        [InlineData(2048)]
        [InlineData(4096)]
        public void DerReaderMatchesBuiltInExport(int keySize)
        {
            for (int i = 0; i < 5; i++)
            {
                using (RSA key = RSA.Create(keySize))
                {
                    RSAParameters expected = key.ExportParameters(true);

                    AssertParametersEqual(expected, RsaDerReader.ReadPkcs1(key.ExportRSAPrivateKey()));
                    AssertParametersEqual(expected, RsaDerReader.ReadPkcs8(key.ExportPkcs8PrivateKey()));
                }
            }
        }

        [Fact]
        public void FromPemLoadsExportedKeys()
        {
            using (RSA original = RSA.Create(2048))
            {
                RSAParameters expected = original.ExportParameters(true);

                using (RSA pkcs1 = RsaPrivateKey.FromPem(original.ExportRSAPrivateKeyPem()))
                using (RSA pkcs8 = RsaPrivateKey.FromPem(original.ExportPkcs8PrivateKeyPem()))
                {
                    AssertParametersEqual(expected, pkcs1.ExportParameters(true));
                    AssertParametersEqual(expected, pkcs8.ExportParameters(true));
                }
            }
        }
#endif

        /// <summary>
        /// Check the key is the test key, and its private values are correct by signing and verifying with the public key
        /// </summary>
        private static void AssertIsTestKey(RSA key)
        {
            RSAParameters expected = RsaDerReader.ReadPkcs1(TestKeys.DecodePem(TestKeys.RsaPkcs1Pem));
            RSAParameters publicKey = key.ExportParameters(false);
            Assert.Equal(expected.Modulus, publicKey.Modulus);
            Assert.Equal(expected.Exponent, publicKey.Exponent);

            byte[] data = Encoding.UTF8.GetBytes("header.claims");
            byte[] signature = key.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            using (RSA verifier = RSA.Create())
            {
                verifier.ImportParameters(publicKey);
                Assert.True(verifier.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
            }
        }

        private static void AssertParametersEqual(RSAParameters expected, RSAParameters actual)
        {
            Assert.Equal(expected.Modulus, actual.Modulus);
            Assert.Equal(expected.Exponent, actual.Exponent);
            Assert.Equal(expected.D, actual.D);
            Assert.Equal(expected.P, actual.P);
            Assert.Equal(expected.Q, actual.Q);
            Assert.Equal(expected.DP, actual.DP);
            Assert.Equal(expected.DQ, actual.DQ);
            Assert.Equal(expected.InverseQ, actual.InverseQ);
        }
    }
}
