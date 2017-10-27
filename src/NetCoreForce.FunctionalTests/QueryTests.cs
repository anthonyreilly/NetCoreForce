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
    public class QueryTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public QueryTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task QuerySingle()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            SfCase singleCase = await client.QuerySingle<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case LIMIT 1");

            Assert.False(singleCase == null);
            Assert.NotNull(singleCase.CaseNumber);
        }

        [Fact]
        public async Task QuerySingleNoResults()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            SfCase singleCase = await client.QuerySingle<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case WHERE CaseNumber = '999999'");

            Assert.True(singleCase == null);
        }

        [Fact]
        public async Task Query()
        {
            ForceClient client = await forceClientFixture.GetForceClient();
            
            List<SfCase> cases = await client.Query<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case");

            SfCase firstCase = cases[0];

            Assert.False(cases == null);
            Assert.True(cases.Count > 1);
            Assert.NotNull(firstCase.CaseNumber);
        }

        [Fact]
        public async Task QueryNoResults()
        {
            ForceClient client = await forceClientFixture.GetForceClient();
            
            List<SfCase> cases = await client.Query<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case WHERE CaseNumber = '999999'");

            Assert.False(cases == null);
            Assert.True(cases.Count == 0);
        }
    }
}