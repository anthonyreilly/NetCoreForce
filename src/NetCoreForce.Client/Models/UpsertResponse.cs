using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Upsert Result
    /// </summary>
    public class UpsertResponse: CreateResponse
    {
        /// <summary>
        /// Whether or not the object was created, as part of an Insert or Update action
        /// Available in API v46 and later
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public bool Created { get; set; }
    }
}
