using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetCoreForce.Client.BulkApi;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    public class BulkApiClientTests
    {
        const string InstanceUrl = "https://na15.salesforce.com";
        const string ApiVersion = "v62.0";
        const string JobsUrl = InstanceUrl + "/services/data/v62.0/jobs/";
        const string IngestJobId = "7506g00000DhRA2AAN";
        const string QueryJobId = "750R0000000zlh9IAA";
        const string IngestJobUrl = JobsUrl + "ingest/" + IngestJobId;
        const string QueryJobUrl = JobsUrl + "query/" + QueryJobId;

        private readonly MockHttpClientHandler _handler = new MockHttpClientHandler();
        private readonly ForceClient _forceClient;
        private readonly BulkApiClient _client;

        public BulkApiClientTests()
        {
            _forceClient = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(_handler));
            _client = new BulkApiClient(_forceClient);
        }

        private static HttpResponseMessage JsonFile(string filename)
        {
            return MockResponse.GetResponse(Path.Combine("bulk", filename), HttpStatusCode.OK);
        }

        private static HttpResponseMessage JsonContent(HttpStatusCode statusCode, string json)
        {
            return new HttpResponseMessage(statusCode) { Content = new StringContent(json, Encoding.UTF8, "application/json") };
        }

        private static HttpResponseMessage CsvContent(string csv, string locator = null, int? numberOfRecords = null)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(csv, Encoding.UTF8, "text/csv") };
            if (locator != null)
            {
                response.Headers.TryAddWithoutValidation("Sforce-Locator", locator);
            }
            if (numberOfRecords.HasValue)
            {
                response.Headers.TryAddWithoutValidation("Sforce-NumberOfRecords", numberOfRecords.Value.ToString());
            }
            return response;
        }

        private static string JobStateJson(string id, string state)
        {
            return $"{{\"id\":\"{id}\",\"state\":\"{state}\"}}";
        }

        [Fact]
        public void NullForceClientThrows()
        {
            Assert.Throws<ArgumentNullException>(() => new BulkApiClient(null));
        }

        #region ingest

        [Fact]
        public async Task CreateIngestJob()
        {
            _handler.AddMockResponse(HttpMethod.Post, new Uri(JobsUrl + "ingest"), () => JsonFile("ingest_job_open.json"));

            IngestJobInfo job = await _client.CreateIngestJobAsync(new CreateIngestJobRequest("Account", BulkIngestOperation.Insert));

            Assert.Equal(HttpMethod.Post, _handler.LastRequestMethod);
            Assert.Equal("application/json", _handler.LastRequestContentType.MediaType);
            // optional values that were not set are omitted, so Salesforce applies its defaults
            Assert.Equal("{\"object\":\"Account\",\"operation\":\"insert\"}", _handler.LastRequestContent);
            Assert.Equal("Bearer", _handler.LastRequestAuthorization.Scheme);
            Assert.Equal("dummyToken", _handler.LastRequestAuthorization.Parameter);

            Assert.Equal(IngestJobId, job.Id);
            Assert.Equal("insert", job.Operation);
            Assert.Equal("Account", job.Object);
            Assert.Equal(BulkJobState.Open, job.State);
            Assert.Equal(BulkContentType.CSV, job.ContentType);
            Assert.Equal(BulkLineEnding.LF, job.LineEnding);
            Assert.Equal(BulkColumnDelimiter.Comma, job.ColumnDelimiter);
            Assert.Equal(62.0m, job.ApiVersion);
            Assert.Equal("V2Ingest", job.JobType);
            Assert.Equal("Parallel", job.ConcurrencyMode);
            Assert.Equal("services/data/v62.0/jobs/ingest/7506g00000DhRA2AAN/batches", job.ContentUrl);
            Assert.False(job.IsTerminal);
        }

        [Fact]
        public async Task CreateIngestJobSerializesAllOptions()
        {
            _handler.AddMockResponse(HttpMethod.Post, new Uri(JobsUrl + "ingest"), () => JsonFile("ingest_job_open.json"));

            var request = new CreateIngestJobRequest("Account", BulkIngestOperation.Upsert)
            {
                ExternalIdFieldName = "External_Id__c",
                ContentType = BulkContentType.CSV,
                ColumnDelimiter = BulkColumnDelimiter.Pipe,
                LineEnding = BulkLineEnding.CRLF,
                AssignmentRuleId = "01QD0000000EqAn"
            };

            await _client.CreateIngestJobAsync(request);

            Assert.Equal(
                "{\"object\":\"Account\",\"operation\":\"upsert\",\"externalIdFieldName\":\"External_Id__c\",\"contentType\":\"CSV\"," +
                "\"columnDelimiter\":\"PIPE\",\"lineEnding\":\"CRLF\",\"assignmentRuleId\":\"01QD0000000EqAn\"}",
                _handler.LastRequestContent);
        }

        [Theory]
        [InlineData(BulkIngestOperation.Insert, "insert")]
        [InlineData(BulkIngestOperation.Update, "update")]
        [InlineData(BulkIngestOperation.Upsert, "upsert")]
        [InlineData(BulkIngestOperation.Delete, "delete")]
        [InlineData(BulkIngestOperation.HardDelete, "hardDelete")]
        [InlineData(BulkIngestOperation.Refresh, "refresh")]
        [InlineData(BulkIngestOperation.ConsentImport, "consentImport")]
        public void IngestOperationSerialization(BulkIngestOperation operation, string expected)
        {
            string json = JsonSerializer.SerializeForCreate(new CreateIngestJobRequest(null, operation));

            Assert.Equal($"{{\"operation\":\"{expected}\"}}", json);
        }

        [Theory]
        [InlineData(BulkColumnDelimiter.Backquote, "BACKQUOTE")]
        [InlineData(BulkColumnDelimiter.Caret, "CARET")]
        [InlineData(BulkColumnDelimiter.Comma, "COMMA")]
        [InlineData(BulkColumnDelimiter.Pipe, "PIPE")]
        [InlineData(BulkColumnDelimiter.Semicolon, "SEMICOLON")]
        [InlineData(BulkColumnDelimiter.Tab, "TAB")]
        public void ColumnDelimiterSerialization(BulkColumnDelimiter delimiter, string expected)
        {
            string json = JsonSerializer.SerializeForCreate(new CreateQueryJobRequest("SELECT Id FROM Account") { ColumnDelimiter = delimiter });

            Assert.Contains($"\"columnDelimiter\":\"{expected}\"", json);
        }

        [Fact]
        public async Task CreateIngestJobWithData()
        {
            _handler.AddMockResponse(HttpMethod.Post, new Uri(JobsUrl + "ingest"),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "UploadComplete")));

            const string csv = "FirstName,LastName\nJane,Doe\n";

            IngestJobInfo job = await _client.CreateIngestJobWithDataAsync(new CreateIngestJobRequest("Contact", BulkIngestOperation.Insert), csv);

            Assert.Equal(BulkJobState.UploadComplete, job.State);
            Assert.Equal("multipart/form-data", _handler.LastRequestContentType.MediaType);

            string content = _handler.LastRequestContent;
            Assert.Contains("form-data; name=\"job\"", content);
            Assert.Contains("{\"object\":\"Contact\",\"operation\":\"insert\"}", content);
            Assert.Contains("form-data; name=\"content\"; filename=\"content\"", content);
            Assert.Contains("text/csv", content);
            Assert.Contains(csv, content);
        }

        [Fact]
        public async Task CreateIngestJobWithDataTooLongThrows()
        {
            string csv = new string('a', BulkApiClient.MaxCreateJobDataLength + 1);

            await Assert.ThrowsAsync<ArgumentException>(() =>
                _client.CreateIngestJobWithDataAsync(new CreateIngestJobRequest("Contact", BulkIngestOperation.Insert), csv));

            Assert.Empty(_handler.Requests);
        }

        [Fact]
        public async Task UploadIngestJobDataString()
        {
            _handler.AddMockResponse(HttpMethod.Put, new Uri(IngestJobUrl + "/batches"), HttpStatusCode.Created, string.Empty);

            const string csv = "Name\nAcme\n";
            await _client.UploadIngestJobDataAsync(IngestJobId, csv);

            Assert.Equal(HttpMethod.Put, _handler.LastRequestMethod);
            Assert.Equal("text/csv", _handler.LastRequestContentType.MediaType);
            Assert.Equal(csv, _handler.LastRequestContent);
        }

        [Fact]
        public async Task UploadIngestJobDataStream()
        {
            _handler.AddMockResponse(HttpMethod.Put, new Uri(IngestJobUrl + "/batches"), HttpStatusCode.Created, string.Empty);

            const string csv = "Name\nAcme\n";
            await _client.UploadIngestJobDataAsync(IngestJobId, new MemoryStream(Encoding.UTF8.GetBytes(csv)));

            Assert.Equal(HttpMethod.Put, _handler.LastRequestMethod);
            Assert.Equal("text/csv", _handler.LastRequestContentType.MediaType);
            Assert.Equal(csv, _handler.LastRequestContent);
        }

        [Fact]
        public async Task CloseIngestJob()
        {
            _handler.AddMockResponse(new HttpMethod("PATCH"), new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "UploadComplete")));

            IngestJobInfo job = await _client.CloseIngestJobAsync(IngestJobId);

            Assert.Equal("PATCH", _handler.LastRequestMethod.Method);
            Assert.Equal("{\"state\":\"UploadComplete\"}", _handler.LastRequestContent);
            Assert.Equal(BulkJobState.UploadComplete, job.State);
        }

        [Fact]
        public async Task AbortIngestJob()
        {
            _handler.AddMockResponse(new HttpMethod("PATCH"), new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "Aborted")));

            IngestJobInfo job = await _client.AbortIngestJobAsync(IngestJobId);

            Assert.Equal("{\"state\":\"Aborted\"}", _handler.LastRequestContent);
            Assert.Equal(BulkJobState.Aborted, job.State);
            Assert.True(job.IsTerminal);
        }

        [Fact]
        public async Task GetIngestJob()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl), () => JsonFile("ingest_job_complete.json"));

            IngestJobInfo job = await _client.GetIngestJobAsync(IngestJobId);

            Assert.Equal(BulkJobState.JobComplete, job.State);
            Assert.True(job.IsTerminal);
            Assert.Equal(3, job.NumberRecordsProcessed);
            Assert.Equal(1, job.NumberRecordsFailed);
            Assert.Equal(0, job.Retries);
            Assert.Equal(334, job.TotalProcessingTime);
            Assert.Equal(201, job.ApiActiveProcessingTime);
            Assert.Equal(12, job.ApexProcessingTime);

            // dates use a +0000 offset, without a colon
            Assert.Equal(new DateTimeOffset(2018, 12, 18, 22, 51, 36, TimeSpan.Zero), job.CreatedDate);
            Assert.Equal(new DateTimeOffset(2018, 12, 18, 22, 52, 30, TimeSpan.Zero), job.SystemModstamp);
        }

        [Fact]
        public async Task ApiVersionAsString()
        {
            // documented as a string, but returned as a number - both are accepted
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.OK, "{\"id\":\"" + IngestJobId + "\",\"apiVersion\":\"58.0\"}"));

            IngestJobInfo job = await _client.GetIngestJobAsync(IngestJobId);

            Assert.Equal(58.0m, job.ApiVersion);
        }

        [Fact]
        public async Task GetIngestJobNotFoundThrows()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.NotFound, "[{\"errorCode\":\"NOT_FOUND\",\"message\":\"The requested resource does not exist\"}]"));

            ForceApiException ex = await Assert.ThrowsAsync<ForceApiException>(() => _client.GetIngestJobAsync(IngestJobId));

            Assert.Equal(HttpStatusCode.NotFound, ex.HttpStatusCode);
            Assert.Equal("NOT_FOUND", ex.Errors[0].ErrorCode);
            // JSON requests report errors the same as before the JsonClient error handling was shared with CSV requests
            Assert.Equal("Unable to complete request, Salesforce API returned NotFound. ErrorCode NOT_FOUND: The requested resource does not exist.", ex.Message);
        }

        [Fact]
        public async Task DeleteIngestJob()
        {
            _handler.AddMockResponse(HttpMethod.Delete, new Uri(IngestJobUrl), HttpStatusCode.NoContent, string.Empty);

            await _client.DeleteIngestJobAsync(IngestJobId);

            Assert.Equal(HttpMethod.Delete, _handler.LastRequestMethod);
        }

        [Fact]
        public async Task GetIngestJobs()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(JobsUrl + "ingest?isPkChunkingEnabled=false&jobType=V2Ingest"),
                () => JsonFile("ingest_job_list.json"));

            BulkJobList<IngestJobInfo> jobs = await _client.GetIngestJobsAsync(false, "V2Ingest");

            Assert.False(jobs.Done);
            Assert.Equal("/services/data/v62.0/jobs/ingest?queryLocator=01gR0000000opRTIAY-2000", jobs.NextRecordsUrl);
            Assert.Equal(2, jobs.Records.Count);
            Assert.Equal(BulkJobState.JobComplete, jobs.Records[0].State);

            // Bulk API (Classic) jobs use values that are not Bulk API 2.0 values
            IngestJobInfo classicJob = jobs.Records[1];
            Assert.Equal("Classic", classicJob.JobType);
            Assert.Null(classicJob.State);
            Assert.Null(classicJob.ContentType);
        }

        [Fact]
        public async Task GetNextIngestJobs()
        {
            const string nextRecordsUrl = "/services/data/v62.0/jobs/ingest?queryLocator=01gR0000000opRTIAY-2000";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(InstanceUrl + nextRecordsUrl),
                () => JsonContent(HttpStatusCode.OK, "{\"done\":true,\"records\":[],\"nextRecordsUrl\":null}"));

            BulkJobList<IngestJobInfo> jobs = await _client.GetNextIngestJobsAsync(nextRecordsUrl);

            Assert.True(jobs.Done);
            Assert.Empty(jobs.Records);
        }

        [Theory]
        [InlineData("https://evil.example/services/data/v62.0/jobs/ingest")]
        [InlineData("//evil.example/services/data/v62.0/jobs/ingest")]
        [InlineData("/services/apexrest/x")]
        public async Task GetNextIngestJobsOtherHostThrows(string nextRecordsUrl)
        {
            await Assert.ThrowsAsync<ForceApiException>(() => _client.GetNextIngestJobsAsync(nextRecordsUrl));

            Assert.Empty(_handler.Requests);
        }

        [Fact]
        public async Task GetSuccessfulResults()
        {
            const string csv = "\"sf__Id\",\"sf__Created\",\"Name\"\n\"001R00000033I6AIAU\",\"true\",\"Acme\"\n";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl + "/successfulResults/"), () => CsvContent(csv));

            string results = await _client.GetSuccessfulResultsAsync(IngestJobId);

            Assert.Equal(csv, results);
            Assert.Contains(_handler.LastRequestHeaders.Accept, a => a.MediaType == "text/csv");
        }

        [Fact]
        public async Task GetFailedResultsStream()
        {
            const string csv = "\"sf__Id\",\"sf__Error\",\"Name\"\n\"\",\"REQUIRED_FIELD_MISSING:Required fields are missing: [Name]:Name --\",\"\"\n";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl + "/failedResults/"), () => CsvContent(csv));

            using (Stream stream = await _client.GetFailedResultsStreamAsync(IngestJobId))
            using (StreamReader reader = new StreamReader(stream))
            {
                Assert.Equal(csv, await reader.ReadToEndAsync());
            }
        }

        [Fact]
        public async Task GetUnprocessedRecords()
        {
            const string csv = "\"Name\"\n\"Acme\"\n";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl + "/unprocessedrecords/"), () => CsvContent(csv));

            Assert.Equal(csv, await _client.GetUnprocessedRecordsAsync(IngestJobId));
        }

        [Fact]
        public async Task CsvRequestErrorThrows()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl + "/successfulResults/"),
                () => JsonContent(HttpStatusCode.BadRequest, "[{\"errorCode\":\"INVALIDJOBSTATE\",\"message\":\"Job is not complete\"}]"));

            ForceApiException ex = await Assert.ThrowsAsync<ForceApiException>(() => _client.GetSuccessfulResultsAsync(IngestJobId));

            Assert.Equal(HttpStatusCode.BadRequest, ex.HttpStatusCode);
            Assert.Equal("INVALIDJOBSTATE", ex.Errors[0].ErrorCode);
            Assert.Equal("Unable to complete request, Salesforce API returned BadRequest. ErrorCode INVALIDJOBSTATE: Job is not complete.", ex.Message);
        }

        [Fact]
        public async Task CallOptionsAndCustomHeadersAreSent()
        {
            _forceClient.ClientName = "BulkTest";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl + "/successfulResults/"), () => CsvContent("Name\n"));

            await _client.GetSuccessfulResultsAsync(IngestJobId, new Dictionary<string, string> { { "X-Custom", "value" } });

            Assert.Equal("client=BulkTest", _handler.LastRequestHeaders.GetValues("Sforce-Call-Options").Single());
            Assert.Equal("value", _handler.LastRequestHeaders.GetValues("X-Custom").Single());
        }

        [Fact]
        public async Task RunIngestJob()
        {
            _handler.AddMockResponse(HttpMethod.Post, new Uri(JobsUrl + "ingest"), () => JsonFile("ingest_job_open.json"));
            _handler.AddMockResponse(HttpMethod.Put, new Uri(IngestJobUrl + "/batches"), HttpStatusCode.Created, string.Empty);
            _handler.AddMockResponse(new HttpMethod("PATCH"), new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "UploadComplete")));
            int getCount = 0;
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl),
                () => ++getCount < 2 ? JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "InProgress")) : JsonFile("ingest_job_complete.json"));

            IngestJobInfo job = await _client.RunIngestJobAsync(new CreateIngestJobRequest("Account", BulkIngestOperation.Insert), "Name\nAcme\n",
                pollInterval: TimeSpan.FromMilliseconds(1));

            Assert.Equal(BulkJobState.JobComplete, job.State);
            Assert.Equal(1, job.NumberRecordsFailed);
            Assert.Equal(new[] { "POST", "PUT", "PATCH", "GET", "GET" }, _handler.Requests.Select(r => r.Method.Method));
            Assert.Equal("{\"state\":\"UploadComplete\"}", _handler.Requests[2].Content);
        }

        [Fact]
        public async Task RunIngestJobAbortsWhenUploadFails()
        {
            _handler.AddMockResponse(HttpMethod.Post, new Uri(JobsUrl + "ingest"), () => JsonFile("ingest_job_open.json"));
            _handler.AddMockResponse(HttpMethod.Put, new Uri(IngestJobUrl + "/batches"),
                () => JsonContent(HttpStatusCode.BadRequest, "[{\"errorCode\":\"ClientInputError\",\"message\":\"Invalid CSV\"}]"));
            _handler.AddMockResponse(new HttpMethod("PATCH"), new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "Aborted")));

            ForceApiException ex = await Assert.ThrowsAsync<ForceApiException>(() =>
                _client.RunIngestJobAsync(new CreateIngestJobRequest("Account", BulkIngestOperation.Insert), "Name\nAcme\n"));

            Assert.Equal("ClientInputError", ex.Errors[0].ErrorCode);
            Assert.Equal(new[] { "POST", "PUT", "PATCH" }, _handler.Requests.Select(r => r.Method.Method));
            Assert.Equal("{\"state\":\"Aborted\"}", _handler.LastRequestContent);
        }

        #endregion

        #region query

        [Fact]
        public async Task CreateQueryJob()
        {
            _handler.AddMockResponse(HttpMethod.Post, new Uri(JobsUrl + "query"),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(QueryJobId, "UploadComplete")));

            QueryJobInfo job = await _client.CreateQueryJobAsync("SELECT Id, Name FROM Account", queryAll: true);

            Assert.Equal("{\"operation\":\"queryAll\",\"query\":\"SELECT Id, Name FROM Account\"}", _handler.LastRequestContent);
            Assert.Equal(QueryJobId, job.Id);
            Assert.Equal(BulkJobState.UploadComplete, job.State);
        }

        [Fact]
        public async Task GetQueryJob()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl), () => JsonFile("query_job_complete.json"));

            QueryJobInfo job = await _client.GetQueryJobAsync(QueryJobId);

            Assert.Equal(BulkJobState.JobComplete, job.State);
            Assert.Equal("V2Query", job.JobType);
            Assert.Equal(500, job.NumberRecordsProcessed);
            Assert.True(job.IsPkChunkingSupported);
        }

        [Fact]
        public async Task AbortQueryJob()
        {
            _handler.AddMockResponse(new HttpMethod("PATCH"), new Uri(QueryJobUrl),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(QueryJobId, "Aborted")));

            QueryJobInfo job = await _client.AbortQueryJobAsync(QueryJobId);

            Assert.Equal("{\"state\":\"Aborted\"}", _handler.LastRequestContent);
            Assert.Equal(BulkJobState.Aborted, job.State);
        }

        [Fact]
        public async Task DeleteQueryJob()
        {
            _handler.AddMockResponse(HttpMethod.Delete, new Uri(QueryJobUrl), HttpStatusCode.NoContent, string.Empty);

            await _client.DeleteQueryJobAsync(QueryJobId);

            Assert.Equal(HttpMethod.Delete, _handler.LastRequestMethod);
        }

        [Fact]
        public async Task GetQueryJobs()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(JobsUrl + "query?jobType=V2Query&concurrencyMode=parallel"),
                () => JsonContent(HttpStatusCode.OK, "{\"done\":true,\"records\":[{\"id\":\"" + QueryJobId + "\",\"state\":\"InProgress\"}],\"nextRecordsUrl\":null}"));

            BulkJobList<QueryJobInfo> jobs = await _client.GetQueryJobsAsync(jobType: "V2Query", concurrencyMode: "parallel");

            Assert.True(jobs.Done);
            Assert.Equal(BulkJobState.InProgress, jobs.Records.Single().State);
        }

        [Fact]
        public async Task GetQueryJobResults()
        {
            const string csv = "\"Id\",\"Name\"\n\"001R00000033I6AIAU\",\"Acme\"\n\"001R00000033I6BIAU\",\"Globex\"\n";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results?locator=MTAwMDA&maxRecords=2"),
                () => CsvContent(csv, "MjAwMDA", 2));

            QueryJobResults results = await _client.GetQueryJobResultsAsync(QueryJobId, "MTAwMDA", 2);

            Assert.Equal(csv, results.Csv);
            Assert.Equal("MjAwMDA", results.Locator);
            Assert.Equal(2, results.NumberOfRecords);
            Assert.False(results.Done);
            Assert.Contains(_handler.LastRequestHeaders.Accept, a => a.MediaType == "text/csv");
        }

        [Fact]
        public async Task GetQueryJobResultsLastSet()
        {
            // Salesforce returns the string "null" when there are no more results
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results"), () => CsvContent("\"Id\"\n", "null", 0));

            QueryJobResults results = await _client.GetQueryJobResultsAsync(QueryJobId);

            Assert.Null(results.Locator);
            Assert.True(results.Done);
            Assert.Equal(0, results.NumberOfRecords);
        }

        [Fact]
        public async Task GetQueryJobResultsStream()
        {
            const string csv = "\"Id\"\n\"001R00000033I6AIAU\"\n";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results"), () => CsvContent(csv, "MTAwMDA", 1));

            using (QueryJobResultsStream results = await _client.GetQueryJobResultsStreamAsync(QueryJobId))
            using (StreamReader reader = new StreamReader(results.Content))
            {
                Assert.Equal("MTAwMDA", results.Locator);
                Assert.Equal(1, results.NumberOfRecords);
                Assert.False(results.Done);
                Assert.Equal(csv, await reader.ReadToEndAsync());
            }
        }

        [Fact]
        public async Task GetQueryJobResultsInvalidMaxRecordsThrows()
        {
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => _client.GetQueryJobResultsAsync(QueryJobId, maxRecords: 0));
        }

        [Fact]
        public async Task GetAllQueryJobResults()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results?maxRecords=1"),
                () => CsvContent("\"Id\"\n\"001R00000033I6AIAU\"\n", "MTAwMDA", 1));
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results?locator=MTAwMDA&maxRecords=1"),
                () => CsvContent("\"Id\"\n\"001R00000033I6BIAU\"\n", "null", 1));

            List<QueryJobResults> sets = new List<QueryJobResults>();
            await foreach (QueryJobResults results in _client.GetAllQueryJobResultsAsync(QueryJobId, maxRecords: 1))
            {
                sets.Add(results);
            }

            Assert.Equal(2, sets.Count);
            Assert.Contains("001R00000033I6AIAU", sets[0].Csv);
            Assert.Contains("001R00000033I6BIAU", sets[1].Csv);
            Assert.True(sets[1].Done);
        }

        [Fact]
        public async Task GetAllQueryJobResultsRepeatedLocatorThrows()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results"), () => CsvContent("\"Id\"\n", "MTAwMDA", 0));
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results?locator=MTAwMDA"), () => CsvContent("\"Id\"\n", "MTAwMDA", 0));

            await Assert.ThrowsAsync<ForceApiException>(async () =>
            {
                await foreach (QueryJobResults results in _client.GetAllQueryJobResultsAsync(QueryJobId))
                {
                }
            });
        }

        [Fact]
        public async Task GetQueryJobResultPages()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/resultPages"), () => JsonFile("query_result_pages.json"));

            QueryJobResultPages pages = await _client.GetQueryJobResultPagesAsync(QueryJobId);

            Assert.False(pages.Done);
            Assert.Equal(2, pages.ResultPages.Count);
            Assert.Equal("/services/data/v62.0/jobs/query/750R0000000zlh9IAA/results?locator=aBcDeFg1N", pages.ResultPages[0].ResultUrl);

            // the next URL is followed as returned, including its lowercase "resultpages"
            _handler.AddMockResponse(HttpMethod.Get, new Uri(InstanceUrl + pages.NextRecordsUrl),
                () => JsonContent(HttpStatusCode.OK, "{\"resultPages\":[],\"nextRecordsUrl\":null,\"done\":true}"));

            QueryJobResultPages nextPages = await _client.GetNextQueryJobResultPagesAsync(pages.NextRecordsUrl);

            Assert.True(nextPages.Done);
            Assert.Equal(InstanceUrl + "/services/data/v62.0/jobs/query/750R0000000zlh9IAA/resultpages?locator=YcApWm4N", _handler.LastRequestUri.AbsoluteUri);
        }

        [Fact]
        public async Task GetQueryJobResultsByUrl()
        {
            const string resultUrl = "/services/data/v62.0/jobs/query/750R0000000zlh9IAA/results?locator=aBcDeFg1N";
            const string csv = "\"Id\"\n\"001R00000033I6AIAU\"\n";
            _handler.AddMockResponse(HttpMethod.Get, new Uri(InstanceUrl + resultUrl), () => CsvContent(csv, null, 1));

            QueryJobResults results = await _client.GetQueryJobResultsByUrlAsync(resultUrl);

            Assert.Equal(csv, results.Csv);
            Assert.Equal(1, results.NumberOfRecords);

            using (QueryJobResultsStream stream = await _client.GetQueryJobResultsByUrlStreamAsync(resultUrl))
            using (StreamReader reader = new StreamReader(stream.Content))
            {
                Assert.Equal(csv, await reader.ReadToEndAsync());
            }
        }

        [Fact]
        public async Task GetQueryJobResultsByUrlOtherHostThrows()
        {
            await Assert.ThrowsAsync<ForceApiException>(() =>
                _client.GetQueryJobResultsByUrlAsync("https://evil.example/services/data/v62.0/jobs/query/750R0000000zlh9IAA/results"));

            Assert.Empty(_handler.Requests);
        }

        [Fact]
        public async Task WaitForQueryJob()
        {
            int getCount = 0;
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl),
                () => ++getCount < 3 ? JsonContent(HttpStatusCode.OK, JobStateJson(QueryJobId, "InProgress")) : JsonFile("query_job_complete.json"));

            QueryJobInfo job = await _client.WaitForQueryJobAsync(QueryJobId, TimeSpan.FromMilliseconds(1));

            Assert.Equal(BulkJobState.JobComplete, job.State);
            Assert.Equal(3, getCount);
        }

        [Fact]
        public async Task WaitForQueryJobFailedIsTerminal()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl),
                () => JsonContent(HttpStatusCode.OK, "{\"id\":\"" + QueryJobId + "\",\"state\":\"Failed\",\"errorMessage\":\"Query timed out\"}"));

            QueryJobInfo job = await _client.WaitForQueryJobAsync(QueryJobId, TimeSpan.FromMilliseconds(1));

            Assert.Equal(BulkJobState.Failed, job.State);
            Assert.Equal("Query timed out", job.ErrorMessage);
        }

        [Fact]
        public async Task WaitForJobTimeout()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "InProgress")));

            await Assert.ThrowsAsync<TimeoutException>(() =>
                _client.WaitForIngestJobAsync(IngestJobId, TimeSpan.FromMilliseconds(10), TimeSpan.FromMilliseconds(50)));
        }

        [Fact]
        public async Task WaitForJobCancelled()
        {
            _handler.AddMockResponse(HttpMethod.Get, new Uri(IngestJobUrl),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(IngestJobId, "InProgress")));

            using (CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(50)))
            {
                await Assert.ThrowsAnyAsync<OperationCanceledException>(() =>
                    _client.WaitForIngestJobAsync(IngestJobId, TimeSpan.FromMilliseconds(10), cancellationToken: cts.Token));
            }
        }

        [Fact]
        public async Task WaitForJobInvalidPollIntervalThrows()
        {
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => _client.WaitForIngestJobAsync(IngestJobId, TimeSpan.Zero));
        }

        [Fact]
        public async Task CancelledCsvRequestThrowsOperationCanceled()
        {
            // cancellation is not wrapped in a ForceApiException
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl + "/results"), () => CsvContent("\"Id\"\n", "null", 0));

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                cts.Cancel();
                await Assert.ThrowsAnyAsync<OperationCanceledException>(() => _client.GetQueryJobResultsAsync(QueryJobId, cancellationToken: cts.Token));
            }
        }

        [Fact]
        public async Task RunQueryJob()
        {
            _handler.AddMockResponse(HttpMethod.Post, new Uri(JobsUrl + "query"),
                () => JsonContent(HttpStatusCode.OK, JobStateJson(QueryJobId, "UploadComplete")));
            _handler.AddMockResponse(HttpMethod.Get, new Uri(QueryJobUrl), () => JsonFile("query_job_complete.json"));

            QueryJobInfo job = await _client.RunQueryJobAsync("SELECT Id FROM Account", pollInterval: TimeSpan.FromMilliseconds(1));

            Assert.Equal(BulkJobState.JobComplete, job.State);
            Assert.Equal(new[] { "POST", "GET" }, _handler.Requests.Select(r => r.Method.Method));
        }

        #endregion

        [Theory]
        [InlineData("../7506g00000DhRA2AAN")]
        [InlineData("7506g00000DhRA2AAN/batches")]
        [InlineData("7506g00000DhRA2AAN?x=1")]
        [InlineData("..")]
        public async Task JobIdPathInjectionThrows(string jobId)
        {
            await Assert.ThrowsAsync<ArgumentException>(() => _client.GetIngestJobAsync(jobId));
            await Assert.ThrowsAsync<ArgumentException>(() => _client.DeleteQueryJobAsync(jobId));
            await Assert.ThrowsAsync<ArgumentException>(() => _client.UploadIngestJobDataAsync(jobId, "Name\nAcme\n"));
            await Assert.ThrowsAsync<ArgumentException>(() => _client.GetQueryJobResultsAsync(jobId));

            Assert.Empty(_handler.Requests);
        }

        [Fact]
        public async Task EmptyJobIdThrows()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => _client.GetIngestJobAsync(string.Empty));
            await Assert.ThrowsAsync<ArgumentNullException>(() => _client.GetQueryJobAsync(null));
        }
    }
}
