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

        // [Fact]
        // public async Task IntrospectTokenAsync_ActiveToken()
        // {
        //     AuthInfo authInfo = forceClientFixture.AuthInfo;

        //     AuthenticationClient auth = new AuthenticationClient();
        //     await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
        //             authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);

        //     IntrospectTokenResponse introspectResponse = await auth.IntrospectTokenAsync(
        //         auth.AccessInfo.AccessToken, authInfo.ClientId, authInfo.ClientSecret, IntrospectTokenEndpoint(authInfo));

        //     Assert.True(introspectResponse.Active);
        //     Assert.Equal(authInfo.ClientId, introspectResponse.ClientId);
        // }

        // [Fact]
        // public async Task IntrospectTokenAsync_InactiveToken()
        // {
        //     AuthInfo authInfo = forceClientFixture.AuthInfo;

        //     AuthenticationClient auth = new AuthenticationClient();

        //     IntrospectTokenResponse introspectResponse = await auth.IntrospectTokenAsync(
        //         "not-a-real-token", authInfo.ClientId, authInfo.ClientSecret, IntrospectTokenEndpoint(authInfo));

        //     Assert.False(introspectResponse.Active);
        // }

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

        // [Fact]
        // public async Task TokenRefreshAsync()
        // {
        //     AuthInfo authInfo = forceClientFixture.AuthInfo;

        //     if (string.IsNullOrEmpty(authInfo.RefreshToken))
        //     {
        //         // the username-password flow used to populate credentials_dev.json doesn't return a refresh
        //         // token, so this test needs one obtained separately (e.g. via the Web Server flow) and set manually
        //         Console.WriteLine("Skipping TokenRefreshAsync - no refreshToken configured in credentials_dev.json");
        //         return;
        //     }

        //     AuthenticationClient auth = new AuthenticationClient();
        //     await auth.TokenRefreshAsync(authInfo.RefreshToken, authInfo.ClientId, authInfo.ClientSecret, authInfo.TokenRequestEndpoint);

        //     Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken));
        //     Assert.Equal(authInfo.RefreshToken, auth.AccessInfo.RefreshToken);
        // }

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

            Assert.False(string.IsNullOrEmpty(ex.ErrorCode));
        }
    }
}
