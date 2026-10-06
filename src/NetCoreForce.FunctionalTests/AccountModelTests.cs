using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
#if !XUNIT_V3
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Verify the SfAccount model round-trips its field types and relationships against a live org
    /// </summary>
    public class AccountModelTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public AccountModelTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        [Fact]
        public async Task AccountFieldTypesRoundTrip()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            List<string> createdIds = new List<string>();

            try
            {
                SfAccount newAccount = new SfAccount()
                {
                    Name = CreateAccountName(),
                    Type = "Customer - Direct",
                    Industry = "Retail",
                    Ownership = "Public",
                    Phone = "(212) 555-1212",
                    Website = "http://www.example.com",
                    AnnualRevenue = 2500000, //currency(18,0), so a whole number
                    NumberOfEmployees = 250,
                    BillingStreet = "123 Main St.",
                    BillingCity = "New York",
                    BillingState = "NY",
                    BillingPostalCode = "10001",
                    BillingCountry = "US",
                    BillingLatitude = 40.7128,
                    BillingLongitude = -74.006
                };

                CreateResponse createResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, newAccount);
                Assert.False(string.IsNullOrEmpty(createResp.Id), "Failed to create account");
                createdIds.Add(createResp.Id);

                //all field types should round-trip
                SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, createResp.Id);

                Assert.Equal(newAccount.Name, account.Name);
                Assert.Equal(newAccount.Type, account.Type);
                Assert.Equal(newAccount.Industry, account.Industry);
                Assert.Equal(newAccount.Ownership, account.Ownership);
                Assert.Equal(newAccount.Phone, account.Phone);
                Assert.Equal(newAccount.Website, account.Website);
                Assert.Equal(newAccount.AnnualRevenue, account.AnnualRevenue);
                Assert.Equal(newAccount.NumberOfEmployees, account.NumberOfEmployees);
                Assert.Equal(newAccount.BillingStreet, account.BillingStreet);
                Assert.Equal(newAccount.BillingCity, account.BillingCity);
                Assert.Equal(newAccount.BillingState, account.BillingState);
                Assert.Equal(newAccount.BillingPostalCode, account.BillingPostalCode);
                Assert.Equal(newAccount.BillingCountry, account.BillingCountry);
                Assert.Equal(newAccount.BillingLatitude, account.BillingLatitude);
                Assert.Equal(newAccount.BillingLongitude, account.BillingLongitude);
                Assert.False(account.IsDeleted);

                //the BillingAddress compound field is populated by Salesforce from the individual billing fields
                Assert.NotNull(account.BillingAddress);
                Assert.Equal(newAccount.BillingStreet, account.BillingAddress.Street);
                Assert.Equal(newAccount.BillingCity, account.BillingAddress.City);
                Assert.Equal(newAccount.BillingState, account.BillingAddress.State);
                Assert.Equal(newAccount.BillingPostalCode, account.BillingAddress.PostalCode);

                //system fields are populated by Salesforce
                Assert.NotNull(account.CreatedDate);
                Assert.NotNull(account.SystemModstamp);
                Assert.False(string.IsNullOrEmpty(account.OwnerId));

                //clear a numeric field with fieldsToNull
                SfAccount accountUpdate = new SfAccount() { NumberOfEmployees = null };
                await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, account.Id, accountUpdate,
                    fieldsToNull: new List<string>() { "NumberOfEmployees" });

                SfAccount updatedAccount = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, account.Id);

                Assert.Null(updatedAccount.NumberOfEmployees);
                Assert.Equal(newAccount.AnnualRevenue, updatedAccount.AnnualRevenue);
                Assert.Equal(newAccount.Name, updatedAccount.Name);
            }
            finally
            {
                await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, createdIds, output);
            }
        }

        [Fact]
        public async Task AccountRelationshipsInQuery()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            List<string> createdIds = new List<string>();

            try
            {
                string parentName = CreateAccountName();
                CreateResponse parentResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, new SfAccount() { Name = parentName });
                Assert.False(string.IsNullOrEmpty(parentResp.Id), "Failed to create parent account");
                createdIds.Add(parentResp.Id);

                //relationships are set through the lookup Id field
                CreateResponse childResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName,
                    new SfAccount() { Name = CreateAccountName(), ParentId = parentResp.Id });
                Assert.False(string.IsNullOrEmpty(childResp.Id), "Failed to create child account");

                //delete the child first, since it references the parent
                createdIds.Insert(0, childResp.Id);

                SfAccount child = await client.QuerySingle<SfAccount>(string.Format(
                    "SELECT Id, Name, ParentId, Parent.Name, Owner.Name, CreatedBy.Name FROM Account WHERE Id = '{0}'",
                    SoqlHelpers.EscapeString(childResp.Id)));

                Assert.NotNull(child);
                Assert.Equal(parentResp.Id, child.ParentId);

                //related objects included in the query are deserialized into the relationship properties
                Assert.NotNull(child.Parent);
                Assert.Equal(parentName, child.Parent.Name);
                Assert.NotNull(child.Owner);
                Assert.False(string.IsNullOrEmpty(child.Owner.Name));
                Assert.NotNull(child.CreatedBy);
                Assert.False(string.IsNullOrEmpty(child.CreatedBy.Name));
            }
            finally
            {
                await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, createdIds, output);
            }
        }

        private static string CreateAccountName()
        {
            return "Test Object ncfacct" + Guid.NewGuid().ToString("N");
        }
    }
}
