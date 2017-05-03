using System.Collections.Generic;
using Newtonsoft.Json;

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
    }
}
