using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class SalesforceVersions
    {
        [JsonProperty(PropertyName = "versions")]
        public List<SalesforceVersion> Versions { get; set; }
    }
    
    public class SalesforceVersion
    {
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}
