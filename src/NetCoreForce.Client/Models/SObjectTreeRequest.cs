using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class SObjectTreeRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="records"></param>
        public SObjectTreeRequest(List<SObject> records)
        {
            Records = records;
        }

        /// <summary>
        /// Required. A list of sObjects. In a POST request using sObject Collections,
        /// set the type attribute for each object, but don’t set the id field for any object.
        /// </summary>
        [JsonProperty(PropertyName = "records")]
        public List<SObject> Records { get; set; }
    }
}
