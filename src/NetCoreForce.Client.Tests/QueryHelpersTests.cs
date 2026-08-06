using System;
using System.Collections.Generic;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class QueryHelpersTests
    {
        [Fact]
        public void AddQueryString_NoExistingQuery()
        {
            string result = QueryHelpers.AddQueryString("http://example.com", "name", "value");

            Assert.Equal("http://example.com?name=value", result);
        }

        [Fact]
        public void AddQueryString_ExistingQuery()
        {
            string result = QueryHelpers.AddQueryString("http://example.com?foo=bar", "name", "value");

            Assert.Equal("http://example.com?foo=bar&name=value", result);
        }

        [Fact]
        public void AddQueryString_WithAnchor()
        {
            string result = QueryHelpers.AddQueryString("http://example.com#section", "name", "value");

            Assert.Equal("http://example.com?name=value#section", result);
        }

        [Fact]
        public void AddQueryString_EncodesSpecialCharacters()
        {
            string result = QueryHelpers.AddQueryString("http://example.com", "na me", "a&b");

            Assert.Equal("http://example.com?na%20me=a%26b", result);
        }

        [Fact]
        public void AddQueryString_Dictionary_AppendsMultipleParams()
        {
            var queryParams = new Dictionary<string, string> { { "a", "1" }, { "b", "2" } };

            string result = QueryHelpers.AddQueryString("http://example.com", queryParams);

            Assert.Equal("http://example.com?a=1&b=2", result);
        }

        [Fact]
        public void AddQueryString_Dictionary_EmptyLeavesUriUnchanged()
        {
            var queryParams = new Dictionary<string, string>();

            string result = QueryHelpers.AddQueryString("http://example.com", queryParams);

            Assert.Equal("http://example.com", result);
        }

        [Fact]
        public void AddQueryString_NullUri_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => QueryHelpers.AddQueryString(null, "name", "value"));
        }

        [Fact]
        public void AddQueryString_NullName_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => QueryHelpers.AddQueryString("http://example.com", null, "value"));
        }

        [Fact]
        public void AddQueryString_NullValue_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => QueryHelpers.AddQueryString("http://example.com", "name", null));
        }

        [Fact]
        public void AddQueryString_Dictionary_NullUri_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => QueryHelpers.AddQueryString(null, new Dictionary<string, string>()));
        }

        [Fact]
        public void AddQueryString_Dictionary_NullDictionary_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => QueryHelpers.AddQueryString("http://example.com", (IDictionary<string, string>)null));
        }
    }
}
