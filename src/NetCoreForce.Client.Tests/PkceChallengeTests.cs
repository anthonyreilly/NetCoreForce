using System;
using System.Text.RegularExpressions;
using NetCoreForce.Client;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class PkceChallengeTests
    {
        [Fact]
        public void ComputeChallengeMatchesRfc7636Example()
        {
            // RFC 7636 Appendix B
            Assert.Equal("E9Melhoa2OwvFrEMTJguCHaoeK1t8URWbuGJSstw-cM", PkceChallenge.ComputeChallenge("dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk"));
        }

        [Fact]
        public void CreateReturnsValidVerifierAndChallenge()
        {
            PkceChallenge pkce = PkceChallenge.Create();

            // RFC 7636 allows 43-128 unreserved characters - base64url uses a subset of them
            Assert.Matches(new Regex("^[A-Za-z0-9_-]{128}$"), pkce.CodeVerifier);
            Assert.Matches(new Regex("^[A-Za-z0-9_-]{43}$"), pkce.CodeChallenge);
            Assert.Equal(PkceChallenge.ComputeChallenge(pkce.CodeVerifier), pkce.CodeChallenge);
            Assert.Equal("S256", pkce.CodeChallengeMethod);
        }

        [Fact]
        public void CreateReturnsNewValuesEachTime()
        {
            PkceChallenge first = PkceChallenge.Create();
            PkceChallenge second = PkceChallenge.Create();

            Assert.NotEqual(first.CodeVerifier, second.CodeVerifier);
            Assert.NotEqual(first.CodeChallenge, second.CodeChallenge);
        }

        [Theory]
        [InlineData("dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk")]
        [InlineData("abc-._~XYZ019")]
        public void ValidateValueAcceptsUnreservedCharacters(string value)
        {
            PkceChallenge.ValidateValue(value, "value");
        }

        [Theory]
        [InlineData("")]
        [InlineData("abc+def")] // standard base64
        [InlineData("abc/def")] // standard base64
        [InlineData("abcdef==")] // base64 padding
        [InlineData("abc def")]
        [InlineData("abc&code=other")]
        public void ValidateValueRejectsOtherCharacters(string value)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => PkceChallenge.ValidateValue(value, "value"));
            Assert.Equal("value", ex.ParamName);
        }
    }
}
