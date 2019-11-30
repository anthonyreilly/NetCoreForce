using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    public class ForceClient
    {
        public string ApiVersion { get; private set; }
        public string InstanceUrl { get; private set; }
        public string AccessToken { get; private set; }
        public string ClientName { get; set; }

        /// <summary>
        /// The Access Token Response data received after a successful login
        /// May not be available if the client was initialized with a pre-existing access token
        /// </summary>
        public AccessTokenResponse AccessInfo { get; set; }

        private HttpClient _httpClient;

        /// <summary>
        /// Login to Salesforce using the username-password authentication flow, and initialize the client
        /// </summary>
        /// <param name="authInfo"></param>
        public ForceClient(AuthInfo authInfo)
        : this(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint, authInfo.ApiVersion)
        { }

        /// <summary>
        /// Login to Salesforce using the username-password authentication flow, and initialize the client
        /// </summary>
        /// <param name="clientId">Client ID, a.k.a. Consumer Key</param>
        /// <param name="clientSecret">Client Secret, a.k.a. Consumer Secret</param>
        /// <param name="username">Salesforce username</param>
        /// <param name="password">Salesforce password</param>
        /// <param name="tokenRequestEndpoint">Token request endpoint <para>e.g. https://login.salesforce.com/services/oauth2/token</para></param>
        /// <param name="apiVersion">Salesforce API version</param>
        /// <param name="httpClient">Optional HttpClient object. Defaults to a shared static instance for best performance, but a custom HttpClient can be specified when custom properties are needed e.g. proxy settings.</param>
        public ForceClient(string clientId, string clientSecret, string username, string password, string tokenRequestEndpoint, string apiVersion = null, HttpClient httpClient = null)
        {
            try
            {
                Login(clientId, clientSecret, username, password, tokenRequestEndpoint, apiVersion, httpClient).Wait();
            }
            catch (AggregateException ax)
            {
                throw ax.InnerException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Initialize the client using previously obtained access token and instance url, if using the AuthenticationClient separately.
        /// </summary>
        /// <param name="instanceUrl">Identifies the Salesforce instance to which API calls should be sent.</param>
        /// <param name="apiVersion">Salesforce API version</param>
        /// <param name="accessToken">Access token</param>
        /// <param name="httpClient">Optional HttpClient object. Defaults to a shared static instance for best performance, but a custom HttpClient can be specified when custom properties are needed e.g. proxy settings.</param>
        /// <param name="accessInfo">AccessTokenResponse object, to store all of the OAuth details received via the AuthenticationClient</param>
        public ForceClient(string instanceUrl, string apiVersion, string accessToken, HttpClient httpClient = null, AccessTokenResponse accessInfo = null)
        {
            Initialize(instanceUrl, apiVersion, accessToken, httpClient, accessInfo);
        }

        private async Task Login(string clientId, string clientSecret, string username, string password, string tokenRequestEndpoint, string apiVersion = null, HttpClient httpClient = null)
        {
            AuthenticationClient authClient = new AuthenticationClient(apiVersion);
            await authClient.UsernamePasswordAsync(clientId, clientSecret, username, password, tokenRequestEndpoint);

            Initialize(authClient.AccessInfo.InstanceUrl, authClient.ApiVersion, authClient.AccessInfo.AccessToken, httpClient, authClient.AccessInfo);
        }

        private void Initialize(string instanceUrl, string apiVersion, string accessToken, HttpClient httpClient = null, AccessTokenResponse accessInfo = null)
        {
            this.ApiVersion = apiVersion;
            this.InstanceUrl = instanceUrl;
            this.AccessToken = accessToken;
            this.AccessInfo = accessInfo;

            _httpClient = httpClient;
        }

        /// <summary>
        /// Does a basic test of the client's connection to the current Salesforce instance, and that the API is responding to requests.
        /// <para>This does not validate authentication.</para>
        /// <para>Makes a call to the Versions resource, since it requires no authentication or permissions.</para>
        /// </summary>
        /// <param name="currentInstanceUrl">Instance URL. Defaults to the client's current instance, this would typically only need to be specified if it is needed to test the connection to a different SFDC instance.</param>
        /// <returns>True or false. Does not throw exceptions, only false in case of any errors.</returns>
        public bool TestConnection(string currentInstanceUrl = null)
        {
            try
            {
                //Makes a call to the Versions resource, since it requires no authentication or permissions.
                //Should serve as an adequate test that the instance is physically reachable and that the API is responding
                GetAvailableRestApiVersions(currentInstanceUrl, deserializeResponse: false).Wait();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("TestConnection() failed with exception: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Retrieve records using a SOQL query.
        /// <para>Will automatically retrieve the complete result set if split into batches. If you want to limit results, use the LIMIT operator in your query.</para>
        /// </summary>
        /// <param name="queryString">SOQL query string, without any URL escaping/encoding</param>
        /// <param name="queryAll">True if deleted records are to be included</param>
        /// <returns>List{T} of results</returns>
        public async Task<List<T>> Query<T>(string queryString, bool queryAll = false)
        {
#if DEBUG
            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif
            try
            {
                Dictionary<string, string> headers = HeaderFormatter.SforceCallOptions(ClientName);
                var queryUri = UriFormatter.Query(InstanceUrl, ApiVersion, queryString, queryAll);

                JsonClient client = new JsonClient(AccessToken, _httpClient);

                List<T> results = new List<T>();

                bool done = false;
                string nextRecordsUrl = string.Empty;

                //larger result sets will be split into batches (sized according to system and account settings)
                //if additional batches are indicated retrieve the rest and append to the result set.
                do
                {
                    if (!string.IsNullOrEmpty(nextRecordsUrl))
                    {
                        queryUri = new Uri(new Uri(InstanceUrl), nextRecordsUrl);
                    }

                    QueryResult<T> qr = await client.HttpGetAsync<QueryResult<T>>(queryUri, headers);

#if DEBUG
                    Debug.WriteLine(string.Format("Got query resuts, {0} totalSize, {1} in this batch, final batch: {2}",
                        qr.TotalSize, qr.Records.Count.ToString(), qr.Done.ToString()));
#endif

                    results.AddRange(qr.Records);

                    done = qr.Done;

                    nextRecordsUrl = qr.NextRecordsUrl;

                    if (!done && string.IsNullOrEmpty(nextRecordsUrl))
                    {
                        //Normally if query has remaining batches, NextRecordsUrl will have a value, and Done will be false.
                        //In case of some unforseen error, flag the result as done if we're missing the NextRecordsUrl
                        //In this situation we'll just get the previous set again and be stuck in a loop.
                        done = true;
                    }

                } while (!done);

#if DEBUG
                sw.Stop();
                Debug.WriteLine(string.Format("Query results retrieved in {0}ms", sw.ElapsedMilliseconds.ToString()));
#endif

                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error querying: " + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Retrieve a single record using a SOQL query.
        /// <para>Will throw an exception if multiple rows are retrieved by the query - if you are note sure of a single result, use Query{T} instead.</para>
        /// </summary>
        /// <param name="queryString">SOQL query string, without any URL escaping/encoding</param>
        /// <param name="queryAll">True if deleted records are to be included</param>
        /// <returns>result object</returns>
        public async Task<T> QuerySingle<T>(string queryString, bool queryAll = false)
        {
            List<T> results = await Query<T>(queryString, queryAll);

            if (results != null && results.Count > 1)
            {
                throw new Exception("Multiple records were returned by query passed into QuerySingle - query must retrieve zero or one record.");
            }

            if (results != null && results.Count == 1)
            {
                return results[0];
            }

            return default(T);
        }

        /// <summary>
        /// Retrieve a <see cref="IAsyncEnumerable{T}"/> using a SOQL query. Batches will be retrieved asynchronously.
        /// <para>When using the iterator, the initial result batch will be returned as soon as it is received. The additional result batches will be retrieved only as needed.</para>
        /// </summary>
        /// <param name="queryString">SOQL query string, without any URL escaping/encoding</param>
        /// <param name="queryAll">Optional. True if deleted records are to be included.await Defaults to false.</param>
        /// <param name="batchSize">Optional. Size of result batches between 200 and 2000</param>
        /// <returns><see cref="IAsyncEnumerable{T}"/> of results</returns>
        public IAsyncEnumerable<T> QueryAsync<T>(string queryString, bool queryAll = false, int? batchSize = null)
        {
            return AsyncEnumerable.CreateEnumerable(() => QueryAsyncEnumerator<T>(queryString, queryAll, batchSize));
        }

        /// <summary>
        /// Retrieve a <see cref="IAsyncEnumerator{T}"/> using a SOQL query. Batches will be retrieved asynchronously.
        /// <para>When using the iterator, the initial result batch will be returned as soon as it is received. The additional result batches will be retrieved only as needed.</para>
        /// </summary>
        /// <param name="queryString">SOQL query string, without any URL escaping/encoding</param>
        /// <param name="queryAll">Optional. True if deleted records are to be included.await Defaults to false.</param>
        /// <param name="batchSize">Optional. Size of result batches between 200 and 2000</param>
        /// <returns><see cref="IAsyncEnumerator{T}"/> of results</returns>
        public IAsyncEnumerator<T> QueryAsyncEnumerator<T>(string queryString, bool queryAll = false, int? batchSize = null)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();

            //Add call options
            Dictionary<string, string> callOptions = HeaderFormatter.SforceCallOptions(ClientName);
            headers.AddRange(callOptions);

            //Add query options headers if batch size specified
            if (batchSize.HasValue)
            {
                Dictionary<string, string> queryOptions = HeaderFormatter.SforceQueryOptions(batchSize.Value);
                headers.AddRange(queryOptions);
            }

            var jsonClient = new JsonClient(AccessToken, _httpClient);

            // Enumerator on the current batch items
            IEnumerator<T> currentBatchEnumerator = null;
            var done = false;
            var nextRecordsUri = UriFormatter.Query(InstanceUrl, ApiVersion, queryString, queryAll);

            return AsyncEnumerable.CreateEnumerator(MoveNextAsync, Current, Dispose);

            async Task<bool> MoveNextAsync(CancellationToken token)
            {
                if (token.IsCancellationRequested)
                {
                    return false;
                }

                // If items remain in the current Batch enumerator, go to next item
                if (currentBatchEnumerator?.MoveNext() == true)
                {
                    return true;
                }

                // if done, no more items.
                if (done)
                {
                    return false;
                }

                // else : no enumerator or currentBatchEnumerator ended
                // so get the next batch
                var qr = await jsonClient.HttpGetAsync<QueryResult<T>>(nextRecordsUri, headers);

#if DEBUG
                Debug.WriteLine($"Got query resuts, {qr.TotalSize} totalSize, {qr.Records.Count} in this batch, final batch: {qr.Done}");
#endif

                currentBatchEnumerator = qr.Records.GetEnumerator();

                if (!string.IsNullOrEmpty(qr.NextRecordsUrl))
                {
                    nextRecordsUri = new Uri(new Uri(InstanceUrl), qr.NextRecordsUrl);
                    done = false;
                }
                else
                {
                    //Normally if query has remaining batches, NextRecordsUrl will have a value, and Done will be false.
                    //In case of some unforseen error, flag the result as done if we're missing the NextRecordsURL
                    done = true;
                }

                return currentBatchEnumerator.MoveNext();
            }

            T Current()
            {
                return currentBatchEnumerator == null ? default(T) : currentBatchEnumerator.Current;
            }

            void Dispose()
            {
                currentBatchEnumerator?.Dispose();
                jsonClient.Dispose();
            }
        }

        /// <summary>
        /// Get a basic SOQL COUNT() query result
        /// <para>The query must start with SELECT COUNT() FROM, with no named field in the count clause. COUNT() must be the only element in the SELECT list.</para>
        /// </summary>
        /// <param name="queryString">SOQL query string starting with SELECT COUNT() FROM</param>
        /// <param name="queryAll">True if deleted records are to be included</param>
        /// <returns>The <see cref="Task{Int}"/> returning the count</returns>
        public async Task<int> CountQuery(string queryString, bool queryAll = false)
        {
            // https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_soql_select_count.htm
            // COUNT() must be the only element in the SELECT list.

            Dictionary<string, string> headers = HeaderFormatter.SforceCallOptions(ClientName);

            if (!queryString.Replace(" ", "").ToLower().StartsWith("selectcount()from"))
            {
                throw new ForceApiException("CountQueryAsync may only be used with a query starting with SELECT COUNT() FROM");
            }

            var jsonClient = new JsonClient(AccessToken, _httpClient);
            var uri = UriFormatter.Query(InstanceUrl, ApiVersion, queryString);
            var qr = await jsonClient.HttpGetAsync<QueryResult<object>>(uri, headers);

            return qr.TotalSize;
        }

        /// <summary>
        /// Executes a SOSL search, returning a type T, e.g. when using "RETURNING Account" in the SOSL query.
        /// <para>Not properly matching the return type T and the RETURNING clause of the SOSL query may return unexpected results</para>
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>SearchResult{T}</returns>
        public async Task<SearchResult<T>> Search<T>(string searchString)
        {
            try
            {
                Dictionary<string, string> headers = HeaderFormatter.SforceCallOptions(ClientName);
                var uri = UriFormatter.Search(InstanceUrl, ApiVersion, searchString);

                JsonClient client = new JsonClient(AccessToken, _httpClient);

                SearchResult<T> searchResult = await client.HttpGetAsync<SearchResult<T>>(uri, headers);

                return searchResult;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error searching: " + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Executes a SOSL search, returning a simple generic object in the results collection that primarly results in a list of object IDs
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>SearchResult{SObjectGeneric}</returns>
        public async Task<SearchResult<SObjectGeneric>> Search(string searchString)
        {
            try
            {
                Dictionary<string, string> headers = HeaderFormatter.SforceCallOptions(ClientName);
                var uri = UriFormatter.Search(InstanceUrl, ApiVersion, searchString);

                JsonClient client = new JsonClient(AccessToken, _httpClient);

                SearchResult<SObjectGeneric> searchResult = await client.HttpGetAsync<SearchResult<SObjectGeneric>>(uri, headers);

                return searchResult;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error searching: " + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Get SObject by ID
        /// </summary>
        /// <param name="sObjectTypeName">SObject name, e.g. "Account"</param>
        /// <param name="objectId">SObject ID</param>
        /// <param name="fields">(optional) List of fields to retrieve, if not supplied, all fields are retrieved.</param>
        public async Task<T> GetObjectById<T>(string sObjectTypeName, string objectId, List<string> fields = null)
        {
            Dictionary<string, string> headers = HeaderFormatter.SforceCallOptions(ClientName);
            var uri = UriFormatter.SObjectRows(InstanceUrl, ApiVersion, sObjectTypeName, objectId, fields);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<T>(uri, headers);
        }

        /// <summary>
        /// Create a new record
        /// </summary>
        /// <param name="sObjectTypeName">SObject name, e.g. "Account"</param>
        /// <param name="sObject">Object to create</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). await The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>CreateResponse object, includes new object's ID</returns>
        /// <exception cref="ForceApiException">Thrown when creation fails</exception>
        public async Task<CreateResponse> CreateRecord<T>(string sObjectTypeName, T sObject, Dictionary<string, string> customHeaders = null)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();

            //Add call options
            Dictionary<string, string> callOptions = HeaderFormatter.SforceCallOptions(ClientName);
            headers.AddRange(callOptions);

            //Add custom headers if specified
            if (customHeaders != null)
            {
                headers.AddRange(customHeaders);
            }

            var uri = UriFormatter.SObjectBasicInformation(InstanceUrl, ApiVersion, sObjectTypeName);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpPostAsync<CreateResponse>(sObject, uri, headers);
        }

        /// <summary>
        /// Updates
        /// </summary>
        /// <param name="sObjectTypeName">SObject name, e.g. "Account"</param>
        /// <param name="objectId">Id of Object to update</param>
        /// <param name="sObject">Object to update</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). await The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>void, API returns 204/NoContent</returns>
        /// <exception cref="ForceApiException">Thrown when update fails</exception>
        public async Task UpdateRecord<T>(string sObjectTypeName, string objectId, T sObject, Dictionary<string, string> customHeaders = null)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();

            //Add call options
            Dictionary<string, string> callOptions = HeaderFormatter.SforceCallOptions(ClientName);
            headers.AddRange(callOptions);

            //Add custom headers if specified
            if (customHeaders != null)
            {
                headers.AddRange(customHeaders);
            }

            var uri = UriFormatter.SObjectRows(InstanceUrl, ApiVersion, sObjectTypeName, objectId);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            await client.HttpPatchAsync<object>(sObject, uri, headers);

            return;
        }

        /// <summary>
        /// Inserts or Updates a records based on external id
        /// </summary>
        /// <param name="sObjectTypeName">SObject name, e.g. "Account"</param>
        /// <param name="fieldName">External ID field name</param>
        /// <param name="fieldValue">External ID field value</param>
        /// <param name="sObject">Object to update</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). await The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>CreateResponse object, includes new object's ID if record was created and no value if object was updated</returns>
        /// <exception cref="ForceApiException">Thrown when request fails</exception>
        public async Task<CreateResponse> InsertOrUpdateRecord<T>(string sObjectTypeName, string fieldName, string fieldValue, T sObject, Dictionary<string, string> customHeaders = null)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();

            //Add call options
            Dictionary<string, string> callOptions = HeaderFormatter.SforceCallOptions(ClientName);
            headers.AddRange(callOptions);

            //Add custom headers if specified
            if (customHeaders != null)
            {
                headers.AddRange(customHeaders);
            }

            var uri = UriFormatter.SObjectRowsByExternalId(InstanceUrl, ApiVersion, sObjectTypeName, fieldName, fieldValue);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpPatchAsync<CreateResponse>(sObject, uri, headers);
        }

        /// <summary>
        /// Delete record
        /// </summary>
        /// <param name="sObjectTypeName">SObject name, e.g. "Account"</param>
        /// <param name="objectId">Id of Object to update</param>
        /// <returns>void, API returns 204/NoContent</returns>
        /// <exception cref="ForceApiException">Thrown when update fails</exception>
        public async Task DeleteRecord(string sObjectTypeName, string objectId)
        {
            Dictionary<string, string> headers = HeaderFormatter.SforceCallOptions(ClientName);
            var uri = UriFormatter.SObjectRows(InstanceUrl, ApiVersion, sObjectTypeName, objectId);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            await client.HttpDeleteAsync<object>(uri, headers);

            return;
        }

        #region metadata

        /// <summary>
        /// Lists information about limits in your org.
        /// <para>This resource is available in REST API version 29.0 and later for API users with the View Setup and Configuration permission.</para>
        /// </summary>
        public async Task<OrganizationLimits> GetOrganizationLimits()
        {
            var uri = UriFormatter.Limits(InstanceUrl, ApiVersion);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<OrganizationLimits>(uri);
        }

        /// <summary>
        /// List summary information about each REST API version currently available, including the version, label, and a link to each version's root.
        /// You do not need authentication to retrieve the list of versions. 
        /// </summary>
        /// <param name="currentInstanceUrl">Current instance URL. If the client has been initialized, the parameter is optional and the client's current instance URL will be used</param>
        /// <returns>List of SalesforceVersion objects</returns>
        public async Task<List<SalesforceVersion>> GetAvailableRestApiVersions(string currentInstanceUrl = null)
        {
            return await GetAvailableRestApiVersions(currentInstanceUrl, true);
        }

        private async Task<List<SalesforceVersion>> GetAvailableRestApiVersions(string currentInstanceUrl = null, bool deserializeResponse = true)
        {
            if (string.IsNullOrEmpty(currentInstanceUrl))
            {
                if (string.IsNullOrEmpty(this.InstanceUrl))
                {
                    throw new ForceApiException("currentInstanceUrl must be specified since the client's instance URL has not been initialized.");

                }
                currentInstanceUrl = this.InstanceUrl;
            }

            if (!Uri.IsWellFormedUriString(currentInstanceUrl, UriKind.Absolute))
            {
                throw new ForceApiException("Specified currentInstanceUrl is not a well formed URI");
            }

            var uri = UriFormatter.Versions(currentInstanceUrl);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<List<SalesforceVersion>>(uri: uri, deserializeResponse: deserializeResponse);
        }

        /// <summary>
        /// Get current user's info via Identity URL
        /// <para>https://developer.salesforce.com/docs/atlas.en-us.mobile_sdk.meta/mobile_sdk/oauth_using_identity_urls.htm</para>
        /// </summary>
        /// <param name="identityUrl"></param>
        /// <returns>UserInfo</returns>
        public async Task<UserInfo> GetUserInfo(string identityUrl)
        {
            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<UserInfo>(new Uri(identityUrl));
        }

        /// <summary>
        /// Retrieve (basic) metadata for an object.
        /// <para>Use the SObject Basic Information resource to retrieve metadata for an object.</para>
        /// </summary>
        /// <param name="objectTypeName">SObject name, e.g. Account</param>
        /// <returns>Returns SObjectMetadataBasic with basic object metadata and a list of recently created items.</returns>
        public async Task<SObjectBasicInfo> GetObjectBasicInfo(string objectTypeName)
        {
            Dictionary<string, string> headers = HeaderFormatter.SforceCallOptions(ClientName);
            var uri = UriFormatter.SObjectBasicInformation(InstanceUrl, ApiVersion, objectTypeName);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<SObjectBasicInfo>(uri, headers);
        }

        /// <summary>
        /// Get field and other metadata for an object.
        /// <para>Use the SObject Describe resource to retrieve all the metadata for an object, including information about each field, URLs, and child relationships.</para>
        /// </summary>
        /// <param name="objectTypeName">SObject name, e.g. Account</param>
        /// <returns>Returns SObjectMetadataAll with full object meta including field metadata</returns>
        public async Task<SObjectDescribeFull> GetObjectDescribe(string objectTypeName)
        {
            var uri = UriFormatter.SObjectDescribe(InstanceUrl, ApiVersion, objectTypeName);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<SObjectDescribeFull>(uri);
        }

        /// <summary>
        /// Get a List of Objects
        /// <para>Use the Describe Global resource to list the objects available in your org and available to the logged-in user. This resource also returns the org encoding, as well as maximum batch size permitted in queries.</para>
        /// </summary>
        /// <returns>Returns DescribeGlobal object with a SObjectDescribe collection</returns>
        public async Task<DescribeGlobal> DescribeGlobal()
        {
            var uri = UriFormatter.DescribeGlobal(InstanceUrl, ApiVersion);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<DescribeGlobal>(uri);
        }

        #endregion

    }
}
