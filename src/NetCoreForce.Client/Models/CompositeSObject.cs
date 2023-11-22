using NetCoreForce.Client.Enumerations;

namespace NetCoreForce.Client.Models
{
    public class CompositeSObject
    {
        public SObject SObject { get; set; }

        public string Id { get; set; }

        public CompositeMethod Method { get; set; }
    }
}
