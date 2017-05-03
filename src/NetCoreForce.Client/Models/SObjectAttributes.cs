using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class SObjectAttributes
    {
        /// <summary>
        /// This record’s type.
        /// e.g. "Account"
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Object URL
        /// e.g. "/services/data/v39.0/sobjects/Account/001XXXXXXXXXXXXXXX"
        /// </summary>
        /// <returns></returns>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Reference ID for this record, Used in SObject Tree reuests.
        /// Must be unique in the context of the request and start with an alphanumeric character.
        /// e.g. "ref1"
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }
    }
}