using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetCoreForce.ModelGenerator
{
    /// <summary>
    /// Mapping configuration
    /// </summary>
    public class ObjectMappingConfig
    {
        /// <summary>
        /// Used to override the class name (or <c>null</c>).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// If <c>true</c>, don't generate the class for this object type (and the relationship to this type too).
        /// </summary>
        public bool Ignore { get; set; }

        /// <summary>
        /// The mappings for the fields of this object type.
        /// </summary>
        public Dictionary<string, FieldMappingConfig> Fields { get; set; } = new Dictionary<string, FieldMappingConfig>();


        private List<RegexFieldMappingConfig> _regexFieldsMappings = null;
        private List<RegexFieldMappingConfig> RegexFieldMappings
        {
            get
            {
                if (_regexFieldsMappings == null)
                    _regexFieldsMappings = Fields.Select(kvp => new RegexFieldMappingConfig(kvp.Key, kvp.Value)).ToList();

                return _regexFieldsMappings;
            }
        }

        /// <summary>
        /// Get the <see cref="FieldMappingConfig"/> which it's regex matches the field name given.
        /// </summary>
        /// <param name="fieldName">The field name</param>
        /// <returns>The <see cref="FieldMappingConfig"/> which it's regex matches the field name given or <c>null</c>.</returns>
        public FieldMappingConfig Field(string fieldName)
        {
            FieldMappingConfig mapping = null;

            if (!string.IsNullOrWhiteSpace(fieldName))
                mapping = RegexFieldMappings.FirstOrDefault(rfb => rfb.IsMatch(fieldName))?.Mapping;
                
            return mapping ?? new FieldMappingConfig();
        }

        /// <summary>
        /// Bind a <see cref="FieldMappingConfig"/> with a <see cref="Regex"/>.
        /// </summary>
        private class RegexFieldMappingConfig
        {
            public RegexFieldMappingConfig(string regexPattern, FieldMappingConfig mapping)
            {
                Regex = new Regex(regexPattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                Mapping = mapping;
            }

            public Regex Regex { get; }
            public FieldMappingConfig Mapping { get; }

            public bool IsMatch(string fieldName) => Regex.IsMatch(fieldName);
        }

        /// <summary>
        /// Field mapping configuration
        /// </summary>
        public class FieldMappingConfig
        {
            /// <summary>
            /// Override the field name with this name (if <c>null</c>, keep field name)
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Ignore this field
            /// </summary>
            public bool Ignore { get; set; }
        }
    }
}