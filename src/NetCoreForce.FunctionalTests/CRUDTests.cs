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
            SfAccount udpatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, newAccountId);
            Assert.True(udpatedAccount != null, "Failed to retrieve udpated object");
            Assert.Equal(description, udpatedAccount.Description);

            //delete
            await client.DeleteRecord(SfAccount.SObjectTypeName, newAccountId);

            //use queryall to find deleted record
        }

        [Fact]
        public async Task CreateAnUpdateMultiple()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            //create new object
            SfAccount firstAccount = new SfAccount() { };
            string firstAccountName = string.Format("Test Object {0}", Guid.NewGuid().ToString());
            firstAccount.Name = firstAccountName;

            CreateResponse createResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, firstAccount);
            string firstAccountId = createResp.Id;
            Assert.True(!string.IsNullOrEmpty(createResp.Id), "Failed to create new object");

            //get new object
            firstAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, firstAccountId);

            //create second new object for testing update multiple
            SfAccount secondAccount = new SfAccount();
            string secondAccountName = string.Format("Test Object {0}", Guid.NewGuid().ToString());
            secondAccount.Name = secondAccountName;

            CreateResponse secondCreateResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, secondAccount);
            string secondAccountId = secondCreateResp.Id;
            Assert.True(!string.IsNullOrEmpty(secondCreateResp.Id), "Failed to create second new object");

            //get new object
            secondAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, secondAccountId);

            //test update multiple
            string firstUpdatedDescription = string.Format("Test Description {0}", Guid.NewGuid().ToString());
            string secondUpdatedDescription = string.Format("Test Description {0}", Guid.NewGuid().ToString());
            firstAccount.Description = firstUpdatedDescription;
            secondAccount.Description = secondUpdatedDescription;

            try
            {
                List<UpdateMultipleResponse> responses = await client.UpdateRecords(new List<SObject>() { firstAccount, secondAccount }, true);
                Assert.True(responses.All(r => r.Success), "Failed to update multiple objects");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //get newly updated objects
            string secondNewAccountId = secondCreateResp.Id;
            SfAccount firstUpdatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, firstAccountId);
            SfAccount secondUpdatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, secondAccountId);
            Assert.True(firstUpdatedAccount != null && secondUpdatedAccount != null, "Failed to retrieve multiple updated objects");
            Assert.Equal(firstUpdatedDescription, firstUpdatedAccount.Description);
            Assert.Equal(secondUpdatedDescription, secondUpdatedAccount.Description);

            //delete
            await client.DeleteRecord(SfAccount.SObjectTypeName, firstAccountId);
            await client.DeleteRecord(SfAccount.SObjectTypeName, secondNewAccountId);

            //use queryall to find deleted record
        }
    }
}