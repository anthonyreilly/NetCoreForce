using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    /// <summary>
    /// Access token response from a successful authentication
    /// </summary>
    public class AccessTokenResponse
    {
        /// <summary>
        /// Access token that acts as a session ID that the application uses for making requests. This token should be protected as though it were user credentials.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Token that can be used in the future to obtain new access tokens. This value is a secret. You should treat it like the user's password and use appropriate measures to protect it.
        /// <remarks>Not included with username-password auth flow.</remarks>
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Base64-encoded HMAC-SHA256 signature signed with the consumer's private key containing the concatenated ID and signature issued_at value. The signature can be used to verify that the identity URL wasn’t modified because it was sent by the server.
        /// </summary>
        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }

        /// <summary>
        /// OAuth scope
        /// <para>may have several values in responses, e.g. "id full api openid refresh_token chatter_api"</para>
        /// <para>https://developer.salesforce.com/docs/atlas.en-us.mobile_sdk.meta/mobile_sdk/oauth_scope_parameter_values.htm</para>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// OpenID Token
        /// <para>A signed JSON Web Token (JWT) that contains authenticated user attributes. This is only returned if the scope parameter includes openid.</para>
        /// </summary>
        [JsonProperty(PropertyName = "id_token")]
        public string IdToken { get; set; }

        /// <summary>
        /// Identifies the Salesforce instance to which API calls should be sent.
        /// </summary>
        [JsonProperty(PropertyName = "instance_url")]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// Identity URL that can be used to both identify the user as well as query for more information about the user. Can be used in an HTTP request to get more information about the end user.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///  OAuth 2.0 token type. Currently this is always "Bearer"
        /// </summary>
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// When the signature was created, represented as the number of seconds since the Unix epoch (00:00:00 UTC on 1 January 1970).
        /// </summary>
        [JsonProperty(PropertyName = "issued_at")]
        public string IssuedAt { get; set; }     
    }
}
