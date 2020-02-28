using System;
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

        /// <summary>
        /// Add <see cref="NetCoreForce.Models"/> namespace using
        /// </summary>
        public bool AddNetCoreForceModelsUsings { get; set; }
        public bool IncludeCustom { get; set; }
        public bool IncludeReferences { get; set; }
        

        public IDictionary<string, ObjectMappingConfig> Mappings { get; set; } = new Dictionary<string, ObjectMappingConfig>(StringComparer.OrdinalIgnoreCase);

        public ObjectMappingConfig Mapping(string objectName)
        {
            ObjectMappingConfig objectMapping = null;

            Mappings?.TryGetValue(objectName, out objectMapping);
                
            return objectMapping ?? new ObjectMappingConfig();
        }

        public GenConfig()
        {
            this.AuthInfo = new AuthInfo(){
                TokenRequestEndpoint = "https://login.salesforce.com/services/oauth2/token",
                ApiVersion = "v41.0"
            };
        }
    }
}