using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class LimitInfo
    {
        /// <summary>
        /// Limit total for the organization.
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// Total number of calls or events left for the organization.
        /// </summary>
        public int Remaining { get; set; }

    }

    public class OrganizationLimits
    {
        public LimitInfo ConcurrentAsyncGetReportInstances { get; set; }

        public LimitInfo ConcurrentSyncReportRuns { get; set; }

        public LimitInfo DailyApiRequests { get; set; }

        public LimitInfo DailyAsyncApexExecutions { get; set; }

        public LimitInfo DailyBulkApiRequests { get; set; }

        public LimitInfo DailyDurableGenericStreamingApiEvents { get; set; }

        public LimitInfo DailyDurableStreamingApiEvents { get; set; }

        public LimitInfo DailyGenericStreamingApiEvents { get; set; }

        public LimitInfo DailyStreamingApiEvents { get; set; }

        public LimitInfo DailyWorkflowEmails { get; set; }

        public LimitInfo DurableStreamingApiConcurrentClients { get; set; }

        public LimitInfo HourlyAsyncReportRuns { get; set; }

        public LimitInfo HourlyDashboardRefreshes { get; set; }

        public LimitInfo HourlyDashboardResults { get; set; }

        public LimitInfo HourlyDashboardStatuses { get; set; }

        public LimitInfo HourlyODataCallout { get; set; }

        public LimitInfo HourlySyncReportRuns { get; set; }

        public LimitInfo HourlyTimeBasedWorkflow { get; set; }

        /// <summary>
        /// Daily number of mass emails that are sent to external email addresses by using Apex or Force.com APIs
        /// </summary>
        public LimitInfo MassEmail { get; set; }

        /// <summary>
        /// Daily number of single emails that are sent to external email addresses by using Apex or Force.com APIs
        /// </summary>
        /// <returns></returns>
        public LimitInfo SingleEmail { get; set; }

        public LimitInfo StreamingApiConcurrentClients { get; set; }

        /// <summary>
        /// Data storage (MB)
        /// <para>Returns these limits if the API user has the Manage Users permission</para>
        /// </summary>
        public LimitInfo DataStorageMB { get; set; }

        /// <summary>
        /// File storage (MB)
        /// <para>Returns these limits if the API user has the Manage Users permission</para>
        /// </summary>
        public LimitInfo FileStorageMB { get; set; }
    }
}