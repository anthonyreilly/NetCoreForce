using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetCoreForce.Client.Models
{
    public class CompositeRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="requests"></param>
        /// <param name="allOrNone"></param>
        /// <param name="collateSubrequests"></param>
        public CompositeRequest(List<CompositeSubRequest> requests, bool allOrNone = false, bool collateSubrequests = true)
        {
            CompositeRequests = requests;
            AllOrNone = allOrNone;
            CollateSubrequests = collateSubrequests;
        }

        /// <summary>
        /// Required. A list of Composite Sub Requests
        /// </summary>
        [JsonProperty(PropertyName = "compositeRequest")]
        public List<CompositeSubRequest> CompositeRequests { get; set; }

        /// <summary>
        /// Optional. Indicates whether to roll back the entire request when the update of any object fails (true) or
        /// to continue with the independent update of other objects in the request. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "allOrNone")]
        public bool AllOrNone { get; set; }

        /// <summary>
        /// Optional. Controls whether the API collates unrelated subrequests to bulkify them (true) or not (false).
        /// In API version 49.0 and later, the default value is true. In version 48.0, the default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "collateSubrequests")]
        public bool CollateSubrequests { get; set; }
    }
}
