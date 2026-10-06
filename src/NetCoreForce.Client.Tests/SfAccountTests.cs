using System;
using System.Collections.Generic;
using System.Linq;
using NetCoreForce.Client;
using NetCoreForce.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// Account model with a custom field added by inheritance, as described in the NetCoreForce.Models README
    /// </summary>
    public class CustomAccount : SfAccount
    {
        [JsonProperty(PropertyName = "customerPriority__c")]
        public string CustomerPriority__c { get; set; }
    }

    public class SfAccountTests
    {
        // fields that are system-assigned or derived, which must never be sent on create or update
        private static readonly string[] ReadOnlyFields = new[]
        {
            "id", "isDeleted", "masterRecordId", "photoUrl", "billingAddress", "shippingAddress",
            "createdDate", "createdById", "lastModifiedDate", "lastModifiedById", "systemModstamp",
            "lastViewedDate", "lastReferencedDate", "jigsawCompanyId"
        };

        // fields with values in the account.json fixture that can be set on both create and update
        private static readonly string[] WritableFields = new[]
        {
            "name", "type", "phone", "billingCity", "industry", "ownerId"
        };

        private static SfAccount DeserializeFixture()
        {
            return JsonSerializer.Deserialize<SfAccount>(MockResponse.GetFileContent("account.json"));
        }

        private static List<string> PropertyNames(string json)
        {
            return JObject.Parse(json).Properties().Select(p => p.Name).ToList();
        }

        [Fact]
        public void SObjectTypeName_IsAccount()
        {
            Assert.Equal("Account", SfAccount.SObjectTypeName);
        }

        [Fact]
        public void Deserialize_StandardFields()
        {
            SfAccount account = DeserializeFixture();

            Assert.Equal("001i000002C8QTIAA3", account.Id);
            Assert.Equal("Acme Corporation", account.Name);
            Assert.Equal("Customer - Direct", account.Type);
            Assert.Equal("Retail", account.Industry);
            Assert.Equal("(212) 555-1212", account.Phone);
            Assert.Equal("http://www.example.com", account.Website);
            Assert.Equal("005i0000000nZmoAAE", account.OwnerId);
            Assert.Equal("Public", account.Ownership);
            Assert.False(account.IsDeleted);
        }

        [Fact]
        public void Deserialize_NullFields()
        {
            SfAccount account = DeserializeFixture();

            Assert.Null(account.AnnualRevenue);
            Assert.Null(account.NumberOfEmployees);
            Assert.Null(account.Description);
            Assert.Null(account.ParentId);
            Assert.Null(account.LastActivityDate);
        }

        [Fact]
        public void Deserialize_Dates()
        {
            SfAccount account = DeserializeFixture();

            // DateTimeOffset equality compares the point in time, so this is independent of the local timezone
            Assert.Equal(new DateTimeOffset(2017, 4, 25, 15, 17, 55, TimeSpan.Zero), account.CreatedDate);
            Assert.Equal(new DateTimeOffset(2017, 4, 25, 15, 43, 1, TimeSpan.Zero), account.LastModifiedDate);
            Assert.Equal(new DateTimeOffset(2017, 4, 25, 15, 43, 1, TimeSpan.Zero), account.SystemModstamp);
        }

        [Fact]
        public void Deserialize_AddressCompoundFields()
        {
            SfAccount account = DeserializeFixture();

            Assert.NotNull(account.BillingAddress);
            Assert.Equal("123 Main St.", account.BillingAddress.Street);
            Assert.Equal("New York", account.BillingAddress.City);
            Assert.Equal("NY", account.BillingAddress.State);
            Assert.Equal("10001", account.BillingAddress.PostalCode);
            Assert.Equal("US", account.BillingAddress.Country);

            Assert.NotNull(account.ShippingAddress);
            Assert.Equal("123 Main St.", account.ShippingAddress.Street);
            Assert.Equal("New York", account.ShippingAddress.City);
        }

        [Fact]
        public void Deserialize_Attributes()
        {
            SfAccount account = DeserializeFixture();

            Assert.NotNull(account.Attributes);
            Assert.Equal("Account", account.Attributes.Type);
            Assert.Equal("/services/data/v57.0/sobjects/Account/001i000002C8QTIAA3", account.Attributes.Url);
        }

        [Fact]
        public void Deserialize_NumericTypes()
        {
            string json = @"{
                ""AnnualRevenue"": 2500000.50,
                ""NumberOfEmployees"": 250,
                ""BillingLatitude"": 40.7128,
                ""BillingLongitude"": -74.006
            }";

            SfAccount account = JsonSerializer.Deserialize<SfAccount>(json);

            Assert.Equal(2500000.50m, account.AnnualRevenue);
            Assert.Equal(250, account.NumberOfEmployees);
            Assert.Equal(40.7128, account.BillingLatitude);
            Assert.Equal(-74.006, account.BillingLongitude);
        }

        [Fact]
        public void Deserialize_InheritedCustomField()
        {
            // the fixture includes several custom fields - only the mapped one is read, and the rest are ignored
            CustomAccount account = JsonSerializer.Deserialize<CustomAccount>(MockResponse.GetFileContent("account.json"));

            Assert.Equal("Medium", account.CustomerPriority__c);
            Assert.Equal("Acme Corporation", account.Name);
        }

        [Fact]
        public void SerializeForCreate_ExcludesReadOnlyFields()
        {
            List<string> properties = PropertyNames(JsonSerializer.SerializeForCreate(DeserializeFixture()));

            Assert.All(ReadOnlyFields, field => Assert.DoesNotContain(field, properties));
            Assert.All(WritableFields, field => Assert.Contains(field, properties));
        }

        [Fact]
        public void SerializeForUpdate_ExcludesReadOnlyFields()
        {
            List<string> properties = PropertyNames(JsonSerializer.SerializeForUpdate(DeserializeFixture()));

            Assert.All(ReadOnlyFields, field => Assert.DoesNotContain(field, properties));
            Assert.All(WritableFields, field => Assert.Contains(field, properties));
        }

        [Fact]
        public void Serialize_ExcludesRelationshipObjects()
        {
            SfAccount account = new SfAccount()
            {
                Name = "Acme",
                ParentId = "001XXXXXXXXXXXXXXX",
                Parent = new SfAccount() { Name = "Parent Account" },
                Owner = new SfUser() { Name = "Owner User" },
                CreatedBy = new SfUser() { Name = "Created By User" }
            };

            string[] relationshipFields = new[] { "parent", "owner", "createdBy" };

            List<string> createProperties = PropertyNames(JsonSerializer.SerializeForCreate(account));
            List<string> updateProperties = PropertyNames(JsonSerializer.SerializeForUpdate(account));

            Assert.All(relationshipFields, field => Assert.DoesNotContain(field, createProperties));
            Assert.All(relationshipFields, field => Assert.DoesNotContain(field, updateProperties));

            // relationships are set through the lookup Id field
            Assert.Contains("parentId", createProperties);
            Assert.Contains("parentId", updateProperties);
        }

        [Fact]
        public void SerializeForCreate_OnlySetFields()
        {
            string json = JsonSerializer.SerializeForCreate(new SfAccount() { Name = "Acme" });

            Assert.Equal("{\"name\":\"Acme\"}", json);
        }

        [Fact]
        public void SerializeForUpdate_FieldsToNull()
        {
            SfAccount account = new SfAccount() { Name = "Acme", Description = null };

            string json = JsonSerializer.SerializeForUpdate(account, fieldsToNull: new List<string>() { "Description" });
            JObject serialized = JObject.Parse(json);

            Assert.Equal(new[] { "name", "description" }, serialized.Properties().Select(p => p.Name));
            Assert.Equal(JTokenType.Null, serialized["description"].Type);
        }

        [Fact]
        public void SerializeForUpdateWithObjectId_IncludesId()
        {
            List<string> properties = PropertyNames(JsonSerializer.SerializeForUpdateWithObjectId(DeserializeFixture()));

            Assert.Contains("id", properties);
            Assert.All(ReadOnlyFields.Where(f => f != "id"), field => Assert.DoesNotContain(field, properties));
            Assert.All(WritableFields, field => Assert.Contains(field, properties));
        }

        [Fact]
        public void Serialize_NumericValues()
        {
            SfAccount account = new SfAccount() { AnnualRevenue = 2500000.50m, NumberOfEmployees = 250 };

            JObject serialized = JObject.Parse(JsonSerializer.SerializeForCreate(account));

            Assert.Equal(JTokenType.Float, serialized["annualRevenue"].Type);
            Assert.Equal(2500000.50m, serialized["annualRevenue"].Value<decimal>());
            Assert.Equal(JTokenType.Integer, serialized["numberOfEmployees"].Type);
            Assert.Equal(250, serialized["numberOfEmployees"].Value<int>());
        }
    }
}
