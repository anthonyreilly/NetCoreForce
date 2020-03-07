
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class SObjectFieldMetadata
    {
        [JsonProperty(PropertyName = "autoNumber")]
        public bool AutoNumber { get; set; }

        [JsonProperty(PropertyName = "calculated")]
        public bool Calculated { get; set; }

        [JsonProperty(PropertyName = "creatable")]
        public bool Creatable { get; set; }

        [JsonProperty(PropertyName = "custom")]
        public bool Custom { get; set; }

        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        [JsonProperty(PropertyName = "htmlFormatted")]
        public bool HtmlFormatted { get; set; }
        
        [JsonProperty(PropertyName = "inlineHelpText")]
        public string InlineHelpText { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "nillable")]
        public bool Nillable { get; set; }

        [JsonProperty(PropertyName = "picklistValues")]
        public List<PickListValue> PicklistValues { get; set; }

        [JsonProperty(PropertyName = "referenceTo")]
        public List<string> ReferenceTo { get; set; }

        [JsonProperty(PropertyName = "relationshipName")]
        public string RelationshipName { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }        

        [JsonProperty(PropertyName = "unique")]
        public bool Unique { get; set; }   

        [JsonProperty(PropertyName = "updateable")]
        public bool Updateable { get; set; }        
    }
}