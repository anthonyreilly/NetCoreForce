---
title: "Salesforce Bulk API 2.0 in .NET"
_description: "How to load and query large Salesforce data sets from .NET and C# with the NetCoreForce Bulk API 2.0 client: ingest jobs for insert, update, upsert and delete, and query jobs with paged, streamed and parallel CSV results."
---

# Bulk API 2.0

The Salesforce Bulk API 2.0 loads or queries large data sets, from thousands to millions of records, using asynchronous jobs that Salesforce processes in the background. [`BulkApiClient`](xref:NetCoreForce.Client.BulkApi.BulkApiClient), in the `NetCoreForce.Client.BulkApi` namespace, supports both kinds of job:

- **Ingest jobs** insert, update, upsert or delete records from CSV data.
- **Query jobs** run a SOQL query, and return the results as CSV.

For smaller sets of records, the REST API calls on `ForceClient` are simpler and return results immediately - see [Create Multiple Records](examples.md#create-multiple-records), [Update Multiple Records](examples.md#update-multiple-records) and [Composite Requests](examples.md#composite-requests).

---

## Supported Features

| Feature | Methods |
|---|---|
| Ingest operations: insert, update, upsert, delete, hardDelete, plus refresh (marketing objects) and consentImport | [`CreateIngestJobRequest`](xref:NetCoreForce.Client.BulkApi.CreateIngestJobRequest) |
| Create a job, upload CSV data as a string or stream, and close the job | [`CreateIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.CreateIngestJobAsync*), [`UploadIngestJobDataAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.UploadIngestJobDataAsync*), [`CloseIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.CloseIngestJobAsync*) |
| Create a job and upload its data in one request, for small data sets | [`CreateIngestJobWithDataAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.CreateIngestJobWithDataAsync*) |
| Successful, failed and unprocessed record results, as a string or stream | [`GetSuccessfulResultsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetSuccessfulResultsAsync*), [`GetFailedResultsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetFailedResultsAsync*), [`GetUnprocessedRecordsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetUnprocessedRecordsAsync*) and their `...StreamAsync` versions |
| Query operations: query and queryAll | [`CreateQueryJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.CreateQueryJobAsync*) |
| Query results one set at a time, all sets as an `IAsyncEnumerable`, or as a stream | [`GetQueryJobResultsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultsAsync*), [`GetAllQueryJobResultsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetAllQueryJobResultsAsync*), [`GetQueryJobResultsStreamAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultsStreamAsync*) |
| Parallel query results (API version 58.0 and later) | [`GetQueryJobResultPagesAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultPagesAsync*), [`GetQueryJobResultsByUrlAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultsByUrlAsync*) |
| Run a whole job and wait for it to finish | [`RunIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.RunIngestJobAsync*), [`RunQueryJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.RunQueryJobAsync*) |
| Wait for an existing job, with a poll interval, timeout and cancellation | [`WaitForIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.WaitForIngestJobAsync*), [`WaitForQueryJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.WaitForQueryJobAsync*) |
| Job info, abort, delete, and list all jobs | [`GetIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetIngestJobAsync*), [`AbortIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.AbortIngestJobAsync*), [`DeleteIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.DeleteIngestJobAsync*), [`GetIngestJobsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetIngestJobsAsync*), and the query job equivalents |

Job data and results are CSV - records are passed as CSV text, not as model objects. The original Bulk API (1.0), with its batches and XML or JSON data, is not supported.

---

## Getting Started

Create a `BulkApiClient` from a logged-in `ForceClient`. It uses the `ForceClient`'s instance URL, API version, access token and HttpClient for all of its requests. See [Authentication](auth.md) for ways to log in.

```csharp
using NetCoreForce.Client;
using NetCoreForce.Client.BulkApi;

ForceClient client = await ForceClient.FromClientCredentialsAsync(
    "your-client-id", "your-client-secret", "https://your-domain.my.salesforce.com/services/oauth2/token");

BulkApiClient bulkClient = new BulkApiClient(client);
```

Ingest jobs need API version 41.0 or later, query jobs 47.0 or later, and parallel query results 58.0 or later. The default API version used by NetCoreForce meets all of these.

---

## Preparing CSV Data

Ingest job data is UTF-8 CSV:

- The first row is a header row of field API names, e.g. `Name,Industry,External_Id__c`.
- Enclose values in double quotes if they contain the column delimiter, a line break or a double quote, and double any double quotes inside the value.
- Empty values are ignored when updating records. Use `#N/A` to set a field to null.
- Use the `yyyy-MM-ddTHH:mm:ss.SSSZ` format for dateTime fields, and `yyyy-MM-dd` for date fields.
- All rows must be for the same object.

A small helper keeps values correctly quoted:

```csharp
static string CsvValue(string value)
{
    if (value == null)
    {
        return string.Empty;
    }

    return "\"" + value.Replace("\"", "\"\"") + "\"";
}

StringBuilder csv = new StringBuilder("Name,Industry,Contract_Start__c,Last_Synced__c\n");
foreach (Customer customer in customers)
{
    csv.Append(CsvValue(customer.Name)).Append(',')
       .Append(CsvValue(customer.Industry)).Append(',')
       .Append(DateFormats.DateOnlyString(customer.ContractStart)).Append(',')
       .Append(customer.LastSynced.UtcDateTime.ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture))
       .Append('\n');
}
```

To set a lookup field by the parent record's external ID instead of its record ID, use `RelationshipName.ExternalIdField` as the column header, e.g. `Account.External_Id__c` on a Contact, or `Parent_Object__r.External_Id__c` for a custom relationship.

The default column delimiter is a comma and the default line ending is LF. Set [`ColumnDelimiter`](xref:NetCoreForce.Client.BulkApi.CreateIngestJobRequest.ColumnDelimiter) and [`LineEnding`](xref:NetCoreForce.Client.BulkApi.CreateIngestJobRequest.LineEnding) on the job request to match your data if it is different, e.g. tab-delimited with CRLF line endings.

---

## Ingest Jobs

An ingest job goes through these steps:

1. Create the job, with the object and operation.
2. Upload the CSV data. Data can be uploaded once per job.
3. Close the job, setting its state to `UploadComplete`. Salesforce starts processing the job once it is closed.
4. Wait for the job to reach `JobComplete`, or `Failed` or `Aborted`.
5. Get the successful and failed record results.

### Running an Ingest Job

[`RunIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.RunIngestJobAsync*) does steps 1 to 4, and returns the final job info:

```csharp
string csv = "Name,Industry\n\"Acme, Inc.\",Manufacturing\nGlobex,Energy\n";

IngestJobInfo job = await bulkClient.RunIngestJobAsync(
    new CreateIngestJobRequest("Account", BulkIngestOperation.Insert),
    csv,
    timeout: TimeSpan.FromMinutes(30));

Console.WriteLine($"{job.State}: {job.NumberRecordsProcessed} processed, {job.NumberRecordsFailed} failed");
```

A job that completes can still have records that failed, e.g. because of a validation rule - check [`NumberRecordsFailed`](xref:NetCoreForce.Client.BulkApi.IngestJobInfo.NumberRecordsFailed) and get the [failed results](#ingest-job-results). If uploading or closing the job fails, `RunIngestJobAsync` aborts the job and rethrows the exception.

The data can also be a stream, e.g. a file. The stream is disposed once it has been uploaded:

```csharp
IngestJobInfo job = await bulkClient.RunIngestJobAsync(
    new CreateIngestJobRequest("Contact", BulkIngestOperation.Insert),
    File.OpenRead("contacts.csv"));
```

### Update, Upsert and Delete

Update jobs need an `Id` column. Upsert jobs match records on an external ID field, set with [`ExternalIdFieldName`](xref:NetCoreForce.Client.BulkApi.CreateIngestJobRequest.ExternalIdFieldName), which must also be a column in the data:

```csharp
var request = new CreateIngestJobRequest("Account", BulkIngestOperation.Upsert)
{
    ExternalIdFieldName = "External_Id__c"
};

string csv = "External_Id__c,Name,Industry\nA-1001,Acme,Manufacturing\nA-1002,Globex,Energy\n";

IngestJobInfo job = await bulkClient.RunIngestJobAsync(request, csv);
```

Delete jobs only need an `Id` column. `Delete` moves records to the Recycle Bin. `HardDelete` deletes them permanently, and needs the "Bulk API Hard Delete" permission.

```csharp
string csv = "Id\n001R00000033I6AIAU\n001R00000033I6BIAU\n";

IngestJobInfo job = await bulkClient.RunIngestJobAsync(
    new CreateIngestJobRequest("Account", BulkIngestOperation.Delete), csv);
```

### Running the Steps Individually

Each step has its own method, e.g. to upload data from one process and check on the job from another:

```csharp
IngestJobInfo job = await bulkClient.CreateIngestJobAsync(
    new CreateIngestJobRequest("Account", BulkIngestOperation.Insert));

using (FileStream data = File.OpenRead("accounts.csv"))
{
    await bulkClient.UploadIngestJobDataAsync(job.Id, data);
}

await bulkClient.CloseIngestJobAsync(job.Id);

// later
IngestJobInfo jobInfo = await bulkClient.GetIngestJobAsync(job.Id);
if (jobInfo.IsTerminal)
{
    Console.WriteLine($"{jobInfo.State}: {jobInfo.NumberRecordsProcessed} processed");
}
```

A job that is not closed is never processed. Use [`AbortIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.AbortIngestJobAsync*) to abandon a job instead.

### Small Data Sets in One Request

For up to 100,000 characters of data ([`MaxCreateJobDataLength`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.MaxCreateJobDataLength)), [`CreateIngestJobWithDataAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.CreateIngestJobWithDataAsync*) creates the job and uploads the data in a single request. The job is closed automatically:

```csharp
IngestJobInfo job = await bulkClient.CreateIngestJobWithDataAsync(
    new CreateIngestJobRequest("Contact", BulkIngestOperation.Insert),
    "FirstName,LastName,Email\nJane,Doe,jane@example.com\n");

IngestJobInfo completedJob = await bulkClient.WaitForIngestJobAsync(job.Id);
```

### Ingest Job Results

Once the job has finished, get the records that were processed successfully, and the records that failed:

```csharp
// "sf__Id","sf__Created", followed by the uploaded fields
string successfulResults = await bulkClient.GetSuccessfulResultsAsync(job.Id);

// "sf__Id","sf__Error", followed by the uploaded fields
string failedResults = await bulkClient.GetFailedResultsAsync(job.Id);
```

`sf__Id` is the record ID, `sf__Created` is `true` for inserted records, and `sf__Error` is the error code and message. The results are not necessarily in the same order as the uploaded data. For a failed or aborted job, [`GetUnprocessedRecordsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetUnprocessedRecordsAsync*) returns the records that were not processed.

For large jobs, the `...StreamAsync` versions stream the results rather than loading them into memory:

```csharp
using (Stream results = await bulkClient.GetFailedResultsStreamAsync(job.Id))
using (FileStream file = File.Create("failed.csv"))
{
    await results.CopyToAsync(file);
}
```

---

## Query Jobs

A query job runs a SOQL query in the background. Salesforce starts processing the job as soon as it is created. Once the job is complete, the results are retrieved as CSV, in one or more sets.

### Running a Query Job

[`RunQueryJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.RunQueryJobAsync*) creates the job and waits for it to finish. [`GetAllQueryJobResultsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetAllQueryJobResultsAsync*) then returns the results one set at a time, retrieving each set as it is needed. Each set includes a header row.

```csharp
QueryJobInfo queryJob = await bulkClient.RunQueryJobAsync("SELECT Id, Name, Industry FROM Account");

if (queryJob.State != BulkJobState.JobComplete)
{
    throw new Exception($"Query job {queryJob.State}: {queryJob.ErrorMessage}");
}

await foreach (QueryJobResults results in bulkClient.GetAllQueryJobResultsAsync(queryJob.Id, maxRecords: 50000))
{
    Console.WriteLine($"{results.NumberOfRecords} records");
    // results.Csv
}
```

`maxRecords` limits the number of records in each set. If it isn't set, Salesforce picks the size of each set.

To include records deleted by a merge or delete, and archived Task and Event records, set `queryAll`:

```csharp
QueryJobInfo queryJob = await bulkClient.RunQueryJobAsync("SELECT Id, Name FROM Account", queryAll: true);
```

[`CreateQueryJobRequest`](xref:NetCoreForce.Client.BulkApi.CreateQueryJobRequest) also sets the column delimiter and line ending of the results:

```csharp
var request = new CreateQueryJobRequest("SELECT Id, Name FROM Account")
{
    ColumnDelimiter = BulkColumnDelimiter.Tab,
    LineEnding = BulkLineEnding.CRLF
};

QueryJobInfo queryJob = await bulkClient.RunQueryJobAsync(request);
```

Bulk API 2.0 queries don't support:
- GROUP BY, OFFSET or TYPEOF clauses
- aggregate functions such as `COUNT()`, or `FIELDS()`
- parent-to-child relationship subqueries - child-to-parent relationships, such as `Account.Name` on a Contact, are supported
- compound address and geolocation fields

### Streaming Query Results

For large result sets, [`GetQueryJobResultsStreamAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultsStreamAsync*) streams each set rather than loading it into memory. Pass the [`Locator`](xref:NetCoreForce.Client.BulkApi.QueryJobResultsStream.Locator) of each set to get the next one, until [`Done`](xref:NetCoreForce.Client.BulkApi.QueryJobResultsStream.Done):

```csharp
string locator = null;
int setNumber = 0;

do
{
    using (QueryJobResultsStream results = await bulkClient.GetQueryJobResultsStreamAsync(queryJob.Id, locator, maxRecords: 100000))
    using (FileStream file = File.Create($"accounts_{++setNumber}.csv"))
    {
        await results.Content.CopyToAsync(file);
        locator = results.Locator;
    }
}
while (locator != null);
```

### Parallel Query Results

With API version 58.0 and later, [`GetQueryJobResultPagesAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultPagesAsync*) returns URLs for the result sets, up to five at a time, so that they can be retrieved in parallel with [`GetQueryJobResultsByUrlAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultsByUrlAsync*):

```csharp
List<QueryJobResults> allResults = new List<QueryJobResults>();

QueryJobResultPages pages = await bulkClient.GetQueryJobResultPagesAsync(queryJob.Id);
while (true)
{
    QueryJobResults[] resultSets = await Task.WhenAll(
        pages.ResultPages.Select(page => bulkClient.GetQueryJobResultsByUrlAsync(page.ResultUrl)));
    allResults.AddRange(resultSets);

    if (pages.Done || string.IsNullOrEmpty(pages.NextRecordsUrl))
    {
        break;
    }

    pages = await bulkClient.GetNextQueryJobResultPagesAsync(pages.NextRecordsUrl);
}
```

[`GetQueryJobResultsByUrlStreamAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobResultsByUrlStreamAsync*) streams a result set instead.

Query results must be retrieved using the same API version that was used to create the job, otherwise Salesforce returns an error.

---

## Monitoring and Managing Jobs

### Job States

| State | Meaning |
|---|---|
| `Open` | Ingest jobs only. The job was created, and data can be uploaded. |
| `UploadComplete` | The job is queued for processing. For ingest jobs, all data has been uploaded. |
| `InProgress` | Salesforce is processing the job. |
| `JobComplete` | The job was processed. Ingest jobs can still have failed records. |
| `Failed` | The job could not be processed. See [`ErrorMessage`](xref:NetCoreForce.Client.BulkApi.BulkJobInfo.ErrorMessage). |
| `Aborted` | The job was aborted. |

`JobComplete`, `Failed` and `Aborted` are terminal states - [`IsTerminal`](xref:NetCoreForce.Client.BulkApi.BulkJobInfo.IsTerminal) is true once a job reaches one of them.

### Waiting for a Job

[`WaitForIngestJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.WaitForIngestJobAsync*) and [`WaitForQueryJobAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.WaitForQueryJobAsync*) check the job's state every 5 seconds by default, until it reaches a terminal state. The `Run...` methods accept the same options.

```csharp
using (CancellationTokenSource cts = new CancellationTokenSource())
{
    IngestJobInfo job = await bulkClient.WaitForIngestJobAsync(
        jobId,
        pollInterval: TimeSpan.FromSeconds(10),
        timeout: TimeSpan.FromHours(1),
        cancellationToken: cts.Token);
}
```

- A `TimeoutException` is thrown if the job hasn't finished within the timeout. The job keeps running in Salesforce - wait for it again, or abort it.
- Cancelling the token stops waiting with an `OperationCanceledException`, and also leaves the job running.

### Aborting and Deleting Jobs

```csharp
// stops a job that hasn't finished - records that were already processed are not rolled back
await bulkClient.AbortIngestJobAsync(jobId);

// deletes the job and its results
await bulkClient.DeleteIngestJobAsync(jobId);
```

Query jobs can only be aborted while they are `UploadComplete` or `InProgress`. Ingest jobs can be deleted once they are `UploadComplete` or in a terminal state, and query jobs once they are in a terminal state. Salesforce deletes jobs automatically 7 days after they finish.

### Listing Jobs

[`GetIngestJobsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetIngestJobsAsync*) and [`GetQueryJobsAsync`](xref:NetCoreForce.Client.BulkApi.BulkApiClient.GetQueryJobsAsync*) list the jobs in the org, up to 1000 per page:

```csharp
BulkJobList<IngestJobInfo> jobs = await bulkClient.GetIngestJobsAsync(jobType: "V2Ingest");
while (true)
{
    foreach (IngestJobInfo job in jobs.Records)
    {
        Console.WriteLine($"{job.Id} {job.Object} {job.Operation} {job.State}");
    }

    if (jobs.Done || string.IsNullOrEmpty(jobs.NextRecordsUrl))
    {
        break;
    }

    jobs = await bulkClient.GetNextIngestJobsAsync(jobs.NextRecordsUrl);
}
```

The lists can also include jobs from the original Bulk API (job type `Classic`). Their `State` and `ContentType` are null when the values aren't Bulk API 2.0 values.

---

## Error Handling

- **API errors** throw a [`ForceApiException`](xref:NetCoreForce.Client.ForceApiException), with the Salesforce `Errors` (error code and message) and the `HttpStatusCode`, the same as other NetCoreForce requests - see [Handling API Errors](examples.md#handling-api-errors). For example, getting a job that has been deleted returns `NOT_FOUND`, and aborting a completed job returns `INVALIDJOBSTATE`.
- **Failed records** don't throw an exception. Check `NumberRecordsFailed` on the job, and get the [failed results](#ingest-job-results).
- **Failed jobs** have the `Failed` state, with the reason in `ErrorMessage`.
- **Timeouts and cancellation** while waiting for a job throw `TimeoutException` and `OperationCanceledException`.

```csharp
try
{
    IngestJobInfo job = await bulkClient.RunIngestJobAsync(request, csv, timeout: TimeSpan.FromMinutes(30));

    if (job.State == BulkJobState.Failed)
    {
        Console.WriteLine($"Job failed: {job.ErrorMessage}");
    }
    else if (job.NumberRecordsFailed > 0)
    {
        string failedResults = await bulkClient.GetFailedResultsAsync(job.Id);
        // log or retry the failed records
    }
}
catch (ForceApiException ex)
{
    Console.WriteLine($"{ex.HttpStatusCode}: {ex.Errors?.FirstOrDefault()?.ErrorCode} {ex.Message}");
}
catch (TimeoutException)
{
    // the job is still running in Salesforce
}
```

---

## Limits

| Limit | Value |
|---|---|
| Data per ingest job | 150 MB after base64 encoding by Salesforce - upload no more than 100 MB |
| Data when creating a job with data | 100,000 characters |
| Records ingested per rolling 24 hours | 150,000,000 |
| Query jobs per rolling 24 hours | 10,000 |
| Query results per rolling 24 hours | 1 TB |
| Results and jobs are kept for | 7 days after the job finishes |

Salesforce processes ingest data in batches of 10,000 records, which count towards the org's daily batch allocation, shared with the original Bulk API. The org's current usage is available from [`GetOrganizationLimits`](xref:NetCoreForce.Client.ForceClient.GetOrganizationLimits) - see [Org Limits and API Versions](examples.md#org-limits-and-api-versions).

For the full details, see the Salesforce documentation: [Bulk API 2.0 and Bulk API Developer Guide](https://developer.salesforce.com/docs/platform/api-asynch/guide/bulk-api-2-0.html) and [Bulk API and Bulk API 2.0 Limits and Allocations](https://developer.salesforce.com/docs/platform/salesforce-app-limits-cheatsheet/guide/salesforce-app-limits-platform-bulkapi.html).
