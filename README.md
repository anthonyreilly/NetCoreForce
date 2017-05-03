# NetCoreForce 

## A .NET Standard and .NET Core Salesforce REST API toolkit and API wrapper

## This project is in Beta.
[CHANGELOG](CHANGELOG.md)
New features are being added.  
There is a possibilty of breaking changes in upcoming releases, although they should be minor if they do happen.

Currently targeting [.NET Standard 1.3](https://docs.microsoft.com/en-us/dotnet/articles/standard/library)

### Projects in this solution:
[NetCoreForce.Client](src/NetCoreForce.Client) - Main library  
[NetCoreForce.Client.Tests](src/NetCoreForce.Client.Tests) - Unit tests (offline/mocked)  
[NetCoreForce.FunctionalTests](src/NetCoreForce.FunctionalTests) - Online Unit tests (Needs valid login credentials)  
[NetCoreForce.ModelGenerator](src/NetCoreForce.ModelGenerator) - Optional tool for code generation of custom objects/fields.  
[NetCoreForce.Models](src/NetCoreForce.Models) [(README)](NetCoreForce.Models/README.md) - Optional library with a set of pre-generated standard models  
[SampleConsole](src/SampleConsole) - A simple .NET Core console app to demonstrate the library.

### Minimal project dependencies:  
[Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)  
[xUnit.net](https://www.nuget.org/packages/xunit)  

Using [semantic versioning](http://semver.org)

Feedback and suggestions welcome.

Licensed under the MIT license.
This project is not offered, sponsored or endorsed by Salesforce.

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

