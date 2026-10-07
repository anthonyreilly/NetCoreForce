using NetCoreForce.Client.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetCoreForce.Client
{
    /*
    In each case, the URI for the resource follows the base URI,
    which you retrieve from the authentication service: http://domain/services/data
    https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_list.htm
    */
    public static class UriFormatter
    {
        // API names of objects and fields, e.g. Account, Custom_Object__c, ns__Custom_Object__c
        // \z rather than $, since $ also matches before a trailing newline
        private static readonly Regex ApiNameRegex = new Regex(@"^[A-Za-z][A-Za-z0-9_]*\z", RegexOptions.Compiled);

        // API version, e.g. v67.0
        private static readonly Regex ApiVersionRegex = new Regex(@"^v\d{1,3}\.\d{1,2}\z", RegexOptions.Compiled);

        // nextRecordsUrl paths returned by query responses, e.g. /services/data/v67.0/query/01gXXXXXXXXXXXXXXX-2000
        private const string DataServicesPath = "/services/data/";

        // characters that would change the structure of the URL if included in a path segment.
        // backslash is included since it is treated as a path separator in http URIs.
        private static readonly char[] UnsafePathSegmentChars = new char[] { '/', '\\', '?', '#', '%' };

        /// <summary>
        /// Validate an object or field API name before including it in a URL
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is not a valid API name</exception>
        private static void ValidateApiName(string value, string paramName)
        {
            if (!ApiNameRegex.IsMatch(value))
            {
                throw new ArgumentException($"'{value}' is not a valid object or field API name", paramName);
            }
        }

        /// <summary>
        /// Validate a value such as a record ID before including it as a single URL path segment.
        /// Prevents values like "../Contact/003XXXXXXXXXXXXXXX" from redirecting the request to a different resource.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value contains characters that would change the URL structure</exception>
        private static void ValidatePathSegment(string value, string paramName)
        {
            if (value == "." || value == ".." || value.IndexOfAny(UnsafePathSegmentChars) != -1)
            {
                throw new ArgumentException($"'{value}' contains characters that are not allowed in a record ID", paramName);
            }
        }

        /// <summary>
        /// URL-encode an arbitrary value, such as an external ID value, for use as a single URL path segment
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is a relative path segment</exception>
        private static string EscapePathSegment(string value, string paramName)
        {
            if (value == "." || value == "..")
            {
                throw new ArgumentException($"'{value}' is not allowed as a URL path segment", paramName);
            }

            return Uri.EscapeDataString(value);
        }

        /// <summary>
        /// Validate an API version, e.g. v67.0, before including it in a URL.
        /// Prevents values like "//other.host/x" or "v67.0/../.." from redirecting the request, and the access token, elsewhere.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is not a valid API version</exception>
        internal static void ValidateApiVersion(string apiVersion, string paramName = "apiVersion")
        {
            if (!ApiVersionRegex.IsMatch(apiVersion))
            {
                throw new ArgumentException($"'{apiVersion}' is not a valid API version, expected a value such as v67.0", paramName);
            }
        }

        /// <summary>
        /// Validate that a URL is an absolute HTTPS URL, since it will be sent credentials or the access token
        /// </summary>
        /// <exception cref="FormatException">Thrown when the value is not an absolute URL</exception>
        /// <exception cref="ArgumentException">Thrown when the URL is not HTTPS</exception>
        internal static Uri ValidateHttpsUrl(string url, string paramName)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uri) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                throw new FormatException($"{paramName} is not a valid absolute URL");
            }

            if (uri.Scheme != Uri.UriSchemeHttps)
            {
                throw new ArgumentException($"{paramName} must be an HTTPS URL", paramName);
            }

            return uri;
        }

        /// <summary>
        /// Resolve a nextRecordsUrl from a query response against the instance URL.
        /// The URL comes from the response, so it must stay on the instance and under services/data - otherwise the access token would be sent elsewhere.
        /// </summary>
        /// <exception cref="ForceApiException">Thrown when the URL would resolve to a different host or resource</exception>
        internal static Uri NextRecordsUri(string instanceUrl, string nextRecordsUrl)
        {
            Uri baseUri = BaseUri(instanceUrl);

            if (!nextRecordsUrl.StartsWith(DataServicesPath, StringComparison.Ordinal) ||
                !Uri.TryCreate(nextRecordsUrl, UriKind.Relative, out _))
            {
                throw new ForceApiException($"Unexpected nextRecordsUrl in query response: {nextRecordsUrl}");
            }

            Uri uri = new Uri(baseUri, nextRecordsUrl);

            if (uri.Scheme != baseUri.Scheme || uri.Authority != baseUri.Authority ||
                !uri.AbsolutePath.StartsWith(DataServicesPath, StringComparison.Ordinal))
            {
                throw new ForceApiException($"Unexpected nextRecordsUrl in query response: {nextRecordsUrl}");
            }

            return uri;
        }

        /// <summary>
        /// SF Base URI
        /// </summary>
        /// <param name="instanceUrl"></param>
        public static Uri BaseUri(string instanceUrl)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));

            // e.g. https://na99.salesforce.com/services/data

            // trailing slash required in services/data/ so that URI combinations work as expected
            return new Uri(ValidateHttpsUrl(instanceUrl, nameof(instanceUrl)), "services/data/");
        }

        /// <summary>
        /// Versions
        /// </summary>
        /// <param name="instanceUrl"></param>
        /// <param name="apexResourceUrl"></param>
        public static Uri ApexUri(string instanceUrl, string apexResourceUrl)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apexResourceUrl)) throw new ArgumentNullException(nameof(apexResourceUrl));

            // format: /

            // nested paths and query strings are allowed, but relative segments would resolve outside of services/apexrest
            string resourcePath = apexResourceUrl.Split('?')[0];

            // encoded separators and double encoding would hide relative segments from the check below
            if (resourcePath.IndexOf("%2f", StringComparison.OrdinalIgnoreCase) != -1 ||
                resourcePath.IndexOf("%5c", StringComparison.OrdinalIgnoreCase) != -1 ||
                resourcePath.IndexOf("%25", StringComparison.OrdinalIgnoreCase) != -1)
            {
                throw new ArgumentException($"'{apexResourceUrl}' contains encoded path separators, which are not allowed", nameof(apexResourceUrl));
            }

            foreach (string segment in resourcePath.Split('/', '\\'))
            {
                string unescapedSegment = Uri.UnescapeDataString(segment);
                if (unescapedSegment == "." || unescapedSegment == "..")
                {
                    throw new ArgumentException($"'{apexResourceUrl}' contains relative path segments, which are not allowed", nameof(apexResourceUrl));
                }
            }

            Uri uri = new Uri(ValidateHttpsUrl(instanceUrl, nameof(instanceUrl)), $"services/apexrest/{apexResourceUrl}");

            return uri;
        }

        /// <summary>
        /// Versions
        /// </summary>
        /// <param name="instanceUrl"></param>
        public static Uri Versions(string instanceUrl)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));

            // format: /

            Uri uri = new Uri(ValidateHttpsUrl(instanceUrl, nameof(instanceUrl)), "services/data");

            return uri;
        }

        //TODO: Resources By Version https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_discoveryresource.htm

        /// <summary>
        /// Limits Resource URL
        /// <para>Use the Limits resource to list limits information for your organization.</para>
        /// </summary>
        public static Uri Limits(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            //format: /vXX.X/limits/

            return new Uri(BaseUri(instanceUrl), LimitsResource(apiVersion));
        }

        //split off full URL formatter and resource relative url formatters?
        //batch/tree reqs may need relative url parsers

        /// <summary>
        /// Limits Resource
        /// <para>Use the Limits resource to list limits information for your organization.</para>
        /// <para>format: /vXX.X/limits/</para>
        /// </summary>
        public static Uri LimitsResource(string apiVersion)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            return new Uri($"{apiVersion}/limits", UriKind.Relative);
        }

        /// <summary>
        /// Describe Global
        /// Use the Describe Global resource to list the objects available in your org and available to the logged-in user.
        /// This resource also returns the org encoding, as well as maximum batch size permitted in queries.
        /// </summary>
        public static Uri DescribeGlobal(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            //format: /vXX.X/sobjects/

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/sobjects");

            return uri;
        }

        /// <summary>
        /// SObject Basic Information
        /// Describes the individual metadata for the specified object. Can also be used to create a new record for a given object.
        /// </summary>
        public static Uri SObjectBasicInformation(string instanceUrl, string apiVersion, string sObjectName)
        {
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            ValidateApiName(sObjectName, nameof(sObjectName));

            //format: /vXX.X/sobjects/SObjectName/

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/sobjects/{sObjectName}");

            return uri;
        }

        /// <summary>
        /// SObject Describe
        /// Completely describes the individual metadata at all levels for the specified object.
        /// </summary>
        public static Uri SObjectDescribe(string instanceUrl, string apiVersion, string sObjectName)
        {
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            ValidateApiName(sObjectName, nameof(sObjectName));

            //format: /vXX.X/sobjects/SObjectName/describe/

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/sobjects/{sObjectName}/describe");

            return uri;
        }

        //TODO: SObject Get Deleted

        //TODO: SObject Get Updated

        //TODO: SObject Named Layouts

        /// <summary>
        /// SObject Rows Resource
        /// Used for: Update, Delete, Field values
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v57.0"</param>
        /// <param name="sObjectName">SObject name, e.g. "Account"</param>
        /// <param name="objectId">SObject ID</param>
        /// <param name="fields">(optional) "fields" parameter, a list of object fields for GET requests</param>
        /// <returns></returns>
        public static Uri SObjectRows(string instanceUrl, string apiVersion, string sObjectName, string objectId, List<string> fields = null)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(objectId)) throw new ArgumentNullException(nameof(objectId));
            ValidateApiName(sObjectName, nameof(sObjectName));
            ValidatePathSegment(objectId, nameof(objectId));

            //https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_sobject_retrieve.htm

            // format: /vXX.X/sobjects/SObjectName/id/
            // example with field parameter: services/data/v20.0/sobjects/Account/001D000000INjVe?fields=AccountNumber,BillingPostalCode

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/sobjects/{sObjectName}/{objectId}");

            if (fields != null && fields.Count > 0)
            {
                string fieldList = string.Join(",", fields);
                uri = new Uri(QueryHelpers.AddQueryString(uri.ToString(), "fields", fieldList));
            }

            return uri;
        }

        /// <summary>
        /// SObject Composite
        /// Used for: Update multiple
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v57.0"</param>
        /// <returns></returns>
        public static Uri SObjectsComposite(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            //format: /vXX.X/composite/sobjects

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/composite/sobjects");

            return uri;
        }

        /// <summary>
        /// Composite Request
        /// Used for: Create/Update multiple
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v41.0"</param>
        /// <returns></returns>
        public static Uri CompositeRequest(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/composite");

            return uri;
        }

        /// <summary>
        /// SObject Composite Subrequest
        /// Describes the individual metadata for the specified object. Can also be used to create a new record for a given object.
        /// </summary>
        public static string CompositeSubRequest(string apiVersion, string sObjectName, string objectId)
        {
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            ValidateApiName(sObjectName, nameof(sObjectName));

            //format: /services/data/vXX.X/sobjects/SObjectName/

            if (string.IsNullOrWhiteSpace(objectId))
            {
                return $"/services/data/{apiVersion}/sobjects/{sObjectName}";
            }

            // objectId may also be a composite reference, e.g. @{refId.id}
            ValidatePathSegment(objectId, nameof(objectId));

            return $"/services/data/{apiVersion}/sobjects/{sObjectName}/{objectId}";
        }

        /// <summary>
        /// sObject Tree
        /// Used for: Create multiple
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v57.0"</param>
        /// <param name="sObjectName">sObject name, e.g. "Account"</param>
        /// <returns></returns>
        public static Uri SObjectTree(string instanceUrl, string apiVersion, string sObjectName)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            ValidateApiName(sObjectName, nameof(sObjectName));

            //format: /vXX.X/composite/tree/sObjectName

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/composite/tree/{sObjectName}");

            return uri;
        }

        /// <summary>
        /// SObject Rows by External ID
        /// Used for:
        /// Retrieve Records Using sObject Rows by External ID
        /// Upsert Records Using sObject Rows by External ID
        /// Delete Records Using sObject Rows by External ID
        /// Return Headers Using sObject Rows by External ID
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v57.0"</param>
        /// <param name="sObjectName">sObject name, e.g. "Account"</param>
        /// <param name="fieldName"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static Uri SObjectRowsByExternalId(string instanceUrl, string apiVersion, string sObjectName, string fieldName, string fieldValue)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(fieldName)) throw new ArgumentNullException(nameof(fieldName));
            if (string.IsNullOrEmpty(fieldValue)) throw new ArgumentNullException(nameof(fieldValue));
            ValidateApiName(sObjectName, nameof(sObjectName));
            ValidateApiName(fieldName, nameof(fieldName));

            //format: /vXX.X/sobjects/SObjectName/fieldName/fieldValue

            // external ID values can contain any characters, so they are URL-encoded rather than validated
            string escapedFieldValue = EscapePathSegment(fieldValue, nameof(fieldValue));

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/sobjects/{sObjectName}/{fieldName}/{escapedFieldValue}");

            return uri;
        }

        /// <summary>
        /// SObjectCollections
        /// </summary>
        /// <param name="apiVersion">SFDC API version, e.g. "v57.0"</param>
        /// <returns></returns>
        public static string CompositeSObjectCollectionsSubRequest(string apiVersion)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            //format: /services/data/vXX.X/composite/sobjects/

            return $"/services/data/{apiVersion}/composite/sobjects/";
        }

        /// <summary>
        /// SObjectCollections Upsert
        /// </summary>
        /// <param name="instanceUrl">SFDC instance URL, e.g. "https://na99.salesforce.com"</param>
        /// <param name="apiVersion">SFDC API version, e.g. "v57.0"</param>
        /// <param name="sObjectName">sObject name, e.g. "Account"</param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static Uri SObjectCollectionsUpsert(string instanceUrl, string apiVersion, string sObjectName, string fieldName)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(fieldName)) throw new ArgumentNullException(nameof(fieldName));
            ValidateApiName(sObjectName, nameof(sObjectName));
            ValidateApiName(fieldName, nameof(fieldName));

            //format: /vXX.X/sobjects/SObjectName/fieldName/fieldValue

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/sobjects/{sObjectName}/{fieldName}");

            return uri;
        }

        //SObject Relationships Resource
        //TODO: Traverse Relationships with Friendly URLs.
        //https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_sobject_relationships.htm#topic-title
        ///format: vXX.X/sobjects/SObject/id/relationship field name

        /// <summary>
        /// SObject Rows
        /// </summary>
        public static Uri SObjectBlobRetrieve(string instanceUrl, string apiVersion, string sObjectName, string objectId, string blobField = "body")
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);
            if (string.IsNullOrEmpty(sObjectName)) throw new ArgumentNullException(nameof(sObjectName));
            if (string.IsNullOrEmpty(objectId)) throw new ArgumentNullException(nameof(objectId));
            if (string.IsNullOrEmpty(blobField)) throw new ArgumentNullException(nameof(blobField));
            ValidateApiName(sObjectName, nameof(sObjectName));
            ValidatePathSegment(objectId, nameof(objectId));
            ValidateApiName(blobField, nameof(blobField));

            //format: /vXX.X/sobjects/SObjectName/id/

            // https://yourInstance.salesforce.com/services/data/v20.0/sobjects/Attachment/001D000000INjVe/body
            // https://yourInstance.salesforce.com/services/data/v20.0/sobjects/Document/015D0000000NdJOIA0/body

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/sobjects/{sObjectName}/{objectId}/{blobField}");

            return uri;
        }

        /// <summary>
        /// SOQL Query
        /// </summary>
        public static Uri Query(string instanceUrl, string apiVersion, string query, bool queryAll = false)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            string queryType = "query";
            if (queryAll)
            {
                queryType = "queryAll";
            }

            //Uri uri = new Uri(new Uri(instanceUrl), string.Format("/services/data/{0}/{1}/?q={2}", apiVersion, queryType, query));

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/{queryType}");
            string queryUri = QueryHelpers.AddQueryString(uri.ToString(), "q", query);

            return new Uri(queryUri);
        }

        /// <summary>
        /// Search Resource, for SOSL searches
        /// </summary>
        public static Uri Search(string instanceUrl, string apiVersion, string query)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/search");
            string searchUri = QueryHelpers.AddQueryString(uri.ToString(), "q", query);

            return new Uri(searchUri);
        }

        /// <summary>
        /// Batch Resource
        /// </summary>
        /// <param name="instanceUrl"></param>
        /// <param name="apiVersion"></param>
        public static Uri Batch(string instanceUrl, string apiVersion)
        {
            if (string.IsNullOrEmpty(instanceUrl)) throw new ArgumentNullException(nameof(instanceUrl));
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            ValidateApiVersion(apiVersion);

            //format: /vXX.X/composite/batch

            Uri uri = new Uri(BaseUri(instanceUrl), $"{apiVersion}/composite/batch");

            return uri;
        }

        /// <summary>
        /// Formats an authentication URL for the User-Agent OAuth Authentication Flow
        /// </summary>
        /// <param name="loginUrl">(Required) Salesforce authorization endpoint.</param>
        /// <param name="clientId">(Required) The Consumer Key from the connected app definition.</param>
        /// <param name="redirectUrl">(Required) The Callback URL from the connected app definition.</param>
        /// <param name="display">Changes the login page’s display type</param>
        /// <param name="scope">OAuth scope - specifies what data your application can access</param>
        /// <param name="state">Specifies any additional URL-encoded state data to be returned in the callback URL after approval.</param>
        public static Uri UserAgentAuthenticationUrl(
            string loginUrl,
            string clientId,
            string redirectUrl,
            DisplayTypes display = DisplayTypes.Page,
            string state = "",
            string scope = "")
        {
            if (string.IsNullOrEmpty(loginUrl)) throw new ArgumentNullException(nameof(loginUrl));
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrEmpty(redirectUrl)) throw new ArgumentNullException(nameof(redirectUrl));

            const ResponseTypes responseType = ResponseTypes.Token;

            Dictionary<string, string> prms = new Dictionary<string, string>();
            prms.Add("response_type", responseType.ToString().ToLower());
            prms.Add("client_id", clientId);
            prms.Add("redirect_uri", redirectUrl);
            prms.Add("display", display.ToString().ToLower());

            if (!string.IsNullOrEmpty(scope))
            {
                prms.Add("scope", scope);
            }

            if (!string.IsNullOrEmpty(state))
            {
                prms.Add("state", state);
            }

            string url = QueryHelpers.AddQueryString(loginUrl, prms);

            return new Uri(url);
        }

        /// <summary>
        /// Formats a manual authentication URL for the Web Server Authentication Flow
        /// </summary>
        /// <param name="loginUrl">Required. Salesforce authorization endpoint.</param>
        /// <param name="clientId">Required. The Consumer Key from the connected app definition.</param>
        /// <param name="clientSecret">Ignored. The authorize endpoint does not use the client secret, and it must not be exposed in a browser URL.</param>
        /// <param name="redirectUrl">Required. The Callback URL from the connected app definition.</param>
        [Obsolete("Use WebServerAuthenticationUrl. The client secret is not used by the authorize endpoint, and is no longer added to the URL.")]
        public static Uri OAuthAuthenticationUrl(
            string loginUrl,
            string clientId,
            string clientSecret,
            string redirectUrl = "https://login.salesforce.com/services/oauth2/success"
            )
        {
            if (string.IsNullOrEmpty(loginUrl)) throw new ArgumentNullException(nameof(loginUrl));
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrEmpty(redirectUrl)) throw new ArgumentNullException(nameof(redirectUrl));

            //TODO: code_challenge, login_hint, nonce, prompt params

            const ResponseTypes responseType = ResponseTypes.Code;

            Dictionary<string, string> prms = new Dictionary<string, string>
            {
                { "client_id", clientId },
                { "redirect_uri", redirectUrl },
                { "response_type", responseType.ToString().ToLower() }
            };
            string url = QueryHelpers.AddQueryString(loginUrl, prms);

            return new Uri(url);
        }

        /// <summary>
        /// Formats an authentication URL for the Web Server Authentication Flow
        /// </summary>
        /// <param name="loginUrl">Required. Salesforce authorization endpoint.</param>
        /// <param name="clientId">Required. The Consumer Key from the connected app definition.</param>
        /// <param name="redirectUrl">Required. The Callback URL from the connected app definition.</param>
        /// <param name="display">Changes the login page’s display type</param>
        /// <param name="immediate">Determines whether the user should be prompted for login and approval. Default is false.</param>
        /// <param name="scope">OAuth scope - specifies what data your application can access</param>
        /// <param name="state">Specifies any additional URL-encoded state data to be returned in the callback URL after approval.</param>
        public static Uri WebServerAuthenticationUrl(
            string loginUrl,
            string clientId,
            string redirectUrl,
            DisplayTypes display = DisplayTypes.Page,
            bool immediate = false,
            string scope = "",
            string state = ""
            )
        {
            if (string.IsNullOrEmpty(loginUrl)) throw new ArgumentNullException(nameof(loginUrl));
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrEmpty(redirectUrl)) throw new ArgumentNullException(nameof(redirectUrl));

            //TODO: code_challenge, login_hint, nonce, prompt params

            const ResponseTypes responseType = ResponseTypes.Code;

            Dictionary<string, string> prms = new Dictionary<string, string>
            {
                { "response_type", responseType.ToString().ToLower() },
                { "client_id", clientId },
                { "redirect_uri", redirectUrl },
                { "display", display.ToString().ToLower() },
                { "immediate", immediate.ToString().ToLower() }
            };

            if (!string.IsNullOrEmpty(scope))
            {
                prms.Add("scope", scope);
            }

            if (!string.IsNullOrEmpty(state))
            {
                prms.Add("state", state);
            }

            string url = QueryHelpers.AddQueryString(loginUrl, prms);

            return new Uri(url);
        }

        /// <summary>
        /// Formats a URL to request a OAuth Token Introspection
        /// </summary>
        /// <param name="introspectTokenUrl"></param>
        /// <param name="token">The token the client application already received.</param>
        /// <param name="clientId">The Consumer Key from the connected app definition.</param>
        /// <param name="clientSecret">The Consumer Secret from the connected app definition. Required unless the Require Secret for Web Server Flow setting is not enabled in the connected app definition.</param>
        /// <returns></returns>
        [Obsolete("Puts the token and client secret in the URL, where they can be recorded by proxies and HTTP logging. Use AuthenticationClient.IntrospectTokenAsync, which sends them in the request body.")]
        public static Uri IntrospectTokenUrl(
            string introspectTokenUrl,
            string token,
            string clientId,
            string clientSecret = "")
        {
            if (introspectTokenUrl == null) throw new ArgumentNullException(nameof(introspectTokenUrl));
            if (token == null) throw new ArgumentNullException(nameof(token));
            if (clientId == null) throw new ArgumentNullException(nameof(clientId));

            Dictionary<string, string> prms = new Dictionary<string, string>
            {
                { "token", token },
                { "client_id", clientId }
            };
            if (!string.IsNullOrEmpty(clientSecret))
            {
                prms.Add("client_secret", clientSecret);
            }
            prms.Add("format", "json");

            string url = QueryHelpers.AddQueryString(introspectTokenUrl, prms);

            return new Uri(url);
        }

        /// <summary>
        /// Formats a URL to request a OAuth Refresh Token
        /// </summary>
        /// <param name="tokenRefreshUrl"></param>
        /// <param name="refreshToken">The refresh token the client application already received.</param>
        /// <param name="clientId">The Consumer Key from the connected app definition.</param>
        /// <param name="clientSecret">The Consumer Secret from the connected app definition. Required unless the Require Secret for Web Server Flow setting is not enabled in the connected app definition.</param>
        /// <returns></returns>
        [Obsolete("Puts the refresh token and client secret in the URL, where they can be recorded by proxies and HTTP logging. Use AuthenticationClient.TokenRefreshAsync, which sends them in the request body.")]
        public static Uri RefreshTokenUrl(
            string tokenRefreshUrl,
            string refreshToken,
            string clientId,
            string clientSecret = "")
        {
            if (tokenRefreshUrl == null) throw new ArgumentNullException(nameof(tokenRefreshUrl));
            if (refreshToken == null) throw new ArgumentNullException(nameof(refreshToken));
            if (clientId == null) throw new ArgumentNullException(nameof(clientId));

            Dictionary<string, string> prms = new Dictionary<string, string>
            {
                { "grant_type", "refresh_token" },
                { "refresh_token", refreshToken },
                { "client_id", clientId }
            };
            if (!string.IsNullOrEmpty(clientSecret))
            {
                prms.Add("client_secret", clientSecret);
            }
            prms.Add("format", "json");

            string url = QueryHelpers.AddQueryString(tokenRefreshUrl, prms);

            return new Uri(url);
        }
    }
}