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
    public class ExternalIdTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public ExternalIdTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
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