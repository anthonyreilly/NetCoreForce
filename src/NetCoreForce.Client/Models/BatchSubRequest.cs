using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class BatchSubRequest
    {
        /// <summary>
        /// The name of the binary part in the multipart request.
        /// <para>Optional</para>
        /// </summary>
        [JsonProperty(PropertyName = "binaryPartName")]
        public string BinaryPartName { get; set; }

        /// <summary>
        /// The name parameter in the Content-Disposition header of the binary body part. Different resources expect different values.
        /// <para>If this value exists, a binaryPartName value must also exist.</para>
        /// <para>Optional</para>
        /// </summary>
        [JsonProperty(PropertyName = "binaryPartNameAlias")]
        public string BinaryPartNameAlias { get; set; }

        /// <summary>
        /// The method to use with the requested resource. For a list of valid methods, refer to the documentation for the requested resource.
        /// <para>Required</para>
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary> 
        /// The input body for the request. The type depends on the request specified in the url property.
        /// <para>Optional</para>
        /// </summary>
        [JsonProperty(PropertyName = "richInput")]
        public string RichInput { get; set; }

        /// <summary>
        /// The resource to request.
        /// <para>Required</para>
        /// <para>The URL can include any query string parameters that the subrequest supports. The query string must be URL-encoded.</para>
        /// <para>You can use parameters to filter response bodies.</para>
        /// <para>You cannot apply headers at the subrequest level.</para>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}