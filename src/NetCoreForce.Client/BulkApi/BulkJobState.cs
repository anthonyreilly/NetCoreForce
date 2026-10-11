using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API 2.0 job state
    /// </summary>
    [JsonConverter(typeof(BulkApiEnumConverter))]
    public enum BulkJobState
    {
        /// <summary>
        /// Ingest jobs only. The job was created, and data can be uploaded.
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// All job data has been uploaded, and the job is queued for processing
        /// </summary>
        [EnumMember(Value = "UploadComplete")]
        UploadComplete,

        /// <summary>
        /// The job is being processed
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress,

        /// <summary>
        /// The job was processed. Terminal state.
        /// </summary>
        [EnumMember(Value = "JobComplete")]
        JobComplete,

        /// <summary>
        /// The job could not be processed. Terminal state.
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// The job was aborted. Terminal state.
        /// </summary>
        [EnumMember(Value = "Aborted")]
        Aborted,
    }
}
