# Getting Started



### Basic Usage Example

```csharp
///Initialize the authentication client
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

### Nested Query Results

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
"SELECT Id,CaseNumber, (Select Contact.Name from Account) FROM Case"
```

### Asynchronous Batch Processing

Query<T> method will retrieve the full result set before returning. By default, results are returned in batches of 2000.
In cases where you are working with large result sets, you may want to use QueryAsync<T> to retrieve the batches asynchronously for better performance.

```csharp
// First create the async enumerable. At this point, no query has been executed.
// batchSize can be omitted to use the default (usually 2000), or given a custom value between 200 and 2000.
IAsyncEnumerable<SfContact> contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id, Name FROM Contact ", batchSize: 200);

// Get the enumerator, in a using block for proper disposal
await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
{
    // MoveNext() will execute the query and get the first batch of results.
    // Once the inital result batch has been exhausted, the remaining batches, if any, will be retrieved.
    while (await contactsEnumerator.MoveNextAsync())
    {
        SfContact contact = contactsEnumerator.Current;
        // process your results
    }
}
```