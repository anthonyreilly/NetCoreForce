using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class IngestJobInfo
    {
        [JsonProperty(PropertyName = "assignmentRuleId")]
        public string AssignmentRuleId { get; set; }

        [JsonProperty(PropertyName = "columnDelimiter")]
        public string ColumnDelimiter { get; set; } = "COMMA";

        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; } = "CSV";

        [JsonProperty(PropertyName = "externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

        [JsonProperty(PropertyName = "lineEnding")]
        public string LineEnding { get; set; } = "CRLF";

        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }
    }
}
