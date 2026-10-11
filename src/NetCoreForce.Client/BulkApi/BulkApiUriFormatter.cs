using System;
using System.Collections.Generic;
using System.Globalization;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Builds Bulk API 2.0 resource URIs
    /// </summary>
    internal static class BulkApiUriFormatter
    {
        private const string IngestJobsPath = "jobs/ingest";
        private const string QueryJobsPath = "jobs/query";

        /// <summary>
        /// Ingest jobs: create a job, or get all jobs
        /// </summary>
        internal static Uri IngestJobs(string instanceUrl, string apiVersion, bool? isPkChunkingEnabled = null, string jobType = null)
        {
            Dictionary<string, string> parameters = JobListParameters(isPkChunkingEnabled, jobType, null);
            return AddQueryString(JobsUri(instanceUrl, apiVersion, IngestJobsPath), parameters);
        }

        /// <summary>
        /// Ingest job: get info, close, abort, or delete
        /// </summary>
        internal static Uri IngestJob(string instanceUrl, string apiVersion, string jobId)
        {
            return JobUri(instanceUrl, apiVersion, IngestJobsPath, jobId, null);
        }

        /// <summary>
        /// Ingest job data upload
        /// </summary>
        internal static Uri IngestJobData(string instanceUrl, string apiVersion, string jobId)
        {
            return JobUri(instanceUrl, apiVersion, IngestJobsPath, jobId, "batches");
        }

        /// <summary>
        /// Ingest job successful record results
        /// </summary>
        internal static Uri IngestJobSuccessfulResults(string instanceUrl, string apiVersion, string jobId)
        {
            return JobUri(instanceUrl, apiVersion, IngestJobsPath, jobId, "successfulResults/");
        }

        /// <summary>
        /// Ingest job failed record results
        /// </summary>
        internal static Uri IngestJobFailedResults(string instanceUrl, string apiVersion, string jobId)
        {
            return JobUri(instanceUrl, apiVersion, IngestJobsPath, jobId, "failedResults/");
        }

        /// <summary>
        /// Ingest job unprocessed records
        /// </summary>
        internal static Uri IngestJobUnprocessedRecords(string instanceUrl, string apiVersion, string jobId)
        {
            return JobUri(instanceUrl, apiVersion, IngestJobsPath, jobId, "unprocessedrecords/");
        }

        /// <summary>
        /// Query jobs: create a job, or get all jobs
        /// </summary>
        internal static Uri QueryJobs(string instanceUrl, string apiVersion, bool? isPkChunkingEnabled = null, string jobType = null, string concurrencyMode = null)
        {
            Dictionary<string, string> parameters = JobListParameters(isPkChunkingEnabled, jobType, concurrencyMode);
            return AddQueryString(JobsUri(instanceUrl, apiVersion, QueryJobsPath), parameters);
        }

        /// <summary>
        /// Query job: get info, abort, or delete
        /// </summary>
        internal static Uri QueryJob(string instanceUrl, string apiVersion, string jobId)
        {
            return JobUri(instanceUrl, apiVersion, QueryJobsPath, jobId, null);
        }

        /// <summary>
        /// Query job results
        /// </summary>
        internal static Uri QueryJobResults(string instanceUrl, string apiVersion, string jobId, string locator = null, int? maxRecords = null)
        {
            if (maxRecords.HasValue && maxRecords.Value < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(maxRecords), "maxRecords must be greater than zero");
            }

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(locator))
            {
                parameters.Add("locator", locator);
            }
            if (maxRecords.HasValue)
            {
                parameters.Add("maxRecords", maxRecords.Value.ToString(CultureInfo.InvariantCulture));
            }

            return AddQueryString(JobUri(instanceUrl, apiVersion, QueryJobsPath, jobId, "results"), parameters);
        }

        /// <summary>
        /// Query job result pages, for retrieving results in parallel
        /// </summary>
        internal static Uri QueryJobResultPages(string instanceUrl, string apiVersion, string jobId)
        {
            return JobUri(instanceUrl, apiVersion, QueryJobsPath, jobId, "resultPages");
        }

        private static Uri JobsUri(string instanceUrl, string apiVersion, string jobsPath)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            UriFormatter.ValidateApiVersion(apiVersion);

            return new Uri(UriFormatter.BaseUri(instanceUrl), $"{apiVersion}/{jobsPath}");
        }

        private static Uri JobUri(string instanceUrl, string apiVersion, string jobsPath, string jobId, string resource)
        {
            if (string.IsNullOrEmpty(apiVersion)) throw new ArgumentNullException(nameof(apiVersion));
            if (string.IsNullOrEmpty(jobId)) throw new ArgumentNullException(nameof(jobId));
            UriFormatter.ValidateApiVersion(apiVersion);
            UriFormatter.ValidatePathSegment(jobId, nameof(jobId));

            string path = $"{apiVersion}/{jobsPath}/{jobId}";
            if (resource != null)
            {
                path += "/" + resource;
            }

            return new Uri(UriFormatter.BaseUri(instanceUrl), path);
        }

        private static Dictionary<string, string> JobListParameters(bool? isPkChunkingEnabled, string jobType, string concurrencyMode)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (isPkChunkingEnabled.HasValue)
            {
                parameters.Add("isPkChunkingEnabled", isPkChunkingEnabled.Value ? "true" : "false");
            }
            if (!string.IsNullOrEmpty(jobType))
            {
                parameters.Add("jobType", jobType);
            }
            if (!string.IsNullOrEmpty(concurrencyMode))
            {
                parameters.Add("concurrencyMode", concurrencyMode);
            }
            return parameters;
        }

        private static Uri AddQueryString(Uri uri, Dictionary<string, string> parameters)
        {
            if (parameters.Count == 0)
            {
                return uri;
            }

            return new Uri(QueryHelpers.AddQueryString(uri.ToString(), parameters));
        }
    }
}
