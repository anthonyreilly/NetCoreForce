using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// A caller-supplied HttpClient is owned by the caller, and should still be usable after the client using it is disposed
    /// </summary>
    public class DisposeTests
    {
        const string TestUrl = "http://example.org/test";

        [Fact]
        public async Task ForceClientDisposeLeavesCallerHttpClientUsable()
        {
            HttpClient httpClient = CreateHttpClient();

            ForceClient client = new ForceClient("https://na15.salesforce.com", "v57.0", "dummyToken", httpClient);
            client.Dispose();

            await AssertHttpClientUsable(httpClient);
        }

        [Fact]
        public async Task JsonClientDisposeLeavesCallerHttpClientUsable()
        {
            HttpClient httpClient = CreateHttpClient();

            JsonClient client = new JsonClient("dummyToken", httpClient);
            client.Dispose();

            await AssertHttpClientUsable(httpClient);
        }

        [Fact]
        public async Task AuthenticationClientDisposeLeavesCallerHttpClientUsable()
        {
            HttpClient httpClient = CreateHttpClient();

            AuthenticationClient client = new AuthenticationClient(httpClient: httpClient);
            client.Dispose();

            await AssertHttpClientUsable(httpClient);
        }

        [Fact]
        public void AuthenticationClientDefaultUsesSharedHttpClient()
        {
            // a new HttpClient per instance means a new connection pool per login
            AuthenticationClient client1 = new AuthenticationClient();
            AuthenticationClient client2 = new AuthenticationClient();

            HttpClient httpClient1 = GetHttpClient(client1);
            HttpClient httpClient2 = GetHttpClient(client2);

            Assert.Same(httpClient1, httpClient2);

            client1.Dispose();
            client2.Dispose();

            // throws ObjectDisposedException if the shared HttpClient was disposed
            httpClient1.CancelPendingRequests();
        }

        private static HttpClient GetHttpClient(AuthenticationClient client)
        {
            FieldInfo field = typeof(AuthenticationClient).GetField("_httpClient", BindingFlags.NonPublic | BindingFlags.Instance);

            return (HttpClient)field.GetValue(client);
        }

        private static HttpClient CreateHttpClient()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri(TestUrl), new HttpResponseMessage(HttpStatusCode.OK));

            return new HttpClient(mockHandler);
        }

        private static async Task AssertHttpClientUsable(HttpClient httpClient)
        {
            // throws ObjectDisposedException if the HttpClient was disposed
            var response = await httpClient.GetAsync(TestUrl);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
