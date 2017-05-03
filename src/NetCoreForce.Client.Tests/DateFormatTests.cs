using System;
using System.Collections.Generic;
using NetCoreForce.Client;
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
    }
}
