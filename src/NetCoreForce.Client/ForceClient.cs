using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreForce.Client.Models;
using System.Diagnostics;

namespace NetCoreForce.Client
{
    public class ForceClient
    {
        public string ApiVersion { get; private set; }
        public string InstanceUrl { get; private set; }
        public string AccessToken { get; private set; }

        private HttpClient _httpClient;

        public ForceClient(AuthInfo authInfo)
        : this(authInfo.ClientId, authInfo.ClientSecret, authInfo.Username, authInfo.Password, authInfo.TokenRequestEndpoint, authInfo.ApiVersion)
        { }

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

        public ForceClient(string instanceUrl, string apiVersion, string accessToken, HttpClient httpClient = null)
        {
            Initialize(instanceUrl, apiVersion, accessToken, httpClient);
        }

        private async Task Login(string clientId, string clientSecret, string username, string password, string tokenRequestEndpoint, string apiVersion = null, HttpClient httpClient = null)
        {
            AuthenticationClient authClient = new AuthenticationClient(apiVersion);
            await authClient.UsernamePasswordAsync(clientId, clientSecret, username, password, tokenRequestEndpoint);

            Initialize(authClient.AccessInfo.InstanceUrl, authClient.ApiVersion, authClient.AccessInfo.AccessToken, httpClient);
        }

        private void Initialize(string instanceUrl, string apiVersion, string accessToken, HttpClient httpClient = null)
        {
            this.ApiVersion = apiVersion;
            this.InstanceUrl = instanceUrl;
            this.AccessToken = accessToken;

            _httpClient = httpClient;
        }

        public bool TestConnection()
        {
            throw new NotImplementedException();
        }        

        /// <summary>
        /// Retrieve records using a SOQL query.
        /// <para>Will automatically retrieve the complete result set if split into batches. If you wan tto limit results, use the LIMIT operator in your query.</para>
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
                var uri = UriFormatter.Query(InstanceUrl, ApiVersion, queryString, queryAll);

                JsonClient client = new JsonClient(AccessToken, _httpClient);

                List<T> results = new List<T>();

                bool done = false;
                string next = string.Empty;

                //larger result sets will be split into batches (sized according to system and account settings)
                //if additional batches are indicated retrieve the rest and append to the result set.
                do
                {
                    if (!string.IsNullOrEmpty(next))
                    {
                        uri = new Uri(next);
                    }

                    QueryResult<T> qr = await client.HttpGetAsync<QueryResult<T>>(uri);

#if DEBUG
                    Debug.WriteLine(string.Format("Got query resuts, {0} totalSize, {1} in this batch, final batch: {2}",
                        qr.TotalSize, qr.Records.Count.ToString(), qr.Done.ToString()));
#endif

                    results.AddRange(qr.Records);

                    done = qr.Done;

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

        public async Task<T> Search<T>(string searchString)
        {
            try
            {
                var uri = UriFormatter.Search(InstanceUrl, ApiVersion, searchString);

                JsonClient client = new JsonClient(AccessToken, _httpClient);

                T searchResult = await client.HttpGetAsync<T>(uri);

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
            var uri = UriFormatter.SObjectRows(InstanceUrl, ApiVersion, sObjectTypeName, objectId, fields);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<T>(uri);
        }

        // public async Task<T> GetObjectFieldValues<T>(string sObjectTypeName, string objectId, List<string> fields)
        // {
        //     string url = UriFormatter.SObjectRows(InstanceUrl, ApiVersion, sObjectTypeName, objectId, fields);

        //     throw new NotImplementedException();
        // }

        /// <summary>
        /// Create a new record
        /// </summary>
        /// <param name="sObjectTypeName">SObject name, e.g. "Account"</param>
        /// <param name="sObject">Object to create</param>
        /// <returns>CreateResponse object, includes new object's ID</returns>
        /// <exception cref="ForceApiException">Thrown when creation fails</exception>
        public async Task<CreateResponse> CreateRecord<T>(string sObjectTypeName, T sObject)
        {
            var uri = UriFormatter.SObjectBasicInformation(InstanceUrl, ApiVersion, sObjectTypeName);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpPostAsync<CreateResponse>(sObject, uri);
        }

        /// <summary>
        /// Updates
        /// </summary>
        /// <param name="sObjectTypeName">SObject name, e.g. "Account"</param>
        /// <param name="objectId">Id of Object to update</param>
        /// <param name="sObject">Object to update</param>
        /// <returns>void, API returns 204/NoContent</returns>
        /// <exception cref="ForceApiException">Thrown when update fails</exception>
        public async Task UpdateRecord<T>(string sObjectTypeName, string objectId, T sObject) //where T : ISObject
        {
            var uri = UriFormatter.SObjectRows(InstanceUrl, ApiVersion, sObjectTypeName, objectId);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            await client.HttpPatchAsync<object>(sObject, uri);

            return;
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
            var uri = UriFormatter.SObjectRows(InstanceUrl, ApiVersion, sObjectTypeName, objectId);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            await client.HttpDeleteAsync<object>(uri);

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
            var uri = UriFormatter.SObjectBasicInformation(InstanceUrl, ApiVersion, objectTypeName);

            JsonClient client = new JsonClient(AccessToken, _httpClient);

            return await client.HttpGetAsync<SObjectBasicInfo>(uri);
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
