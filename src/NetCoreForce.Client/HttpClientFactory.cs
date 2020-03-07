using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NetCoreForce.Client
{
    public class HttpClientFactory
    {
        private const string GZipEncoding = "gzip";
        private const string DeflateEncoding = "deflate";

        public static HttpClient CreateHttpClient(bool useCompression = true, string proxyUrl = null)
        {
            var handler = new HttpClientHandler();
            if (useCompression && handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }

            if (!string.IsNullOrEmpty(proxyUrl))
            {
                handler.Proxy = new CustomProxy(proxyUrl);
            }

            var httpClient = new HttpClient(handler);

            if (useCompression && handler.SupportsAutomaticDecompression)
            {
                httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue(GZipEncoding));
                httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue(DeflateEncoding));
            }

            return httpClient;
        }
    }
}