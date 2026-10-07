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
        // a new response is created for each request, since the client disposes each response after reading it
        private readonly Dictionary<Uri, Func<HttpResponseMessage>> _MockResponses = new Dictionary<Uri, Func<HttpResponseMessage>>();

        /// <summary>
        /// URI of the most recent request
        /// </summary>
        public Uri LastRequestUri { get; private set; }

        /// <summary>
        /// Content of the most recent request, if any
        /// </summary>
        public string LastRequestContent { get; private set; }

        /// <summary>
        /// Authorization header of the most recent request, if any
        /// </summary>
        public System.Net.Http.Headers.AuthenticationHeaderValue LastRequestAuthorization { get; private set; }

        public void AddMockResponse(Uri uri, HttpResponseMessage responseMessage)
        {
            // buffer the content now, and return a copy for each request
            byte[] content = responseMessage.Content != null ? responseMessage.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult() : null;

            _MockResponses.Add(uri, () =>
            {
                var copy = new HttpResponseMessage(responseMessage.StatusCode) { ReasonPhrase = responseMessage.ReasonPhrase };
                foreach (var header in responseMessage.Headers)
                {
                    copy.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }

                if (content != null)
                {
                    copy.Content = new ByteArrayContent(content);
                    foreach (var header in responseMessage.Content.Headers)
                    {
                        copy.Content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                    }
                }

                return copy;
            });
        }

        public void AddMockResponse(Uri uri, HttpStatusCode statusCode, string responseContent)
        {
            _MockResponses.Add(uri, () => new HttpResponseMessage(statusCode) { Content = new StringContent(responseContent) });
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            // read the content here - .NET Framework's HttpClient disposes request content once the request completes
            LastRequestUri = request.RequestUri;
            LastRequestAuthorization = request.Headers.Authorization;
            LastRequestContent = request.Content != null ? await request.Content.ReadAsStringAsync() : null;

            if (_MockResponses.ContainsKey(request.RequestUri))
            {
                return _MockResponses[request.RequestUri]();
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
