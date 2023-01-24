using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class DeleteRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="allOrNone"></param>
        public DeleteRequest(List<string> ids, bool allOrNone = false)
        {
            Ids = ids;
            AllOrNone = allOrNone;
        }

        /// <summary>
        /// Required. A list of up to 200 IDs of objects to be deleted.
        /// The IDs can belong to different object types, including custom objects.
        /// </summary>
        [JsonProperty(PropertyName = "Ids")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Optional. Indicates whether to roll back the entire request when the deletion of any object fails (true)
        /// or to continue with the independent deletion of other objects in the request. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "allOrNone")]
        public bool AllOrNone { get; set; }
    }
}
