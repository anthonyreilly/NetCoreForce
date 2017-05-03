using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Contains login info for the Salesforce API, including OAuth endpoint URLs
    /// </summary>
    public class AuthInfo
    {
        /// <summary>
        /// Client ID, a.k.a. Consumer Key
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Client Secret, a.k.a. Consumer Secret
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Salesforce username
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Salesforce password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Salesforce API version
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Authorization Endpoint
        /// <para>e.g. https://login.salesforce.com/services/oauth2/authorize</para>
        /// </summary>
        [JsonProperty(PropertyName = "authorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Token request endpoint
        /// <para>e.g. https://login.salesforce.com/services/oauth2/token</para>
        /// <para> Also used for the OAuth refresh roken process</para>
        /// </summary>
        [JsonProperty(PropertyName = "tokenRequestEndpoint")]
        public string TokenRequestEndpoint { get; set; }

        /// <summary>
        /// OAuth token revocation endpoint
        /// <para>e.g. https://login.salesforce.com/services/oauth2/revoke</para>
        /// </summary>
        [JsonProperty(PropertyName = "tokenRevocationEndpoint")]
        public string TokenRevocationEndpoint { get; set; }
    }
}
