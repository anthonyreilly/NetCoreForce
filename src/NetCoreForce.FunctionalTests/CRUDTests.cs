using System;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;

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
    }
}