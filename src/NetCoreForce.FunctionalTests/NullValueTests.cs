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
    public class NullValueTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public NullValueTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task FieldsToNullTest()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            CreateResponse createResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName,
            new SfAccount()
            {
                Name = "test account " + Guid.NewGuid().ToString(),
                Description = Guid.NewGuid().ToString(),
                BillingCity = Guid.NewGuid().ToString()
            });

            Assert.True(!string.IsNullOrEmpty(createResp.Id), "Failed to create new object");

            //get newly created
            string accountId = createResp.Id;
            SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, accountId);
            Assert.True(account != null, "Failed to retrieve new object");
            Assert.NotNull(account.Description);
            Assert.NotNull(account.BillingCity);

            //update object
            account.Description = null;
            account.BillingCity = null;
            List<string> fieldsToNull = new List<string>() { "description" };
            await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, account.Id, account, fieldsToNull: fieldsToNull);

            //get newly updated
            SfAccount udpatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, accountId);
            Assert.True(udpatedAccount != null, "Failed to retrieve udpated object");

            //delete
            await client.DeleteRecord(SfAccount.SObjectTypeName, accountId);
            
            // We're expecting only description to be set to null
            Assert.Null(udpatedAccount.Description);
            Assert.NotNull(udpatedAccount.BillingCity);
        }
    }
}