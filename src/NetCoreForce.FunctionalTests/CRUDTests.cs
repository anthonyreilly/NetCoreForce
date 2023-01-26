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

            //use queryall to find deleted record?
        }

        [Fact]
        public async Task CreateAndUpdateMultiple()
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

            List<UpsertResponse> responses = await client.UpdateRecords(new List<SObject>() { firstAccount, secondAccount }, true);
            Assert.True(responses.All(r => r.Success), "Failed to update multiple objects");

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
        }

        [Fact]
        public async Task CreateMultiple()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            //create new objects
            SfAccount firstAccount = new SfAccount() { };
            string firstAccountRefId = Guid.NewGuid().ToString();
            string firstAccountName = string.Format("Test Object refId {0}", firstAccountRefId);
            firstAccount.Name = firstAccountName;
            // firstAccount.Attributes = new SObjectAttributes() { ReferenceId = firstAccountRefId };
            // firstAccount.Attributes.ReferenceId = firstAccountRefId;

            SfAccount secondAccount = new SfAccount();
            string secondAccountRefId = Guid.NewGuid().ToString();
            string secondAccountName = string.Format("Test Object refId {0}", secondAccountRefId);
            secondAccount.Name = secondAccountName;
            // secondAccount.Attributes = new SObjectAttributes() { ReferenceId = secondAccountRefId };
            // secondAccount.Attributes.ReferenceId = secondAccountRefId;

            List<SObject> objects = new List<SObject>() { firstAccount, secondAccount };

            SObjectTreeResponse response = await client.CreateMultiple(SfAccount.SObjectTypeName, objects);

            Assert.True(response.HasErrors == "false", "Create multiple failed");
            Assert.True(response.Results.All(r => r.Errors == null), "Create multiple failed");

            // get newly created objects
            SfAccount firstCreatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, response.Results[0].Id);
            SfAccount secondCreatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, response.Results[1].Id);
            Assert.True(firstCreatedAccount != null && secondCreatedAccount != null, "Failed to retrieve multiple updated objects");
            Assert.Equal(firstAccountName, firstCreatedAccount.Name);
            Assert.Equal(secondAccountName, secondCreatedAccount.Name);

            //delete
            await client.DeleteRecord(SfAccount.SObjectTypeName, firstCreatedAccount.Id);
            await client.DeleteRecord(SfAccount.SObjectTypeName, secondCreatedAccount.Id);
        }

        [Fact]
        public async Task CreateMultipleWithReferenceIds()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            //create new objects
            SfAccount firstAccount = new SfAccount() { };
            string firstAccountRefId = Guid.NewGuid().ToString();
            string firstAccountName = string.Format("Test Object refId {0}", firstAccountRefId);
            firstAccount.Name = firstAccountName;
            firstAccount.Attributes = new SObjectAttributes() { ReferenceId = firstAccountRefId, Type = SfAccount.SObjectTypeName };


            SfAccount secondAccount = new SfAccount();
            string secondAccountRefId = Guid.NewGuid().ToString();
            string secondAccountName = string.Format("Test Object refId {0}", secondAccountRefId);
            secondAccount.Name = secondAccountName;
            secondAccount.Attributes = new SObjectAttributes() { ReferenceId = secondAccountRefId, Type = SfAccount.SObjectTypeName };

            List<SObject> objects = new List<SObject>() { firstAccount, secondAccount };

            SObjectTreeResponse response = await client.CreateMultiple(SfAccount.SObjectTypeName, objects, autoFillAttributes: false);

            Assert.True(response.HasErrors == "false", "Create multiple failed");
            Assert.True(response.Results.All(r => r.Errors == null), "Create multiple failed");

            // check for matching reference IDs in results
            Assert.Equal(firstAccountRefId, response.Results[0].ReferenceId);
            Assert.Equal(secondAccountRefId, response.Results[1].ReferenceId);

            //delete
            await client.DeleteRecord(SfAccount.SObjectTypeName, response.Results[0].Id);
            await client.DeleteRecord(SfAccount.SObjectTypeName, response.Results[1].Id);
        }

        // [Fact]
        // public async Task DeleteMultiple()
        // {
        //     ForceClient client = await forceClientFixture.GetForceClient();

        //     //create new objects
        //     SfAccount firstAccount = new SfAccount() { Name = string.Format("Test Object {0}", Guid.NewGuid().ToString()) };
        //     SfAccount secondAccount = new SfAccount() { Name = string.Format("Test Object {0}", Guid.NewGuid().ToString()) };

        //     List<SObject> objects = new List<SObject>() { firstAccount, secondAccount };

        //     SObjectTreeResponse createResponse = await client.CreateMultiple(SfAccount.SObjectTypeName, objects);

        //     Assert.True(createResponse.HasErrors == "false", "Create multiple failed");
        //     Assert.True(createResponse.Results.All(r => r.Errors == null), "Create multiple failed");

        //     // get newly created objects
            

        //     //delete
        //     // await client.DeleteRecord(SfAccount.SObjectTypeName, firstCreatedAccount.Id);
        //     // await client.DeleteRecord(SfAccount.SObjectTypeName, secondCreatedAccount.Id);
        // }
    }
}