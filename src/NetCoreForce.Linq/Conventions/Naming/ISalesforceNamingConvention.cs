using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NetCoreForce.Linq.Conventions.Naming
{
    /// <summary>
    /// Get/Adapts the field/object's name during Object to SOQL translation
    /// </summary>
    public interface ISalesforceNamingConvention
    {
        /// <summary>
        /// Get the Salesforce object name. (ie: ... FROM {objectName} ...)
        /// corresponding to the <c>elementType</c> given.
        /// </summary>
        /// <param name="elementType">The object <see cref="Type"/>.</param>
        /// <returns>The Salesforce object name corresponding.</returns>
        string GetObjectTypeName(Type elementType);

        /// <summary>
        /// Get all the Salesforce fields names of a given object type.
        /// </summary>
        /// <param name="elementType">The object <see cref="Type"/>.</param>
        /// <returns>All the Salesforce fields names of a given object type.</returns>
        IEnumerable<string> GetAllPropertyNames(Type elementType);

        /// <summary>
        /// Get the Salesforce field name of a given <see cref="MemberExpression"/>.
        /// </summary>
        /// <param name="memberExpression">The <see cref="MemberExpression"/>.</param>
        /// <returns>The Salesforce field name.</returns>
        string GetMemberName(MemberExpression memberExpression);
    }
}