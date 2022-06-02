using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Success response after creating new record
    /// </summary>
    public class InsertOrUpdateResponse : CreateResponse
    {
        /// <summary>
        /// Whether or not the object was created, as part of an Insert or Update action
        /// Available in API v46 and later
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public bool Created { get; set; }
    }
}

