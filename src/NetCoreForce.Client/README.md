# NetCoreForce.Client

NetCoreForce.Client is a Salesforce REST API client library for .NET and C#, for querying, creating, updating and deleting Salesforce records from .NET 8-10, .NET Standard and .NET Framework applications.

Documentation: [https://netcoreforce.com/](https://netcoreforce.com/)

## Install

```
dotnet add package NetCoreForce.Client
```

Optional companion packages:
- [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/) - pre-generated models for standard Salesforce objects (e.g. `SfAccount`, `SfContact`)
- [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/) - .NET CLI tool to generate models for your org, including custom objects and fields

## Quick Start

```csharp
// Log in with the OAuth Client Credentials flow
ForceClient client = await ForceClient.FromClientCredentialsAsync(
    "your-client-id", "your-client-secret", "https://your-domain.my.salesforce.com/services/oauth2/token");

// Query records
List<SfAccount> accounts = await client.Query<SfAccount>("SELECT Id, Name FROM Account LIMIT 10");

// Create, update and delete
CreateResponse created = await client.CreateRecord<SfAccount>(SfAccount.SObjectTypeName, new SfAccount { Name = "Acme" });
await client.UpdateRecord<SfAccount>(SfAccount.SObjectTypeName, created.Id, new SfAccount { Description = "Updated" });
await client.DeleteRecord(SfAccount.SObjectTypeName, created.Id);
```

Other login flows (Web Server, refresh token, existing access token) are covered in the [Authentication docs](https://netcoreforce.com/auth.html). For more usage examples, see the [Examples](https://netcoreforce.com/examples.html).

## Features

- OAuth 2.0 login: Client Credentials, Web Server (authorization code), refresh token, Username-Password, and token introspection
- Create, read, update, delete and upsert by external ID
- SOQL queries, including streaming large result sets with `QueryAsync` (`IAsyncEnumerable`)
- SOSL search
- Multiple records per request: sObject Tree, sObject Collections, and composite requests
- Blob/file downloads, custom Apex REST endpoints, and object metadata (describe), limits and API versions
- `SoqlHelpers` for safely escaping untrusted values in SOQL and SOSL queries

## Target Frameworks

- .NET Standard 2.0 and 2.1
- .NET 8.0, 9.0 and 10.0
- .NET Framework 4.6.2, 4.7.2, 4.8 and 4.8.1

Tested on .NET 8.0 - 10.0, with partial testing on .NET Framework.

## What's New in v6

- Added .NET 10.0 and .NET Framework 4.8.1 targets, and removed .NET Core 3.1 and .NET 5.0 - 7.0 targets
- Added Client Credentials login via `ForceClient.FromClientCredentialsAsync`
- Record IDs and object/field names are validated to prevent URL path injection
- Added `SoqlHelpers` for escaping values in SOQL and SOSL queries
- Default Salesforce API version is now v67.0

See the [CHANGELOG](https://github.com/anthonyreilly/NetCoreForce/blob/main/CHANGELOG.md) for full details, including breaking changes.

## Links

- [Documentation](https://netcoreforce.com/)
- [GitHub repository](https://github.com/anthonyreilly/NetCoreForce)
- [Issues](https://github.com/anthonyreilly/NetCoreForce/issues)

Licensed under the MIT license.
