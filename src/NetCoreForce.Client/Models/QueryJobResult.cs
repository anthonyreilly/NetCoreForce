using System.Collections.Generic;

namespace NetCoreForce.Client.Models
{
    internal class QueryJobResult
    {
        internal int NumberOfRecords { get; set; }

        internal string Locator { get; set; }

        internal string Items { get; set; }
    }

    public class QueryJobResult<T>
    {
        internal QueryJobResult(QueryJobResult baseResult)
        {
            NumberOfRecords = baseResult.NumberOfRecords;
            Locator = baseResult.Locator;
        }

        public int NumberOfRecords { get; set; }

        public string Locator { get; set; }

        public List<T> Items { get; set; }
    }
}