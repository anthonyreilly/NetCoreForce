using System;
using System.Collections.Generic;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    //https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_soql_select_dateformats.htm
    public class DateFormatTests
    {

        public class TestObject
        {
            public DateTimeOffset DateProp { get; set; }
        }

        readonly DateTimeOffset _dto = new DateTimeOffset(2017, 5, 1, 12, 0, 0, 0, new TimeSpan(-5, 0, 0));
        readonly string _expectedDate = "2017-05-01T12:00:00-05:00";

        [Fact]
        public void SerializedFullDate()
        {
            TestObject obj = new TestObject() { DateProp = _dto };

            string serialized = JsonSerializer.SerializeComplete(obj, false);

            Assert.Contains(_expectedDate, serialized);
        }

        [Fact]
        public void FullDateFormatExtension()
        {
            string convertedDate = _dto.ToSfDateString();

            Assert.Equal(_expectedDate, convertedDate);
        }

        [Fact]
        public void FullDateFormat()
        {
            string convertedDate = _dto.ToString(DateFormats.FullDateFormatString);

            Assert.Equal(_expectedDate, convertedDate);
        }

        [Theory]
        [InlineData(DateTimeKind.Utc)]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        public void FullDateFormat_From_DateTime_Kind(DateTimeKind kind)
        {
            DateTime dateTimeLocal = new DateTime(2018, 1, 1, 0, 0, 0, kind);

            TimeSpan localOffset = TimeZoneInfo.Local.GetUtcOffset(dateTimeLocal);

            if(kind == DateTimeKind.Utc)
            {
                // for UTC DateTime, the offset is always zero
                localOffset = TimeSpan.Zero;
            }

            string convertedDate = DateFormats.FullDateString(dateTimeLocal);

            // get timespan formatting to end up with e.g. "2018-01-01T00:00:00-05:00"
            string timeSpanFormat = GetTimeSpanFormat(localOffset);
            string expectedConvertedDate = $"2018-01-01T00:00:00{localOffset.ToString(timeSpanFormat)}";

            Assert.Equal(expectedConvertedDate, convertedDate);
        }

        private string GetTimeSpanFormat(TimeSpan ts)
        {
            // get timespan formatting to end up with e.g. "2018-01-01T00:00:00-05:00"
            return (ts < TimeSpan.Zero ? "\\-" : "\\+") + "hh\\:mm";
        }

        [Theory]
        [InlineData("America/New_York")]
        [InlineData("America/Phoenix")]
        [InlineData("Europe/London")]
        [InlineData("Asia/Tokyo")]
        [InlineData("Asia/Kathmandu")] // Nepal Time (UTC+5:45)
        [InlineData("Pacific/Auckland")]
        [InlineData("Europe/Moscow")]
        [InlineData("Asia/Shanghai")]
        public void FullDateFormat_From_Other_Timezone(string timeZoneId)
        {
            using (new LocalTimeZoneInfoMocker(TimeZoneInfo.FindSystemTimeZoneById(timeZoneId)))
            {
                DateTime dateTimeUnspecified = new DateTime(2018, 1, 1, 0, 0, 0);

                // check that the DateTimeKind is Unspecified
                Assert.Equal(DateTimeKind.Unspecified, dateTimeUnspecified.Kind);

                TimeSpan localOffset = TimeZoneInfo.Local.GetUtcOffset(dateTimeUnspecified);

                string convertedDate = DateFormats.FullDateString(dateTimeUnspecified);

                // get timespan formatting to end up with e.g. "2018-01-01T00:00:00-05:00"
                string timeSpanFormat = GetTimeSpanFormat(localOffset);
                string expectedConvertedDate = $"2018-01-01T00:00:00{localOffset.ToString(timeSpanFormat)}";

                Assert.Equal(expectedConvertedDate, convertedDate);
            }
        }

        [Fact]
        public void DateTimeAndDateTimeOffset()
        {
            DateTimeOffset dto = DateTimeOffset.Now;
            DateTime dt = DateTime.Now;
            DateTimeOffset dtoConverted = dt;

            string convertedDateTimeOffset = dto.ToString(DateFormats.FullDateFormatString);
            string convertedDateTime = dt.ToString(DateFormats.FullDateFormatString);
            string convertedDateTimeOffsetConverted = dt.ToString(DateFormats.FullDateFormatString);

            Assert.Equal(convertedDateTimeOffset, convertedDateTime);
            Assert.Equal(convertedDateTimeOffset, convertedDateTimeOffsetConverted);
        }

        [Fact]
        public void AccessTokenTimetampConversionSeconds()
        {
            AccessTokenResponse token = new AccessTokenResponse();
            token.IssuedAt = 1530216542;

            var expected = new DateTime(2018, 6, 28, 20, 9, 2, DateTimeKind.Utc);

            Assert.Equal(expected, token.IssuedAtDateTime);
        }

        [Fact]
        public void AccessTokenTimetampConversionMilliseconds()
        {
            AccessTokenResponse token = new AccessTokenResponse();
            token.IssuedAt = 1537283732843;

            var expected = new DateTime(2018, 9, 18, 15, 15, 32, 843, DateTimeKind.Utc);

            Assert.Equal(expected, token.IssuedAtDateTime);
        }
    }
}
