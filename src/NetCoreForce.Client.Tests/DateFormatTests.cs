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

        readonly DateTimeOffset _dto = new DateTimeOffset(2017,5,1,12,0,0,0,new TimeSpan(-5,0,0));
        readonly string _expectedDate = "2017-05-01T12:00:00-05:00";

        [Fact]
        public void SerializedFullDate()
        {
            TestObject obj = new TestObject() { DateProp = _dto };

            string serialized = JsonSerializer.SerializeComplete(obj, false);         

            Assert.True(serialized.Contains(_expectedDate));
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

        [Fact]
        public void FullDateFormatFromDateTime()
        {
            var dt = new DateTime(2018,1,1);

            DateTimeOffset dto = new DateTimeOffset(dt);
            int offset = dto.Offset.Hours;

            string convertedDate = DateFormats.FullDateString(dt);

            string expected = "2018-01-01T00:00:00-05:00";

            Assert.Equal(expected, convertedDate);
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
        public void AccessTokenTimetampConversion()
        {
            AccessTokenResponse token = new AccessTokenResponse();
            token.IssuedAt = 1530216542;

            var expected = new DateTime(2018, 6, 28, 20, 9, 2);

            Assert.Equal(expected, token.IssuedAtDateTime);
        }
    }
}
