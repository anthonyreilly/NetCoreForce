using System;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.FunctionalTests
{
    public class AuthenticationClientTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public AuthenticationClientTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        // Client credentials flow needs the org's specific instanceUrl instead of just login.salesforce.com,
        // so the username-password flow is used here just to discover that url
        private static async Task<string> GetInstanceSpecificTokenEndpoint(AuthInfo authInfo)
        {
            AuthenticationClient auth = new AuthenticationClient();
            await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);
            return auth.AccessInfo.InstanceUrl + @"/services/oauth2/token";
        }

        // Token introspection endpoint - the configured one if set, otherwise the org's instance-specific endpoint
        private static async Task<string> GetIntrospectTokenEndpoint(AuthInfo authInfo)
        {
            if (!string.IsNullOrEmpty(authInfo.TokenIntrospectionEndpoint))
            {
                return authInfo.TokenIntrospectionEndpoint;
            }

            AuthenticationClient auth = new AuthenticationClient();
            await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);
            return auth.AccessInfo.InstanceUrl + @"/services/oauth2/introspect";
        }

        // Introspection requires the connected app to be allowed to introspect the token - tokens issued to the
        // same connected app can be introspected, otherwise the app needs the "Introspect All Tokens" setting.
        // The token is sent in the request body, so this verifies Salesforce accepts the body-based request.
        [Fact]
        public async Task IntrospectTokenAsync_ActiveToken()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();
            await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);

            IntrospectTokenResponse introspectResponse = await auth.IntrospectTokenAsync(
                auth.AccessInfo.AccessToken, authInfo.ClientId, authInfo.ClientSecret, await GetIntrospectTokenEndpoint(authInfo));

            // a valid token reported as inactive means the connected app isn't permitted to introspect it
            Assert.True(introspectResponse.Active, "Token reported as inactive - check the connected app is allowed to introspect tokens (e.g. enable \"Introspect All Tokens\")");
            Assert.Equal(authInfo.ClientId, introspectResponse.ClientId);
        }

        [Fact]
        public async Task IntrospectTokenAsync_InvalidToken()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            // Salesforce rejects a value that isn't a token at all, rather than reporting it as inactive.
            // The OAuth error code shows Salesforce read the token from the request body.
            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                async () => await auth.IntrospectTokenAsync("not-a-real-token", authInfo.ClientId, authInfo.ClientSecret, await GetIntrospectTokenEndpoint(authInfo))
            );

            Assert.Equal("unsupported_token_type", ex.ErrorCode);
        }

        [Fact]
        public async Task ClientCredentialsAsync()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            string tokenRequestEndpointUrl = await GetInstanceSpecificTokenEndpoint(authInfo);

            AuthenticationClient auth = new AuthenticationClient();
            await auth.ClientCredentialsAsync(
                authInfo.ClientId,
                authInfo.ClientSecret,
                tokenRequestEndpointUrl);

            Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken));
        }

        [Fact]
        public async Task ClientCredentialsAsync_BadSecret()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            string tokenRequestEndpointUrl = await GetInstanceSpecificTokenEndpoint(authInfo);

            AuthenticationClient auth = new AuthenticationClient();

            // the OAuth error code was previously replaced with "Unknown" in this flow
            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                async () => await auth.ClientCredentialsAsync(authInfo.ClientId, "not-the-client-secret", tokenRequestEndpointUrl)
            );

            Assert.Equal("invalid_client", ex.ErrorCode);
        }

        [Fact]
        public async Task ForceClient_ClientCredentials()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            string tokenRequestEndpointUrl = await GetInstanceSpecificTokenEndpoint(authInfo);

            AuthInfo clientCredentialsAuthInfo = new AuthInfo
            {
                AuthMethod = AuthInfo.AuthMethodType.ClientCredentials,
                ClientId = authInfo.ClientId,
                ClientSecret = authInfo.ClientSecret,
                TokenRequestEndpoint = tokenRequestEndpointUrl,
                ApiVersion = authInfo.ApiVersion
            };

            ForceClient client = new ForceClient(clientCredentialsAuthInfo);

            Assert.True(!string.IsNullOrEmpty(client.AccessInfo.AccessToken));
        }

        [Fact]
        public async Task ForceClient_FromClientCredentialsAsync()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            string tokenRequestEndpointUrl = await GetInstanceSpecificTokenEndpoint(authInfo);

            ForceClient client = await ForceClient.FromClientCredentialsAsync(
                authInfo.ClientId, authInfo.ClientSecret, tokenRequestEndpointUrl, authInfo.ApiVersion);

            Assert.True(!string.IsNullOrEmpty(client.AccessInfo.AccessToken));
            Assert.False(string.IsNullOrEmpty(client.InstanceUrl));
        }

        [Fact]
        public async Task TokenRefreshAsync()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            // the username-password flow used to populate credentials_dev.json doesn't return a refresh
            // token, so this test needs one obtained separately (e.g. via the Web Server flow) and set manually
            const string skipReason = "No refreshToken configured in credentials_dev.json";
            if (string.IsNullOrEmpty(authInfo.RefreshToken) || authInfo.RefreshToken.StartsWith("optional"))
            {
#if XUNIT_V3
                Assert.Skip(skipReason);
#else
                Console.WriteLine("Skipping TokenRefreshAsync - " + skipReason);
                return;
#endif
            }

            AuthenticationClient auth = new AuthenticationClient();
            await auth.TokenRefreshAsync(authInfo.RefreshToken, authInfo.ClientId, authInfo.ClientSecret, authInfo.TokenRequestEndpoint);

            Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken));

            // with refresh token rotation enabled a new refresh token is returned, otherwise the current one is kept
            Assert.False(string.IsNullOrEmpty(auth.AccessInfo.RefreshToken));
        }

        [Fact]
        public async Task TokenRefreshAsync_InvalidToken()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            // the refresh token and credentials are sent in the request body - invalid_grant shows Salesforce read
            // grant_type and refresh_token from the body (otherwise e.g. unsupported_grant_type), without needing a real refresh token
            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                async () => await auth.TokenRefreshAsync("not-a-real-refresh-token", authInfo.ClientId, authInfo.ClientSecret, authInfo.TokenRequestEndpoint)
            );

            Assert.Equal("invalid_grant", ex.ErrorCode);
        }

        [Fact]
        public async Task WebServerAsync_InvalidCode()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            // WebServerAsync requires an authorization code from an interactive browser consent flow,
            // which can't be automated here - this only covers the error-handling branch with a bad code
            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                async () => await auth.WebServerAsync(authInfo.ClientId, authInfo.ClientSecret, "https://localhost/callback", "not-a-real-authorization-code", authInfo.TokenRequestEndpoint)
            );

            // the OAuth error code was previously replaced with "Unknown" in this flow. The actual code depends on the
            // connected app - e.g. redirect_uri_mismatch is returned before the code is checked if the callback URL doesn't match
            Assert.False(string.IsNullOrEmpty(ex.ErrorCode));
            Assert.NotEqual("Unknown", ex.ErrorCode);
        }
    }
}
