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
            TimeZoneInfo actualLocalTimeZoneInfo = TimeZoneInfo.Local;
            TimeZoneInfo mockTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            // compare against the expected zone rather than asserting it differs from the local zone,
            // so the test does not depend on the runner's time zone - e.g. a UTC runner and the London
            // sample zone have different names but the same base UTC offset
            using (new LocalTimeZoneInfoMocker(mockTimeZoneInfo))
            {
                TimeZoneInfo mockedLocalTimeZoneInfo = TimeZoneInfo.Local;

                Assert.Equal(mockTimeZoneInfo.Id, mockedLocalTimeZoneInfo.Id);
                Assert.Equal(mockTimeZoneInfo.StandardName, mockedLocalTimeZoneInfo.StandardName);
                Assert.Equal(mockTimeZoneInfo.BaseUtcOffset, mockedLocalTimeZoneInfo.BaseUtcOffset);
            }

            // disposing the mocker should restore the local machine's time zone
            TimeZoneInfo restoredLocalTimeZoneInfo = TimeZoneInfo.Local;

            Assert.Equal(actualLocalTimeZoneInfo.Id, restoredLocalTimeZoneInfo.Id);
            Assert.Equal(actualLocalTimeZoneInfo.BaseUtcOffset, restoredLocalTimeZoneInfo.BaseUtcOffset);
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
