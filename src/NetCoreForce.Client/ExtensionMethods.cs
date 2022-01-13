using System;
using System.Collections.Generic;

namespace NetCoreForce.Client
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Convert DateTimeOffset to a Salesforce-compatible string
        /// </summary>
        public static string ToSfDateString(this DateTimeOffset value)
        {
            return value.ToString("yyyy-MM-ddTHH:mm:sszzz");
        }

        /// <summary>
        /// Uppercase the first letter in the string.
        /// </summary>
        public static string UppercaseFirstLetter(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

        /// <summary>
        /// Lowercase the first letter in the string.
        /// </summary>
        public static string LowercaseFirstLetter(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToLower(array[0]);
                return new string(array);
            }
            return value;
        }

        /// <summary>
        /// Add all key pairs from another dictionary
        /// </summary>
        public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Dictionary<TKey, TValue> range)
        {
            foreach (TKey key in range.Keys)
            { dictionary.Add(key, range[key]); }
        }
    }
}
