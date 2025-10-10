using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetCoreForce.Client.Models
{
    public class CompositeSObjectCollection : SObject
    {
        [JsonProperty(PropertyName = "allOrNone")]
        public bool AllOrNone { get; set; } = true;

        [JsonProperty(PropertyName = "records")]
        public List<SObject> Records { get; set; }
    }
}
