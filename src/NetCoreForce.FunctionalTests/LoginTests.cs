using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class LoginTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public LoginTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task UsernamePasswordLoginAuthenticationClientAsync()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);
            
            ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

            Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken)); //check for access token
            Assert.True(string.IsNullOrEmpty(auth.AccessInfo.RefreshToken)); //this flow should not return a refresh token
        }

        [Fact]
        public async Task GetUserInfoFromIdentityUrl()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);

            ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

            //the identity URL from the token response should pass GetUserInfo's HTTPS URL validation
            UserInfo userInfo = await client.GetUserInfo(auth.AccessInfo.Id);

            Assert.NotNull(userInfo);
            Assert.False(string.IsNullOrEmpty(userInfo.UserId));
            Assert.False(string.IsNullOrEmpty(userInfo.OrganizationId));
            Assert.Equal(authInfo.Username, userInfo.Username, ignoreCase: true);
        }

        [Fact]
        public void UsernamePasswordLoginAuthInfo()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;
            
            ForceClient client = new ForceClient(authInfo);

            Assert.True(!string.IsNullOrEmpty(client.AccessInfo.AccessToken)); //check for access token
            Assert.True(string.IsNullOrEmpty(client.AccessInfo.RefreshToken)); //this flow should not return a refresh token
        }

        [Fact]
        public void UsernamePasswordLogin()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            auth.UsernamePassword(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);

            ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

            Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken)); //check for access token
            Assert.True(string.IsNullOrEmpty(auth.AccessInfo.RefreshToken)); //this flow should not return a refresh token
        }

        [Fact]
        public async Task UsernamePasswordLoginFailAsync()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                async () => await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, "badpassword", authInfo.TokenRequestEndpoint)
            );

            Assert.Equal("invalid_grant", ex.ErrorCode);
            Assert.Equal("authentication failure", ex.Message);
        }

        [Fact]
        public void UsernamePasswordLoginFail()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            ForceAuthException ex = Assert.Throws<ForceAuthException>(() =>
                auth.UsernamePassword(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, "badpassword", authInfo.TokenRequestEndpoint)
            );

            Assert.Equal("invalid_grant", ex.ErrorCode);
            Assert.Equal("authentication failure", ex.Message);
        }        
    }
}