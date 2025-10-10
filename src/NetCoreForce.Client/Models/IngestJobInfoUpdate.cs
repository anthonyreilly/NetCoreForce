using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class IngestJobInfoUpdate
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}
