using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;

namespace NetCoreForce.Client.Models
{
    public class TokenRequest
    {
        [JsonProperty(PropertyName = "grant_type")]
        public string GrantType { get; set; }

        [JsonProperty(PropertyName = "client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        [JsonProperty(PropertyName = "redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        public FormUrlEncodedContent GetUrlEncoded ()
        {
            return new System.Net.Http.FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", GrantType),
                    new KeyValuePair<string, string>("client_id", ClientId),
                    new KeyValuePair<string, string>("client_secret", ClientSecret),
                    new KeyValuePair<string, string>("redirect_uri", RedirectUri),
                    new KeyValuePair<string, string>("code", Code)
                });
        }
    }
}
