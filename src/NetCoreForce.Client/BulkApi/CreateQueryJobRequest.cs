using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Request to create a Bulk API 2.0 query job
    /// </summary>
    public class CreateQueryJobRequest
    {
        public CreateQueryJobRequest()
        {
        }

        /// <summary>
        /// Create a request for a query job
        /// </summary>
        /// <param name="query">SOQL query</param>
        /// <param name="operation">query, or queryAll to include deleted and archived records</param>
        public CreateQueryJobRequest(string query, BulkQueryOperation operation = BulkQueryOperation.Query)
        {
            Query = query;
            Operation = operation;
        }

        /// <summary>
        /// The type of query. Required.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public BulkQueryOperation Operation { get; set; }

        /// <summary>
        /// The SOQL query to be performed. Required.
        /// <para>Bulk API 2.0 does not support GROUP BY, OFFSET, or TYPEOF clauses, aggregate functions such as COUNT(), FIELDS(),
        /// parent-to-child relationship subqueries, or compound address and geolocation fields.</para>
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// The format to be used for the results. Optional, CSV is the only, and default, value.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public BulkContentType? ContentType { get; set; }

        /// <summary>
        /// The column delimiter used for the CSV results. Optional, defaults to COMMA.
        /// </summary>
        [JsonProperty(PropertyName = "columnDelimiter")]
        public BulkColumnDelimiter? ColumnDelimiter { get; set; }

        /// <summary>
        /// The line ending used for the CSV results. Optional, defaults to LF.
        /// </summary>
        [JsonProperty(PropertyName = "lineEnding")]
        public BulkLineEnding? LineEnding { get; set; }
    }
}
