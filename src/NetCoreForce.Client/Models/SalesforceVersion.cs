using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{    
    /// <summary>
    /// API Version, returned by the Versions resource
    /// </summary>
    public class SalesforceVersion
    {
        /// <summary>
        /// API Version, e.g. "44.0"
        /// </summary>
        /// <value></value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Base URL of the version's root, e.g. "/services/data/v57.0"
        /// </summary>
        /// <value></value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Name of the version, e.g. "Winter '19"
        /// </summary>
        /// <value></value>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}
