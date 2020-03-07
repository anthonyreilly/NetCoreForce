using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    ///  SObject Describe resource response, for all sobject metadata
    /// </summary>
    public class SObjectDescribeFull : SObjectDescribeBasic
    {
        //actionOverrides
        // [JsonProperty(PropertyName = "actionOverrides")]
        // public List<XXXX> actionOverrides { get; set; }

        [JsonProperty(PropertyName = "childRelationships")]
        public List<ChildRelationship> ChildRelationships { get; set; }

        [JsonProperty(PropertyName = "compactLayoutable")]
        public bool CompactLayoutable { get; set; }

        [JsonProperty(PropertyName = "fields")]
        public List<SObjectFieldMetadata> Fields { get; set; }

        //listviewable

        //lookupLayoutable

        //namedLayoutInfos

        [JsonProperty(PropertyName = "networkScopeFieldName")]
        public string NetworkScopeFieldName { get; set; }

        //recordTypeInfos

        [JsonProperty(PropertyName = "searchLayoutable")]
        public bool SearchLayoutable { get; set; }

        //supportedScopes

        //uiDetailTemplate

        /// <summary>
        /// Get the collection of PickListValues for the given field
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <returns>Returns empty list if none found</returns>
        public List<PickListValue> GetPicklistValues(string fieldName)
        {
            var values = new List<PickListValue>();

            if (Fields != null && Fields.Count > 0)
            {
                values =  Fields.Where(f => f.Name == fieldName).Select(f => f.PicklistValues).SingleOrDefault();
            }

            return values;
        }
    }
}