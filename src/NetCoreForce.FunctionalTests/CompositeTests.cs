using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
#if !XUNIT_V3
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;
using NetCoreForce.Client.Enumerations;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json.Linq;

namespace NetCoreForce.FunctionalTests
{
    public class CompositeTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public CompositeTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        /// <summary>
        /// Create a record and update it in the same composite request, using a reference (@{refId.id}) to the created record's Id
        /// </summary>
        [Fact]
        public async Task CompositeCreateAndUpdateWithReference()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            string accountName = string.Format("Test Object ncfcomp{0}", Guid.NewGuid().ToString("N"));
            string description = string.Format("Test Description {0}", Guid.NewGuid().ToString());
            List<string> createdIds = new List<string>();

            try
            {
                List<CompositeSObject> operations = new List<CompositeSObject>()
                {
                    new CompositeSObject()
                    {
                        Type = SfAccount.SObjectTypeName,
                        Method = CompositeMethod.Write,
                        ReferenceId = "newAccount",
                        SObject = new SfAccount() { Name = accountName }
                    },
                    new CompositeSObject()
                    {
                        Type = SfAccount.SObjectTypeName,
                        Method = CompositeMethod.Write,
                        Id = "@{newAccount.id}",
                        ReferenceId = "updateAccount",
                        SObject = new SfAccount() { Description = description }
                    }
                };

                CompositeRequestResponse response = await client.ExecuteCompositeRecords(operations, allOrNone: true);

                //track the created record for cleanup before asserting anything
                string createdId = (response?.CompositeResponse?.FirstOrDefault()?.Body as JObject)?["id"]?.ToString();
                if (!string.IsNullOrEmpty(createdId))
                {
                    createdIds.Add(createdId);
                }

                Assert.NotNull(response);
                Assert.Equal(new[] { 201, 204 }, response.CompositeResponse.Select(r => r.HttpStatusCode));

                List<SfAccount> results = await client.Query<SfAccount>(
                    string.Format("SELECT Id, Description FROM Account WHERE Name = '{0}'", SoqlHelpers.EscapeString(accountName)));

                foreach (SfAccount result in results.Where(r => !createdIds.Contains(r.Id)))
                {
                    createdIds.Add(result.Id);
                }

                Assert.Single(results);
                Assert.Equal(description, results[0].Description);
            }
            finally
            {
                await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, createdIds, output);
            }
        }
    }
}
