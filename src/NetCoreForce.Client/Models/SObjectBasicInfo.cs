
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// SObject Basic Information resource response
    /// </summary>
    public class SObjectBasicInfo
    {
        /// <summary>
        /// SObject Basic Information
        /// </summary>
        [JsonProperty(PropertyName = "objectDescribe")]
        public SObjectDescribeBasic ObjectDescribe { get; set; }

        /// <summary>
        /// Recent objects of this type
        /// </summary>
        [JsonProperty(PropertyName = "recentItems")]
        public List<RecentItem> RecentItems { get; set; }
    }
}