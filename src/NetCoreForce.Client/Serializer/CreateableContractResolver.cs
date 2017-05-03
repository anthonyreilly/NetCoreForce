using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Serializer
{
    public class CreateableContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization serialization)
        {
            var property = base.CreateProperty(member, serialization);

            var createableAttribute = member.GetCustomAttribute<CreateableAttribute>();
            if (createableAttribute != null)
            {
                    property.ShouldSerialize = x => createableAttribute.Createable;
            }

            return property;
        }
    }
}