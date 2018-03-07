using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace NetCoreForce.Linq.Conventions.Naming
{
    /// <inheritdoc />
    /// <summary>
    /// NetCoreForcE.ModelGenerator naming convention :
    /// <list type="bullet">
    ///     <item>
    ///         <term>Object name</term>
    ///         <description>From a static <c>SObjectTypeName</c> property.</description>
    ///     </item>
    ///     <item>
    ///         <term>Fields name</term>
    ///         <description>From the <c>JsonProperty</c> attribute. (<see cref="P:Newtonsoft.Json.JsonPropertyAttribute.PropertyName" />)</description>
    ///     </item>
    /// </list>
    /// </summary>
    public class ModelGeneratorNamingConvention : ISalesforceNamingConvention
    {
        public const string ObjectTypeNamePropertyName = "SObjectTypeName";

        public string GetObjectTypeName(Type elementType)
        {
            var propertyInfo = elementType.GetTypeInfo().GetProperty(ObjectTypeNamePropertyName, BindingFlags.Public | BindingFlags.Static);

            if (propertyInfo == null)
                throw new InvalidOperationException($"The type '{elementType.FullName}' has no static property named '{ObjectTypeNamePropertyName}'.");

            var value = propertyInfo.GetValue(null, null);
            return (string) value;
        }

        public IEnumerable<string> GetAllPropertyNames(Type elementType)
        {
            var allPropertyNames = (
                    from property in elementType.GetTypeInfo().GetProperties() 
                    let type = property.PropertyType 
                    where type == typeof(string) || type == typeof(decimal?) || type == typeof(DateTime?) 
                    where !IgnoreProperty(property)
                    select GetPropertyName(property))
                .ToList();
            return allPropertyNames;
        }

        public string GetMemberName(MemberExpression m)
        {
            var nameBuilder = new StringBuilder();
            
            AddNameRecursive(m);

            var result = nameBuilder.ToString();

            return result;

            void AddNameRecursive(MemberExpression e)
            {
                if (e.Expression is MemberExpression memberExpression)
                {
                    AddNameRecursive(memberExpression);
                    nameBuilder.Append(".");
                }
                else if (e.Expression != null && !(e.Expression is ParameterExpression))
                    throw new NotImplementedException($"{nameof(GetMemberName)} cannot be fin with sub-expression of type '{e.Expression.GetType().Name}'");
                
                var name = e.Member.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;

                nameBuilder.Append(name);
            }
        }

        public bool IgnoreProperty(PropertyInfo property)
        {
            return property.GetCustomAttributes<JsonIgnoreAttribute>().Any();
        }

        public string GetPropertyName(PropertyInfo property)
        {
            return property.GetCustomAttribute<JsonPropertyAttribute>().PropertyName;
        }
    }
}