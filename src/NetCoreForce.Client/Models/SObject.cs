using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public abstract class SObject
    {
        /// <summary>
        /// Contains the type and url of the object, included in some responses
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public SObjectAttributes Attributes { get; set; }        
    }
}