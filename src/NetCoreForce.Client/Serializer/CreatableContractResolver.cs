using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Serializer
{
    public class CreatableContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization serialization)
        {
            var property = base.CreateProperty(member, serialization);

            var creatableAttribute = member.GetCustomAttribute<CreatableAttribute>();
            if (creatableAttribute != null)
            {
                property.ShouldSerialize = x => creatableAttribute.Creatable;
            }

            return property;
        }
    }
}