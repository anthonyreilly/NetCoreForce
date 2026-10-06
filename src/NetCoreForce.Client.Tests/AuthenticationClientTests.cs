using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class AuthenticationClientTests
    {
        const string TokenEndpoint = "https://login.salesforce.com/services/oauth2/token";
        const string ClientId = "CLIENTID";
        const string ClientSecret = "CLIENTSECRET";
        const string CurrentRefreshToken = "currentRefreshToken";
        const string IntrospectEndpoint = "https://login.salesforce.com/services/oauth2/introspect";
        const string RefreshResponseContent = @"{ ""access_token"": ""newAccessToken"", ""instance_url"": ""https://na15.salesforce.com"", ""token_type"": ""Bearer"" }";

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

        [Fact]
        public async Task TokenRefreshAsyncSendsCredentialsInBody()
        {
            // credentials in the URL can be recorded by proxies, APM tools and HTTP logs
            MockHttpClientHandler mockHandler;
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.OK, RefreshResponseContent, out mockHandler);

            await auth.TokenRefreshAsync(CurrentRefreshToken, ClientId, ClientSecret, TokenEndpoint);

            Assert.Equal(new Uri(TokenEndpoint), mockHandler.LastRequestUri);
            Assert.Equal("", mockHandler.LastRequestUri.Query);
            Assert.Equal("grant_type=refresh_token&refresh_token=currentRefreshToken&client_id=CLIENTID&client_secret=CLIENTSECRET&format=json", mockHandler.LastRequestContent);
        }

        [Fact]
        public async Task TokenRefreshAsyncOmitsEmptyClientSecret()
        {
            MockHttpClientHandler mockHandler;
            AuthenticationClient auth = CreateAuthenticationClient(TokenEndpoint, HttpStatusCode.OK, RefreshResponseContent, out mockHandler);

            await auth.TokenRefreshAsync(CurrentRefreshToken, ClientId, "", TokenEndpoint);

            Assert.Equal("grant_type=refresh_token&refresh_token=currentRefreshToken&client_id=CLIENTID&format=json", mockHandler.LastRequestContent);
        }

        [Fact]
        public async Task TokenRefreshAsyncValidatesArguments()
        {
            AuthenticationClient auth = CreateAuthenticationClient(HttpStatusCode.OK, RefreshResponseContent);

            await Assert.ThrowsAsync<ArgumentNullException>(() => auth.TokenRefreshAsync("", ClientId, ClientSecret, TokenEndpoint));
            await Assert.ThrowsAsync<ArgumentNullException>(() => auth.TokenRefreshAsync(CurrentRefreshToken, "", ClientSecret, TokenEndpoint));
            await Assert.ThrowsAsync<FormatException>(() => auth.TokenRefreshAsync(CurrentRefreshToken, ClientId, ClientSecret, "/services/oauth2/token"));
        }

        [Fact]
        public async Task IntrospectTokenAsyncSendsTokenInBody()
        {
            // the access token and credentials in the URL can be recorded by proxies, APM tools and HTTP logs
            string responseContent = @"{
                ""active"": true,
                ""scope"": ""api"",
                ""client_id"": ""CLIENTID"",
                ""username"": ""user@example.org"",
                ""sub"": ""https://login.salesforce.com/id/00DXXXXXXXXXXXXXXX/005XXXXXXXXXXXXXXX"",
                ""token_type"": ""access_token"",
                ""exp"": 1530220142,
                ""iat"": 1530216542,
                ""nbf"": 1530216542
            }";

            MockHttpClientHandler mockHandler;
            AuthenticationClient auth = CreateAuthenticationClient(IntrospectEndpoint, HttpStatusCode.OK, responseContent, out mockHandler);

            IntrospectTokenResponse response = await auth.IntrospectTokenAsync("accessToken", ClientId, ClientSecret, IntrospectEndpoint);

            Assert.True(response.Active);
            Assert.Equal(new Uri(IntrospectEndpoint), mockHandler.LastRequestUri);
            Assert.Equal("", mockHandler.LastRequestUri.Query);
            Assert.Equal("token=accessToken&client_id=CLIENTID&client_secret=CLIENTSECRET&format=json", mockHandler.LastRequestContent);
        }

        /// <summary>
        /// Create an AuthenticationClient that returns the given response for the token refresh request
        /// </summary>
        private static AuthenticationClient CreateAuthenticationClient(HttpStatusCode statusCode, string responseContent)
        {
            MockHttpClientHandler mockHandler;
            return CreateAuthenticationClient(TokenEndpoint, statusCode, responseContent, out mockHandler);
        }

        /// <summary>
        /// Create an AuthenticationClient that returns the given response for requests to the endpoint
        /// </summary>
        private static AuthenticationClient CreateAuthenticationClient(string endpoint, HttpStatusCode statusCode, string responseContent, out MockHttpClientHandler mockHandler)
        {
            mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri(endpoint), statusCode, responseContent);

            return new AuthenticationClient(httpClient: new HttpClient(mockHandler));
        }
    }
}
