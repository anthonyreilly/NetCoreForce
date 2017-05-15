using System;
using System.Dynamic;
using Newtonsoft.Json;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// A generic SObject, with ID and audit fields
    /// </summary>
    public class SObjectGeneric : SObject
    {

        // [JsonIgnore]
        // public string SObjectTypeName { get; set; }

        // public SObjectGeneric(string sObjectTypeName)
        // {
        //     if (string.IsNullOrEmpty(sObjectTypeName)) throw new ArgumentNullException("sObjectTypeName");

        //     this.SObjectTypeName = sObjectTypeName;
        // }

        /// <summary>
        /// Name: Id
        /// SF Type: id
        /// Custom: False
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [Updateable(false), Createable(false)]
        public string Id { get; set; }


        //Audit Fields

        /// <summary>
        /// ID of the User who created this record
        /// SF Type: reference
        /// </summary>
        /// <returns></returns>
        [JsonProperty(PropertyName = "createdById")]
        [Updateable(false), Createable(false)]
        public string CreatedById { get; set; }

        /// <summary>
        /// Date and time when this record was created
        /// SF Type: datetime
        /// </summary> 
        [JsonProperty(PropertyName = "createdDate")]
        [Updateable(false), Createable(false)]
        public DateTimeOffset? CreatedDate { get; set; }

        /// <summary>
        /// ID of the User who last updated this record
        /// SF Type: reference
        /// </summary>
        /// <returns></returns>
        [JsonProperty(PropertyName = "lastModifiedById")]
        [Updateable(false), Createable(false)]
        public string LastModifiedById { get; set; }

        /// <summary>
        /// Date and time when a user last modified this record
        /// SF Type: datetime
        /// </summary> 
        [JsonProperty(PropertyName = "lastModifiedDate")]
        [Updateable(false), Createable(false)]
        public DateTimeOffset? LastModifiedDate { get; set; }

        /// <summary>
        /// Date and time when a user or automated process (such as a trigger) last modified this record. 
        /// SF Type: datetime
        /// </summary> 
        [JsonProperty(PropertyName = "systemModstamp")]
        [Updateable(false), Createable(false)]
        public DateTimeOffset? SystemModstamp { get; set; }

        
    }
}