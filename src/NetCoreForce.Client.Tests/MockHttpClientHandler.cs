using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class MockHttpClientHandler : DelegatingHandler
    {
        private readonly Dictionary<Uri, HttpResponseMessage> _MockResponses = new Dictionary<Uri, HttpResponseMessage>();

        public void AddMockResponse(Uri uri, HttpResponseMessage responseMessage)
        {
            _MockResponses.Add(uri, responseMessage);
        }

        public void AddMockResponse(Uri uri, HttpStatusCode statusCode, string responseContent)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            responseMessage.Content = new StringContent(responseContent);
            
            _MockResponses.Add(uri, responseMessage);
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            if (_MockResponses.ContainsKey(request.RequestUri))
            {
                //return _MockResponses[request.RequestUri];
                return await Task.FromResult(_MockResponses[request.RequestUri]);
            }
            else
            {
                //return new HttpResponseMessage(HttpStatusCode.NotFound) { RequestMessage = request };
                return await Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound) { RequestMessage = request });
            }
        }

        // protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        // {
        //     if (_MockResponses.ContainsKey(request.RequestUri))
        //     {
        //         return Task.FromResult(_MockResponses[request.RequestUri]);
        //     }
        //     else
        //     {
        //         return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotFound) { RequestMessage = request });
        //     }
        // }
    }
}
