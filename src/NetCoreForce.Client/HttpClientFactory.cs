using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NetCoreForce.Client.Serializer;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    public class HttpClientFactory
    {
        private const string GZipEncoding = "gzip";
        private const string DeflateEncoding = "deflate";

        /// <summary>
        /// How long a pooled connection is reused before being replaced.
        /// <para>HttpClient instances are long-lived, so without this, connections are kept open indefinitely and DNS changes are never picked up.</para>
        /// </summary>
        internal static readonly TimeSpan ConnectionLifetime = TimeSpan.FromMinutes(2);

        /// <summary>
        /// Create an HttpClient, intended to be long-lived and shared.
        /// <para>On .NET 8+ and .NET Framework, pooled connections are periodically replaced so DNS changes are picked up.</para>
        /// </summary>
        /// <param name="useCompression">Request gzip/deflate compressed responses</param>
        /// <param name="proxyUrl">Proxy URL (Optional)</param>
        public static HttpClient CreateHttpClient(bool useCompression = true, string proxyUrl = null)
        {
            bool decompress;
            HttpMessageHandler handler = CreateHandler(useCompression, proxyUrl, out decompress);

            HttpClient httpClient = new HttpClient(handler);

            if (decompress)
            {
                httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue(GZipEncoding));
                httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue(DeflateEncoding));
            }

            return httpClient;
        }

        internal static HttpMessageHandler CreateHandler(bool useCompression, string proxyUrl, out bool decompress)
        {
#if NET
            if (UseSocketsHttpHandler())
            {
                var socketsHandler = new SocketsHttpHandler
                {
                    PooledConnectionLifetime = ConnectionLifetime
                };

                decompress = useCompression;
                if (decompress)
                {
                    socketsHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                }

                if (!string.IsNullOrEmpty(proxyUrl))
                {
                    socketsHandler.Proxy = new CustomProxy(proxyUrl);
                }

                return socketsHandler;
            }
#endif

            var handler = new HttpClientHandler();

            decompress = useCompression && handler.SupportsAutomaticDecompression;
            if (decompress)
            {
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }

            if (!string.IsNullOrEmpty(proxyUrl))
            {
                handler.Proxy = new CustomProxy(proxyUrl);
            }

#if NETFRAMEWORK
            return new ConnectionLeaseHandler(handler);
#else
            return handler;
#endif
        }

#if NET
        /// <summary>
        /// On browser and mobile platforms HttpClientHandler wraps the platform's native handler, which manages its own connections - keep it there.
        /// </summary>
        private static bool UseSocketsHttpHandler()
        {
            return SocketsHttpHandler.IsSupported
                && !OperatingSystem.IsAndroid()
                && !OperatingSystem.IsIOS()
                && !OperatingSystem.IsTvOS()
                && !OperatingSystem.IsMacCatalyst();
        }
#endif

#if NETFRAMEWORK
        /// <summary>
        /// On .NET Framework, HttpClientHandler connections are managed by ServicePoint, which keeps them open indefinitely by default.
        /// <para>Sets a connection lease timeout on the ServicePoint for each request's host, so connections are periodically replaced and DNS changes are picked up.</para>
        /// </summary>
        internal class ConnectionLeaseHandler : DelegatingHandler
        {
            public ConnectionLeaseHandler(HttpMessageHandler innerHandler) : base(innerHandler) { }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
            {
                //set on every request, since an idle ServicePoint is discarded and recreated with the default timeout
                ServicePointManager.FindServicePoint(request.RequestUri).ConnectionLeaseTimeout = (int)ConnectionLifetime.TotalMilliseconds;

                return base.SendAsync(request, cancellationToken);
            }
        }
#endif
    }
}
