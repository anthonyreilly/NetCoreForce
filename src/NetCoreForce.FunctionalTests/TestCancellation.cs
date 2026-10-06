using System.Threading;
using Xunit;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Cancellation token for the current test.
    /// xUnit v3 provides one via TestContext so long-running calls stop when a test run is cancelled; xUnit v2 (net462) has no equivalent.
    /// </summary>
    internal static class TestCancellation
    {
        public static CancellationToken Token
        {
            get
            {
#if XUNIT_V3
                return TestContext.Current.CancellationToken;
#else
                return CancellationToken.None;
#endif
            }
        }
    }
}
