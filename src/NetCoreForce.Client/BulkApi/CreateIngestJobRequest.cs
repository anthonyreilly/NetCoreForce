using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Request to create a Bulk API 2.0 ingest job
    /// </summary>
    public class CreateIngestJobRequest
    {
        public CreateIngestJobRequest()
        {
        }

        /// <summary>
        /// Create a request for an ingest job
        /// </summary>
        /// <param name="objectName">The object type for the data being processed, e.g. Account</param>
        /// <param name="operation">The processing operation for the job</param>
        public CreateIngestJobRequest(string objectName, BulkIngestOperation operation)
        {
            Object = objectName;
            Operation = operation;
        }

        /// <summary>
        /// The object type for the data being processed. Use only a single object type per job.
        /// <para>Required, except for the consentImport operation, where it must not be set.</para>
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        /// <summary>
        /// The processing operation for the job. Required.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public BulkIngestOperation Operation { get; set; }

        /// <summary>
        /// The external ID field in the object being updated. Required for upsert operations.
        /// <para>Field values must also exist in the CSV job data.</para>
        /// </summary>
        [JsonProperty(PropertyName = "externalIdFieldName")]
        public string ExternalIdFieldName { get; set; }

        /// <summary>
        /// The content type for the job. Optional, CSV is the only, and default, value.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public BulkContentType? ContentType { get; set; }

        /// <summary>
        /// The column delimiter used for CSV job data. Optional, defaults to COMMA.
        /// </summary>
        [JsonProperty(PropertyName = "columnDelimiter")]
        public BulkColumnDelimiter? ColumnDelimiter { get; set; }

        /// <summary>
        /// The line ending used for CSV job data. Optional, defaults to LF.
        /// </summary>
        [JsonProperty(PropertyName = "lineEnding")]
        public BulkLineEnding? LineEnding { get; set; }

        /// <summary>
        /// The ID of an assignment rule to run for a Case or a Lead. The assignment rule can be active or inactive. Optional.
        /// <para>Available in API version 49.0 and later.</para>
        /// </summary>
        [JsonProperty(PropertyName = "assignmentRuleId")]
        public string AssignmentRuleId { get; set; }
    }
}
