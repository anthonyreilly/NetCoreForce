using System;
using System.Collections.Generic;
using System.Linq;
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

            Dictionary<string, string> customHeaders = HeaderFormatter.IfModifiedSince(date);

            Assert.Equal(1, customHeaders.Count);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("If-Modified-Since: Mon, 23 Mar 2015 00:00:00 GMT", result);
        }

        [Fact]
        public void QueryOptionsHeader()
        {
            Dictionary<string, string> customHeaders = HeaderFormatter.SforceQueryOptions(1000);

            Assert.Equal(1, customHeaders.Count);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("Sforce-Query-Options: batchSize=1000", result);
        }

        [Fact]
        public void QueryOptionsHeaderMaxException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var customHeaders = HeaderFormatter.SforceQueryOptions(2001);
            });
        }

        [Fact]
        public void QueryOptionsHeaderMinException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var customHeaders = HeaderFormatter.SforceQueryOptions(0);
            });
        }

        [Fact]
        public void AutoAssignHeader()
        {
            Dictionary<string, string> customHeaders = HeaderFormatter.SforceAutoAssign(false);

            Assert.Equal(1, customHeaders.Count);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("Sforce-Auto-Assign: FALSE", result);
        }

    }
}
