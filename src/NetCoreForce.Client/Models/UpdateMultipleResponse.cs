using System;
using System.Collections.Generic;

using Newtonsoft.Json;

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

    public class InsertMultipleResponse
    {
        /// <summary>
        /// results
        /// </summary>
        [JsonProperty(PropertyName = "hasErrors")]
        public bool HasErrors { get; set; }
        /// <summary>
        /// results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public List<InsertMultipleResult> Results { get; set; }
    }

    public class InsertMultipleResult
    {
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }

}
