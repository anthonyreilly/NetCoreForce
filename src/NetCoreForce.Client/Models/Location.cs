using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class Location
    {
        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; set; }
    }
}