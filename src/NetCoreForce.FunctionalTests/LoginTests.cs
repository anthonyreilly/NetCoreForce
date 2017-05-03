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
        public async Task UsernamePasswordLogin()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
                    authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint);

            Assert.True(!string.IsNullOrEmpty(auth.AccessInfo.AccessToken)); //check for access token
            Assert.True(string.IsNullOrEmpty(auth.AccessInfo.RefreshToken)); //this flow should not return a refresh token
        }

        [Fact]
        public async Task UsernamePasswordLoginFail()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;

            AuthenticationClient auth = new AuthenticationClient();

            // try
            // {
            //     await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret,
            //         authInfo.Username, "badpassword", authInfo.TokenRequestEndpoint);
            // }
            // catch (ForceAuthException ex)
            // {
            //     Assert.Equal("invalid_grant", ex.ErrorCode);
            //     Assert.Equal("authentication failure", ex.Message);
            // }

            ForceAuthException ex = await Assert.ThrowsAsync<ForceAuthException>(
                async () => await auth.UsernamePasswordAsync(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, "badpassword", authInfo.TokenRequestEndpoint)
            );

            Assert.Equal("invalid_grant", ex.ErrorCode);
            Assert.Equal("authentication failure", ex.Message);
        }
    }
}