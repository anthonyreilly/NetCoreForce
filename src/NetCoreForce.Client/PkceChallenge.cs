using System;
using System.Security.Cryptography;
using System.Text;

namespace NetCoreForce.Client
{
    /// <summary>
    /// A Proof Key for Code Exchange (PKCE) code verifier and challenge, for the Web Server flow
    /// <para>https://help.salesforce.com/s/articleView?id=sf.remoteaccess_pkce.htm</para>
    /// <para>Pass <see cref="CodeChallenge"/> to <see cref="UriFormatter.WebServerAuthenticationUrl(string, string, string, Models.DisplayTypes, bool, string, string, string)"/>,
    /// keep <see cref="CodeVerifier"/> server-side (e.g. in the user's session), then pass it to
    /// <see cref="AuthenticationClient.WebServerAsync(string, string, string, string, string, string)"/> to exchange the authorization code.
    /// An intercepted authorization code can't be exchanged without the verifier.</para>
    /// </summary>
    public sealed class PkceChallenge
    {
        /// <summary>
        /// The code challenge method - Salesforce only supports S256
        /// </summary>
        public const string S256 = "S256";

        //96 bytes base64url-encode to 128 characters, the maximum code verifier length in RFC 7636
        private const int VerifierByteLength = 96;

        /// <summary>
        /// The secret code verifier, sent in the token request. Keep it server-side - don't expose it in a URL or to the browser.
        /// </summary>
        public string CodeVerifier { get; }

        /// <summary>
        /// The code challenge, sent in the authorization URL: the base64url-encoded SHA256 hash of the code verifier
        /// </summary>
        public string CodeChallenge { get; }

        /// <summary>
        /// The code challenge method, always S256
        /// </summary>
        public string CodeChallengeMethod { get { return S256; } }

        private PkceChallenge(string codeVerifier, string codeChallenge)
        {
            CodeVerifier = codeVerifier;
            CodeChallenge = codeChallenge;
        }

        /// <summary>
        /// Create a new random code verifier and its code challenge. Use a new one for each login.
        /// </summary>
        public static PkceChallenge Create()
        {
            byte[] bytes = new byte[VerifierByteLength];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            string codeVerifier = JwtBearerAssertion.Base64UrlEncode(bytes);
            return new PkceChallenge(codeVerifier, ComputeChallenge(codeVerifier));
        }

        /// <summary>
        /// The S256 code challenge for a code verifier: BASE64URL(SHA256(ASCII(code_verifier)))
        /// </summary>
        internal static string ComputeChallenge(string codeVerifier)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return JwtBearerAssertion.Base64UrlEncode(sha256.ComputeHash(Encoding.ASCII.GetBytes(codeVerifier)));
            }
        }

        /// <summary>
        /// Check a code verifier or challenge only contains the RFC 7636 unreserved characters [A-Za-z0-9-._~]
        /// <para>Catches values encoded with standard base64 (+, / and = padding) instead of base64url, which Salesforce rejects.
        /// The length isn't checked, since Salesforce's PKCE generator endpoint can return verifiers longer than RFC 7636 allows.</para>
        /// </summary>
        /// <exception cref="ArgumentException">The value is empty or contains other characters</exception>
        internal static void ValidateValue(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Value is empty", paramName);
            }

            foreach (char c in value)
            {
                bool isUnreserved = (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9')
                    || c == '-' || c == '.' || c == '_' || c == '~';
                if (!isUnreserved)
                {
                    throw new ArgumentException("Value must be base64url-encoded, containing only A-Z, a-z, 0-9, '-', '.', '_' and '~'", paramName);
                }
            }
        }
    }
}
