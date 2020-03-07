using System;

namespace NetCoreForce.Client.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class CreatableAttribute : Attribute
    {
        public bool Creatable { get; private set; }

        public CreatableAttribute(bool creatable)
        {
            Creatable = creatable;
        }
    }
}