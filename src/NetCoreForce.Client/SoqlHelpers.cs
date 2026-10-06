using System;
using System.Text;

namespace NetCoreForce.Client
{
    /// <summary>
    /// Helpers for safely including values in SOQL and SOSL queries.
    /// <para>Always escape values that come from user input or other untrusted sources before adding them to a query string, to prevent SOQL/SOSL injection.</para>
    /// </summary>
    public static class SoqlHelpers
    {
        // SOSL reserved characters, which must be escaped with a backslash to be matched literally
        // https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_sosl_find.htm
        private const string SoslReservedChars = "?&|!{}[]()^~*:\\\"'+-";

        /// <summary>
        /// Escape a value for use inside a quoted SOQL string literal.
        /// <para>Example: <c>$"SELECT Id FROM Account WHERE Name = '{SoqlHelpers.EscapeString(name)}'"</c></para>
        /// </summary>
        /// <param name="value">Value to escape</param>
        /// <returns>Escaped value, without surrounding quotes</returns>
        public static string EscapeString(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            // https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_soql_select_quotedstringescapes.htm
            StringBuilder sb = new StringBuilder(value.Length);
            foreach (char c in value)
            {
                switch (c)
                {
                    case '\\': sb.Append("\\\\"); break;
                    case '\'': sb.Append("\\'"); break;
                    case '"': sb.Append("\\\""); break;
                    case '\n': sb.Append("\\n"); break;
                    case '\r': sb.Append("\\r"); break;
                    case '\t': sb.Append("\\t"); break;
                    case '\b': sb.Append("\\b"); break;
                    case '\f': sb.Append("\\f"); break;
                    default: sb.Append(c); break;
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Escape a value for use inside a quoted SOQL LIKE pattern, so that any _ and % characters in the value are matched literally.
        /// <para>Example: <c>$"SELECT Id FROM Account WHERE Name LIKE '{SoqlHelpers.EscapeLike(prefix)}%'"</c></para>
        /// </summary>
        /// <param name="value">Value to escape</param>
        /// <returns>Escaped value, without surrounding quotes or wildcards</returns>
        public static string EscapeLike(string value)
        {
            return EscapeString(value)
                .Replace("_", "\\_")
                .Replace("%", "\\%");
        }

        /// <summary>
        /// Escape a search term for use inside a SOSL FIND clause, so that reserved characters are matched literally.
        /// <para>Example: <c>$"FIND {{{SoqlHelpers.EscapeSosl(term)}}} IN NAME FIELDS RETURNING Account (Id, Name)"</c></para>
        /// </summary>
        /// <param name="value">Search term to escape</param>
        /// <returns>Escaped search term, without surrounding braces</returns>
        public static string EscapeSosl(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            StringBuilder sb = new StringBuilder(value.Length);
            foreach (char c in value)
            {
                if (SoslReservedChars.IndexOf(c) != -1)
                {
                    sb.Append('\\');
                }
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
