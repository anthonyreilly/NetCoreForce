using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class SObjectTreeResponse
    {
        /// <summary>
        /// Has Errors
        /// </summary>
        [JsonProperty(PropertyName = "hasErrors")]
        public string HasErrors { get; set; }

        /// <summary>
        /// Success flag
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public List<SObjectTreeResult> Results { get; set; }
    }

    public class SObjectTreeResult
    {
        /// <summary>
        /// Reference Id
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Object Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public List<SObjectTreeError> Errors { get; set; }
    }

    public class SObjectTreeError
    {
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "fields")]
        public List<string> Fields { get; set; }
    }
}
