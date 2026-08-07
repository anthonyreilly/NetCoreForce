using System;
using System.Collections.Generic;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using System.Linq;
using System.Text;

namespace NetCoreForce.Client.Tests
{
    [Collection(LocalTimeZoneInfoMocker.CollectionName)]
    public class TimeZoneInfoMockerTests
    {
        public static TheoryData<string> TimeZoneIdData => new TheoryData<string>(TimeZoneIds.All);

        [Theory]
        [MemberData(nameof(TimeZoneIdData))]
        public void TestLocalTimeZoneInfoMocker(string timeZoneId)
        {
            TimeZoneInfo localTimeZoneInfo = TimeZoneInfo.Local;
            TimeZoneInfo mockTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            TimeSpan mockedUtcOffset;
            TimeSpan actualLocalUtcOffset = localTimeZoneInfo.BaseUtcOffset;

            if (localTimeZoneInfo.StandardName == mockTimeZoneInfo.StandardName)
            {
                // same TZ as local machine, pass test
                return;
            }

            using (new LocalTimeZoneInfoMocker(mockTimeZoneInfo))
            {
                TimeZoneInfo currentTimeZoneInfo = TimeZoneInfo.Local;

                mockedUtcOffset = currentTimeZoneInfo.BaseUtcOffset;

                Assert.Equal(mockTimeZoneInfo.StandardName, currentTimeZoneInfo.StandardName);
                Assert.NotEqual(currentTimeZoneInfo.BaseUtcOffset, actualLocalUtcOffset);
            }

            // back to local machine's TZ
            Assert.NotEqual(localTimeZoneInfo.StandardName, mockTimeZoneInfo.StandardName);
            Assert.NotEqual(localTimeZoneInfo.BaseUtcOffset, mockedUtcOffset);
        }

        [Fact]
        public void GetAllTimeZoneIds()
        {
            // Given
            var expectedTimeZoneIds = TimeZoneInfo.GetSystemTimeZones().ToList();

            List<string> zones = expectedTimeZoneIds.Select(x => $"{x.BaseUtcOffset} -- {x.DisplayName} -- {x.StandardName}").ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var zone in zones)
            {
                sb.AppendLine(zone);
            }

            // When
            var result = sb.ToString();

            // Then
        }
    }
}
