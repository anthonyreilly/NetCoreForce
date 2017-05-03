using System;
using System.Collections.Generic;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class HeaderFormatterTest
    {
        [Fact]
        public void IfModifiedSinceHeader()
        {
            DateTimeOffset date = new DateTimeOffset(2015, 3, 23, 0, 0, 0, 0, new TimeSpan(0));

            KeyValuePair<string, string> header = HeaderFormatter.IfModifiedSince(date);

            string result = string.Format("{0}: {1}", header.Key, header.Value);            

            Assert.Equal("If-Modified-Since: Mon, 23 Mar 2015 00:00:00 GMT", result);
        }

        [Fact]
        public void QueryOptionsHeader()
        {
            KeyValuePair<string, string> header = HeaderFormatter.SforceQueryOptions(1000);

            string result = string.Format("{0}: {1}", header.Key, header.Value);            

            Assert.Equal("Sforce-Query-Options: batchSize=1000", result);
        }

        [Fact]
        public void AutoAssignHeader()
        {
            KeyValuePair<string, string> header = HeaderFormatter.SforceAutoAssign(false);

            string result = string.Format("{0}: {1}", header.Key, header.Value);            

            Assert.Equal("Sforce-Auto-Assign: FALSE", result);
        }

    }
}
