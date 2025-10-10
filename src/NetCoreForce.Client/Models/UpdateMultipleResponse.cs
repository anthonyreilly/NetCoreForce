using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetCoreForce.Client.Models
{
    public class UpdateMultipleResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Success flag
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public List<UpdateMultipleError> Errors { get; set; }
    }

    public class UpdateMultipleError
    {
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "fields")]
        public List<string> Fields { get; set; }
    }
}
