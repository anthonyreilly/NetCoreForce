using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class ChildRelationship
    {
        [JsonProperty(PropertyName = "cascadeDelete")]
        public bool CascadeDelete { get; set; }

        [JsonProperty(PropertyName = "childSObject")]
        public string ChildSObject { get; set; }

        [JsonProperty(PropertyName = "deprecatedAndHidden")]
        public bool DeprecatedAndHidden { get; set; }

        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        //TODO: check type def
        [JsonProperty(PropertyName = "junctionIdListNames")]
        public List<string> JunctionIdListNames { get; set; }

        //TODO: check type def
        [JsonProperty(PropertyName = "junctionReferenceTo")]
        public List<string> JunctionReferenceTo { get; set; }

        [JsonProperty(PropertyName = "relationshipName")]
        public string RelationshipName { get; set; }

        [JsonProperty(PropertyName = "restrictedDelete")]
        public bool RestrictedDelete { get; set; }

    }
}