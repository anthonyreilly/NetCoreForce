using System;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class SoqlHelpersTests
    {
        [Theory]
        [InlineData("Acme", "Acme")]
        [InlineData("O'Brien", "O\\'Brien")]
        [InlineData("say \"hi\"", "say \\\"hi\\\"")]
        [InlineData("back\\slash", "back\\\\slash")]
        [InlineData("line1\nline2\r\n", "line1\\nline2\\r\\n")]
        [InlineData("tab\tbackspace\bformfeed\f", "tab\\tbackspace\\bformfeed\\f")]
        [InlineData("100%_match", "100%_match")]
        [InlineData("", "")]
        public void EscapeString(string value, string expected)
        {
            Assert.Equal(expected, SoqlHelpers.EscapeString(value));
        }

        [Fact]
        public void EscapeStringPreventsInjection()
        {
            string input = "x' OR Name != '";

            string query = $"SELECT Id FROM Account WHERE Name = '{SoqlHelpers.EscapeString(input)}'";

            Assert.Equal("SELECT Id FROM Account WHERE Name = 'x\\' OR Name != \\''", query);
        }

        [Theory]
        [InlineData("Acme", "Acme")]
        [InlineData("100%_match", "100\\%\\_match")]
        [InlineData("O'Brien_%", "O\\'Brien\\_\\%")]
        public void EscapeLike(string value, string expected)
        {
            Assert.Equal(expected, SoqlHelpers.EscapeLike(value));
        }

        [Theory]
        [InlineData("Acme", "Acme")]
        [InlineData("Acme Corp", "Acme Corp")]
        [InlineData("x} RETURNING User (Id", "x\\} RETURNING User \\(Id")]
        [InlineData("?&|!{}[]()^~*:\\\"'+-", "\\?\\&\\|\\!\\{\\}\\[\\]\\(\\)\\^\\~\\*\\:\\\\\\\"\\'\\+\\-")]
        public void EscapeSosl(string value, string expected)
        {
            Assert.Equal(expected, SoqlHelpers.EscapeSosl(value));
        }

        [Fact]
        public void NullValueThrows()
        {
            Assert.Throws<ArgumentNullException>(() => SoqlHelpers.EscapeString(null));
            Assert.Throws<ArgumentNullException>(() => SoqlHelpers.EscapeLike(null));
            Assert.Throws<ArgumentNullException>(() => SoqlHelpers.EscapeSosl(null));
        }
    }
}
