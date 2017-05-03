using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class AuthErrorResponse
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }    
    }
}