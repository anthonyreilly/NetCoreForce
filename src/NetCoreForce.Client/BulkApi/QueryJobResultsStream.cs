using System;
using System.IO;
using System.Net.Http;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// A set of query job results, streamed rather than buffered to memory.
    /// <para>Dispose once the content has been read, to release the connection.</para>
    /// </summary>
    public class QueryJobResultsStream : IDisposable
    {
        private readonly HttpResponseMessage _response;

        internal QueryJobResultsStream(HttpResponseMessage response, Stream content, string locator, int? numberOfRecords)
        {
            _response = response;
            Content = content;
            Locator = locator;
            NumberOfRecords = numberOfRecords;
        }

        /// <summary>
        /// CSV results, including a header row
        /// </summary>
        public Stream Content { get; private set; }

        /// <summary>
        /// Locator for the next set of results. Null if there are no more results.
        /// </summary>
        public string Locator { get; private set; }

        /// <summary>
        /// Number of records in this set of results
        /// </summary>
        public int? NumberOfRecords { get; private set; }

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

        /// <summary>
        /// Dispose the content stream and the underlying response
        /// </summary>
        public void Dispose()
        {
            Content?.Dispose();
            _response?.Dispose();
        }
    }
}
