using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Serializer
{
    public class UpdateableContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization serialization)
        {
            var property = base.CreateProperty(member, serialization);

            var updateableAttribute = member.GetCustomAttribute<UpdateableAttribute>();
            if (updateableAttribute != null)
            {
                    property.ShouldSerialize = x => updateableAttribute.Updateable;
            }

            return property;
        }
    }
}