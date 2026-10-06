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
    /// Verify that values escaped with SoqlHelpers are interpreted literally by Salesforce
    /// </summary>
    public class SoqlEscapingTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public SoqlEscapingTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        [Fact]
        public async Task EscapeStringMatchesLiteral()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            string accountName = string.Format("Test Object {0} O'Brien \"Q\" back\\slash 100%_x", CreateToken());
            List<string> createdIds = new List<string>();

            try
            {
                createdIds.Add(await CreateAccount(client, accountName));

                List<SfAccount> results = await client.Query<SfAccount>(
                    string.Format("SELECT Id, Name FROM Account WHERE Name = '{0}'", SoqlHelpers.EscapeString(accountName)));

                Assert.Single(results);
                Assert.Equal(createdIds[0], results[0].Id);
                Assert.Equal(accountName, results[0].Name);
            }
            finally
            {
                await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, createdIds, output);
            }
        }

        [Fact]
        public async Task EscapeLikeMatchesWildcardsLiterally()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            string token = CreateToken();
            List<string> createdIds = new List<string>();

            try
            {
                //unescaped, the pattern "{token} 100%_%" would match both records
                string literalMatchId = await CreateAccount(client, string.Format("Test Object {0} 100%_A", token));
                createdIds.Add(literalMatchId);
                createdIds.Add(await CreateAccount(client, string.Format("Test Object {0} 100XYA", token)));

                string prefix = SoqlHelpers.EscapeLike(string.Format("Test Object {0} 100%_", token));
                List<SfAccount> results = await client.Query<SfAccount>(
                    string.Format("SELECT Id, Name FROM Account WHERE Name LIKE '{0}%'", prefix));

                Assert.Single(results);
                Assert.Equal(literalMatchId, results[0].Id);
            }
            finally
            {
                await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, createdIds, output);
            }
        }

        [Fact]
        public async Task EscapeStringPreventsInjection()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            string token = CreateToken();
            List<string> createdIds = new List<string>();

            try
            {
                createdIds.Add(await CreateAccount(client, string.Format("Test Object {0} Injection Target", token)));

                string maliciousInput = string.Format("x' OR Name LIKE 'Test Object {0}%", token);

                //unescaped, the input changes the query logic and returns the record
                List<SfAccount> unescapedResults = await client.Query<SfAccount>(
                    string.Format("SELECT Id FROM Account WHERE Name = '{0}'", maliciousInput));
                Assert.Single(unescapedResults);

                //escaped, the input is treated as a literal name, which matches nothing
                List<SfAccount> escapedResults = await client.Query<SfAccount>(
                    string.Format("SELECT Id FROM Account WHERE Name = '{0}'", SoqlHelpers.EscapeString(maliciousInput)));
                Assert.Empty(escapedResults);
            }
            finally
            {
                await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, createdIds, output);
            }
        }

        private static string CreateToken()
        {
            return "ncfesc" + Guid.NewGuid().ToString("N");
        }

        private static async Task<string> CreateAccount(ForceClient client, string name)
        {
            CreateResponse createResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, new SfAccount() { Name = name });
            Assert.True(!string.IsNullOrEmpty(createResp.Id), "Failed to create test account");
            return createResp.Id;
        }
    }
}
