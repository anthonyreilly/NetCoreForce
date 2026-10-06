using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class AuthenticationClientTests
    {
        const string TokenEndpoint = "https://login.salesforce.com/services/oauth2/token";
        const string ClientId = "CLIENTID";
        const string ClientSecret = "CLIENTSECRET";
        const string CurrentRefreshToken = "currentRefreshToken";

        [Fact]
        public async Task TokenRefreshAsyncReturnsRotatedRefreshToken()
        {
            // with refresh token rotation enabled, Salesforce returns a new refresh token that replaces the current one
            string responseContent = @"{
                ""access_token"": ""newAccessToken"",
                ""refresh_token"": ""rotatedRefreshToken"",
                ""instance_url"": ""https://na15.salesforce.com"",
                ""id"": ""https://login.salesforce.com/id/00DXXXXXXXXXXXXXXX/005XXXXXXXXXXXXXXX"",
                ""token_type"": ""Bearer"",
                ""issued_at"": ""1530216542000"",
                ""signature"": ""signature""
            }";

            AuthenticationClient auth = CreateAuthenticationClient(HttpStatusCode.OK, responseContent);

            await auth.TokenRefreshAsync(CurrentRefreshToken, ClientId, ClientSecret, TokenEndpoint);

            Assert.Equal("newAccessToken", auth.AccessInfo.AccessToken);
            Assert.Equal("rotatedRefreshToken", auth.AccessInfo.RefreshToken);
        }

        [Fact]
        public async Task TokenRefreshAsyncKeepsRefreshTokenWhenNotReturned()
        {
            // without refresh token rotation, the response does not include a refresh token, so the current one is kept
            string responseContent = @"{
                ""access_token"": ""newAccessToken"",
                ""instance_url"": ""https://na15.salesforce.com"",
                ""id"": ""https://login.salesforce.com/id/00DXXXXXXXXXXXXXXX/005XXXXXXXXXXXXXXX"",
                ""token_type"": ""Bearer"",
                ""issued_at"": ""1530216542000"",
                ""signature"": ""signature""
            }";

            AuthenticationClient auth = CreateAuthenticationClient(HttpStatusCode.OK, responseContent);

            await auth.TokenRefreshAsync(CurrentRefreshToken, ClientId, ClientSecret, TokenEndpoint);

            Assert.Equal("newAccessToken", auth.AccessInfo.AccessToken);
            Assert.Equal(CurrentRefreshToken, auth.AccessInfo.RefreshToken);
        }

        [Fact]
        public async Task TokenRefreshAsyncInvalidTokenThrows()
        {
            string responseContent = @"{ ""error"": ""invalid_grant"", ""error_description"": ""expired access/refresh token"" }";

            AuthenticationClient auth = CreateAuthenticationClient(HttpStatusCode.BadRequest, responseContent);

            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                () => auth.TokenRefreshAsync(CurrentRefreshToken, ClientId, ClientSecret, TokenEndpoint));

            Assert.Equal("invalid_grant", ex.ErrorCode);
            Assert.Equal(HttpStatusCode.BadRequest, ex.HttpStatusCode);
        }

        /// <summary>
        /// Create an AuthenticationClient that returns the given response for the token refresh request
        /// </summary>
        private static AuthenticationClient CreateAuthenticationClient(HttpStatusCode statusCode, string responseContent)
        {
            var mockHandler = new MockHttpClientHandler();

            Uri refreshUri = UriFormatter.RefreshTokenUrl(TokenEndpoint, CurrentRefreshToken, ClientId, ClientSecret);
            mockHandler.AddMockResponse(refreshUri, statusCode, responseContent);

            return new AuthenticationClient(httpClient: new HttpClient(mockHandler));
        }
    }
}
