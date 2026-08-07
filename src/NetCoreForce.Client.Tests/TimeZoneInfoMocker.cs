using System;
using System.Reflection;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    // LocalTimeZoneInfoMocker mutates TimeZoneInfo's process-wide static cache via reflection.
    // xunit runs different test classes in parallel by default, so any test class using this mocker
    // must be tagged with [Collection(LocalTimeZoneInfoMocker.CollectionName)] - collections run
    // sequentially internally, which prevents concurrent tests from racing on that shared state.
    [CollectionDefinition(LocalTimeZoneInfoMocker.CollectionName, DisableParallelization = true)]
    public class TimeZoneMockingCollection { }

    public class LocalTimeZoneInfoMocker : IDisposable
    {
        public const string CollectionName = "TimeZoneInfo Mocking";

        private readonly TimeZoneInfo _actualLocalTimeZoneInfo;

        public LocalTimeZoneInfoMocker(TimeZoneInfo mockTimeZoneInfo)
        {
            _actualLocalTimeZoneInfo = TimeZoneInfo.Local;
            SetLocalTimeZone(mockTimeZoneInfo);
        }

        // the private field backing TimeZoneInfo.Local is named "_localTimeZone" on modern .NET,
        // but "m_localTimeZone" on .NET Framework
        private static readonly string[] LocalTimeZoneFieldNames = { "_localTimeZone", "m_localTimeZone" };

        private static void SetLocalTimeZone(TimeZoneInfo timeZoneInfo)
        {
            var info = typeof(TimeZoneInfo).GetField("s_cachedData", BindingFlags.NonPublic | BindingFlags.Static);
            object cachedData = info.GetValue(null);

            FieldInfo field = null;
            foreach (string fieldName in LocalTimeZoneFieldNames)
            {
                field = cachedData.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                if (field != null) break;
            }

            if (field == null) throw new InvalidOperationException("Unable to find the local time zone field on TimeZoneInfo.CachedData");

            field.SetValue(cachedData, timeZoneInfo);
        }

        public void Dispose()
        {
            TimeZoneInfo.ClearCachedData();
            SetLocalTimeZone(_actualLocalTimeZoneInfo);
        }
    }
}
