using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class CompositeRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="items"></param>
        /// <param name="allOrNone"></param>
        public CompositeRequest(List<CompositeItem> items, bool allOrNone = false)
        {
            Request   = items;
            AllOrNone = allOrNone;
        }

        /// <summary>
        /// Optional. Indicates whether to roll back the entire request when the update of any object fails (true) or
        /// to continue with the independent update of other objects in the request.
        /// The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "allOrNone")]
        public bool AllOrNone { get; set; }

        /// <summary>
        /// Optional. Controls whether the API collates unrelated subrequests to bulkify them(true) or not(false).
        /// When subrequests are collated, the processing speed is faster, but the order of execution is not guaranteed
        /// (unless there is an explicit dependency between the subrequests).
        /// 
        /// If collation is disabled, then the subrequests are executed in the order in which they are received.
        /// Subrequests that contain valid HTTP headers are not collated.
        /// In API version 49.0 and later, the default value is true. In version 48.0, the default value is false.
        /// 
        /// Subrequests can be collated if they meet these conditions:
        ///     - The HTTP methods are the same.
        ///     - The API versions of the resources are the same.
        ///     - The parents of the resources are /sobjects resources.
        ///     - No more than five sObjects resources are present across a grouping of subrequests.
        /// </summary>
        [JsonProperty(PropertyName = "collateSubrequests")]
        public bool CollateSubRequests { get; set; }

        /// <summary>
        /// Required. Collection of subrequests to execute.
        /// </summary>
        [JsonProperty(PropertyName = "compositeRequest")]
        public List<CompositeItem> Request { get; set; }
    }
}
