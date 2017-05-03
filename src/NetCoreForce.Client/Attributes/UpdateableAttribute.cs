using System;

namespace NetCoreForce.Client.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class UpdateableAttribute : Attribute
    {
        public bool Updateable { get; private set; }

        public UpdateableAttribute(bool updateable)
        {
            Updateable = updateable;
        }
    }
}