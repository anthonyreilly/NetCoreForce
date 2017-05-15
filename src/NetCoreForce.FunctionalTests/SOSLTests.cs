using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class SOSLTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public SOSLTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task BasicSearch()
        {
            //TODO: this test assumes certain records will be present, it should create its own sample records to search for

            ForceClient client = await forceClientFixture.GetForceClient();

            SearchResult<SObjectGeneric> result = await client.Search("FIND {cd*}");

            Assert.NotNull(result);
            Assert.NotNull(result.SearchRecords);
        }

        [Fact]
        public async Task TypedSearch()
        {
            //TODO: this test assumes certain records will be present, it should create its own sample records to search for

            ForceClient client = await forceClientFixture.GetForceClient();

            SearchResult<SfAccount> result = await client.Search<SfAccount>("FIND {cd*} IN ALL FIELDS RETURNING Account (Id, Name)");

            Assert.NotNull(result);
            Assert.NotNull(result.SearchRecords);

            //returned objects should be Accounts
            Assert.Equal("Account", result.SearchRecords[0].Attributes.Type);
        }
    }
}