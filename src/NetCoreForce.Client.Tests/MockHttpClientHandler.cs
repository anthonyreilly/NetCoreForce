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

        // responses for a specific method and URI, checked before the URI-only responses
        private readonly Dictionary<string, Func<HttpResponseMessage>> _MockMethodResponses = new Dictionary<string, Func<HttpResponseMessage>>();

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

        /// <summary>
        /// HTTP method of the most recent request
        /// </summary>
        public HttpMethod LastRequestMethod { get; private set; }

        /// <summary>
        /// Content type of the most recent request, if any
        /// </summary>
        public System.Net.Http.Headers.MediaTypeHeaderValue LastRequestContentType { get; private set; }

        /// <summary>
        /// Headers of the most recent request
        /// </summary>
        public System.Net.Http.Headers.HttpRequestHeaders LastRequestHeaders { get; private set; }

        /// <summary>
        /// All requests received, in order
        /// </summary>
        public List<MockRequest> Requests { get; } = new List<MockRequest>();

        /// <summary>
        /// Add a response for a specific method and URI. The function is called for each request, so it can return a different response each time.
        /// </summary>
        public void AddMockResponse(HttpMethod method, Uri uri, Func<HttpResponseMessage> responseFactory)
        {
            _MockMethodResponses.Add(MethodKey(method, uri), responseFactory);
        }

        /// <summary>
        /// Add a response for a specific method and URI
        /// </summary>
        public void AddMockResponse(HttpMethod method, Uri uri, HttpStatusCode statusCode, string responseContent)
        {
            AddMockResponse(method, uri, () => new HttpResponseMessage(statusCode) { Content = new StringContent(responseContent ?? string.Empty) });
        }

        private static string MethodKey(HttpMethod method, Uri uri)
        {
            return method.Method + " " + uri.AbsoluteUri;
        }

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
            // as a real handler would
            cancellationToken.ThrowIfCancellationRequested();

            // read the content here - .NET Framework's HttpClient disposes request content once the request completes
            LastRequestUri = request.RequestUri;
            LastRequestAuthorization = request.Headers.Authorization;
            LastRequestContent = request.Content != null ? await request.Content.ReadAsStringAsync() : null;
            LastRequestMethod = request.Method;
            LastRequestContentType = request.Content?.Headers.ContentType;
            LastRequestHeaders = request.Headers;
            Requests.Add(new MockRequest(request.Method, request.RequestUri, LastRequestContent, LastRequestContentType?.MediaType));

            if (_MockMethodResponses.TryGetValue(MethodKey(request.Method, request.RequestUri), out Func<HttpResponseMessage> methodResponse))
            {
                return methodResponse();
            }

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

    /// <summary>
    /// A request received by the MockHttpClientHandler
    /// </summary>
    public class MockRequest
    {
        public MockRequest(HttpMethod method, Uri uri, string content, string contentType)
        {
            Method = method;
            Uri = uri;
            Content = content;
            ContentType = contentType;
        }

        public HttpMethod Method { get; }
        public Uri Uri { get; }
        public string Content { get; }
        public string ContentType { get; }
    }
}
