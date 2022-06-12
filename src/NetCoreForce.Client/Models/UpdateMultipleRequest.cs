using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class UpdateMultipleRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="records"></param>
        /// <param name="allOrNone"></param>
        public UpdateMultipleRequest(List<SObject> records, bool allOrNone = false)
        {
            Records = records;
            AllOrNone = allOrNone;
        }

        /// <summary>
        /// Required. A list of sObjects. In a POST request using sObject Collections,
        /// set the type attribute for each object, but don’t set the id field for any object.
        /// </summary>
        [JsonProperty(PropertyName = "records")]
        public List<SObject> Records { get; set; }

        /// <summary>
        /// Optional. Indicates whether to roll back the entire request when the update of any object fails (true) or
        /// to continue with the independent update of other objects in the request. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "allOrNone")]
        public bool AllOrNone { get; set; }
    }

    public class InsertMultipleRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="records"></param>
        public InsertMultipleRequest(List<SObject> records)
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
