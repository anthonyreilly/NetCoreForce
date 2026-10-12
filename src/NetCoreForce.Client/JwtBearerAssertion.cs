using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Cryptography;
using System.Text;

namespace NetCoreForce.Client
{
    /// <summary>
    /// Builds the signed JWT assertion for the OAuth 2.0 JWT Bearer flow
    /// <para>https://help.salesforce.com/s/articleView?id=xcloud.remoteaccess_oauth_jwt_flow.htm</para>
    /// </summary>
    internal static class JwtBearerAssertion
    {
        internal const string GrantType = "urn:ietf:params:oauth:grant-type:jwt-bearer";
        internal const string ProductionAudience = "https://login.salesforce.com";
        internal const string SandboxAudience = "https://test.salesforce.com";

        /// <summary>
        /// A new assertion is created for each request, so it only needs to be valid briefly.
        /// Salesforce also accepts an assertion for up to 3 minutes after it expires, to allow for clock skew.
        /// </summary>
        internal static readonly TimeSpan AssertionLifetime = TimeSpan.FromMinutes(2);

        //Salesforce only supports RS256
        private const string Header = "{\"alg\":\"RS256\"}";

        /// <summary>
        /// Create a signed JWT assertion
        /// </summary>
        /// <param name="clientId">The connected app's Consumer Key - the iss claim</param>
        /// <param name="username">The Salesforce username to log in as - the sub claim</param>
        /// <param name="audience">The authorization server - the aud claim</param>
        /// <param name="privateKey">The private key matching the certificate uploaded to the connected app</param>
        /// <param name="now">The current time, used to set the exp claim</param>
        internal static string Create(string clientId, string username, string audience, RSA privateKey, DateTimeOffset now)
        {
            //JObject doesn't use the host application's global JsonConvert.DefaultSettings
            JObject claims = new JObject
            {
                ["iss"] = clientId,
                ["sub"] = username,
                ["aud"] = audience,
                ["exp"] = now.Add(AssertionLifetime).ToUnixTimeSeconds(),
                //optional, but when present Salesforce rejects a JWT ID it has seen before, so an intercepted assertion can't be replayed
                ["jti"] = Guid.NewGuid().ToString("N")
            };

            string unsigned = string.Concat(
                Base64UrlEncode(Encoding.UTF8.GetBytes(Header)), ".",
                Base64UrlEncode(Encoding.UTF8.GetBytes(claims.ToString(Formatting.None))));

            byte[] signature = privateKey.SignData(Encoding.UTF8.GetBytes(unsigned), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            return string.Concat(unsigned, ".", Base64UrlEncode(signature));
        }

        /// <summary>
        /// The default aud claim for a token endpoint: https://test.salesforce.com for a sandbox, otherwise https://login.salesforce.com
        /// <para>An Experience Cloud site must set the audience explicitly, to the site URL.</para>
        /// </summary>
        internal static string DefaultAudience(string tokenRequestEndpointUrl)
        {
            string host = new Uri(tokenRequestEndpointUrl).Host.ToLowerInvariant();

            if (host == "test.salesforce.com" || host.EndsWith(".sandbox.my.salesforce.com", StringComparison.Ordinal))
            {
                return SandboxAudience;
            }

            return ProductionAudience;
        }

        /// <summary>
        /// Base64url encoding without padding (RFC 7515)
        /// </summary>
        internal static string Base64UrlEncode(byte[] data)
        {
            return Convert.ToBase64String(data).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }
    }
}
