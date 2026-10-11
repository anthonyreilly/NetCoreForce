using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// A page of jobs returned by Get All Jobs. Up to 1000 jobs are returned per page.
    /// </summary>
    public class BulkJobList<T> where T : BulkJobInfo
    {
        /// <summary>
        /// False if there are more jobs to retrieve using <see cref="NextRecordsUrl"/>
        /// </summary>
        [JsonProperty(PropertyName = "done")]
        public bool Done { get; set; }

        /// <summary>
        /// Jobs in this page
        /// </summary>
        [JsonProperty(PropertyName = "records")]
        public List<T> Records { get; set; }

        /// <summary>
        /// Relative URL of the next page of jobs, if any
        /// </summary>
        [JsonProperty(PropertyName = "nextRecordsUrl")]
        public string NextRecordsUrl { get; set; }
    }
}
