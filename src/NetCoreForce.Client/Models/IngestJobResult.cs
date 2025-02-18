using System.Collections.Generic;

namespace NetCoreForce.Client.Models
{
    internal class IngestJobResult
    {

        internal string Items { get; set; }

    }
    public class IngestJobResult<T>
    {
        public List<T> Items { get; set; }
    }
}
