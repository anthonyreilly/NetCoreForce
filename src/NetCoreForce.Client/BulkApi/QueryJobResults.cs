namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// A set of query job results
    /// </summary>
    public class QueryJobResults
    {
        /// <summary>
        /// CSV results, including a header row
        /// </summary>
        public string Csv { get; set; }

        /// <summary>
        /// Locator for the next set of results. Null if there are no more results.
        /// </summary>
        public string Locator { get; set; }

        /// <summary>
        /// Number of records in this set of results
        /// </summary>
        public int? NumberOfRecords { get; set; }

        /// <summary>
        /// True if there are no more results to retrieve
        /// </summary>
        public bool Done
        {
            get
            {
                return Locator == null;
            }
        }
    }
}
