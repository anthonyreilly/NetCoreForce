using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Xunit;
#if !XUNIT_V3
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Host application settings that previously leaked into the library: global Newtonsoft settings and the current culture.
    /// <para>These change process-wide state, so they run in a collection that isn't parallelized.</para>
    /// </summary>
    [Collection(GlobalStateCollection.Name)]
    public class HostSettingsTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public HostSettingsTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        [Fact]
        public async Task CrudWithHostGlobalJsonSettings()
        {
            // previously these settings were picked up by the library: TypeNameHandling added "$type" to request
            // payloads, which Salesforce rejects, and MissingMemberHandling.Error failed on any field not in the model
            ForceClient client = await forceClientFixture.GetForceClient();

            Func<JsonSerializerSettings> previousSettings = JsonConvert.DefaultSettings;
            string accountId = null;
            try
            {
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    MissingMemberHandling = MissingMemberHandling.Error
                };

                string accountName = "NetCoreForce Test " + Guid.NewGuid().ToString();
                CreateResponse createResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, new SfAccount() { Name = accountName });
                accountId = createResp.Id;

                SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, accountId);
                Assert.Equal(accountName, account.Name);

                account.Description = "Updated " + Guid.NewGuid().ToString();
                await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, accountId, account);

                List<SfAccount> accounts = await client.Query<SfAccount>($"SELECT Id, Name, Description FROM Account WHERE Id = '{accountId}'");
                Assert.Single(accounts);
                Assert.Equal(account.Description, accounts[0].Description);
            }
            finally
            {
                JsonConvert.DefaultSettings = previousSettings;

                if (!string.IsNullOrEmpty(accountId))
                {
                    await TestRecords.DeleteAsync(client, SfAccount.SObjectTypeName, new[] { accountId }, output);
                }
            }
        }

        [Theory]
        [InlineData("fi-FI")] // time separator is "."
        [InlineData("th-TH")] // Buddhist calendar - the year would be 543 years ahead
        public async Task DateLiteralQueryUnderCulture(string cultureName)
        {
            // SOQL date literals were previously formatted with the current culture, giving a MALFORMED_QUERY
            ForceClient client = await forceClientFixture.GetForceClient();

            CultureInfo previousCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = new CultureInfo(cultureName);

                string query = $"SELECT Id FROM Account WHERE CreatedDate < {DateTimeOffset.UtcNow.ToSfDateString()} LIMIT 1";
                output.WriteLine(query);

                List<SfAccount> accounts = await client.Query<SfAccount>(query);

                Assert.NotNull(accounts);
            }
            finally
            {
                CultureInfo.CurrentCulture = previousCulture;
            }
        }
    }
}
