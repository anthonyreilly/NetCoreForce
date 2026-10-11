using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Line ending used for CSV job data. Salesforce defaults to LF.
    /// </summary>
    [JsonConverter(typeof(BulkApiEnumConverter))]
    public enum BulkLineEnding
    {
        /// <summary>
        /// Linefeed character
        /// </summary>
        [EnumMember(Value = "LF")]
        LF,

        /// <summary>
        /// Carriage return character followed by a linefeed character
        /// </summary>
        [EnumMember(Value = "CRLF")]
        CRLF,
    }
}
