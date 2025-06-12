# NetCoreForce 

## A .NET Standard and .NET Core Salesforce REST API integration library
*This project is not offered, sponsored, or endorsed by Salesforce.*

Targets:  
    - .NET Standard 2.0 : widest possible support including .NET Framework 4.6.1+ and .NET Core 2.0+  
    - .NET Standard 2.1 : for newer .NET Core versions

For more info on .NET Standard compatiblity [see the Microsoft documentation here](https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0)

Full tested support is for .NET Core 6.0 - 9.0 as tooling and tests target those.

![NuGet Downloads](https://img.shields.io/nuget/dt/NetCoreForce.Client)  

### [CHANGELOG](CHANGELOG.md)  

CI main:  
[![CI](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml)  
CI dev:  
[![CI](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml/badge.svg?branch=dev)](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml)



### Projects in this solution:
* [NetCoreForce.Client](src/NetCoreForce.Client)
    - Main library  
* [NetCoreForce.Client.Tests](src/NetCoreForce.Client.Tests)
    - Unit tests (offline/mocked)  
* [NetCoreForce.FunctionalTests](src/NetCoreForce.FunctionalTests)
    - Online Unit tests (Needs valid login credentials)  
* [NetCoreForce.ModelGenerator](src/NetCoreForce.ModelGenerator)
    - Check [README](src/NetCoreForce.ModelGenerator/README.md) for docs
    - Optional custom dotnet-cli tool for code generation of custom objects/fields.  
* [NetCoreForce.Models](src/NetCoreForce.Models)
    - Check [README](src/NetCoreForce.Models/README.md) for docs
    - Optional library with a set of pre-generated standard models  
* [SampleConsole](src/SampleConsole)
    - A simple .NET Core console app to demonstrate the library.

### NuGet Packages
* [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/)
* [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/)
* [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/)

### Designed to minimize dependencies:
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) (JSON Serialization)
* [System.Text.Encodings.Web](https://www.nuget.org/packages/System.Text.Encodings.Web) (URL formatting)
* [Microsoft.Bcl.AsyncInterfaces](https://www.nuget.org/packages/Microsoft.Bcl.AsyncInterfaces/)
    - Only included in .netstandard2.0, .netcoreapp2.0 targets
    - Provides await using, async disposables

(Migration from Newtonsoft.Json to System.Text.Json is planned)

Feedback and suggestions welcome.

Licensed under the MIT license.


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
