namespace NetCoreForce.Client.Models
{
    public static class BulkConstants
    {
        public sealed class OperationType
        {
            public static readonly OperationType Insert = new OperationType("insert");
            public static readonly OperationType Update = new OperationType("update");
            public static readonly OperationType Upsert = new OperationType("upsert");
            public static readonly OperationType Delete = new OperationType("delete");
            public static readonly OperationType HardDelete = new OperationType("hardDelete");

            private readonly string _value;

            private OperationType(string value)
            {
                _value = value;
            }

            public string Value()
            {
                return _value;
            }
        }

        public sealed class BatchState
        {
            public static readonly BatchState Queued = new BatchState("Open");
            public static readonly BatchState UploadComplete = new BatchState("UploadComplete");
            public static readonly BatchState InProgress = new BatchState("InProgress");
            public static readonly BatchState Completed = new BatchState("Completed");
            public static readonly BatchState Failed = new BatchState("Failed");
            public static readonly BatchState NotProcessed = new BatchState("Not Processed");

            private readonly string _value;

            private BatchState(string value)
            {
                _value = value;
            }

            public string Value()
            {
                return _value;
            }
        }

        public sealed class QueryJobState
        {
            public static readonly QueryJobState UploadComplete = new QueryJobState("UploadComplete");
            public static readonly QueryJobState InProgress = new QueryJobState("InProgress");
            public static readonly QueryJobState Aborted = new QueryJobState("Aborted");
            public static readonly QueryJobState JobComplete = new QueryJobState("JobComplete");
            public static readonly QueryJobState Failed = new QueryJobState("Failed");

            private readonly string _value;

            private QueryJobState(string value)
            {
                _value = value;
            }

            public string Value()
            {
                return _value;
            }
        }
    }
}
