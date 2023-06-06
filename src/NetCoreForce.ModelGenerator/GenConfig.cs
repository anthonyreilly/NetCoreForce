using System.Collections.Generic;
using NetCoreForce.Client.Models;

namespace NetCoreForce.ModelGenerator
{
    public class GenConfig
    {
        public AuthInfo AuthInfo { get; set; }

        public string OutputDirectory { get; set; }
        public List<string> Objects { get; set; }
        public string ClassPrefix { get; set; }
        public string ClassSuffix { get; set; }
        public string ClassNamespace { get; set; }
        public bool IncludeCustom { get; set; }
        public bool IncludeReferences { get; set; }

        public GenConfig()
        {
            this.AuthInfo = new AuthInfo(){
                TokenRequestEndpoint = "https://login.salesforce.com/services/oauth2/token",
                ApiVersion = "v57.0"
            };
        }
    }
}