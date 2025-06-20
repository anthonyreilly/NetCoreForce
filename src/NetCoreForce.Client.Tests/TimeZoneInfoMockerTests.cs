using System;
using System.Collections.Generic;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client.Tests
{
    public class TimeZoneInfoMockerTests
    {
        [Fact]
        public void TestLocalTimeZoneInfoMocker()
        {
            TimeSpan mockedUtcOffset;
            TimeSpan actualLocalUtcOffset = TimeZoneInfo.Local.BaseUtcOffset;

            using (new LocalTimeZoneInfoMocker(TimeZoneInfo.FindSystemTimeZoneById(TimeZoneIds.TimeZoneIdPhoenix)))
            {
                // shifted to Phoenix TZ
                Assert.Equal(TimeZoneIds.TimeZoneIdPhoenix, TimeZoneInfo.Local.Id);
                mockedUtcOffset = TimeZoneInfo.Local.BaseUtcOffset;
                Assert.NotEqual(TimeZoneInfo.Local.BaseUtcOffset, actualLocalUtcOffset);
            }

            // back to local machine's TZ
            Assert.NotEqual(TimeZoneInfo.Local.Id, TimeZoneIds.TimeZoneIdPhoenix);
            Assert.NotEqual(TimeZoneInfo.Local.BaseUtcOffset, mockedUtcOffset);
        }

    }
}
