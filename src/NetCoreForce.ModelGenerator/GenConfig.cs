using System.Collections.Generic;

namespace NetCoreForce.ModelGenerator
{
    public class GenConfig
    {
        public string OutputDirectory { get; set; }
        public List<string> Objects { get; set; }
        public string ClassPrefix { get; set; }
        public string ClassSuffix { get; set; }
        public string ClassNamespace { get; set; }
        public bool IncludeCustom { get; set; }
        public bool IncludeReferences { get; set; }
        public string ApiVersion { get; set; }
    }
}