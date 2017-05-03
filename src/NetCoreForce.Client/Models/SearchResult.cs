using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{   

    public class SearchResult<T>
    {
        [JsonProperty(PropertyName = "searchRecords")]
        public List<T> SearchRecords { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public SearchResultMetadata Metadata { get; set; }
    }

    public class SearchResultMetadata
    {
        [JsonProperty(PropertyName = "entityMetadata")]
        public List<SearchEntityMetadata> EntityMetadata { get; set; }
    }

    public class SearchEntityMetadata
    {
        public string EntityName { get; set; }

        public List<SearchFieldMetadata> FieldMetadata { get; set; }

    }

    public class SearchFieldMetadata
    {
        public string Name { get; set; }
        public string Label { get; set; }
    }


    //experimental.... maybe just stick with expandoobjects for result collection?
    // public class SearchRecord : DynamicObject
    // {
    //     /// <summary>
    //     /// SObject Attributes
    //     /// </summary>
    //     /// <returns></returns>
    //     [JsonProperty(PropertyName = "attributes")]
    //     public SObjectAttributes Attributes { get; set; }

    //     /// <summary>
    //     /// Object Id. Results include Id by default, but it is possible to explicity omit them.
    //     /// </summary>
    //     [JsonProperty(PropertyName = "id")]
    //     public string Id { get; set; }

    //     private Dictionary<string, object> _properties = new Dictionary<string, object>();

    //     public override bool TryGetMember(GetMemberBinder binder, out object result)
    //     {
    //         return _properties.TryGetValue(binder.Name, out result);
    //     }

    //     public override bool TrySetMember(SetMemberBinder binder, object value)
    //     {
    //         _properties[binder.Name] = value;
    //         return true;
    //     }
    // }
}