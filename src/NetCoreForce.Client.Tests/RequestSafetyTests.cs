using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// The access token and credentials should only ever be sent over HTTPS, to the expected host,
    /// and request values should not be able to change the structure of the request
    /// </summary>
    public class RequestSafetyTests
    {
        const string InstanceUrl = "https://na15.salesforce.com";
        const string ApiVersion = "v57.0";
        const string TokenEndpoint = "https://login.salesforce.com/services/oauth2/token";

        [Fact]
        public void NonHttpsInstanceUrlThrows()
        {
            Assert.Throws<ArgumentException>(() => new ForceClient("http://na15.salesforce.com", ApiVersion, "dummyToken"));
        }

        [Fact]
        public void InvalidApiVersionThrows()
        {
            Assert.Throws<ArgumentException>(() => new ForceClient(InstanceUrl, "//evil.example/x", "dummyToken"));
        }

        [Fact]
        public async Task AuthenticationNonHttpsEndpointThrows()
        {
            // credentials must not be sent in cleartext
            const string httpEndpoint = "http://login.salesforce.com/services/oauth2/token";
            AuthenticationClient auth = new AuthenticationClient(httpClient: new HttpClient(new MockHttpClientHandler()));

            await Assert.ThrowsAsync<ArgumentException>(() => auth.UsernamePasswordAsync("id", "secret", "user", "password", httpEndpoint));
            await Assert.ThrowsAsync<ArgumentException>(() => auth.WebServerAsync("id", "secret", "https://example.org/callback", "code", httpEndpoint));
            await Assert.ThrowsAsync<ArgumentException>(() => auth.ClientCredentialsAsync("id", "secret", httpEndpoint));
            await Assert.ThrowsAsync<ArgumentException>(() => auth.TokenRefreshAsync("refreshToken", "id", "secret", httpEndpoint));
            await Assert.ThrowsAsync<ArgumentException>(() => auth.IntrospectTokenAsync("token", "id", "secret", "http://login.salesforce.com/services/oauth2/introspect"));
        }

        [Fact]
        public async Task AuthenticationNonHttpsInstanceUrlInResponseThrows()
        {
            // instance_url comes from the token response - the access token must not then be sent over http
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri(TokenEndpoint), HttpStatusCode.OK,
                @"{ ""access_token"": ""token"", ""instance_url"": ""http://na15.salesforce.com"", ""token_type"": ""Bearer"" }");

            await Assert.ThrowsAsync<ArgumentException>(() =>
                ForceClient.FromClientCredentialsAsync("id", "secret", TokenEndpoint, ApiVersion, new HttpClient(mockHandler)));
        }

        [Fact]
        public async Task VersionsRequestDoesNotSendAccessToken()
        {
            // the Versions resource needs no authentication, and can be pointed at any instance URL
            const string otherInstanceUrl = "https://other.example.org";

            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Versions(otherInstanceUrl), MockResponse.GetResponse("versions.json", HttpStatusCode.OK));

            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            List<SalesforceVersion> versions = await client.GetAvailableRestApiVersions(otherInstanceUrl);

            Assert.NotEmpty(versions);
            Assert.Null(mockHandler.LastRequestAuthorization);
        }

        [Fact]
        public async Task QueryNextRecordsUrlOffInstanceThrows()
        {
            // nextRecordsUrl comes from the response - the access token must not follow it to another host
            const string query = "SELECT Id FROM Account";

            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(InstanceUrl, ApiVersion, query), HttpStatusCode.OK,
                @"{ ""totalSize"": 4, ""done"": false, ""nextRecordsUrl"": ""https://evil.example/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000"",
                    ""records"": [ { ""attributes"": { ""type"": ""Account"" }, ""Id"": ""001XXXXXXXXXXXXXXX"" } ] }");

            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            await Assert.ThrowsAsync<ForceApiException>(() => client.Query<SfAccount>(query));
            Assert.Equal("na15.salesforce.com", mockHandler.LastRequestUri.Host);
        }

        [Fact]
        public async Task QueryAsyncNextRecordsUrlOffInstanceThrows()
        {
            const string query = "SELECT Id FROM Account";

            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(InstanceUrl, ApiVersion, query), HttpStatusCode.OK,
                @"{ ""totalSize"": 4, ""done"": false, ""nextRecordsUrl"": ""//evil.example/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000"",
                    ""records"": [ { ""attributes"": { ""type"": ""Account"" }, ""Id"": ""001XXXXXXXXXXXXXXX"" } ] }");

            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            await Assert.ThrowsAsync<ForceApiException>(async () =>
            {
                await using (IAsyncEnumerator<SfAccount> enumerator = client.QueryAsync<SfAccount>(query).GetAsyncEnumerator())
                {
                    while (await enumerator.MoveNextAsync()) { }
                }
            });
            Assert.Equal("na15.salesforce.com", mockHandler.LastRequestUri.Host);
        }

        [Theory]
        [InlineData("app\nX-Injected: 1")]
        [InlineData("app\rX-Injected: 1")]
        [InlineData("app\0")]
        [InlineData("app, defaultNamespace=evil")]
        [InlineData("app=evil")]
        public void CallOptionsInvalidValueThrows(string value)
        {
            // control characters can inject headers on .NET Framework, and , or = can inject call options on any runtime
            Assert.Throws<ArgumentException>(() => HeaderFormatter.SforceCallOptions(client: value));
            Assert.Throws<ArgumentException>(() => HeaderFormatter.SforceCallOptions(defaultNamespace: value));
        }

        [Fact]
        public async Task ClientNameInvalidValueThrows()
        {
            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(new MockHttpClientHandler()));
            client.ClientName = "app\nX-Injected: 1";

            await Assert.ThrowsAsync<ArgumentException>(() => client.Query<SfAccount>("SELECT Id FROM Account"));
        }

        [Fact]
        public async Task CustomHeaderControlCharacterThrows()
        {
            JsonClient client = new JsonClient("dummyToken", new HttpClient(new MockHttpClientHandler()));
            var headers = new Dictionary<string, string> { { "X-Test", "a\nX-Injected: 1" } };

            await Assert.ThrowsAsync<ArgumentException>(() => client.HttpGetAsync<object>(new Uri(InstanceUrl), headers));
        }

        [Fact]
        public void AccessTokenControlCharacterThrows()
        {
            Assert.Throws<ArgumentException>(() => new JsonClient("token\nX-Injected: 1"));
        }

        [Fact]
        public void AuthenticationHandlerDoesNotFollowRedirects()
        {
            // a 307/308 redirect would re-send the credentials in the request body to the redirect location
            bool decompress;
            HttpMessageHandler handler = HttpClientFactory.CreateHandler(true, null, false, out decompress);

            while (handler is DelegatingHandler delegatingHandler)
            {
                handler = delegatingHandler.InnerHandler;
            }

#if NET
            if (handler is SocketsHttpHandler socketsHandler)
            {
                Assert.False(socketsHandler.AllowAutoRedirect);
                return;
            }
#endif
            Assert.False(Assert.IsType<HttpClientHandler>(handler).AllowAutoRedirect);
        }
    }
}
