using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Picklist value
    /// </summary>
    public class PickListValue
    {
        /// <summary>
        /// Active
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        /// <summary>
        /// Default picklist value
        /// </summary>
        [JsonProperty(PropertyName = "defaultValue")]
        public bool DefaultValue { get; set; }

        /// <summary>
        /// Value label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Valid for property
        /// </summary>
        [JsonProperty(PropertyName = "validFor")]
        public byte[] ValidFor { get; set; }

        /// <summary>
        /// Picklist item value
        /// </summary>
        /// <returns></returns>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
