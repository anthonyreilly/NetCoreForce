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
    public class JsonClient : IDisposable
    {
        private const string JsonMimeType = "application/json";
        // private const string GZipEncoding = "gzip";
        // private const string DeflateEncoding = "deflate";

        //best practice is to reuse HttpClient
        //https://github.com/mspnp/performance-optimization/blob/master/ImproperInstantiation/docs/ImproperInstantiation.md
        //By default, and the ideal case, is using the static readonly HttpClient.
        //Alternatively, for testing and special cases, a class instance instnace of an HttpClient can be used instead.
        private static readonly HttpClient _SharedHttpClient;
        private HttpClient _httpClient;
        private HttpClient SharedHttpClient
        {
            get
            {
                //use the instance client when extant, otherwise use the default shared instance.
                return _httpClient ?? _SharedHttpClient;
            }
        }

        AuthenticationHeaderValue _authHeaderValue;

        /// <summary>
        /// JSON Client static constructor, initializes the default shared HttpClient instance.
        /// </summary>
        static JsonClient()
        {
            _SharedHttpClient = HttpClientFactory.CreateHttpClient();
        }

        /// <summary>
        /// Intialize the JSON client.
        /// <para>By default, uses a shared static HttpClient instance for best performance.</para>
        /// </summary>
        /// <param name="accessToken">API Access token</param>
        /// <param name="httpClient">Optional custom HttpClient. Ideally this should be a shared static instance for best performance.</param>
        public JsonClient(string accessToken, HttpClient httpClient = null)
        {
            _authHeaderValue = new AuthenticationHeaderValue("Bearer", accessToken);

            if (httpClient != null)
            {
                _httpClient = httpClient;
            }
        }

        public async Task<T> HttpGetAsync<T>(Uri uri, Dictionary<string, string> customHeaders = null)
        {
            //can handle T = string?
            //request.Headers.Add("Sforce-Auto-Assign", "FALSE");
            try
            {
                // HttpRequestMessage request = new HttpRequestMessage();
                // request.Headers.Authorization = _authHeaderValue;
                // request.RequestUri = new Uri(url);
                // request.Method = HttpMethod.Get;
                // return await GetResponse<T>(request, customHeaders);

                return await HttpAsync<T>(uri, HttpMethod.Get, null, customHeaders);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> HttpPostAsync<T>(object inputObject, Uri uri, Dictionary<string, string> customHeaders = null)
        {
            var json = JsonSerializer.SerializeForCreate(inputObject);

            try
            {
                var content = new StringContent(json, Encoding.UTF8, JsonMimeType);

                HttpRequestMessage request = new HttpRequestMessage();
                request.Headers.Authorization = _authHeaderValue;
                request.RequestUri = uri;
                request.Method = HttpMethod.Post;
                request.Content = content;

                return await GetResponse<T>(request, customHeaders);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> HttpPatchAsync<T>(object inputObject, Uri uri, Dictionary<string, string> customHeaders = null)
        {
            // var json = JsonSerializer.SerializeForUpdate(inputObject);

            // try
            // {
            //     var content = new StringContent(json, Encoding.UTF8, JsonMimeType);

            //     HttpRequestMessage request = new HttpRequestMessage();
            //     request.Headers.Authorization = _authHeaderValue;
            //     request.RequestUri = uri;
            //     request.Method = new HttpMethod("PATCH");
            //     request.Content = content;

            //     return await GetResponse<T>(request, customHeaders);
            // }
            // catch (Exception ex)
            // {
            //     throw ex;
            // }            

            try
            {
                var json = JsonSerializer.SerializeForUpdate(inputObject);
                var content = new StringContent(json, Encoding.UTF8, JsonMimeType);
                
                return await HttpAsync<T>(uri, new HttpMethod("PATCH"), content, customHeaders);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public async Task<T> HttpDeleteAsync<T>(Uri uri, Dictionary<string, string> customHeaders = null)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.Headers.Authorization = _authHeaderValue;
                request.RequestUri = uri;
                request.Method = HttpMethod.Delete;

                return await GetResponse<T>(request, customHeaders);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<T> HttpAsync<T>(Uri uri, HttpMethod httpMethod, HttpContent content = null, Dictionary<string, string> customHeaders = null)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.Headers.Authorization = _authHeaderValue;
                request.RequestUri = uri;
                request.Method = httpMethod;
                if(content != null)
                {
                    request.Content = content;
                }

                return await GetResponse<T>(request, customHeaders);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<T> GetResponse<T>(HttpRequestMessage request, Dictionary<string, string> customHeaders = null)
        {
            //const string ContentEncoding = "Content-Encoding";

            if (customHeaders != null && customHeaders.Count > 0)
            {
                foreach (KeyValuePair<string, string> header in customHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            HttpResponseMessage responseMessage = null;
            try
            {
                responseMessage = await SharedHttpClient.SendAsync(request).ConfigureAwait(false);
            }
            catch(Exception ex)
            {
                string errMsg = "Error sending HTTP request:" + ex.Message;
                if(ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    errMsg += " " + ex.InnerException.Message;
                }
                Debug.WriteLine(errMsg);
                throw new ForceApiException(errMsg);
            }

#if DEBUG
            //API usage response header
            //e.g. "Sforce-Limit-Info: api-usage=90/15000"
            const string SforceLimitInfoHeaderName = "Sforce-Limit-Info";
            IEnumerable<string> limitValues = GetHeaderValues(responseMessage.Headers, SforceLimitInfoHeaderName);            
            if(limitValues != null)
            {
                Debug.WriteLine(string.Format("{0}: {1}", SforceLimitInfoHeaderName, limitValues.FirstOrDefault() ?? "none"));
            }
#endif

            if (responseMessage.StatusCode == HttpStatusCode.NoContent)
            {
                return JsonConvert.DeserializeObject<T>(string.Empty);
            }

            if (responseMessage.Content != null)
            {
                //TODO need trycatch here
                string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (responseMessage.IsSuccessStatusCode)
                {
                    if (string.IsNullOrEmpty(responseContent))
                    {
                        throw new ForceApiException("Response content was empty");
                    }
                    return JsonConvert.DeserializeObject<T>(responseContent);
                }
                else
                {
                    var errors = JsonConvert.DeserializeObject<List<ErrorResponse>>(responseContent);
                    throw new ForceApiException(string.Format("Salesforce API returned {0}, see Errors for details.", responseMessage.StatusCode.ToString()), errors, responseMessage.StatusCode);
                }
            }

            throw new ForceApiException("Error processing reponse content");
        }

        /// <summary>
        /// Get values for a particular reponse header
        /// </summary>
        /// <param name="headers">HttpHeaders from the HttpResponseMessage</param>
        /// <param name="headerName">Header Name</param>
        /// <returns>IEnumerable{string} of header values, if any, Null if none found.</returns>
        private IEnumerable<string> GetHeaderValues(HttpHeaders headers, string headerName)
        {
            if (headers != null)
            {                
                IEnumerable<string> values;
                if (headers.TryGetValues(headerName, out values))
                {
                    return values;
                }
            }

            Debug.WriteLine(string.Format("{0} header not found in response", headerName));
            return null;
        }

        /// <summary>
        /// Dispose client - only disposes instance HttpClient, if any. Shared static HttpClient is left as-is.
        /// </summary>
        public void Dispose()
        {
            //only dispose instance member, if any
            if(_httpClient != null)
            {
                _httpClient.Dispose();
            }
        }
    }
}