using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class SObjectUriTests
    {
        const string ApiVersion = "v44.0";
        const string SObjectName = "Account";
        const string ObjectId = "001XXXXXXXXXXXXXXX";

        [Fact]
        public void SObjectRows()
        {
            string uriString = "/services/data/v44.0/sobjects/Account/001XXXXXXXXXXXXXXX";
            SObjectUri soi = new SObjectUri(uriString);

            Assert.Equal(uriString, soi.UriString);
            Assert.Equal(uriString, soi.ToString());
            Assert.Equal(ApiVersion, soi.ApiVersion);
            Assert.Equal(SObjectName, soi.SObjectName);
            Assert.Equal(ObjectId, soi.SObjectId);
        }
    }
}
