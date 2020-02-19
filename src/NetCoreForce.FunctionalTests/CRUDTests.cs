using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class CRUDTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public CRUDTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task CrudChain()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            //create new object
            SfAccount newAccount = new SfAccount();
            string accountName = string.Format("Test Object {0}", Guid.NewGuid().ToString());
            newAccount.Name = accountName;

            CreateResponse createResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, newAccount);

            Assert.True(!string.IsNullOrEmpty(createResp.Id), "Failed to create new object");

            //get newly created
            string newAccountId = createResp.Id;
            SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, newAccountId);
            Assert.True(account != null, "Failed to retrieve new object");

            //update object
            string description = string.Format("Test Description {0}", Guid.NewGuid().ToString());
            account.Description = description;
            await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, account.Id, account);

            //get newly updated
            SfAccount updatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, newAccountId);
            Assert.True(updatedAccount != null, "Failed to retrieve updated object");
            Assert.Equal(description, updatedAccount.Description);

            //create second new object for testing update multiple
            SfAccount secondNewAccount = new SfAccount();
            string secondAccountName = string.Format("Test Object {0}", Guid.NewGuid().ToString());
            secondNewAccount.Name = secondAccountName;

            CreateResponse secondCreateResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, secondNewAccount);

            Assert.True(!string.IsNullOrEmpty(secondCreateResp.Id), "Failed to create second new object");

            //test update multiple
            string multipleDescription1 = string.Format("Test Description {0}", Guid.NewGuid().ToString());
            string multipleDescription2 = string.Format("Test Description {0}", Guid.NewGuid().ToString());
            newAccount.Description = multipleDescription1;
            secondNewAccount.Description = multipleDescription2;
            List<UpdateMultipleResponse> responses = await client.UpdateRecords(new List<object>() { newAccount, secondNewAccount }, true);
            Assert.True(responses.All(r => r.Success), "Failed to update multiple objects");

            //get newly updated objects
            string secondNewAccountId = secondCreateResp.Id;
            updatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, newAccountId);
            SfAccount secondUpdatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, secondNewAccountId);
            Assert.True(updatedAccount != null && secondUpdatedAccount != null, "Failed to retrieve multiple updated objects");
            Assert.Equal(updatedAccount.Description, multipleDescription1);
            Assert.Equal(secondUpdatedAccount.Description, multipleDescription2);

            //delete
            await client.DeleteRecord(SfAccount.SObjectTypeName, newAccountId);
            await client.DeleteRecord(SfAccount.SObjectTypeName, secondNewAccountId);

            //use queryall to find deleted record
        }
    }
}