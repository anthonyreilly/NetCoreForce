using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// Tests that change process-wide state (e.g. JsonConvert.DefaultSettings, CurrentCulture) must not run in parallel with other tests
    /// </summary>
    [CollectionDefinition(Name, DisableParallelization = true)]
    public class GlobalStateCollection
    {
        public const string Name = "Global state";
    }
}
