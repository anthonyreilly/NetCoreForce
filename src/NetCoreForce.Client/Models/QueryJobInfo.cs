using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class QueryJobInfo
    {
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; } = "CSV";

        [JsonProperty(PropertyName = "lineEnding")]
        public string LineEnding { get; set; } = "CRLF";

        [JsonProperty(PropertyName = "columnDelimiter")]
        public string ColumnDelimiter { get; set; } = "COMMA";
    }
}
