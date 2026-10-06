using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
#if !XUNIT_V3
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Helpers for cleaning up records created by functional tests
    /// </summary>
    internal static class TestRecords
    {
        /// <summary>
        /// Delete records created by a test. Each delete is attempted even if a previous one fails, and failures are logged
        /// rather than thrown so they don't hide the original test failure.
        /// <para>Call from a finally block so records are removed regardless of the test outcome.</para>
        /// </summary>
        public static async Task DeleteAsync(ForceClient client, string sObjectTypeName, IEnumerable<string> ids, ITestOutputHelper output)
        {
            foreach (string id in ids)
            {
                try
                {
                    await client.DeleteRecord(sObjectTypeName, id);
                }
                catch (Exception ex)
                {
                    output.WriteLine("Failed to delete test {0} {1}: {2}", sObjectTypeName, id, ex.Message);
                }
            }
        }
    }
}
