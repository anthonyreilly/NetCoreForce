using Newtonsoft.Json;

namespace NetCoreForce.Client.BulkApi
{
    /// <summary>
    /// Request to change the state of a job, i.e. to close or abort it
    /// </summary>
    internal class BulkJobStateRequest
    {
        public BulkJobStateRequest(BulkJobState state)
        {
            State = state;
        }

        [JsonProperty(PropertyName = "state")]
        public BulkJobState State { get; set; }
    }
}
