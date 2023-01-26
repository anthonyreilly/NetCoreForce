using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Serializer
{
    public class UpdateableContractResolver : DefaultContractResolver
    {
        List<string> _fieldsToNull;
        public UpdateableContractResolver(List<string> fieldsToNull = null)
        {
            _fieldsToNull = fieldsToNull;
        }
        
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization serialization)
        {
            var property = base.CreateProperty(member, serialization);

            var updateableAttribute = member.GetCustomAttribute<UpdateableAttribute>();
            if (updateableAttribute != null)
            {
                property.ShouldSerialize = x => updateableAttribute.Updateable;
            }

            if (_fieldsToNull != null && _fieldsToNull.FindIndex(x => x.Equals(property.PropertyName, System.StringComparison.OrdinalIgnoreCase)) != -1)
            {
                property.NullValueHandling = NullValueHandling.Include;
            }

            return property;
        }
    }
}