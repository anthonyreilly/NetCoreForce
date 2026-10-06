using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
#if !(NET8_0_OR_GREATER || NET472_OR_GREATER)
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Manual only tests - due to the long execution times, these tests are not run by default.
    /// <para>Each test must wait for Salesforce to index its sample records for search, which can take several minutes.</para>
    /// <para>.NET 8+ and .NET Framework 4.7.2+ (xUnit v3): the tests are marked Explicit. Run them individually from Test Explorer, or with:
    /// dotnet test -f net10.0 --filter "FullyQualifiedName~SOSLTests" -- xUnit.Explicit=on</para>
    /// <para>.NET Framework 4.6.2 (xUnit v2): Explicit is not supported, so the tests are skipped. Temporarily remove the Skip to run them.</para>
    /// </summary>
    public class SOSLTests : IClassFixture<ForceClientFixture>
    {
        private const string ManualOnlyReason = "Manual only: waits for Salesforce search indexing, which can take several minutes per test.";

        //new records are indexed for search asynchronously, so they may not be searchable immediately after creation.
        //indexing usually takes a minute or two, but can take longer when the org is busy.
        private static readonly TimeSpan SearchIndexTimeout = TimeSpan.FromMinutes(5);
        private static readonly TimeSpan SearchRetryInterval = TimeSpan.FromSeconds(5);

        private const int SampleRecordCount = 2;

        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public SOSLTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        //manual only, see class summary
#if NET8_0_OR_GREATER || NET472_OR_GREATER
        [Fact(Explicit = true)]
#else
        [Fact(Skip = ManualOnlyReason)]
#endif
        public async Task BasicSearch()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            string searchTerm = CreateSearchTerm();
            List<string> sampleIds = new List<string>();

            try
            {
                await CreateSampleAccounts(client, searchTerm, sampleIds);

                SearchResult<SObjectGeneric> result = await SearchUntilFound(
                    () => client.Search(string.Format("FIND {{{0}}}", searchTerm)),
                    r => r.Id,
                    sampleIds);

                Assert.NotNull(result);
                Assert.NotNull(result.SearchRecords);

                //all sample records should be returned, and only the sample records
                Assert.Equal(sampleIds.OrderBy(id => id), result.SearchRecords.Select(r => r.Id).OrderBy(id => id));
                Assert.All(result.SearchRecords, r => Assert.Equal("Account", r.Attributes.Type));
            }
            finally
            {
                await DeleteSampleAccounts(client, sampleIds);
            }
        }

        //manual only, see class summary
#if NET8_0_OR_GREATER || NET472_OR_GREATER
        [Fact(Explicit = true)]
#else
        [Fact(Skip = ManualOnlyReason)]
#endif
        public async Task TypedSearch()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            string searchTerm = CreateSearchTerm();
            List<string> sampleIds = new List<string>();

            try
            {
                await CreateSampleAccounts(client, searchTerm, sampleIds);

                SearchResult<SfAccount> result = await SearchUntilFound(
                    () => client.Search<SfAccount>(string.Format("FIND {{{0}}} IN NAME FIELDS RETURNING Account (Id, Name)", searchTerm)),
                    r => r.Id,
                    sampleIds);

                Assert.NotNull(result);
                Assert.NotNull(result.SearchRecords);

                //all sample records should be returned, and only the sample records
                Assert.Equal(sampleIds.OrderBy(id => id), result.SearchRecords.Select(r => r.Id).OrderBy(id => id));

                //returned objects should be Accounts, with the requested fields populated
                Assert.All(result.SearchRecords, r =>
                {
                    Assert.Equal("Account", r.Attributes.Type);
                    Assert.Contains(searchTerm, r.Name);
                });
            }
            finally
            {
                await DeleteSampleAccounts(client, sampleIds);
            }
        }

        /// <summary>
        /// Create a unique, letters-only search term so the search only matches records created by the current test
        /// </summary>
        private static string CreateSearchTerm()
        {
            const string letters = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            char[] suffix = Enumerable.Range(0, 12).Select(_ => letters[random.Next(letters.Length)]).ToArray();
            return "ncfsosl" + new string(suffix);
        }

        /// <summary>
        /// Create sample accounts containing the search term, adding each Id to createdIds as soon as it is created
        /// so that any records created before a failure are still cleaned up
        /// </summary>
        private async Task CreateSampleAccounts(ForceClient client, string searchTerm, List<string> createdIds)
        {
            for (int i = 1; i <= SampleRecordCount; i++)
            {
                SfAccount account = new SfAccount()
                {
                    Name = string.Format("SOSL Test {0} {1}", searchTerm, i)
                };

                CreateResponse createResp = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, account);
                Assert.True(!string.IsNullOrEmpty(createResp.Id), "Failed to create sample account");
                createdIds.Add(createResp.Id);
            }
        }

        /// <summary>
        /// Delete sample accounts. Each delete is attempted even if a previous one fails, and failures are logged
        /// rather than thrown so they don't hide the original test failure.
        /// </summary>
        private async Task DeleteSampleAccounts(ForceClient client, List<string> sampleIds)
        {
            foreach (string id in sampleIds)
            {
                try
                {
                    await client.DeleteRecord(SfAccount.SObjectTypeName, id);
                }
                catch (Exception ex)
                {
                    output.WriteLine("Failed to delete sample account {0}: {1}", id, ex.Message);
                }
            }
        }

        /// <summary>
        /// Repeat the search until all expected records are returned, or the timeout is reached
        /// </summary>
        private async Task<SearchResult<T>> SearchUntilFound<T>(Func<Task<SearchResult<T>>> search, Func<T, string> getId, List<string> expectedIds)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            while (true)
            {
                SearchResult<T> result = await search();

                List<string> foundIds = result?.SearchRecords?.Select(getId).ToList() ?? new List<string>();
                if (expectedIds.All(id => foundIds.Contains(id)) || stopwatch.Elapsed >= SearchIndexTimeout)
                {
                    output.WriteLine("Search returned {0} of {1} sample records after {2:0.0}s", foundIds.Count, expectedIds.Count, stopwatch.Elapsed.TotalSeconds);
                    return result;
                }

                await Task.Delay(SearchRetryInterval);
            }
        }
    }
}
