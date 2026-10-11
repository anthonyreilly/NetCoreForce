using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API 2.0 ingest job operation
    /// </summary>
    [JsonConverter(typeof(BulkApiEnumConverter))]
    public enum BulkIngestOperation
    {
        [EnumMember(Value = "insert")]
        Insert,

        [EnumMember(Value = "update")]
        Update,

        /// <summary>
        /// Requires <see cref="CreateIngestJobRequest.ExternalIdFieldName"/>
        /// </summary>
        [EnumMember(Value = "upsert")]
        Upsert,

        /// <summary>
        /// Soft delete, records are moved to the Recycle Bin
        /// </summary>
        [EnumMember(Value = "delete")]
        Delete,

        /// <summary>
        /// Permanent delete. Requires the "Bulk API Hard Delete" permission.
        /// </summary>
        [EnumMember(Value = "hardDelete")]
        HardDelete,

        /// <summary>
        /// Marketing objects only
        /// </summary>
        [EnumMember(Value = "refresh")]
        Refresh,

        /// <summary>
        /// Consent ingest. Do not set <see cref="CreateIngestJobRequest.Object"/> for this operation.
        /// </summary>
        [EnumMember(Value = "consentImport")]
        ConsentImport,
    }
}
