using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;

namespace NetCoreForce.FunctionalTests
{
    public class InstanceInfoTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public InstanceInfoTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }        

        [Fact]
        public async Task GetApiVersions()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;            
            ForceClient client = new ForceClient(authInfo);

            List<SalesforceVersion> versions = await client.GetAvailableRestApiVersions();

            Assert.NotNull(versions);
            Assert.NotEmpty(versions);

            var sampleVersion = versions[0];

            Assert.True(!string.IsNullOrEmpty(sampleVersion.Label)); 
            Assert.True(!string.IsNullOrEmpty(sampleVersion.Url));
            Assert.True(!string.IsNullOrEmpty(sampleVersion.Version));
        }

        [Fact]
        public async Task GetApiVersionsCustomUrl()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;            
            ForceClient client = new ForceClient(authInfo);

            List<SalesforceVersion> versions = await client.GetAvailableRestApiVersions(client.InstanceUrl);

            Assert.NotNull(versions);
            Assert.NotEmpty(versions);

            var sampleVersion = versions[0];

            Assert.True(!string.IsNullOrEmpty(sampleVersion.Label)); 
            Assert.True(!string.IsNullOrEmpty(sampleVersion.Url));
            Assert.True(!string.IsNullOrEmpty(sampleVersion.Version));
        }

        [Fact]
        public async Task GetApiVersionsBadUrl()
        {
            AuthInfo authInfo = forceClientFixture.AuthInfo;
            ForceClient client = new ForceClient(authInfo);

            await Assert.ThrowsAsync<ForceApiException>(
                async () => await client.GetAvailableRestApiVersions("https://badurl")
            );
        }
    }
}