using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.BulkApi;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Manual only - Bulk API 2.0 jobs are processed asynchronously by Salesforce, which can take several minutes.
    /// <para>.NET 8+ and .NET Framework 4.7.2+ (xUnit v3): marked Explicit. Run with:
    /// dotnet test -f net10.0 --filter "FullyQualifiedName~BulkApiTests" -- xUnit.Explicit=on</para>
    /// <para>.NET Framework 4.6.2 (xUnit v2): Explicit is not supported, so the tests are skipped. Temporarily remove the Skip to run them.</para>
    /// </summary>
    public class BulkApiTests : IClassFixture<ForceClientFixture>
    {
        private const string ManualOnlyReason = "Manual only: Bulk API jobs are processed asynchronously, which can take several minutes.";

        private static readonly TimeSpan PollInterval = TimeSpan.FromSeconds(2);
        private static readonly TimeSpan JobTimeout = TimeSpan.FromMinutes(10);

        ForceClientFixture forceClientFixture;

        public BulkApiTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        //manual only, see class summary
#if XUNIT_V3
        [Fact(Explicit = true)]
#else
        [Fact(Skip = ManualOnlyReason)]
#endif
        public async Task IngestAndQuery()
        {
            ForceClient client = await forceClientFixture.GetForceClient();
            BulkApiClient bulkClient = new BulkApiClient(client);

            string namePrefix = $"BulkApiTest {Guid.NewGuid():N}";
            const int recordCount = 3;

            StringBuilder csv = new StringBuilder("Name\n");
            for (int i = 1; i <= recordCount; i++)
            {
                csv.Append($"\"{namePrefix} {i}\"\n");
            }

            List<string> ingestJobIds = new List<string>();
            string queryJobId = null;
            List<string> recordIds = new List<string>();

            try
            {
                // ingest
                IngestJobInfo insertJob = await bulkClient.RunIngestJobAsync(
                    new CreateIngestJobRequest("Account", BulkIngestOperation.Insert), csv.ToString(),
                    PollInterval, JobTimeout, cancellationToken: TestCancellation.Token);
                ingestJobIds.Add(insertJob.Id);

                Assert.Equal(BulkJobState.JobComplete, insertJob.State);
                Assert.Equal(recordCount, insertJob.NumberRecordsProcessed);
                Assert.Equal(0, insertJob.NumberRecordsFailed);

                string successfulResults = await bulkClient.GetSuccessfulResultsAsync(insertJob.Id, cancellationToken: TestCancellation.Token);
                recordIds.AddRange(CsvRows(successfulResults).Select(row => row.Split(',')[0].Trim('"')));
                Assert.Equal(recordCount, recordIds.Count);

                string failedResults = await bulkClient.GetFailedResultsAsync(insertJob.Id, cancellationToken: TestCancellation.Token);
                Assert.Empty(CsvRows(failedResults));

                // query
                string soql = $"SELECT Id, Name FROM Account WHERE Name LIKE '{SoqlHelpers.EscapeLike(namePrefix)}%'";
                QueryJobInfo queryJob = await bulkClient.RunQueryJobAsync(soql, false, PollInterval, JobTimeout, cancellationToken: TestCancellation.Token);
                queryJobId = queryJob.Id;

                Assert.Equal(BulkJobState.JobComplete, queryJob.State);
                Assert.Equal(recordCount, queryJob.NumberRecordsProcessed);

                // a small maxRecords, to retrieve the results in more than one set
                int resultSetCount = 0;
                List<string> queriedRows = new List<string>();
                await foreach (QueryJobResults results in bulkClient.GetAllQueryJobResultsAsync(queryJob.Id, maxRecords: 2, cancellationToken: TestCancellation.Token))
                {
                    resultSetCount++;
                    queriedRows.AddRange(CsvRows(results.Csv));
                }

                Assert.True(resultSetCount > 1, "Expected results in more than one set");
                Assert.Equal(recordCount, queriedRows.Count);
                Assert.All(recordIds, id => Assert.Contains(queriedRows, row => row.Contains(id)));

                // parallel results
                int pageRowCount = 0;
                QueryJobResultPages pages = await bulkClient.GetQueryJobResultPagesAsync(queryJob.Id);
                while (true)
                {
                    foreach (QueryJobResultPage page in pages.ResultPages)
                    {
                        QueryJobResults results = await bulkClient.GetQueryJobResultsByUrlAsync(page.ResultUrl, cancellationToken: TestCancellation.Token);
                        pageRowCount += CsvRows(results.Csv).Count;
                    }

                    if (pages.Done || string.IsNullOrEmpty(pages.NextRecordsUrl))
                    {
                        break;
                    }
                    pages = await bulkClient.GetNextQueryJobResultPagesAsync(pages.NextRecordsUrl);
                }

                Assert.Equal(recordCount, pageRowCount);

                // created jobs are listed
                BulkJobList<QueryJobInfo> queryJobs = await bulkClient.GetQueryJobsAsync(jobType: "V2Query");
                Assert.NotNull(queryJobs.Records);
            }
            finally
            {
                if (recordIds.Count > 0)
                {
                    IngestJobInfo deleteJob = await bulkClient.RunIngestJobAsync(
                        new CreateIngestJobRequest("Account", BulkIngestOperation.Delete), "Id\n" + string.Join("\n", recordIds) + "\n",
                        PollInterval, JobTimeout, cancellationToken: CancellationToken.None); // clean up even if the test was cancelled
                    ingestJobIds.Add(deleteJob.Id);

                    Assert.Equal(BulkJobState.JobComplete, deleteJob.State);
                    Assert.Equal(0, deleteJob.NumberRecordsFailed);
                }

                foreach (string jobId in ingestJobIds)
                {
                    await bulkClient.DeleteIngestJobAsync(jobId);
                }

                if (queryJobId != null)
                {
                    await bulkClient.DeleteQueryJobAsync(queryJobId);
                }
            }
        }

        //manual only, see class summary
#if XUNIT_V3
        [Fact(Explicit = true)]
#else
        [Fact(Skip = ManualOnlyReason)]
#endif
        public async Task CreateJobWithDataAndAbort()
        {
            ForceClient client = await forceClientFixture.GetForceClient();
            BulkApiClient bulkClient = new BulkApiClient(client);

            // an update with an invalid ID - the job is only checked for the error, and is aborted or completes with failed records
            IngestJobInfo job = await bulkClient.CreateIngestJobWithDataAsync(
                new CreateIngestJobRequest("Account", BulkIngestOperation.Update), "Id,Name\n001000000000000AAA,Test\n",
                cancellationToken: TestCancellation.Token);

            try
            {
                Assert.Equal(BulkJobState.UploadComplete, job.State);

                try
                {
                    IngestJobInfo abortedJob = await bulkClient.AbortIngestJobAsync(job.Id);
                    Assert.Equal(BulkJobState.Aborted, abortedJob.State);
                }
                catch (ForceApiException)
                {
                    // the job may already have been processed
                }

                IngestJobInfo finalJob = await bulkClient.WaitForIngestJobAsync(job.Id, PollInterval, JobTimeout, cancellationToken: TestCancellation.Token);
                Assert.True(finalJob.IsTerminal);
            }
            finally
            {
                await bulkClient.DeleteIngestJobAsync(job.Id);
            }
        }

        /// <summary>
        /// Data rows of a CSV result, excluding the header row. Test data does not contain line breaks within values.
        /// </summary>
        private static List<string> CsvRows(string csv)
        {
            return csv.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.TrimEnd('\r'))
                .Skip(1)
                .ToList();
        }
    }
}
