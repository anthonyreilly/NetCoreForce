using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Format of job data. CSV is the only format supported by Bulk API 2.0, and is the default.
    /// </summary>
    [JsonConverter(typeof(BulkApiEnumConverter))]
    public enum BulkContentType
    {
        [EnumMember(Value = "CSV")]
        CSV,
    }
}
