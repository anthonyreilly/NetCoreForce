using NetCoreForce.Client.Enumerations;

namespace NetCoreForce.Client.Models
{
    public class CompositeSObject
    {
        public CompositeType CompositeType { get; set; }

        public string Id { get; set; }

        public CompositeMethod Method { get; set; }

        public string ReferenceId { get; set; }

        public SObject SObject { get; set; }

        public string Type { get; set; }
    }
}
