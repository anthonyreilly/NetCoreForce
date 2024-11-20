using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NetCoreForce.Client.Models
{
    public class ErrorResponse
    {
        /// <summary>
        /// Fields related to the error
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }
        
        /// <summary>
        /// Additional data
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JToken> AdditionalData { get; set; }
    }
}
