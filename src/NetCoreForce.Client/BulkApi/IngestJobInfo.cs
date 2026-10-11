using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API 2.0 ingest job information
    /// </summary>
    public class IngestJobInfo : BulkJobInfo
    {
        /// <summary>
        /// The external ID field used for upsert operations
        /// </summary>
        [JsonProperty(PropertyName = "externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

        /// <summary>
        /// The URL to use for upload job data requests. Only valid while the job is Open.
        /// </summary>
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// The ID of the assignment rule run for a Case or a Lead, if any
        /// </summary>
        [JsonProperty(PropertyName = "assignmentRuleId")]
        public string AssignmentRuleId { get; set; }

        /// <summary>
        /// The number of records that were not processed successfully
        /// </summary>
        [JsonProperty(PropertyName = "numberRecordsFailed")]
        public long? NumberRecordsFailed { get; set; }

        /// <summary>
        /// The number of milliseconds taken to actively process the job, including Apex processing time
        /// </summary>
        [JsonProperty(PropertyName = "apiActiveProcessingTime")]
        public long? ApiActiveProcessingTime { get; set; }

        /// <summary>
        /// The number of milliseconds taken to process triggers and other processes related to the job data
        /// </summary>
        [JsonProperty(PropertyName = "apexProcessingTime")]
        public long? ApexProcessingTime { get; set; }
    }
}
