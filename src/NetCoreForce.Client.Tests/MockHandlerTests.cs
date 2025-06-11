using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreForce.Client;
using Xunit;
using NetCoreForce.Models;

namespace NetCoreForce.Client.Tests
{
    public class MockHandlerTests
    {
        [Fact]
        public async Task MockHandlerTest()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri("http://example.org/test"), new HttpResponseMessage(HttpStatusCode.OK));

            var httpClient = new HttpClient(mockHandler);

            var response1 = await httpClient.GetAsync("http://example.org/notthere");
            var response2 = await httpClient.GetAsync("http://example.org/test");

            Assert.Equal(HttpStatusCode.NotFound, response1.StatusCode);
            Assert.Equal(HttpStatusCode.OK, response2.StatusCode);
        }
    }
}
