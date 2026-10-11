using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Result page URLs for a query job, which can be retrieved in parallel. Up to five URLs are returned per response.
    /// </summary>
    public class QueryJobResultPages
    {
        /// <summary>
        /// Result page URLs, to be retrieved with <see cref="BulkApiClient.GetQueryJobResultsByUrlAsync"/>
        /// </summary>
        [JsonProperty(PropertyName = "resultPages")]
        public List<QueryJobResultPage> ResultPages { get; set; }

        /// <summary>
        /// Relative URL of the next set of result page URLs, if any
        /// </summary>
        [JsonProperty(PropertyName = "nextRecordsUrl")]
        public string NextRecordsUrl { get; set; }

        /// <summary>
        /// False if there are more result page URLs to retrieve using <see cref="NextRecordsUrl"/>
        /// </summary>
        [JsonProperty(PropertyName = "done")]
        public bool Done { get; set; }
    }

    /// <summary>
    /// A single query job result page
    /// </summary>
    public class QueryJobResultPage
    {
        /// <summary>
        /// Relative URL of the result page
        /// </summary>
        [JsonProperty(PropertyName = "resultUrl")]
        public string ResultUrl { get; set; }
    }
}
