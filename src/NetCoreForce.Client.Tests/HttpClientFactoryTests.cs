using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class HttpClientFactoryTests
    {
        [Fact]
        public void CreateHttpClientRequestsCompression()
        {
            HttpClient httpClient = HttpClientFactory.CreateHttpClient();

            Assert.Contains(httpClient.DefaultRequestHeaders.AcceptEncoding, e => e.Value == "gzip");
            Assert.Contains(httpClient.DefaultRequestHeaders.AcceptEncoding, e => e.Value == "deflate");
        }

#if NET
        [Fact]
        public void CreateHandlerSetsPooledConnectionLifetime()
        {
            // without a connection lifetime, a long-lived HttpClient never picks up DNS changes
            bool decompress;
            HttpMessageHandler handler = HttpClientFactory.CreateHandler(true, null, out decompress);

            SocketsHttpHandler socketsHandler = Assert.IsType<SocketsHttpHandler>(handler);
            Assert.Equal(HttpClientFactory.ConnectionLifetime, socketsHandler.PooledConnectionLifetime);
            Assert.Equal(DecompressionMethods.GZip | DecompressionMethods.Deflate, socketsHandler.AutomaticDecompression);
            Assert.True(decompress);
        }

        [Fact]
        public void CreateHandlerSetsProxy()
        {
            bool decompress;
            HttpMessageHandler handler = HttpClientFactory.CreateHandler(false, "http://proxy.example.org:8080", out decompress);

            SocketsHttpHandler socketsHandler = Assert.IsType<SocketsHttpHandler>(handler);
            Assert.IsType<CustomProxy>(socketsHandler.Proxy);
            Assert.Equal(DecompressionMethods.None, socketsHandler.AutomaticDecompression);
            Assert.False(decompress);
        }
#endif

#if NETFRAMEWORK
        [Fact]
        public void CreateHandlerWrapsWithConnectionLeaseHandler()
        {
            bool decompress;
            HttpMessageHandler handler = HttpClientFactory.CreateHandler(true, null, out decompress);

            Assert.IsType<HttpClientFactory.ConnectionLeaseHandler>(handler);
        }

        [Fact]
        public async Task ConnectionLeaseHandlerSetsServicePointLeaseTimeout()
        {
            // without a lease timeout, ServicePoint keeps connections open indefinitely and never picks up DNS changes
            Uri uri = new Uri("http://lease.example.org/test");

            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(uri, new HttpResponseMessage(HttpStatusCode.OK));

            HttpClient httpClient = new HttpClient(new HttpClientFactory.ConnectionLeaseHandler(mockHandler));
            await httpClient.GetAsync(uri);

            Assert.Equal((int)HttpClientFactory.ConnectionLifetime.TotalMilliseconds, ServicePointManager.FindServicePoint(uri).ConnectionLeaseTimeout);
        }
#endif
    }
}
