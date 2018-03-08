using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Attributes;
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

        public class AccountWithContactsSub : SfAccount 
        {
            [JsonProperty(PropertyName = "contacts")]
            [Updateable(false), Createable(false)]
            public QueryResult<SfContact> Contacts { get; set; }
        }

        [Fact]
        public async Task QueryRelationship()
        {
            //This isn't fully supported yet - this wont query all if there are NextRecordsUrl values in the subqueries
            ForceClient client = await forceClientFixture.GetForceClient();
            
            List<AccountWithContactsSub> accounts = await client.Query<AccountWithContactsSub>("SELECT Account.Name, (Select Contact.Name from Contacts) FROM Account");

            Assert.NotNull(accounts);
            Assert.True(accounts[0].Contacts.Done);
            Assert.NotNull(accounts[0].Contacts.Records[0].Name);
        }

        [Fact]
        public async Task CountQuery()
        {
            ForceClient client = await forceClientFixture.GetForceClient();
            
            int count = await client.CountQuery("SELECT COUNT() FROM Case");

            Assert.True(count > 1);
        }
    }
}