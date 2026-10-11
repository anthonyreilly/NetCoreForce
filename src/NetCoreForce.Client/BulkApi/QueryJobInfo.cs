using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API 2.0 query job information
    /// </summary>
    public class QueryJobInfo : BulkJobInfo
    {
        /// <summary>
        /// Whether PK chunking is supported for the queried object
        /// </summary>
        [JsonProperty(PropertyName = "isPkChunkingSupported")]
        public bool? IsPkChunkingSupported { get; set; }
    }
}
