using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Bulk API 2.0 query job operation
    /// </summary>
    [JsonConverter(typeof(BulkApiEnumConverter))]
    public enum BulkQueryOperation
    {
        /// <summary>
        /// Returns records that have not been deleted
        /// </summary>
        [EnumMember(Value = "query")]
        Query,

        /// <summary>
        /// Also returns records deleted by a merge or delete, and archived Task and Event records
        /// </summary>
        [EnumMember(Value = "queryAll")]
        QueryAll,
    }
}
