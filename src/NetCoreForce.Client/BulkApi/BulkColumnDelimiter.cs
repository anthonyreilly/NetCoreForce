using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Column delimiter used for CSV job data. Salesforce defaults to COMMA.
    /// </summary>
    [JsonConverter(typeof(BulkApiEnumConverter))]
    public enum BulkColumnDelimiter
    {
        /// <summary>
        /// Backquote character (`)
        /// </summary>
        [EnumMember(Value = "BACKQUOTE")]
        Backquote,

        /// <summary>
        /// Caret character (^)
        /// </summary>
        [EnumMember(Value = "CARET")]
        Caret,

        /// <summary>
        /// Comma character (,)
        /// </summary>
        [EnumMember(Value = "COMMA")]
        Comma,

        /// <summary>
        /// Pipe character (|)
        /// </summary>
        [EnumMember(Value = "PIPE")]
        Pipe,

        /// <summary>
        /// Semicolon character (;)
        /// </summary>
        [EnumMember(Value = "SEMICOLON")]
        Semicolon,

        /// <summary>
        /// Tab character
        /// </summary>
        [EnumMember(Value = "TAB")]
        Tab,
    }
}
