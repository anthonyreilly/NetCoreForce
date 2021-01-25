using System.Collections.Generic;

using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class CompositeItem
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="referenceId"></param>
        public CompositeItem(string method, string url, string referenceId)
        {
            Url         = url;
            Method      = method;
            ReferenceId = referenceId;
        }

        /// <summary>
        /// Optional. Request headers and their values to include with the subrequest.
        /// You can include any header supported by the requested resource except for the following three headers.
        ///     - Accept
        ///     - Authorization
        ///     - Content-Type
        ///     
        /// Subrequests inherit these three header values from the top-level request. Don’t specify these headers in a subrequest.
        /// If you do, the top-level request fails and returns an HTTP 400 response.
        /// </summary>
        [JsonProperty(PropertyName = "httpHeaders")]
        public Dictionary<string, string> HttpHeaders { get; set; }

        /// <summary>
        /// Required. The method to use with the requested resource.
        /// Possible values are POST, PUT, PATCH, GET, and DELETE (case-sensitive).
        /// For a list of valid methods, refer to the documentation for the requested resource.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Required. Reference ID that maps to the subrequest’s response and can be used to reference the response in later subrequests.
        /// You can reference the referenceId in either the body or URL of a subrequest.
        /// Use this syntax to include a reference: `@{referenceId.FieldName}`.
        /// 
        /// You can use two operators with the reference ID.
        /// The `.` operator references a field on a JSON object in the response.
        /// For example, let’s say you retrieve an account record’s data in one subrequest and assign the reference ID Account1Data to the output.
        /// You can refer to the account’s name in later subrequests like this: `@{Account1Data.Name}`.
        /// 
        /// The `[]` operator indexes a JSON collection in the response.
        /// For example, let’s say you request basic account information with the sObject Basic Information resource in one subrequest and
        /// assign the reference ID AccountInfo to the output. Part of the response includes a collection of recently created accounts.
        /// You can refer to the ID of the first account in the recent items collection like this: `@{AccountInfo.recentItems[0].Id}`.
        /// 
        /// You can use each operator recursively as long as it makes sense in the context of the response.
        /// For example, to refer to the billing city component of an account’s compound address field: `@{NewAccount.BillingAddress.city}`.
        /// `referenceId` is case-sensitive, so pay close attention to the case of the fields you’re referring to.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Required. The resource to request.
        ///     - The URL can include any query string parameters that the subrequest supports. The query string must be URL-encoded.
        ///     - You can use parameters to filter response bodies.
        ///     - The URL must start with `/services/data/vXX.X/`.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
