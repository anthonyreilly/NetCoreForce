using System;
using System.Collections.Generic;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class ExtensionMethodsTests
    {
        [Theory]
        [InlineData("hello", "Hello")]
        [InlineData("Hello", "Hello")]
        [InlineData("h", "H")]
        [InlineData("", "")]
        public void UppercaseFirstLetter(string value, string expected)
        {
            Assert.Equal(expected, value.UppercaseFirstLetter());
        }

        [Theory]
        [InlineData("Hello", "hello")]
        [InlineData("hello", "hello")]
        [InlineData("H", "h")]
        [InlineData("", "")]
        public void LowercaseFirstLetter(string value, string expected)
        {
            Assert.Equal(expected, value.LowercaseFirstLetter());
        }

        [Fact]
        public void AddRange_MergesDictionaries()
        {
            var dictionary = new Dictionary<string, string> { { "a", "1" } };
            var range = new Dictionary<string, string> { { "b", "2" }, { "c", "3" } };

            dictionary.AddRange(range);

            Assert.Equal(3, dictionary.Count);
            Assert.Equal("1", dictionary["a"]);
            Assert.Equal("2", dictionary["b"]);
            Assert.Equal("3", dictionary["c"]);
        }

        [Fact]
        public void AddRange_ThrowsOnDuplicateKey()
        {
            var dictionary = new Dictionary<string, string> { { "a", "1" } };
            var range = new Dictionary<string, string> { { "a", "2" } };

            Assert.Throws<ArgumentException>(() => dictionary.AddRange(range));
        }
    }
}
