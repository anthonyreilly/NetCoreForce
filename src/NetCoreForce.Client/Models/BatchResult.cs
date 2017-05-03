using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    //https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/dome_composite_batch.htm

    public class BatchResponse
    {
        /// <summary>
        /// true if at least one of the results in the result set is an HTTP status code in the 400 or 500 range; false otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "hasErrors")]
        public bool HasErrors { get; set; }

        /// <summary>
        /// Collection of subrequest results.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public List<BatchSubrequestResult> Results { get; set; }
    }

    public class BatchSubrequestResult
    {
        /// <summary>
        /// An HTTP status code indicating the status of this subrequest.
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// The response body of this subrequest.
        /// <para>The type depends on the response type of the subrequest.</para>
        /// <para>If the result is an error, the type is a collection containing the error message and error code.</para>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }
    }
}