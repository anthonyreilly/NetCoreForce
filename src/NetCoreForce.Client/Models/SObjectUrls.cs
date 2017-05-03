using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    [JsonObject("urls")]
    public class SObjectUrls
    {
        [JsonProperty(PropertyName = "compactLayouts")]
        public string CompactLayouts { get; set; }

        [JsonProperty(PropertyName = "rowTemplate")]
        public string RowTemplate { get; set; }

        [JsonProperty(PropertyName = "approvalLayouts")]
        public string ApprovalLayouts { get; set; }

        /// <summary>
        /// Not included in basic info/metdata
        /// </summary>
        [JsonProperty(PropertyName = "uiDetailTemplate")]
        public string UiDetailTemplate { get; set; }

        /// <summary>
        /// Not included in basic info/metdata
        /// </summary>
        [JsonProperty(PropertyName = "uiEditTemplate")]
        public string UiEditTemplate { get; set; }

        [JsonProperty(PropertyName = "defaultValues")]
        public string DefaultValues { get; set; }

        [JsonProperty(PropertyName = "listviews")]
        public string Listviews { get; set; }

        [JsonProperty(PropertyName = "describe")]
        public string Describe { get; set; }

        /// <summary>
        /// Not included in basic info/metdata
        /// </summary>
        [JsonProperty(PropertyName = "uiNewRecord")]
        public string UiNewRecord { get; set; }

        [JsonProperty(PropertyName = "quickActions")]
        public string QuickActions { get; set; }

        [JsonProperty(PropertyName = "layouts")]
        public string Layouts { get; set; }

        [JsonProperty(PropertyName = "sobject")]
        public string Sobject { get; set; }
    }
}