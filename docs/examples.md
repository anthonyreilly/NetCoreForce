# Examples

Usage examples for common tasks, starting with everyday CRUD and query operations and moving on to less common ones. For other ways to log in and initialize the client, see [Authentication](auth.md).

The examples use the pre-generated models from [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/) (e.g. `SfAccount`, `SfCase`, `SfContact`). See [Custom Objects and Fields](#custom-objects-and-fields) to generate models for your own org.

---

## Basic Usage

Authenticate with [`AuthenticationClient`](xref:NetCoreForce.Client.AuthenticationClient), create a [`ForceClient`](xref:NetCoreForce.Client.ForceClient), then retrieve, update, delete and query records with
[```GetObjectById<T>```](xref:NetCoreForce.Client.ForceClient.GetObjectById``1(System.String,System.String,System.Collections.Generic.List{System.String})),
[```UpdateRecord<T>```](xref:NetCoreForce.Client.ForceClient.UpdateRecord``1(System.String,System.String,``0,System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.List{System.String},System.Boolean)),
[```DeleteRecord```](xref:NetCoreForce.Client.ForceClient.DeleteRecord(System.String,System.String)) and
[```Query<T>```](xref:NetCoreForce.Client.ForceClient.Query``1(System.String,System.Boolean)).

```csharp
//Initialize the authentication client
AuthenticationClient auth = new AuthenticationClient();

//Pass in the login information
await auth.UsernamePasswordAsync("your-client-id", "your-client-secret", "your-username", "your-password", "token-endpoint-url");

//the AuthenticationClient object will then contain the instance URL and access token to be used in each of the API calls
ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);

//Retrieve an object by Id
SfAccount acct = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, "001i000002C8QTI");
//Modify the record and update
acct.Description = "Updated Description";
await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, acct.Id, acct);
//Delete the record
await client.DeleteRecord(SfAccount.SObjectTypeName, acct.Id);

//Get the results of a SOQL query
List<SfCase> cases = await client.Query<SfCase>("SELECT Id,CaseNumber,Account.Name,Contact.Name FROM Case");
```

---

## Create a Record

Use [```CreateRecord<T>```](xref:NetCoreForce.Client.ForceClient.CreateRecord``1(System.String,``0,System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.List{System.String},System.Boolean)) to insert a new record. The returned [`CreateResponse`](xref:NetCoreForce.Client.Models.CreateResponse) contains the new record's Id.

```csharp
SfAccount newAccount = new SfAccount
{
    Name = "Acme Corporation",
    Description = "New customer"
};

CreateResponse createResponse = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, newAccount);
string newAccountId = createResponse.Id;
```

Only fields that are createable and not null are included in the request, so you only need to set the fields you want to populate.

---

## Retrieve Specific Fields by Id

By default [```GetObjectById<T>```](xref:NetCoreForce.Client.ForceClient.GetObjectById``1(System.String,System.String,System.Collections.Generic.List{System.String})) retrieves all fields. Pass a list of field names to retrieve only the fields you need.

```csharp
List<string> fields = new List<string> { "Id", "Name", "Description" };

SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, "001i000002C8QTI", fields);
```

---

## Upsert by External ID

[```InsertOrUpdateRecord<T>```](xref:NetCoreForce.Client.ForceClient.InsertOrUpdateRecord``1(System.String,System.String,System.String,``0,System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.List{System.String},System.Boolean)) creates a record if no record matches the external ID value, or updates the existing record if one does. The field must be marked as an External ID in Salesforce.

```csharp
SfAccount account = new SfAccount
{
    Name = "Acme Corporation",
    Description = "Synced from ERP"
};

UpsertResponse upsertResponse = await client.InsertOrUpdateRecord<SfAccount>(SfAccount.SObjectTypeName, "ERP_Id__c", "ERP-10042", account);

if (upsertResponse.Created)
{
    // a new record was created, upsertResponse.Id contains the new Id
}
else
{
    // an existing record was updated
}
```

If the external ID value matches more than one record, a [`ForceApiException`](xref:NetCoreForce.Client.ForceApiException) is thrown and its `ObjectUrls` property lists the matching records.

---

## Setting a Field to Null

Null properties are not serialized by default, so setting a property to `null` and calling `UpdateRecord` will leave the field unchanged in Salesforce. To clear a field, set it to `null` and include its name in `fieldsToNull`:

```csharp
SfAccount account = await client.GetObjectById<SfAccount>(SfAccount.SObjectTypeName, "001i000002C8QTI");
account.Description = null;

List<string> fieldsToNull = new List<string> { "Description" };
await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, account.Id, account, fieldsToNull: fieldsToNull);
```

`fieldsToNull` is also available on `CreateRecord`, `CreateMultiple`, `UpdateRecords` and `InsertOrUpdateRecord`.

---

## Nested Query Results

When you include related objects in a SOQL query:
```
SELECT Id,CaseNumber,Account.Name,Contact.Name FROM Case
```

And get the results via the client, you can then access the related objects and fields included in the query in a fluent manner.
```csharp
List<SfCase> cases = await client.Query<SfCase>("SELECT Id,CaseNumber,Account.Name,Contact.Name FROM Case");
SfCase firstCase = cases[0];
string caseNumber = firstCase.CaseNumber;
string caseAccountName = firstCase.Account.Name;
string caseContactName = firstCase.Contact.Name;
```

Nested queries are not fully supported - the subquery results will not be complete if they exceed the batch size as the NextRecordsUrl in the subquery results is not being acted upon. Instead use the relationship syntax in the example above.
```
// *NOT* fully supported
SELECT Id,CaseNumber, (Select Contact.Name from Account) FROM Case
```

---

## Single Record and Count Queries

When you expect at most one result, [```QuerySingle<T>```](xref:NetCoreForce.Client.ForceClient.QuerySingle``1(System.String,System.Boolean)) returns the record directly, or `null` if nothing matched. It throws an exception if the query returns more than one record.

```csharp
SfCase singleCase = await client.QuerySingle<SfCase>("SELECT Id,CaseNumber,Subject FROM Case WHERE CaseNumber = '00001001'");

if (singleCase != null)
{
    // record found
}
```

To get a record count without retrieving any records, use [```CountQuery```](xref:NetCoreForce.Client.ForceClient.CountQuery(System.String,System.Boolean)). The query must start with `SELECT COUNT() FROM`.

```csharp
int openCaseCount = await client.CountQuery("SELECT COUNT() FROM Case WHERE IsClosed = false");
```

---

## Including Deleted Records

Set `queryAll` to `true` to include deleted and archived records in the results. This is available on `Query`, `QuerySingle`, `QueryAsync` and `CountQuery`.

```csharp
List<SfAccount> deletedAccounts = await client.Query<SfAccount>("SELECT Id, Name FROM Account WHERE IsDeleted = true", queryAll: true);
```

---

## Asynchronous Batch Processing

[```Query<T>```](xref:NetCoreForce.Client.ForceClient.Query``1(System.String,System.Boolean)) will retrieve the full result set before returning. By default, results are returned in batches of 2000.
In cases where you are working with large result sets, you may want to use
[```QueryAsync<T>```](xref:NetCoreForce.Client.ForceClient.QueryAsync``1(System.String,System.Boolean,System.Nullable{System.Int32},System.Threading.CancellationToken))
to retrieve the batches asynchronously for better performance.

```csharp
// First create the async enumerable. At this point, no query has been executed.
// batchSize can be omitted to use the default (usually 2000), or given a custom value between 200 and 2000.
IAsyncEnumerable<SfContact> contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id, Name FROM Contact ", batchSize: 200);

// Get the enumerator, in a using block for proper disposal
await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
{
    // MoveNext() will execute the query and get the first batch of results.
    // Once the initial result batch has been exhausted, the remaining batches, if any, will be retrieved.
    while (await contactsEnumerator.MoveNextAsync())
    {
        SfContact contact = contactsEnumerator.Current;
        // process your results
    }
}
```

---

## Handling API Errors

API calls throw a [`ForceApiException`](xref:NetCoreForce.Client.ForceApiException) when Salesforce returns an error. The `Errors` property contains the error details returned by the API.

```csharp
try
{
    await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, account.Id, account);
}
catch (ForceApiException ex)
{
    Console.WriteLine($"Request failed ({ex.HttpStatusCode}): {ex.Message}");

    foreach (ErrorResponse error in ex.Errors)
    {
        Console.WriteLine($"{error.ErrorCode}: {error.Message} Fields: {string.Join(", ", error.Fields ?? new List<string>())}");
    }
}
```

Authentication failures throw a [`ForceAuthException`](xref:NetCoreForce.Client.ForceAuthException) instead. See [Authentication - Error Handling](auth.md#error-handling).

---

## Custom Objects and Fields

The models in NetCoreForce.Models only include standard objects and fields. To work with custom objects and fields, generate models for your org with the [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/) CLI tool:

```
dotnet tool install --global NetCoreForce.ModelGenerator

NetCoreForce.ModelGenerator generate -p Sf -r -c -n MyProject.Models -d ./Models
```

This generates classes prefixed with `Sf`, including referenced objects (`-r`) and custom objects and fields (`-c`), in the `MyProject.Models` namespace. The generated classes are used the same way as the pre-generated models:

```csharp
List<SfInvoice__c> invoices = await client.Query<SfInvoice__c>("SELECT Id, Name, Amount__c FROM Invoice__c");
```

See the [ModelGenerator README](https://github.com/anthonyreilly/NetCoreForce/blob/main/src/NetCoreForce.ModelGenerator/README.md) for all options.

---

## Create Multiple Records

[```CreateMultiple```](xref:NetCoreForce.Client.ForceClient.CreateMultiple(System.String,System.Collections.Generic.List{NetCoreForce.Client.Models.SObject},System.Boolean,System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.List{System.String},System.Boolean)) creates up to 200 records of the same type in a single request.

```csharp
List<SObject> newAccounts = new List<SObject>
{
    new SfAccount { Name = "First Account" },
    new SfAccount { Name = "Second Account" }
};

SObjectTreeResponse response = await client.CreateMultiple(SfAccount.SObjectTypeName, newAccounts);

foreach (SObjectTreeResult result in response.Results)
{
    // result.ReferenceId is the zero-based index of the record in the request
    // result.Id is the new record's Id
}
```

By default, the reference Id for each record is set to its index in the list. To use your own reference Ids, set `Attributes` (with `Type` and `ReferenceId`) on each record and pass `autoFillAttributes: false`.

---

## Update Multiple Records

[```UpdateRecords```](xref:NetCoreForce.Client.ForceClient.UpdateRecords(System.Collections.Generic.List{NetCoreForce.Client.Models.SObject},System.Boolean,System.Collections.Generic.Dictionary{System.String,System.String},System.Collections.Generic.List{System.String},System.Boolean)) updates up to 200 records in a single request. The records can be of different types. Each record must have an `Id` and its `Attributes.Type` set. Records retrieved with `GetObjectById` or `Query` already have these populated.

```csharp
List<SfAccount> accounts = await client.Query<SfAccount>("SELECT Id, Description FROM Account WHERE Industry = 'Energy' LIMIT 200");

foreach (SfAccount account in accounts)
{
    account.Description = "Energy sector customer";
}

// allOrNone: true rolls back all updates if any record fails
List<UpsertResponse> responses = await client.UpdateRecords(accounts.Cast<SObject>().ToList(), allOrNone: true);

bool allSucceeded = responses.All(r => r.Success);
```

---

## SOSL Search

Use [```Search<T>```](xref:NetCoreForce.Client.ForceClient.Search``1(System.String)) to run a SOSL search. The type `T` should match the object in the `RETURNING` clause.

```csharp
SearchResult<SfAccount> result = await client.Search<SfAccount>("FIND {Acme} IN ALL FIELDS RETURNING Account (Id, Name)");

foreach (SfAccount account in result.SearchRecords)
{
    // process results
}
```

The untyped [```Search```](xref:NetCoreForce.Client.ForceClient.Search(System.String)) overload returns [`SObjectGeneric`](xref:NetCoreForce.Client.Models.SObjectGeneric) records, which is useful for searches across several object types. Each record has an `Id`, and `Attributes.Type` identifies the object type.

```csharp
SearchResult<SObjectGeneric> result = await client.Search("FIND {Acme}");

foreach (SObjectGeneric record in result.SearchRecords)
{
    Console.WriteLine($"{record.Attributes.Type}: {record.Id}");
}
```

For more on SOSL see the Salesforce Documentation: [Salesforce Object Search Language (SOSL)](https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_sosl.htm)

---

## Composite Requests

[```ExecuteCompositeRecords```](xref:NetCoreForce.Client.ForceClient.ExecuteCompositeRecords(System.Collections.Generic.List{NetCoreForce.Client.Models.CompositeSObject},System.Boolean,System.Boolean,System.Collections.Generic.Dictionary{System.String,System.String})) sends multiple create, update, read and delete operations in a single request. Each operation is a [`CompositeSObject`](xref:NetCoreForce.Client.Models.CompositeSObject):
- `Method = CompositeMethod.Write` without an `Id` creates a record, with an `Id` it updates the record
- `Method = CompositeMethod.Read` or `CompositeMethod.Delete` with an `Id` reads or deletes the record
- `ReferenceId` identifies each operation in the response

```csharp
List<CompositeSObject> operations = new List<CompositeSObject>
{
    new CompositeSObject
    {
        Type = SfAccount.SObjectTypeName,
        Method = CompositeMethod.Write,
        ReferenceId = "newAccount",
        SObject = new SfAccount { Name = "New Account" }
    },
    new CompositeSObject
    {
        Type = SfAccount.SObjectTypeName,
        Method = CompositeMethod.Write,
        Id = "001i000002C8QTI",
        ReferenceId = "updateAccount",
        SObject = new SfAccount { Description = "Updated via composite request" }
    },
    new CompositeSObject
    {
        Type = SfContact.SObjectTypeName,
        Method = CompositeMethod.Delete,
        Id = "003i000001AbCdE",
        ReferenceId = "deleteContact"
    }
};

CompositeRequestResponse response = await client.ExecuteCompositeRecords(operations, allOrNone: true);

foreach (CompositeSubrequestResponse subResponse in response.CompositeResponse)
{
    Console.WriteLine($"{subResponse.ReferenceId}: {subResponse.HttpStatusCode}");
}
```

---

## Custom Apex REST Endpoints

Call a custom Apex REST endpoint with [```ExecuteApexPost<TRequest, TResponse>```](xref:NetCoreForce.Client.ForceClient.ExecuteApexPost``2(System.String,``0,System.Collections.Generic.Dictionary{System.String,System.String})). Pass the resource path relative to `/services/apexrest/`, e.g. `DuplicateCheck` for `/services/apexrest/DuplicateCheck`.

```csharp
public class DuplicateCheckRequest
{
    public string Email { get; set; }
}

public class DuplicateCheckResponse
{
    public bool IsDuplicate { get; set; }
    public string ExistingContactId { get; set; }
}

DuplicateCheckResponse result = await client.ExecuteApexPost<DuplicateCheckRequest, DuplicateCheckResponse>(
    "DuplicateCheck",
    new DuplicateCheckRequest { Email = "jane@example.com" });
```

---

## Downloading Files and Attachments

Binary content, such as an Attachment `Body` or ContentVersion `VersionData`, is retrieved as a stream with [```BlobRetrieveStream```](xref:NetCoreForce.Client.ForceClient.BlobRetrieveStream(System.String,System.String,System.String)). The content is streamed rather than loaded into memory.

```csharp
using (Stream blobStream = await client.BlobRetrieveStream("ContentVersion", "068i0000001AbCdE", "VersionData"))
using (FileStream fileStream = File.Create("download.pdf"))
{
    await blobStream.CopyToAsync(fileStream);
}
```

If you already have the relative blob URL from a record, e.g. `/services/data/v64.0/sobjects/Attachment/00Pi000000AbCdE/Body`, pass it to the [```BlobRetrieveStream(string)```](xref:NetCoreForce.Client.ForceClient.BlobRetrieveStream(System.String)) overload instead.

---

## Object Metadata

List the objects available to the current user with [```DescribeGlobal```](xref:NetCoreForce.Client.ForceClient.DescribeGlobal):

```csharp
DescribeGlobal describeGlobal = await client.DescribeGlobal();

foreach (SObjectDescribeBasic sObject in describeGlobal.SObjects.Where(o => o.Custom))
{
    Console.WriteLine($"{sObject.Name} ({sObject.Label})");
}
```

Get the full metadata for an object, including fields and picklist values, with [```GetObjectDescribe```](xref:NetCoreForce.Client.ForceClient.GetObjectDescribe(System.String)):

```csharp
SObjectDescribeFull accountDescribe = await client.GetObjectDescribe("Account");

foreach (SObjectFieldMetadata field in accountDescribe.Fields)
{
    Console.WriteLine($"{field.Name} ({field.Type}) updateable: {field.Updateable}");

    if (field.Type == "picklist")
    {
        foreach (PickListValue value in field.PicklistValues.Where(v => v.Active))
        {
            Console.WriteLine($"  {value.Value}");
        }
    }
}
```

[```GetObjectBasicInfo```](xref:NetCoreForce.Client.ForceClient.GetObjectBasicInfo(System.String)) returns basic object metadata and a list of recent items for that object.

---

## Org Limits and API Versions

Check your org's API usage and other limits with [```GetOrganizationLimits```](xref:NetCoreForce.Client.ForceClient.GetOrganizationLimits). This requires the View Setup and Configuration permission.

```csharp
OrganizationLimits limits = await client.GetOrganizationLimits();

Console.WriteLine($"Daily API requests remaining: {limits.DailyApiRequests.Remaining} of {limits.DailyApiRequests.Max}");
```

List the REST API versions available on your instance with [```GetAvailableRestApiVersions```](xref:NetCoreForce.Client.ForceClient.GetAvailableRestApiVersions(System.String)):

```csharp
List<SalesforceVersion> versions = await client.GetAvailableRestApiVersions();
SalesforceVersion latest = versions.Last();

Console.WriteLine($"Latest API version: {latest.Version} ({latest.Label})");
```
