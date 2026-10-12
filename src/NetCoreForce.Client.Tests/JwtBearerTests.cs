using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Newtonsoft.Json.Linq;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class JwtBearerTests
    {
        const string TokenEndpoint = "https://login.salesforce.com/services/oauth2/token";
        const string ClientId = "CLIENTID";
        const string Username = "user@example.org";
        const string GrantType = "urn:ietf:params:oauth:grant-type:jwt-bearer";
        const string ResponseContent = @"{
            ""access_token"": ""jwtAccessToken"",
            ""scope"": ""api"",
            ""instance_url"": ""https://na15.salesforce.com"",
            ""id"": ""https://login.salesforce.com/id/00DXXXXXXXXXXXXXXX/005XXXXXXXXXXXXXXX"",
            ""token_type"": ""Bearer""
        }";

        [Fact]
        public async Task JwtBearerAsyncSendsSignedAssertion()
        {
            MockHttpClientHandler mockHandler;
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.OK, ResponseContent, out mockHandler);

            using (RSA key = RSA.Create())
            {
                long before = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                await auth.JwtBearerAsync(ClientId, Username, key, TokenEndpoint);
                long after = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

                // credentials go in the body, and there's no client secret or password
                Assert.Equal(new Uri(TokenEndpoint), mockHandler.LastRequestUri);
                Assert.Equal("", mockHandler.LastRequestUri.Query);
                Dictionary<string, string> form = ParseForm(mockHandler.LastRequestContent);
                Assert.Equal(2, form.Count);
                Assert.Equal(GrantType, form["grant_type"]);

                string[] parts = form["assertion"].Split('.');
                Assert.Equal(3, parts.Length);
                Assert.Equal(@"{""alg"":""RS256""}", Encoding.UTF8.GetString(Base64UrlDecode(parts[0])));

                JObject claims = JObject.Parse(Encoding.UTF8.GetString(Base64UrlDecode(parts[1])));
                Assert.Equal(ClientId, (string)claims["iss"]);
                Assert.Equal(Username, (string)claims["sub"]);
                Assert.Equal("https://login.salesforce.com", (string)claims["aud"]);

                // a new assertion is created for each request, so it's only valid briefly
                long exp = (long)claims["exp"];
                Assert.True(exp >= before + 120 && exp <= after + 120, "exp should be 2 minutes after the assertion is created");
                Assert.False(string.IsNullOrEmpty((string)claims["jti"]));

                Assert.True(key.VerifyData(Encoding.UTF8.GetBytes(parts[0] + "." + parts[1]), Base64UrlDecode(parts[2]), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
            }
        }

        [Fact]
        public async Task JwtBearerAsyncSetsAccessInfo()
        {
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.OK, ResponseContent, out _);

            using (RSA key = RSA.Create())
            {
                await auth.JwtBearerAsync(ClientId, Username, key, TokenEndpoint);
            }

            Assert.Equal("jwtAccessToken", auth.AccessInfo.AccessToken);
            Assert.Equal("https://na15.salesforce.com", auth.AccessInfo.InstanceUrl);
            Assert.Null(auth.AccessInfo.RefreshToken);
        }

        [Fact]
        public async Task JwtBearerAsyncUsesExplicitAudience()
        {
            const string siteEndpoint = "https://example.my.site.com/customers/services/oauth2/token";
            MockHttpClientHandler mockHandler;
            AuthenticationClient auth = CreateAuthenticationClient(siteEndpoint, HttpStatusCode.OK, ResponseContent, out mockHandler);

            using (RSA key = RSA.Create())
            {
                await auth.JwtBearerAsync(ClientId, Username, key, siteEndpoint, "https://example.my.site.com/customers");
            }

            JObject claims = ParseClaims(mockHandler.LastRequestContent);
            Assert.Equal("https://example.my.site.com/customers", (string)claims["aud"]);
        }

        [Fact]
        public async Task JwtBearerAsyncDefaultsSandboxAudience()
        {
            const string sandboxEndpoint = "https://test.salesforce.com/services/oauth2/token";
            MockHttpClientHandler mockHandler;
            AuthenticationClient auth = CreateAuthenticationClient(sandboxEndpoint, HttpStatusCode.OK, ResponseContent, out mockHandler);

            using (RSA key = RSA.Create())
            {
                await auth.JwtBearerAsync(ClientId, Username, key, sandboxEndpoint);
            }

            Assert.Equal("https://test.salesforce.com", (string)ParseClaims(mockHandler.LastRequestContent)["aud"]);
        }

        [Theory]
        [InlineData("https://login.salesforce.com/services/oauth2/token", "https://login.salesforce.com")]
        [InlineData("https://test.salesforce.com/services/oauth2/token", "https://test.salesforce.com")]
        [InlineData("https://TEST.salesforce.com/services/oauth2/token", "https://test.salesforce.com")]
        [InlineData("https://mydomain.my.salesforce.com/services/oauth2/token", "https://login.salesforce.com")]
        [InlineData("https://mydomain--dev.sandbox.my.salesforce.com/services/oauth2/token", "https://test.salesforce.com")]
        [InlineData("https://example.my.site.com/services/oauth2/token", "https://example.my.site.com")]
        [InlineData("https://example.my.site.com/customers/services/oauth2/token", "https://example.my.site.com/customers")]
        [InlineData("https://example--dev.sandbox.my.site.com/customers/services/oauth2/token", "https://example--dev.sandbox.my.site.com/customers")]
        [InlineData("https://example.my.site.com/customers/", "https://example.my.site.com/customers")]
        public void DefaultAudience(string tokenRequestEndpoint, string expectedAudience)
        {
            Assert.Equal(expectedAudience, JwtBearerAssertion.DefaultAudience(tokenRequestEndpoint));
        }

        [Fact]
        public void AssertionExpiresTwoMinutesAfterNow()
        {
            DateTimeOffset now = DateTimeOffset.FromUnixTimeSeconds(1700000000);

            using (RSA key = RSA.Create())
            {
                string assertion = JwtBearerAssertion.Create(ClientId, Username, "https://login.salesforce.com", key, now);
                JObject claims = JObject.Parse(Encoding.UTF8.GetString(Base64UrlDecode(assertion.Split('.')[1])));

                Assert.Equal(1700000120L, (long)claims["exp"]);
            }
        }

        [Fact]
        public void AssertionClaimsAreJsonEscaped()
        {
            // a username or client ID can't add or change claims
            const string username = "user\"@example.org\",\"sub\":\"admin@example.org";

            using (RSA key = RSA.Create())
            {
                string assertion = JwtBearerAssertion.Create(ClientId, username, "https://login.salesforce.com", key, DateTimeOffset.UtcNow);
                JObject claims = JObject.Parse(Encoding.UTF8.GetString(Base64UrlDecode(assertion.Split('.')[1])));

                Assert.Equal(username, (string)claims["sub"]);
                Assert.Equal(new[] { "iss", "sub", "aud", "exp", "jti" }, claims.Properties().Select(p => p.Name));
            }
        }

        [Fact]
        public void AssertionJwtIdIsUnique()
        {
            // when a jti is present Salesforce rejects one it has seen before, so each assertion must have a new one
            DateTimeOffset now = DateTimeOffset.UtcNow;

            using (RSA key = RSA.Create())
            {
                var jwtIds = new HashSet<string>();
                for (int i = 0; i < 10; i++)
                {
                    string assertion = JwtBearerAssertion.Create(ClientId, Username, "https://login.salesforce.com", key, now);
                    JObject claims = JObject.Parse(Encoding.UTF8.GetString(Base64UrlDecode(assertion.Split('.')[1])));
                    Assert.True(jwtIds.Add((string)claims["jti"]), "jti should be unique");
                }
            }
        }

        [Fact]
        public async Task JwtBearerAsyncReturnsExperienceCloudSite()
        {
            string responseContent = @"{
                ""access_token"": ""jwtAccessToken"",
                ""instance_url"": ""https://na15.salesforce.com"",
                ""id"": ""https://login.salesforce.com/id/00DXXXXXXXXXXXXXXX/005XXXXXXXXXXXXXXX"",
                ""token_type"": ""Bearer"",
                ""sfdc_site_url"": ""https://example.my.site.com/customers"",
                ""sfdc_site_id"": ""0DMXXXXXXXXXXXXXXX""
            }";
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.OK, responseContent, out _);

            using (RSA key = RSA.Create())
            {
                await auth.JwtBearerAsync(ClientId, Username, key, TokenEndpoint, "https://example.my.site.com/customers");
            }

            Assert.Equal("https://example.my.site.com/customers", auth.AccessInfo.SfdcSiteUrl);
            Assert.Equal("0DMXXXXXXXXXXXXXXX", auth.AccessInfo.SfdcSiteId);
        }

        [Theory]
        [InlineData("invalid_grant", "Audience validation failed")]
        [InlineData("invalid_app_access", "User isn't approved by an admin to access this app")]
        [InlineData("invalid_request", "The JWT bearer and SAML assertion bearer flows require a refresh_token scope")]
        public async Task JwtBearerAsyncErrorKeepsErrorCode(string error, string errorDescription)
        {
            string responseContent = new JObject { ["error"] = error, ["error_description"] = errorDescription }.ToString();
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.BadRequest, responseContent, out _);

            using (RSA key = RSA.Create())
            {
                ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(() => auth.JwtBearerAsync(ClientId, Username, key, TokenEndpoint));

                Assert.Equal(error, ex.ErrorCode);
                Assert.Equal(errorDescription, ex.Message);
                Assert.Equal(HttpStatusCode.BadRequest, ex.HttpStatusCode);
            }
        }

        [Theory]
        [InlineData("<html><body>Proxy error</body></html>")]
        [InlineData("")]
        [InlineData("{}")]
        public async Task JwtBearerAsyncUnexpectedResponseThrowsForceAuthException(string responseContent)
        {
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.OK, responseContent, out _);

            using (RSA key = RSA.Create())
            {
                await Assert.ThrowsAsync<ForceAuthException>(() => auth.JwtBearerAsync(ClientId, Username, key, TokenEndpoint));
            }
        }

        [Fact]
        public async Task JwtBearerAsyncValidatesArguments()
        {
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.OK, ResponseContent, out _);

            using (RSA key = RSA.Create())
            {
                ArgumentNullException clientIdEx = await Assert.ThrowsAsync<ArgumentNullException>(() => auth.JwtBearerAsync("", Username, key, TokenEndpoint));
                ArgumentNullException usernameEx = await Assert.ThrowsAsync<ArgumentNullException>(() => auth.JwtBearerAsync(ClientId, null, key, TokenEndpoint));
                ArgumentNullException keyEx = await Assert.ThrowsAsync<ArgumentNullException>(() => auth.JwtBearerAsync(ClientId, Username, null, TokenEndpoint));
                ArgumentNullException endpointEx = await Assert.ThrowsAsync<ArgumentNullException>(() => auth.JwtBearerAsync(ClientId, Username, key, ""));
                await Assert.ThrowsAsync<FormatException>(() => auth.JwtBearerAsync(ClientId, Username, key, "/services/oauth2/token"));

                Assert.Equal("clientId", clientIdEx.ParamName);
                Assert.Equal("username", usernameEx.ParamName);
                Assert.Equal("privateKey", keyEx.ParamName);
                Assert.Equal("tokenRequestEndpointUrl", endpointEx.ParamName);
            }
        }

        [Fact]
        public async Task ForceClientFromJwtBearerAsync()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri(TokenEndpoint), HttpStatusCode.OK, ResponseContent);

            using (RSA key = RSA.Create())
            {
                ForceClient client = await ForceClient.FromJwtBearerAsync(ClientId, Username, key, TokenEndpoint, httpClient: new HttpClient(mockHandler));

                Assert.Equal("https://na15.salesforce.com", client.InstanceUrl);
                Assert.Equal("jwtAccessToken", client.AccessToken);
                Assert.Equal("jwtAccessToken", client.AccessInfo.AccessToken);
            }
        }

        [Fact]
        public void ForceClientAuthInfoJwtBearerRequiresPrivateKeyFile()
        {
            AuthInfo authInfo = new AuthInfo
            {
                AuthMethod = AuthInfo.AuthMethodType.JwtBearer,
                ClientId = ClientId,
                Username = Username,
                TokenRequestEndpoint = TokenEndpoint
            };

            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => new ForceClient(authInfo));
            Assert.Equal("privateKeyFile", ex.ParamName);
        }

        [Theory]
        [InlineData(new byte[0], "")]
        [InlineData(new byte[] { 0x00 }, "AA")]
        [InlineData(new byte[] { 0xFB, 0xFF }, "-_8")]
        [InlineData(new byte[] { 0xFF, 0xFE, 0xFD }, "__79")]
        public void Base64UrlEncode(byte[] data, string expected)
        {
            Assert.Equal(expected, JwtBearerAssertion.Base64UrlEncode(data));
        }

        private static JObject ParseClaims(string requestContent)
        {
            string assertion = ParseForm(requestContent)["assertion"];
            return JObject.Parse(Encoding.UTF8.GetString(Base64UrlDecode(assertion.Split('.')[1])));
        }

        private static Dictionary<string, string> ParseForm(string content)
        {
            var form = new Dictionary<string, string>();
            foreach (string pair in content.Split('&'))
            {
                string[] parts = pair.Split('=');
                form.Add(WebUtility.UrlDecode(parts[0]), WebUtility.UrlDecode(parts[1]));
            }
            return form;
        }

        private static byte[] Base64UrlDecode(string value)
        {
            string base64 = value.Replace('-', '+').Replace('_', '/');
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        private static AuthenticationClient CreateAuthenticationClient(string endpoint, HttpStatusCode statusCode, string responseContent, out MockHttpClientHandler mockHandler)
        {
            mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri(endpoint), statusCode, responseContent);

            return new AuthenticationClient(httpClient: new HttpClient(mockHandler));
        }
    }
}
