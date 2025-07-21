using Newtonsoft.Json;
using System;

namespace NetCoreForce.Client.Models
{
    public class IngestJobInfoResult
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "assignmentRuleId")]
        public string AssignmentRuleId { get; set; }

        [JsonProperty(PropertyName = "jobType")]
        public string JobType { get; set; }

        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty(PropertyName = "systemModstamp")]
        public DateTime SystemModstamp { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "concurrencyMode")]
        public string ConcurrencyMode { get; set; }

        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty(PropertyName = "externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

        [JsonProperty(PropertyName = "apiVersion")]
        public double ApiVersion { get; set; }

        [JsonProperty(PropertyName = "lineEnding")]
        public string LineEnding { get; set; }

        [JsonProperty(PropertyName = "columnDelimiter")]
        public string ColumnDelimiter { get; set; }

        [JsonProperty(PropertyName = "numberRecordsProcessed")]
        public long? NumberRecordsProcessed { get; set; }

        [JsonProperty(PropertyName = "retries")]
        public int? Retries { get; set; }

        [JsonProperty(PropertyName = "totalProcessingTime")]
        public long? TotalProcessingTime { get; set; }

        [JsonProperty(PropertyName = "isPkChunkingSupported")]
        public bool IsPkChunkingSupported { get; set; }
    }
}
