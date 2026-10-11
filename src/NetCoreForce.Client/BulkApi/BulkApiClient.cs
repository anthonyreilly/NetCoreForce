using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Client for the Salesforce Bulk API 2.0, for asynchronously loading or querying large data sets as CSV.
    /// <para>Uses the instance URL, API version, access token, and HttpClient of the given <see cref="ForceClient"/>.</para>
    /// </summary>
    /// <remarks>
    /// Ingest: create a job, upload CSV data, close the job, wait for it to complete, then get the successful and failed record results.
    /// <see cref="RunIngestJobAsync(CreateIngestJobRequest, string, TimeSpan?, TimeSpan?, Dictionary{string, string}, CancellationToken)"/> does all of these steps except getting the results.
    /// <para>Query: create a job, wait for it to complete, then get the CSV results.
    /// <see cref="RunQueryJobAsync(string, bool, TimeSpan?, TimeSpan?, Dictionary{string, string}, CancellationToken)"/> creates the job and waits for it to complete.</para>
    /// </remarks>
    public class BulkApiClient
    {
        /// <summary>
        /// Maximum length of CSV data that can be included when creating a job, using <see cref="CreateIngestJobWithDataAsync"/>
        /// </summary>
        public const int MaxCreateJobDataLength = 100000;

        private const string JsonMimeType = "application/json";
        private const string CsvMimeType = "text/csv";
        private const string SforceLocatorHeaderName = "Sforce-Locator";
        private const string SforceNumberOfRecordsHeaderName = "Sforce-NumberOfRecords";

        private static readonly TimeSpan DefaultPollInterval = TimeSpan.FromSeconds(5);

        private readonly ForceClient _forceClient;

        /// <summary>
        /// Initialize the Bulk API 2.0 client
        /// </summary>
        /// <param name="forceClient">An initialized ForceClient. Its instance URL, API version, access token, and HttpClient are used for all requests.</param>
        public BulkApiClient(ForceClient forceClient)
        {
            _forceClient = forceClient ?? throw new ArgumentNullException(nameof(forceClient));
        }

        private string InstanceUrl
        {
            get { return _forceClient.InstanceUrl; }
        }

        private string ApiVersion
        {
            get { return _forceClient.ApiVersion; }
        }

        #region ingest

        /// <summary>
        /// Create an ingest job. Upload the job data with <see cref="UploadIngestJobDataAsync(string, string, Dictionary{string, string}, CancellationToken)"/>,
        /// then close the job with <see cref="CloseIngestJobAsync"/> to start processing.
        /// </summary>
        /// <param name="request">Job details</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info, the job state will be Open</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<IngestJobInfo> CreateIngestJobAsync(CreateIngestJobRequest request, Dictionary<string, string> customHeaders = null)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            Uri uri = BulkApiUriFormatter.IngestJobs(InstanceUrl, ApiVersion);

            return await CreateJsonClient().HttpPostAsync<IngestJobInfo>(request, uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Create an ingest job and upload its data in a single multipart request, for small amounts of data.
        /// <para>The upload is completed automatically, so the job does not need to be closed.</para>
        /// </summary>
        /// <param name="request">Job details</param>
        /// <param name="csvData">CSV job data, including a header row. Up to <see cref="MaxCreateJobDataLength"/> characters.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Job info, the job state will be UploadComplete</returns>
        /// <exception cref="ArgumentException">Thrown when the data is longer than <see cref="MaxCreateJobDataLength"/> characters</exception>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<IngestJobInfo> CreateIngestJobWithDataAsync(
            CreateIngestJobRequest request,
            string csvData,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrEmpty(csvData)) throw new ArgumentNullException(nameof(csvData));
            if (csvData.Length > MaxCreateJobDataLength)
            {
                throw new ArgumentException($"CSV data included when creating a job is limited to {MaxCreateJobDataLength} characters, upload larger data sets separately", nameof(csvData));
            }

            Uri uri = BulkApiUriFormatter.IngestJobs(InstanceUrl, ApiVersion);

            StringContent jobContent = new StringContent(JsonSerializer.SerializeForCreate(request), Encoding.UTF8, JsonMimeType);
            jobContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { Name = "\"job\"" };

            StringContent dataContent = new StringContent(csvData, Encoding.UTF8, CsvMimeType);
            dataContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { Name = "\"content\"", FileName = "\"content\"" };

            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(jobContent);
            content.Add(dataContent);

            using (HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, uri) { Content = content })
            using (HttpResponseMessage response = await CreateJsonClient().HttpSendAsync(httpRequest, BuildHeaders(customHeaders), HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false))
            {
                return await ReadJsonAsync<IngestJobInfo>(response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Upload CSV data for an Open ingest job. Data can be uploaded once per job.
        /// <para>Data is limited to 150 MB once base64 encoded by Salesforce, so upload no more than 100 MB of raw data.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="csvData">CSV job data, including a header row</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task UploadIngestJobDataAsync(
            string jobId,
            string csvData,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(csvData)) throw new ArgumentNullException(nameof(csvData));

            Uri uri = BulkApiUriFormatter.IngestJobData(InstanceUrl, ApiVersion, jobId);

            await UploadIngestJobDataAsync(uri, new StringContent(csvData, Encoding.UTF8, CsvMimeType), customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Upload CSV data for an Open ingest job. Data can be uploaded once per job.
        /// <para>Data is limited to 150 MB once base64 encoded by Salesforce, so upload no more than 100 MB of raw data.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="csvData">UTF-8 CSV job data, including a header row, read from the current position. The stream is disposed once the upload completes.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task UploadIngestJobDataAsync(
            string jobId,
            Stream csvData,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            if (csvData == null) throw new ArgumentNullException(nameof(csvData));

            Uri uri = BulkApiUriFormatter.IngestJobData(InstanceUrl, ApiVersion, jobId);

            StreamContent content = new StreamContent(csvData);
            content.Headers.ContentType = new MediaTypeHeaderValue(CsvMimeType);

            await UploadIngestJobDataAsync(uri, content, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        private async Task UploadIngestJobDataAsync(Uri uri, HttpContent content, Dictionary<string, string> customHeaders, CancellationToken cancellationToken)
        {
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, uri) { Content = content })
            using (await CreateJsonClient().HttpSendAsync(request, BuildHeaders(customHeaders), HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false))
            {
                // successful upload returns 201 Created, with no content
            }
        }

        /// <summary>
        /// Close an ingest job, setting its state to UploadComplete, once all job data has been uploaded.
        /// <para>Salesforce starts processing the job once it is closed. Jobs that are not closed are not processed.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<IngestJobInfo> CloseIngestJobAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            return await SetIngestJobStateAsync(jobId, BulkJobState.UploadComplete, customHeaders).ConfigureAwait(false);
        }

        /// <summary>
        /// Abort an ingest job. Records that were already processed are not rolled back.
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<IngestJobInfo> AbortIngestJobAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            return await SetIngestJobStateAsync(jobId, BulkJobState.Aborted, customHeaders).ConfigureAwait(false);
        }

        private async Task<IngestJobInfo> SetIngestJobStateAsync(string jobId, BulkJobState state, Dictionary<string, string> customHeaders)
        {
            Uri uri = BulkApiUriFormatter.IngestJob(InstanceUrl, ApiVersion, jobId);

            return await CreateJsonClient().HttpPatchAsync<IngestJobInfo>(new BulkJobStateRequest(state), uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about an ingest job, including its state and the number of records processed and failed
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<IngestJobInfo> GetIngestJobAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.IngestJob(InstanceUrl, ApiVersion, jobId);

            return await CreateJsonClient().HttpGetAsync<IngestJobInfo>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete an ingest job, along with its data and results.
        /// <para>The job state must be UploadComplete, JobComplete, Aborted, or Failed.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task DeleteIngestJobAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.IngestJob(InstanceUrl, ApiVersion, jobId);

            await CreateJsonClient().HttpDeleteAsync<object>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about all ingest jobs in the org. Up to 1000 jobs are returned per page,
        /// use <see cref="GetNextIngestJobsAsync"/> to get the next page.
        /// </summary>
        /// <param name="isPkChunkingEnabled">Optional. If true, only returns jobs with PK chunking enabled.</param>
        /// <param name="jobType">Optional. Job type filter: BigObjectIngest, Classic, or V2Ingest</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>A page of jobs</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<BulkJobList<IngestJobInfo>> GetIngestJobsAsync(bool? isPkChunkingEnabled = null, string jobType = null, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.IngestJobs(InstanceUrl, ApiVersion, isPkChunkingEnabled, jobType);

            return await CreateJsonClient().HttpGetAsync<BulkJobList<IngestJobInfo>>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the next page of ingest jobs
        /// </summary>
        /// <param name="nextRecordsUrl"><see cref="BulkJobList{T}.NextRecordsUrl"/> from the previous page</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>A page of jobs</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<BulkJobList<IngestJobInfo>> GetNextIngestJobsAsync(string nextRecordsUrl, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = ResolveRelativeUrl(nextRecordsUrl, nameof(nextRecordsUrl));

            return await CreateJsonClient().HttpGetAsync<BulkJobList<IngestJobInfo>>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the successfully processed records for a completed ingest job.
        /// <para>The CSV includes the sf__Id and sf__Created columns, followed by the uploaded fields.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>CSV results, including a header row</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<string> GetSuccessfulResultsAsync(string jobId, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.IngestJobSuccessfulResults(InstanceUrl, ApiVersion, jobId);

            return await GetCsvStringAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the successfully processed records for a completed ingest job, as a stream.
        /// <para>The CSV includes the sf__Id and sf__Created columns, followed by the uploaded fields.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>CSV results stream, including a header row. Dispose once read, to release the connection.</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<Stream> GetSuccessfulResultsStreamAsync(string jobId, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.IngestJobSuccessfulResults(InstanceUrl, ApiVersion, jobId);

            return await GetCsvStreamAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the records that failed processing for a completed ingest job.
        /// <para>The CSV includes the sf__Error and sf__Id columns, followed by the uploaded fields.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>CSV results, including a header row</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<string> GetFailedResultsAsync(string jobId, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.IngestJobFailedResults(InstanceUrl, ApiVersion, jobId);

            return await GetCsvStringAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the records that failed processing for a completed ingest job, as a stream.
        /// <para>The CSV includes the sf__Error and sf__Id columns, followed by the uploaded fields.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>CSV results stream, including a header row. Dispose once read, to release the connection.</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<Stream> GetFailedResultsStreamAsync(string jobId, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.IngestJobFailedResults(InstanceUrl, ApiVersion, jobId);

            return await GetCsvStreamAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the records that were not processed, for a failed or aborted ingest job.
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>CSV records as uploaded, including a header row</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<string> GetUnprocessedRecordsAsync(string jobId, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.IngestJobUnprocessedRecords(InstanceUrl, ApiVersion, jobId);

            return await GetCsvStringAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the records that were not processed, for a failed or aborted ingest job, as a stream.
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>CSV records stream, including a header row. Dispose once read, to release the connection.</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<Stream> GetUnprocessedRecordsStreamAsync(string jobId, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.IngestJobUnprocessedRecords(InstanceUrl, ApiVersion, jobId);

            return await GetCsvStreamAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Wait for an ingest job to reach a terminal state: JobComplete, Failed, or Aborted
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="pollInterval">Time between job info requests. Defaults to 5 seconds.</param>
        /// <param name="timeout">Optional. Maximum time to wait. The job is not aborted if the timeout is reached.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Final job info</returns>
        /// <exception cref="TimeoutException">Thrown when the job does not reach a terminal state within the timeout</exception>
        /// <exception cref="ForceApiException">Thrown when a request fails</exception>
        public async Task<IngestJobInfo> WaitForIngestJobAsync(
            string jobId,
            TimeSpan? pollInterval = null,
            TimeSpan? timeout = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            return await WaitForJobAsync(() => GetIngestJobAsync(jobId, customHeaders), jobId, pollInterval, timeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Run an ingest job: create the job, upload the data, close the job, and wait for it to reach a terminal state.
        /// <para>If uploading or closing fails, the job is aborted. Check <see cref="BulkJobInfo.State"/> and <see cref="IngestJobInfo.NumberRecordsFailed"/>
        /// on the result, and use <see cref="GetFailedResultsAsync"/> to get the failed records.</para>
        /// </summary>
        /// <param name="request">Job details</param>
        /// <param name="csvData">CSV job data, including a header row</param>
        /// <param name="pollInterval">Time between job info requests. Defaults to 5 seconds.</param>
        /// <param name="timeout">Optional. Maximum time to wait for the job to be processed. The job is not aborted if the timeout is reached.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Final job info</returns>
        /// <exception cref="TimeoutException">Thrown when the job does not reach a terminal state within the timeout</exception>
        /// <exception cref="ForceApiException">Thrown when a request fails</exception>
        public async Task<IngestJobInfo> RunIngestJobAsync(
            CreateIngestJobRequest request,
            string csvData,
            TimeSpan? pollInterval = null,
            TimeSpan? timeout = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(csvData)) throw new ArgumentNullException(nameof(csvData));

            return await RunIngestJobAsync(request, jobId => UploadIngestJobDataAsync(jobId, csvData, customHeaders, cancellationToken),
                pollInterval, timeout, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Run an ingest job: create the job, upload the data, close the job, and wait for it to reach a terminal state.
        /// <para>If uploading or closing fails, the job is aborted. Check <see cref="BulkJobInfo.State"/> and <see cref="IngestJobInfo.NumberRecordsFailed"/>
        /// on the result, and use <see cref="GetFailedResultsAsync"/> to get the failed records.</para>
        /// </summary>
        /// <param name="request">Job details</param>
        /// <param name="csvData">UTF-8 CSV job data, including a header row. The stream is disposed once the upload completes.</param>
        /// <param name="pollInterval">Time between job info requests. Defaults to 5 seconds.</param>
        /// <param name="timeout">Optional. Maximum time to wait for the job to be processed. The job is not aborted if the timeout is reached.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Final job info</returns>
        /// <exception cref="TimeoutException">Thrown when the job does not reach a terminal state within the timeout</exception>
        /// <exception cref="ForceApiException">Thrown when a request fails</exception>
        public async Task<IngestJobInfo> RunIngestJobAsync(
            CreateIngestJobRequest request,
            Stream csvData,
            TimeSpan? pollInterval = null,
            TimeSpan? timeout = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            if (csvData == null) throw new ArgumentNullException(nameof(csvData));

            return await RunIngestJobAsync(request, jobId => UploadIngestJobDataAsync(jobId, csvData, customHeaders, cancellationToken),
                pollInterval, timeout, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        private async Task<IngestJobInfo> RunIngestJobAsync(
            CreateIngestJobRequest request,
            Func<string, Task> uploadData,
            TimeSpan? pollInterval,
            TimeSpan? timeout,
            Dictionary<string, string> customHeaders,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IngestJobInfo job = await CreateIngestJobAsync(request, customHeaders).ConfigureAwait(false);
            if (job == null || string.IsNullOrEmpty(job.Id))
            {
                throw new ForceApiException("Create job response did not include a job ID");
            }

            try
            {
                await uploadData(job.Id).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                await CloseIngestJobAsync(job.Id, customHeaders).ConfigureAwait(false);
            }
            catch
            {
                // an Open job is not processed and is eventually removed by Salesforce, but abort it so that it is not left open
                try
                {
                    await AbortIngestJobAsync(job.Id, customHeaders).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // keep the original exception
                    Debug.WriteLine($"Unable to abort job {job.Id}: {ex.Message}");
                }
                throw;
            }

            return await WaitForIngestJobAsync(job.Id, pollInterval, timeout, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #region query

        /// <summary>
        /// Create a query job. Salesforce starts processing the job once it is created.
        /// </summary>
        /// <param name="request">Job details</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobInfo> CreateQueryJobAsync(CreateQueryJobRequest request, Dictionary<string, string> customHeaders = null)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            Uri uri = BulkApiUriFormatter.QueryJobs(InstanceUrl, ApiVersion);

            return await CreateJsonClient().HttpPostAsync<QueryJobInfo>(request, uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a query job, with CSV results using the default COMMA column delimiter and LF line ending.
        /// <para>Bulk API 2.0 does not support GROUP BY, OFFSET, or TYPEOF clauses, aggregate functions such as COUNT(), FIELDS(),
        /// parent-to-child relationship subqueries, or compound address and geolocation fields.</para>
        /// </summary>
        /// <param name="query">SOQL query</param>
        /// <param name="queryAll">True to include records deleted by a merge or delete, and archived Task and Event records</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobInfo> CreateQueryJobAsync(string query, bool queryAll = false, Dictionary<string, string> customHeaders = null)
        {
            if (string.IsNullOrEmpty(query)) throw new ArgumentNullException(nameof(query));

            return await CreateQueryJobAsync(new CreateQueryJobRequest(query, queryAll ? BulkQueryOperation.QueryAll : BulkQueryOperation.Query), customHeaders).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about a query job, including its state and the number of records processed
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobInfo> GetQueryJobAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.QueryJob(InstanceUrl, ApiVersion, jobId);

            return await CreateJsonClient().HttpGetAsync<QueryJobInfo>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Abort a query job. The job state must be UploadComplete or InProgress.
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Job info</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobInfo> AbortQueryJobAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.QueryJob(InstanceUrl, ApiVersion, jobId);

            return await CreateJsonClient().HttpPatchAsync<QueryJobInfo>(new BulkJobStateRequest(BulkJobState.Aborted), uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a query job, along with its results.
        /// <para>The job state must be JobComplete, Aborted, or Failed.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task DeleteQueryJobAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.QueryJob(InstanceUrl, ApiVersion, jobId);

            await CreateJsonClient().HttpDeleteAsync<object>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about all query jobs in the org. Up to 1000 jobs are returned per page,
        /// use <see cref="GetNextQueryJobsAsync"/> to get the next page.
        /// </summary>
        /// <param name="isPkChunkingEnabled">Optional. If true, only returns jobs with PK chunking enabled. Only applies to Bulk API (Classic) jobs.</param>
        /// <param name="jobType">Optional. Job type filter: Classic, V2Query, or V2Ingest</param>
        /// <param name="concurrencyMode">Optional. Reserved for future use.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>A page of jobs</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<BulkJobList<QueryJobInfo>> GetQueryJobsAsync(
            bool? isPkChunkingEnabled = null,
            string jobType = null,
            string concurrencyMode = null,
            Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.QueryJobs(InstanceUrl, ApiVersion, isPkChunkingEnabled, jobType, concurrencyMode);

            return await CreateJsonClient().HttpGetAsync<BulkJobList<QueryJobInfo>>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the next page of query jobs
        /// </summary>
        /// <param name="nextRecordsUrl"><see cref="BulkJobList{T}.NextRecordsUrl"/> from the previous page</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>A page of jobs</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<BulkJobList<QueryJobInfo>> GetNextQueryJobsAsync(string nextRecordsUrl, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = ResolveRelativeUrl(nextRecordsUrl, nameof(nextRecordsUrl));

            return await CreateJsonClient().HttpGetAsync<BulkJobList<QueryJobInfo>>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a set of results for a completed query job.
        /// <para>Results must be retrieved using the same API version used to create the job.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="locator">Optional. <see cref="QueryJobResults.Locator"/> from the previous set of results. Omit to get the first set.</param>
        /// <param name="maxRecords">Optional. Maximum number of records to return in this set. Defaults to a value determined by Salesforce.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A set of CSV results</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobResults> GetQueryJobResultsAsync(
            string jobId,
            string locator = null,
            int? maxRecords = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.QueryJobResults(InstanceUrl, ApiVersion, jobId, locator, maxRecords);

            return await GetQueryJobResultsAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a set of results for a completed query job, as a stream.
        /// <para>Results must be retrieved using the same API version used to create the job.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="locator">Optional. <see cref="QueryJobResultsStream.Locator"/> from the previous set of results. Omit to get the first set.</param>
        /// <param name="maxRecords">Optional. Maximum number of records to return in this set. Defaults to a value determined by Salesforce.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A set of CSV results. Dispose once read, to release the connection.</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobResultsStream> GetQueryJobResultsStreamAsync(
            string jobId,
            string locator = null,
            int? maxRecords = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            Uri uri = BulkApiUriFormatter.QueryJobResults(InstanceUrl, ApiVersion, jobId, locator, maxRecords);

            return await GetQueryJobResultsStreamAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get all results for a completed query job, one set at a time. The next set is only retrieved as needed.
        /// <para>Results must be retrieved using the same API version used to create the job.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="maxRecords">Optional. Maximum number of records to return in each set. Defaults to a value determined by Salesforce.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Sets of CSV results. Each set includes a header row.</returns>
        /// <exception cref="ForceApiException">Thrown when a request fails</exception>
        public async IAsyncEnumerable<QueryJobResults> GetAllQueryJobResultsAsync(
            string jobId,
            int? maxRecords = null,
            Dictionary<string, string> customHeaders = null,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            string locator = null;

            do
            {
                QueryJobResults results = await GetQueryJobResultsAsync(jobId, locator, maxRecords, customHeaders, cancellationToken).ConfigureAwait(false);

                //a repeated locator would otherwise loop forever
                if (locator != null && results.Locator == locator)
                {
                    throw new ForceApiException($"Query results repeated the previous locator: {locator}");
                }

                locator = results.Locator;

                yield return results;
            }
            while (locator != null);
        }

        /// <summary>
        /// Get result page URLs for a completed query job, so that results can be retrieved in parallel using <see cref="GetQueryJobResultsByUrlAsync"/>.
        /// <para>Up to five URLs are returned per response, use <see cref="GetNextQueryJobResultPagesAsync"/> to get more.
        /// Available in API version 58.0 and later. Results must be retrieved using the same API version used to create the job.</para>
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Result page URLs</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobResultPages> GetQueryJobResultPagesAsync(string jobId, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = BulkApiUriFormatter.QueryJobResultPages(InstanceUrl, ApiVersion, jobId);

            return await CreateJsonClient().HttpGetAsync<QueryJobResultPages>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the next set of result page URLs for a query job
        /// </summary>
        /// <param name="nextRecordsUrl"><see cref="QueryJobResultPages.NextRecordsUrl"/> from the previous response</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <returns>Result page URLs</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobResultPages> GetNextQueryJobResultPagesAsync(string nextRecordsUrl, Dictionary<string, string> customHeaders = null)
        {
            Uri uri = ResolveRelativeUrl(nextRecordsUrl, nameof(nextRecordsUrl));

            return await CreateJsonClient().HttpGetAsync<QueryJobResultPages>(uri, BuildHeaders(customHeaders)).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a page of query job results, using a URL from <see cref="GetQueryJobResultPagesAsync"/>
        /// </summary>
        /// <param name="resultUrl"><see cref="QueryJobResultPage.ResultUrl"/></param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A set of CSV results</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobResults> GetQueryJobResultsByUrlAsync(string resultUrl, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = ResolveRelativeUrl(resultUrl, nameof(resultUrl));

            return await GetQueryJobResultsAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a page of query job results as a stream, using a URL from <see cref="GetQueryJobResultPagesAsync"/>
        /// </summary>
        /// <param name="resultUrl"><see cref="QueryJobResultPage.ResultUrl"/></param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A set of CSV results. Dispose once read, to release the connection.</returns>
        /// <exception cref="ForceApiException">Thrown when the request fails</exception>
        public async Task<QueryJobResultsStream> GetQueryJobResultsByUrlStreamAsync(string resultUrl, Dictionary<string, string> customHeaders = null, CancellationToken cancellationToken = default)
        {
            Uri uri = ResolveRelativeUrl(resultUrl, nameof(resultUrl));

            return await GetQueryJobResultsStreamAsync(uri, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Wait for a query job to reach a terminal state: JobComplete, Failed, or Aborted
        /// </summary>
        /// <param name="jobId">Job ID</param>
        /// <param name="pollInterval">Time between job info requests. Defaults to 5 seconds.</param>
        /// <param name="timeout">Optional. Maximum time to wait. The job is not aborted if the timeout is reached.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Final job info</returns>
        /// <exception cref="TimeoutException">Thrown when the job does not reach a terminal state within the timeout</exception>
        /// <exception cref="ForceApiException">Thrown when a request fails</exception>
        public async Task<QueryJobInfo> WaitForQueryJobAsync(
            string jobId,
            TimeSpan? pollInterval = null,
            TimeSpan? timeout = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            return await WaitForJobAsync(() => GetQueryJobAsync(jobId, customHeaders), jobId, pollInterval, timeout, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Run a query job: create the job, and wait for it to reach a terminal state.
        /// <para>Check <see cref="BulkJobInfo.State"/> on the result, then use <see cref="GetAllQueryJobResultsAsync"/> to get the results.</para>
        /// </summary>
        /// <param name="query">SOQL query</param>
        /// <param name="queryAll">True to include records deleted by a merge or delete, and archived Task and Event records</param>
        /// <param name="pollInterval">Time between job info requests. Defaults to 5 seconds.</param>
        /// <param name="timeout">Optional. Maximum time to wait for the job to be processed. The job is not aborted if the timeout is reached.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Final job info</returns>
        /// <exception cref="TimeoutException">Thrown when the job does not reach a terminal state within the timeout</exception>
        /// <exception cref="ForceApiException">Thrown when a request fails</exception>
        public async Task<QueryJobInfo> RunQueryJobAsync(
            string query,
            bool queryAll = false,
            TimeSpan? pollInterval = null,
            TimeSpan? timeout = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(query)) throw new ArgumentNullException(nameof(query));

            return await RunQueryJobAsync(new CreateQueryJobRequest(query, queryAll ? BulkQueryOperation.QueryAll : BulkQueryOperation.Query),
                pollInterval, timeout, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Run a query job: create the job, and wait for it to reach a terminal state.
        /// <para>Check <see cref="BulkJobInfo.State"/> on the result, then use <see cref="GetAllQueryJobResultsAsync"/> to get the results.</para>
        /// </summary>
        /// <param name="request">Job details</param>
        /// <param name="pollInterval">Time between job info requests. Defaults to 5 seconds.</param>
        /// <param name="timeout">Optional. Maximum time to wait for the job to be processed. The job is not aborted if the timeout is reached.</param>
        /// <param name="customHeaders">Custom headers to include in request (Optional). The HeaderFormatter helper class can be used to generate the custom header as needed.</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Final job info</returns>
        /// <exception cref="TimeoutException">Thrown when the job does not reach a terminal state within the timeout</exception>
        /// <exception cref="ForceApiException">Thrown when a request fails</exception>
        public async Task<QueryJobInfo> RunQueryJobAsync(
            CreateQueryJobRequest request,
            TimeSpan? pollInterval = null,
            TimeSpan? timeout = null,
            Dictionary<string, string> customHeaders = null,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            QueryJobInfo job = await CreateQueryJobAsync(request, customHeaders).ConfigureAwait(false);
            if (job == null || string.IsNullOrEmpty(job.Id))
            {
                throw new ForceApiException("Create job response did not include a job ID");
            }

            return await WaitForQueryJobAsync(job.Id, pollInterval, timeout, customHeaders, cancellationToken).ConfigureAwait(false);
        }

        #endregion

        private JsonClient CreateJsonClient()
        {
            return new JsonClient(_forceClient.AccessToken, _forceClient.SharedHttpClient);
        }

        private Dictionary<string, string> BuildHeaders(Dictionary<string, string> customHeaders)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();

            //Add call options
            Dictionary<string, string> callOptions = HeaderFormatter.SforceCallOptions(_forceClient.ClientName);
            headers.AddRange(callOptions);

            //Add custom headers if specified
            if (customHeaders != null)
            {
                headers.AddRange(customHeaders);
            }

            return headers;
        }

        /// <summary>
        /// Resolve a relative URL returned by the API, e.g. nextRecordsUrl, ensuring it stays on the instance.
        /// </summary>
        private Uri ResolveRelativeUrl(string url, string paramName)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(paramName);

            return UriFormatter.NextRecordsUri(InstanceUrl, url);
        }

        private async Task<HttpResponseMessage> GetCsvResponseAsync(Uri uri, Dictionary<string, string> customHeaders, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri))
            {
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(CsvMimeType));

                return await CreateJsonClient().HttpSendAsync(request, BuildHeaders(customHeaders), completionOption, cancellationToken).ConfigureAwait(false);
            }
        }

        private async Task<string> GetCsvStringAsync(Uri uri, Dictionary<string, string> customHeaders, CancellationToken cancellationToken)
        {
            using (HttpResponseMessage response = await GetCsvResponseAsync(uri, customHeaders, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false))
            {
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        private async Task<Stream> GetCsvStreamAsync(Uri uri, Dictionary<string, string> customHeaders, CancellationToken cancellationToken)
        {
            //ResponseHeadersRead = do not buffer the content to memory. Disposing the stream releases the connection.
            HttpResponseMessage response = await GetCsvResponseAsync(uri, customHeaders, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }

        private async Task<QueryJobResults> GetQueryJobResultsAsync(Uri uri, Dictionary<string, string> customHeaders, CancellationToken cancellationToken)
        {
            using (HttpResponseMessage response = await GetCsvResponseAsync(uri, customHeaders, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false))
            {
                return new QueryJobResults()
                {
                    Csv = await response.Content.ReadAsStringAsync().ConfigureAwait(false),
                    Locator = GetLocator(response),
                    NumberOfRecords = GetNumberOfRecords(response)
                };
            }
        }

        private async Task<QueryJobResultsStream> GetQueryJobResultsStreamAsync(Uri uri, Dictionary<string, string> customHeaders, CancellationToken cancellationToken)
        {
            //ResponseHeadersRead = do not buffer the content to memory
            HttpResponseMessage response = await GetCsvResponseAsync(uri, customHeaders, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            try
            {
                Stream content = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                return new QueryJobResultsStream(response, content, GetLocator(response), GetNumberOfRecords(response));
            }
            catch
            {
                response.Dispose();
                throw;
            }
        }

        private static async Task<T> ReadJsonAsync<T>(HttpResponseMessage response)
        {
            string responseContent = response.Content != null ? await response.Content.ReadAsStringAsync().ConfigureAwait(false) : null;
            if (string.IsNullOrEmpty(responseContent))
            {
                throw new ForceApiException("Response content was empty");
            }

            return JsonSerializer.Deserialize<T>(responseContent);
        }

        /// <summary>
        /// Get the Sforce-Locator header value. Salesforce returns the string "null" when there are no more results.
        /// </summary>
        private static string GetLocator(HttpResponseMessage response)
        {
            string locator = GetHeaderValue(response, SforceLocatorHeaderName);
            if (string.IsNullOrEmpty(locator) || locator == "null")
            {
                return null;
            }

            return locator;
        }

        private static int? GetNumberOfRecords(HttpResponseMessage response)
        {
            string numberOfRecords = GetHeaderValue(response, SforceNumberOfRecordsHeaderName);
            if (int.TryParse(numberOfRecords, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value))
            {
                return value;
            }

            return null;
        }

        private static string GetHeaderValue(HttpResponseMessage response, string headerName)
        {
            if (response.Headers.TryGetValues(headerName, out IEnumerable<string> values))
            {
                return values.FirstOrDefault();
            }

            return null;
        }

        private static async Task<T> WaitForJobAsync<T>(Func<Task<T>> getJob, string jobId, TimeSpan? pollInterval, TimeSpan? timeout, CancellationToken cancellationToken)
            where T : BulkJobInfo
        {
            if (string.IsNullOrEmpty(jobId)) throw new ArgumentNullException(nameof(jobId));

            TimeSpan interval = pollInterval ?? DefaultPollInterval;
            if (interval <= TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(pollInterval), "pollInterval must be greater than zero");
            }
            if (timeout.HasValue && timeout.Value < TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(timeout), "timeout must not be negative");
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                T job = await getJob().ConfigureAwait(false);
                if (job == null)
                {
                    throw new ForceApiException("Job info response was empty");
                }

                if (job.IsTerminal)
                {
                    return job;
                }

                if (timeout.HasValue && stopwatch.Elapsed + interval > timeout.Value)
                {
                    throw new TimeoutException($"Job {jobId} did not complete within {timeout.Value}, last state was {job.State}");
                }

                await Task.Delay(interval, cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
