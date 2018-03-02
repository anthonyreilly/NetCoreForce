using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace NetCoreForce.Linq.Conventions.Naming
{
    /// <inheritdoc />
    /// <summary>
    /// simple naming convention :
    /// <list type="bullet">
    ///     <item>
    ///         <term>Object name</term>
    ///         <description>From class name.</description>
    ///     </item>
    ///     <item>
    ///         <term>Fields name</term>
    ///         <description>From property name.</description>
    ///     </item>
    /// </list>
    /// </summary>
    public class SimpleNamingConvention : ISalesforceNamingConvention
    {
        
        public string GetObjectTypeName(Type elementType)
        {
            return (string) elementType.Name;
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
                
                var name = e.Member.Name;

                nameBuilder.Append(name);
            }
        }

        public bool IgnoreProperty(PropertyInfo property)
        {
            return false;
        }

        public string GetPropertyName(PropertyInfo property)
        {
            return property.Name;
        }
    }
}