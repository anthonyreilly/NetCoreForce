using System;
using System.Reflection;

namespace NetCoreForce.Client.Tests
{
    public class LocalTimeZoneInfoMocker : IDisposable
    {
        private readonly TimeZoneInfo _actualLocalTimeZoneInfo;

        public LocalTimeZoneInfoMocker(TimeZoneInfo mockTimeZoneInfo)
        {
            _actualLocalTimeZoneInfo = TimeZoneInfo.Local;
            SetLocalTimeZone(mockTimeZoneInfo);
        }

        private static void SetLocalTimeZone(TimeZoneInfo timeZoneInfo)
        {
            var info = typeof(TimeZoneInfo).GetField("s_cachedData", BindingFlags.NonPublic | BindingFlags.Static);
            object cachedData = info.GetValue(null);

            var field = cachedData.GetType().GetField("_localTimeZone", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Instance);
            field.SetValue(cachedData, timeZoneInfo);
        }

        public void Dispose()
        {
            TimeZoneInfo.ClearCachedData();
            SetLocalTimeZone(_actualLocalTimeZoneInfo);
        }
    }
}
