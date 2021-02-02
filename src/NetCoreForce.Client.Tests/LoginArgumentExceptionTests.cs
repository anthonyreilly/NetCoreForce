using System;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class LoginArgumentExceptionTests
    {
        const string DefaultTokenRequestEndpoint = "https://login.salesforce.com/services/oauth2/token";

        [Fact]
        public void MalformedTokenRequestEndpoint()
        {
            AuthenticationClient auth = new AuthenticationClient();

            FormatException ex = Assert.Throws<FormatException>(() =>
                auth.UsernamePassword("ClientId", "ClientSecret", "username", "badpassword", "malformed_tokenRequestEndpoint")
            );

            Assert.Contains("tokenRequestEndpointUrl", ex.Message);
        }

        [Fact]
        public void ForceClientAndAuthenticationClientThrowSameError()
        {
            //check that the ForceClient and AuthenticationClient both throw the same argument exception
            AuthenticationClient auth = new AuthenticationClient();

            ArgumentNullException acex = Assert.Throws<ArgumentNullException>(() =>
            {
                var client = new ForceClient("ClientId", "ClientSecret", "username", "", DefaultTokenRequestEndpoint);
            });

            ArgumentNullException fcex = Assert.Throws<ArgumentNullException>(() =>
                auth.UsernamePassword("ClientId", "ClientSecret", "username", "", DefaultTokenRequestEndpoint)
            );

            Assert.True(fcex.GetType() == acex.GetType());
            Assert.True(acex.Message == fcex.Message);
        }

        [Fact]
        public void EmptyClientIdArgumentNullException()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var client = new ForceClient(null, "ClientSecret", "username", "password", DefaultTokenRequestEndpoint);
            });

            Assert.Contains("clientid", ex.Message.ToLower());
        }

        [Fact]
        public void EmptyClientSecretArgumentNullException()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var client = new ForceClient("ClientId", null, "username", "password", DefaultTokenRequestEndpoint);
            });

            Assert.Contains("clientsecret", ex.Message.ToLower());
        }

        [Fact]
        public void EmptyUsernameArgumentNullException()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var client = new ForceClient("ClientId", "ClientSecret", null, "password", DefaultTokenRequestEndpoint);
            });

            Assert.Contains("username", ex.Message.ToLower());
        }

        [Fact]
        public void EmptyPasswordArgumentNullException()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var client = new ForceClient("ClientId", "ClientSecret", "username", null, DefaultTokenRequestEndpoint);
            });

            Assert.Contains("password", ex.Message.ToLower());
        }
    }
}