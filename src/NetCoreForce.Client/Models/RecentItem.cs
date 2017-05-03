
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Recent SObjects, used in SObject basic info/metadata requests
    /// </summary>
    public class RecentItem
    {
        [JsonProperty(PropertyName = "attributes")]
        public SObjectAttributes Attributes { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        //an additional parameter may be included, depending on object type.
        //e.g. Account Name, Case Number
        //most often Name

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}