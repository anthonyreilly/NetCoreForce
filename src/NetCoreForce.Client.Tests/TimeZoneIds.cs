using System;
using System.Collections.Generic;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// Sample TimeZone IDs for use in tests.
    /// Windows and Linux/macOS use different TimeZoneInfo ID formats (Windows-native vs IANA),
    /// so the appropriate ID for the current OS is exposed here.
    /// </summary>
    public static class TimeZoneIds
    {
        private static readonly bool IsWindows = Environment.OSVersion.Platform == PlatformID.Win32NT;

        public static string NewYork => IsWindows ? "Eastern Standard Time" : "America/New_York";
        public static string Phoenix => IsWindows ? "US Mountain Standard Time" : "America/Phoenix"; // no DST
        public static string London => IsWindows ? "GMT Standard Time" : "Europe/London";
        public static string Tokyo => IsWindows ? "Tokyo Standard Time" : "Asia/Tokyo";
        public static string Kathmandu => IsWindows ? "Nepal Standard Time" : "Asia/Kathmandu"; // UTC+5:45
        public static string Auckland => IsWindows ? "New Zealand Standard Time" : "Pacific/Auckland";
        public static string Moscow => IsWindows ? "Russian Standard Time" : "Europe/Moscow";
        public static string Shanghai => IsWindows ? "China Standard Time" : "Asia/Shanghai";

        public static IEnumerable<string> All => new[]
        {
            NewYork, Phoenix, London, Tokyo, Kathmandu, Auckland, Moscow, Shanghai
        };
    }
}
