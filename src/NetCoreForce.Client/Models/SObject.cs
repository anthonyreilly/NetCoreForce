using System;
using Newtonsoft.Json;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Models
{
    public abstract class SObject// : ISObject
    {
        // [JsonIgnore]
        // public static string SObjectTypeName { get; private set; }

        // [JsonIgnore]
        // public string SObjectTypeName { get; private set; }

        // private string _sOBjectTypeName;

        // public SObject(string sObjectTypeName)
        // {
        //     if (string.IsNullOrEmpty(sObjectTypeName)) throw new ArgumentNullException("sObjectTypeName");

        //     _sOBjectTypeName = sObjectTypeName;
        // }

        /// <summary>
        /// Contains the type and url of the object, included in some responses
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public SObjectAttributes Attributes { get; set; }        
    }
}