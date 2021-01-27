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

            Assert.Single(customHeaders);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("If-Modified-Since: Mon, 23 Mar 2015 00:00:00 GMT", result);
        }

        [Fact]
        public void QueryOptionsHeader()
        {
            Dictionary<string, string> customHeaders = HeaderFormatter.SforceQueryOptions(1000);

            Assert.Single(customHeaders);

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
        public void CallOptionsHeaderWithDefaultParameters()
        {
            Dictionary<string, string> customHeaders = HeaderFormatter.SforceCallOptions();

            Assert.Single(customHeaders);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("Sforce-Call-Options: client=ForceClient", result);
        }

        [Fact]
        public void CallOptionsHeaderWithClientParameter()
        {
            Dictionary<string, string> customHeaders = HeaderFormatter.SforceCallOptions("Test");

            Assert.Single(customHeaders);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("Sforce-Call-Options: client=Test", result);
        }

        [Fact]
        public void CallOptionsHeaderWithDefaultNamespaceParameter()
        {
            Dictionary<string, string> customHeaders = HeaderFormatter.SforceCallOptions(defaultNamespace: "Test");

            Assert.Single(customHeaders);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("Sforce-Call-Options: client=ForceClient, defaultNamespace=Test", result);
        }

        [Fact]
        public void AutoAssignHeader()
        {
            Dictionary<string, string> customHeaders = HeaderFormatter.SforceAutoAssign(false);

            Assert.Single(customHeaders);

            var header = customHeaders.First();

            string result = string.Format("{0}: {1}", header.Key, header.Value);

            Assert.Equal("Sforce-Auto-Assign: FALSE", result);
        }

    }
}
