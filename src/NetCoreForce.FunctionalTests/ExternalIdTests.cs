using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
#if !XUNIT_V3
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;
using NetCoreForce.Client.Attributes;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class ExternalIdTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public ExternalIdTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        /// <summary>
        /// External ID values are URL-encoded in the upsert URL - verify Salesforce decodes and matches them,
        /// with one case per special character so any unsupported character is reported individually
        /// </summary>
        [Theory]
        [InlineData("ncf/")]
        [InlineData("ncf#")]
        [InlineData("ncf?")]
        [InlineData("ncf ")]
        [InlineData("ncf%")]
        [InlineData("ncf'")]
        public async Task ExternalIdSpecialCharacters(string externalIdPrefix)
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            string externalId = externalIdPrefix + Guid.NewGuid().ToString("N");
            List<string> createdIds = new List<string>();

            try
            {
                //insert
                SfAccount newAccount = new SfAccount() { Name = string.Format("Test Object {0}", externalId) };
                UpsertResponse insertResponse = await client.InsertOrUpdateRecord<SfAccount>(SfAccount.SObjectTypeName, "AccountExtId__c", externalId, newAccount);
                if (!string.IsNullOrEmpty(insertResponse.Id))
                {
                    createdIds.Add(insertResponse.Id);
                }
                Assert.True(insertResponse.Created, "Expected a new record to be created");
                Assert.NotNull(insertResponse.Id);

                //upsert again with the same value - should match and update the record created above
                SfAccount accountUpdate = new SfAccount() { Description = "Updated via external ID" };
                UpsertResponse updateResponse = await client.InsertOrUpdateRecord<SfAccount>(SfAccount.SObjectTypeName, "AccountExtId__c", externalId, accountUpdate);
                if (!string.IsNullOrEmpty(updateResponse.Id) && !createdIds.Contains(updateResponse.Id))
                {
                    createdIds.Add(updateResponse.Id);
                }
                Assert.False(updateResponse.Created, "Expected the existing record to be updated");
                Assert.Equal(insertResponse.Id, updateResponse.Id);

                //the stored value should match the original, unencoded value
                List<SfAccount> results = await client.Query<SfAccount>(
                    string.Format("SELECT Id FROM Account WHERE AccountExtId__c = '{0}'", SoqlHelpers.EscapeString(externalId)));
                Assert.Single(results);
                Assert.Equal(insertResponse.Id, results[0].Id);
            }
            finally
            {
                await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, createdIds, output);
            }
        }

        [Fact]
        public async Task ExternalIdInsertAndUpdate()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            //create new object
            SfAccount newAccount = new SfAccount();
            string accountName = string.Format("Test Object {0}", Guid.NewGuid().ToString());
            string externalId = Guid.NewGuid().ToString();
            newAccount.Name = accountName;

            UpsertResponse insertResponse = await client.InsertOrUpdateRecord<SfAccount>(SfAccount.SObjectTypeName, "AccountExtId__c", externalId, newAccount);
            Assert.True(insertResponse.Created);
            Assert.NotNull(insertResponse.Id);

            //get newly created
            string newAccountId = insertResponse.Id;
            SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, newAccountId);
            Assert.True(account != null, "Failed to retrieve new object");
            Assert.Equal(newAccountId, account.Id);

            //update object description            
            SfAccount accountUpdate = new SfAccount();
            string description = string.Format("Test Description {0}", Guid.NewGuid().ToString());
            accountUpdate.Description = description;
            UpsertResponse updateResponse = await client.InsertOrUpdateRecord<SfAccount>(SfAccount.SObjectTypeName, "AccountExtId__c", externalId, accountUpdate);
            Assert.Equal(newAccountId, updateResponse.Id);
            Assert.False(updateResponse.Created);

            //get newly updated
            SfAccount udpatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, newAccountId);
            Assert.True(udpatedAccount != null, "Failed to retrieve udpated object");
            Assert.Equal(description, udpatedAccount.Description);

            //delete
            await client.DeleteRecord(SfAccount.SObjectTypeName, newAccountId);
        }


    }
}