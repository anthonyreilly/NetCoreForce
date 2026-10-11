using System;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API 2.0 job information common to ingest and query jobs
    /// </summary>
    public class BulkJobInfo
    {
        /// <summary>
        /// Unique ID for this job
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The processing operation for the job, e.g. insert, upsert, query
        /// <para>A string rather than an enum, since job lists can include Bulk API (Classic) jobs</para>
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// The object type for the data being processed
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        /// <summary>
        /// The ID of the user who created the job
        /// </summary>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }

        /// <summary>
        /// The date and time when the job was created
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public DateTimeOffset? CreatedDate { get; set; }

        /// <summary>
        /// The date and time when the job was last modified
        /// </summary>
        [JsonProperty(PropertyName = "systemModstamp")]
        public DateTimeOffset? SystemModstamp { get; set; }

        /// <summary>
        /// The current state of the job.
        /// <para>Null if the value is not a Bulk API 2.0 job state, e.g. Bulk API (Classic) jobs returned when listing jobs.</para>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public BulkJobState? State { get; set; }

        /// <summary>
        /// Reserved for future use. Currently always Parallel.
        /// </summary>
        [JsonProperty(PropertyName = "concurrencyMode")]
        public string ConcurrencyMode { get; set; }

        /// <summary>
        /// The format of the job data
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public BulkContentType? ContentType { get; set; }

        /// <summary>
        /// The API version that the job was created in, e.g. 62.0
        /// <para>Query job results must be retrieved using the same API version.</para>
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public decimal? ApiVersion { get; set; }

        /// <summary>
        /// The type of job, e.g. V2Ingest, V2Query, BigObjectIngest, or Classic
        /// </summary>
        [JsonProperty(PropertyName = "jobType")]
        public string JobType { get; set; }

        /// <summary>
        /// The line ending used for CSV job data
        /// </summary>
        [JsonProperty(PropertyName = "lineEnding")]
        public BulkLineEnding? LineEnding { get; set; }

        /// <summary>
        /// The column delimiter used for CSV job data
        /// </summary>
        [JsonProperty(PropertyName = "columnDelimiter")]
        public BulkColumnDelimiter? ColumnDelimiter { get; set; }

        /// <summary>
        /// The number of records already processed
        /// </summary>
        [JsonProperty(PropertyName = "numberRecordsProcessed")]
        public long? NumberRecordsProcessed { get; set; }

        /// <summary>
        /// The number of times that Salesforce attempted to save the results of an operation
        /// </summary>
        [JsonProperty(PropertyName = "retries")]
        public int? Retries { get; set; }

        /// <summary>
        /// The number of milliseconds taken to process the job
        /// </summary>
        [JsonProperty(PropertyName = "totalProcessingTime")]
        public long? TotalProcessingTime { get; set; }

        /// <summary>
        /// The error message shown for jobs with errors
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// True if the job is in a terminal state: JobComplete, Failed, or Aborted
        /// </summary>
        [JsonIgnore]
        public bool IsTerminal
        {
            get
            {
                return State == BulkJobState.JobComplete || State == BulkJobState.Failed || State == BulkJobState.Aborted;
            }
        }
    }
}
