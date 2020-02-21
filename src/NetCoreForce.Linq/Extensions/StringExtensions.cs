using System;
using System.Linq;

namespace System
{
    public static class NetCoreForceStringExtensions
    {
        public static bool Includes(this string str, string include)
        {
            string[] strParts = str.Split(';');
            string[] includeParts = include.Split(';');
            return includeParts.All(p => strParts.Contains(p));
        }

        public static bool Excludes(this string str, string exclude)
        {
            string[] strParts = str.Split(';');
            string[] excludeParts = exclude.Split(';');
            return excludeParts.All(p => !strParts.Contains(p));
        }
    }
}
