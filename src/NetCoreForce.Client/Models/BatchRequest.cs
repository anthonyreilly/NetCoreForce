using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class BatchRequest
    {
        /// <summary>
        /// Collection of subrequests to execute.
        /// </summary>
        [JsonProperty(PropertyName = "batchRequests")]
        public List<BatchSubRequest> BatchRequests { get; set; }

        /// <summary>
        /// Controls whether Salesforce should stop processing subrequests if a subrequest fails. The default is false.
        /// <para>If the value is false and a subrequest in the batch doesn’t complete, Salesforce attempts to execute the subsequent subrequests in the batch.</para>
        /// </summary>
        [JsonProperty(PropertyName = "haltOnError")]
        public bool HaltOnError { get; set; }
    }
}