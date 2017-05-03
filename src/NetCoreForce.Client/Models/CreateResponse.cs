using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Success response after creating new record
    /// </summary>
    public class CreateResponse
    {
        /// <summary>
        /// Object Id of the newly created record/object.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Whether or not the object was created.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// List of errors, if creation failed.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public object Errors { get; set; }
    }
}

