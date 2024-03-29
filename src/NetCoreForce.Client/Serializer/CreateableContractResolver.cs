﻿using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NetCoreForce.Client.Attributes;

namespace NetCoreForce.Client.Serializer
{
    public class CreateableContractResolver : DefaultContractResolver
    {
        List<string> _fieldsToNull;
        public CreateableContractResolver(List<string> fieldsToNull = null)
        {
            _fieldsToNull = fieldsToNull;
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization serialization)
        {
            var property = base.CreateProperty(member, serialization);

            var createableAttribute = member.GetCustomAttribute<CreateableAttribute>();
            if (createableAttribute != null)
            {
                property.ShouldSerialize = x => createableAttribute.Createable;
            }

            if (_fieldsToNull != null && _fieldsToNull.FindIndex(x => x.Equals(property.PropertyName, System.StringComparison.OrdinalIgnoreCase)) != -1)
            {
                property.NullValueHandling = NullValueHandling.Include;
            }

            return property;
        }
    }
}