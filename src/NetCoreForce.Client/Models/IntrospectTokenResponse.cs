using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class IntrospectTokenResponse
    {
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "sub")]
        public string Sub { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "exp")]
        public int Exp { get; set; }

        [JsonProperty(PropertyName = "iat")]
        public int Iat { get; set; }

        [JsonProperty(PropertyName = "nbf")]
        public int Nbf { get; set; }

    }
}
