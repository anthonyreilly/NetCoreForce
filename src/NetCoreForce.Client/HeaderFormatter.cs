using System;
using System.Collections.Generic;
using System.Globalization;

namespace NetCoreForce.Client
{
    /// <summary>
    /// Formats custom HTTP request and response headers used for REST API
    /// <para>
    /// See also <see href="https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/headers.htm">Salesforce REST API Developer Guide - Headers</see>
    /// </para>
    /// </summary>
    public static class HeaderFormatter
    {
        /// <summary>
        /// Use the Describe Global resource and the If-Modified-Since HTTP header to determine if an object’s metadata has changed.
        /// </summary>
        /// <param name="startDate">Start date after which to look for changed object metadata</param>
        /// <returns>Single entry dictionary of "If-Modified-Since" with date value in the RFC1123 Pattern</returns>
        public static Dictionary<string, string> IfModifiedSince(DateTimeOffset startDate)
        {
            //example: "If-Modified-Since: Tue, 23 Mar 2015 00:00:00 GMT"
            const string headerName = "If-Modified-Since";

            string dateString = startDate.ToString("r", CultureInfo.InvariantCulture); //RFC1123 Pattern

            var customHeaders = new Dictionary<string, string>(1);
            customHeaders.Add(headerName, dateString);

            return customHeaders;
        }

        /// <summary>
        /// Assignment Rule Header
        /// <para>The Assignment Rule header is a request header applied when creating or updating Cases or Leads. If enabled, the active assignment
        /// rules are used. If disabled, the active assignment rules are not applied. If a valid AssignmentRule ID is provided, the AssignmentRule is
        /// applied. If the header is not provided with a request, REST API defaults to using the active assignment rules.</para>
        /// </summary>
        /// <param name="autoAssign">Active assignment rules are applied for created or updated Cases or Leads</param>
        /// <returns>Single entry dictionary of "Sforce-Auto-Assign" with TRUE/FALSE value</returns>
        public static Dictionary<string, string> SforceAutoAssign(bool autoAssign)
        {
            //TODO: support field: Valid AssignmentRule ID. The given AssignmentRule is applied for created Cases or Leads.
            //https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/headers_autoassign.htm

            //true false is not case sensitive.

            //example: "Sforce-Auto-Assign: FALSE"
            const string headerName = "Sforce-Auto-Assign";

            string valueString = autoAssign.ToString().ToUpper();

            var customHeaders = new Dictionary<string, string>(1);
            customHeaders.Add(headerName, valueString);

            return customHeaders;
        }

        /// <summary>
        /// Query Options Header
        /// <para>Specifies options used in a query, such as the query results batch size. Use this request header with the Query resource.</para>
        /// <remarks>Child objects count toward the number of records for the batch size. For example, in relationship queries, multiple child objects are returned per parent row returned.
        /// The default is 2,000; the minimum is 200, and the maximum is 2,000. There is no guarantee that the requested batch size is the
        /// actual batch size. Changes are made as necessary to maximize performance.</remarks>
        /// </summary>
        /// <param name="batchSize">the number of records returned for a query request</param>
        /// <returns>Single entry dictionary of "Sforce-Query-Options" with value of batchSize={batchSize}</returns>
        public static Dictionary<string, string> SforceQueryOptions(int batchSize)
        {
            if(batchSize > 2000)
            {
                throw new ArgumentException("Batch size can not exceed 2000", "batchSize");
            }

            if(batchSize < 200)
            {
                throw new ArgumentException("Batch size minimum is 200", "batchSize");
            }

            //example: "Sforce-Query-Options: batchSize=1000"
            const string headerName = "Sforce-Query-Options";

            string valueString = string.Format("batchSize={0}", batchSize.ToString(CultureInfo.InvariantCulture));

            var customHeaders = new Dictionary<string, string>(1);
            customHeaders.Add(headerName, valueString);

            return customHeaders;
        }

        /// <summary>
        /// Call Options Header
        /// <para>Specifies the client-specific options when accessing REST API resources. For example, you can write client code that ignores namespace prefixes by specifying the prefix in the call options header.</para>
        /// <remarks>The Call Options header can be used with SObject Basic Information, SObject Rows, Query, QueryAll, Search, and SObject Rows by External ID.</remarks>
        /// </summary>
        /// <param name="client">A string that identifies a client.</param>
        /// <param name="defaultNamespace">A string that identifies a developer namespace prefix. Resolve field names in managed packages without having to specify the namespace everywhere.</param>
        /// <returns>Single entry dictionary of "Sforce-Call-Options" with value of client={client}, defaultNamespace={defaultNamespace}</returns>
        public static Dictionary<string, string> SforceCallOptions(string client = "ForceClient",
                                                                   string defaultNamespace = null)
        {
            //example: "Sforce-Call-Options: client=ForceClient, defaultNamespace=Test"
            const string headerName = "Sforce-Call-Options";
            List<string> values = new List<string>();

            if (!string.IsNullOrEmpty(client))
            { values.Add(string.Format("client={0}", client)); }

            if (!string.IsNullOrEmpty(defaultNamespace))
            { values.Add(string.Format("defaultNamespace={0}", defaultNamespace)); }

            string valueString = string.Join(", ", values);

            var customHeaders = new Dictionary<string, string>(1);
            customHeaders.Add(headerName, valueString);

            return customHeaders;
        }
    }
}
