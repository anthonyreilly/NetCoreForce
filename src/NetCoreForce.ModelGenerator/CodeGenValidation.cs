using System;
using System.Text.RegularExpressions;

namespace NetCoreForce.ModelGenerator
{
    /// <summary>
    /// Validates names before they are written into generated C# source or used as file names.
    /// <para>Object and field names come from the org's metadata, and the token endpoint can come from a config file, so a malicious
    /// endpoint could otherwise return names that inject code into the generated classes or write files outside the output directory.</para>
    /// </summary>
    internal static class CodeGenValidation
    {
        // Salesforce API names, and the C# identifiers generated from them, e.g. Account, Custom_Object__c
        // \z rather than $, since $ also matches before a trailing newline
        private static readonly Regex IdentifierRegex = new Regex(@"^[A-Za-z_][A-Za-z0-9_]*\z", RegexOptions.Compiled);

        // class prefix/suffix, combined with an API name to form the class name
        private static readonly Regex AffixRegex = new Regex(@"^[A-Za-z0-9_]*\z", RegexOptions.Compiled);

        // dotted namespace, e.g. MyProject.Models
        private static readonly Regex NamespaceRegex = new Regex(@"^[A-Za-z_][A-Za-z0-9_]*(\.[A-Za-z_][A-Za-z0-9_]*)*\z", RegexOptions.Compiled);

        /// <summary>
        /// Validate an object/field API name or class name, for use as a C# identifier, string literal or file name
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is not a valid identifier</exception>
        public static string Identifier(string value, string description)
        {
            if (value == null || !IdentifierRegex.IsMatch(value))
            {
                throw new ArgumentException($"{description} '{value}' is not a valid identifier - refusing to generate code from it");
            }

            return value;
        }

        /// <summary>
        /// Validate a class prefix or suffix
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value contains characters not allowed in an identifier</exception>
        public static void Affix(string value, string description)
        {
            if (!string.IsNullOrEmpty(value) && !AffixRegex.IsMatch(value))
            {
                throw new ArgumentException($"{description} '{value}' may only contain letters, digits and underscores");
            }
        }

        /// <summary>
        /// Validate a namespace, e.g. MyProject.Models
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the value is not a valid namespace</exception>
        public static void Namespace(string value)
        {
            if (!string.IsNullOrEmpty(value) && !NamespaceRegex.IsMatch(value))
            {
                throw new ArgumentException($"Namespace '{value}' is not a valid C# namespace");
            }
        }
    }
}
