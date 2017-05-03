using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class QueryResult<T>
    {
        /// <summary>
        /// TRUE if the end of the result batch has been reached.
        /// </summary>
        [JsonProperty(PropertyName = "done")]
        public bool Done { get; set; }

        /// <summary>
        /// Total number of records in result batch
        /// </summary>
        [JsonProperty(PropertyName = "totalSize")]
        public int TotalSize { get; set; }

        /// <summary>
        /// Continuation link, when there are additional results to retrieve
        /// </summary>
        [JsonProperty(PropertyName = "nextRecordsUrl")]
        public string NextRecordsUrl { get; set; }

        /// <summary>
        /// Array of object results in this batch
        /// </summary>
        [JsonProperty(PropertyName = "records")]
        public List<T> Records { get; set; }
    }
}