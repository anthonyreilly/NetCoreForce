using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class CompositeSubRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="body"></param>
        /// <param name="method"></param>
        /// <param name="referenceId"></param>
        /// <param name="url"></param>
        public CompositeSubRequest(SObject body, string method, string referenceId, string url)
        {
            Body = body;
            Method = method;
            ReferenceId = referenceId;
            Url = url;
        }

        [JsonProperty(PropertyName = "body")]
        public SObject Body { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
