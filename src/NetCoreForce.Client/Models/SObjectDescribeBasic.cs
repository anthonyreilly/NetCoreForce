
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Basic SObject metadata
    /// </summary>
    [JsonObject("objectDescribe")]
    public class SObjectDescribeBasic
    {
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Name))
                return Name;
            else
                return base.ToString();
        }

        [JsonProperty(PropertyName = "activateable")]
        public bool Activateable { get; set; }

        [JsonProperty(PropertyName = "createable")]
        public bool Creatable { get; set; }

        [JsonProperty(PropertyName = "custom")]
        public bool Custom { get; set; }

        [JsonProperty(PropertyName = "customSetting")]
        public bool CustomSetting { get; set; }

        [JsonProperty(PropertyName = "deletable")]
        public bool Deletable { get; set; }

        [JsonProperty(PropertyName = "deprecatedAndHidden")]
        public bool DeprecatedAndHidden { get; set; }

        [JsonProperty(PropertyName = "feedEnabled")]
        public bool FeedEnabled { get; set; }

        [JsonProperty(PropertyName = "hasSubtypes")]
        public bool HasSubtypes { get; set; }

        [JsonProperty(PropertyName = "isSubtype")]
        public bool IsSubtype { get; set; }

        [JsonProperty(PropertyName = "keyPrefix")]
        public string KeyPrefix { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "labelPlural")]
        public string LabelPlural { get; set; }

        [JsonProperty(PropertyName = "layoutable")]
        public bool layoutable { get; set; }

        [JsonProperty(PropertyName = "mergeable")]
        public bool Mergeable { get; set; }

        [JsonProperty(PropertyName = "mruEnabled")]
        public bool MruEnabled { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "queryable")]
        public bool Queryable { get; set; }

        [JsonProperty(PropertyName = "replicateable")]
        public bool Replicateable { get; set; }

        [JsonProperty(PropertyName = "retrieveable")]
        public bool Retrieveable { get; set; }

        [JsonProperty(PropertyName = "searchable")]
        public bool Searchable { get; set; }

        [JsonProperty(PropertyName = "triggerable")]
        public bool Triggerable { get; set; }

        [JsonProperty(PropertyName = "undeletable")]
        public bool Undeletable { get; set; }

        [JsonProperty(PropertyName = "updateable")]
        public bool Updateable { get; set; }

        [JsonProperty(PropertyName = "urls")]
        public SObjectUrls Urls { get; set; }
        //TODO: evaluate if this would be better off as a Dictionary<string, string>
    }
}