---
_layout: landing
title: "NetCoreForce: Salesforce REST API Client for .NET"
_description: "NetCoreForce is a Salesforce REST API client library for .NET and C#: OAuth login, SOQL queries, CRUD, composite requests, and generated object models."
---

# NetCoreForce

## A Salesforce REST API client library for .NET and C#
*This project is not offered, sponsored, or endorsed by Salesforce.*

NetCoreForce lets .NET applications query, create, update and delete Salesforce records through the Salesforce REST API, with OAuth 2.0 login, SOQL and SOSL queries, composite requests, and strongly typed models for Salesforce objects.

![NuGet Version](https://img.shields.io/nuget/v/NetCoreForce.Client) ![NuGet Downloads](https://img.shields.io/nuget/dt/NetCoreForce.Client)

## Install

```
dotnet add package NetCoreForce.Client
dotnet add package NetCoreForce.Models
```

## Quick Start

```csharp
// Log in with the OAuth Client Credentials flow
ForceClient client = await ForceClient.FromClientCredentialsAsync(
    "your-client-id", "your-client-secret", "https://your-domain.my.salesforce.com/services/oauth2/token");

// Query records
List<SfAccount> accounts = await client.Query<SfAccount>("SELECT Id, Name FROM Account LIMIT 10");
```

- [Authentication](auth.md) - Client Credentials, Web Server, refresh token, and other login flows
- [Examples](examples.md) - CRUD, queries, upserts, composite requests, search, metadata and more
- [API Reference](api/NetCoreForce.Client.ForceClient.yml) - full `ForceClient` reference

## NuGet Packages
* [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/) - the Salesforce REST API client
* [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/) - pre-generated models for standard Salesforce objects
* [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/) - .NET CLI tool to generate models for your org, including custom objects and fields

### [CHANGELOG](https://github.com/anthonyreilly/NetCoreForce/blob/main/CHANGELOG.md)
  
  
# Features

---

## Authentication

Log in with the Salesforce OAuth 2.0 flows - see [Authentication](auth.md).

- **Client Credentials** - server-to-server login with a connected app, in one call with [`ForceClient.FromClientCredentialsAsync`](xref:NetCoreForce.Client.ForceClient.FromClientCredentialsAsync(System.String,System.String,System.String,System.String,System.Net.Http.HttpClient))
- **Web Server (Authorization Code)** - exchange an authorization code from the browser login for access and refresh tokens, with helpers to build the authorization URL
- **Refresh tokens** - get a new access token without the user logging in again, including support for refresh token rotation
- **Token introspection** - check whether an access token is still valid
- **Existing access tokens** - create a client from a token obtained elsewhere
- **Username-Password** - supported for existing integrations (deprecated by Salesforce)

---

## Queries

- **SOQL queries** into strongly typed objects with [`Query<T>`](xref:NetCoreForce.Client.ForceClient.Query``1(System.String,System.Boolean)) - large result sets are retrieved in full, following each batch automatically
- **Streaming large result sets** with [`QueryAsync<T>`](xref:NetCoreForce.Client.ForceClient.QueryAsync``1(System.String,System.Boolean,System.Nullable{System.Int32},System.Threading.CancellationToken)), which returns an `IAsyncEnumerable<T>` and only fetches the next batch when needed. Batch size and cancellation are supported.
- **Single record and count queries** - `QuerySingle<T>` and `CountQuery`
- **Deleted and archived records** with the `queryAll` option
- **Relationship queries** - parent fields (e.g. `Account.Name`) and child subqueries
- **Safe query building** - [`SoqlHelpers`](xref:NetCoreForce.Client.SoqlHelpers) escapes values for SOQL string literals, `LIKE` patterns and SOSL search terms, to prevent query injection

See [Examples](examples.md#nested-query-results) for nested results, [single record and count queries](examples.md#single-record-and-count-queries), and [building queries safely](examples.md#building-queries-safely).

---

## Records

- **Create, read, update and delete** single records - see [Create a Record](examples.md#create-a-record)
- **Retrieve specific fields** by record Id
- **Upsert by external ID** with `InsertOrUpdateRecord<T>` - see [Upsert by External ID](examples.md#upsert-by-external-id)
- **Set fields to null** explicitly on update - see [Setting a Field to Null](examples.md#setting-a-field-to-null)
- **Create-only and update-only fields** - read-only fields such as system fields are left out of create and update requests automatically, based on the `Createable` and `Updateable` attributes on the models

---

## Bulk and Composite Requests

- **Create multiple records** of one type in a single request - see [Create Multiple Records](examples.md#create-multiple-records)
- **Update multiple records**, of one or more types, in a single request - see [Update Multiple Records](examples.md#update-multiple-records)
- **Composite requests** - combine create, update, read and delete operations in one request, with references between them (e.g. create an Account and a Contact for it). See [Composite Requests](examples.md#composite-requests).

---

## Search

- **SOSL search**, returning typed results or generic records - see [SOSL Search](examples.md#sosl-search)

---

## Apex, Files and Org Information

- **Custom Apex REST endpoints** - POST to your own `@RestResource` classes with typed requests and responses. See [Custom Apex REST Endpoints](examples.md#custom-apex-rest-endpoints).
- **File and attachment downloads** - stream blob fields such as `ContentVersion.VersionData` and `Attachment.Body` without loading them fully into memory. See [Downloading Files and Attachments](examples.md#downloading-files-and-attachments).
- **Object metadata** - describe all objects, or the fields and relationships of one object. See [Object Metadata](examples.md#object-metadata).
- **Org limits, API versions and user info** - API usage limits, available REST API versions, a connection test, and the logged-in user's details. See [Org Limits and API Versions](examples.md#org-limits-and-api-versions).

---

## Object Models

- **Pre-generated models** for the standard Salesforce objects (e.g. `SfAccount`, `SfContact`, `SfCase`) in the [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/) package
- **Model generator** - the [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/) .NET CLI tool generates models from your own org, including custom objects and fields. See [Custom Objects and Fields](examples.md#custom-objects-and-fields).
- **Your own classes** - any class can be used for query results and records. Models are optional.

---

## Request Options

Standard Salesforce request headers are available through [`HeaderFormatter`](xref:NetCoreForce.Client.HeaderFormatter):
- **Call options** - client name and default namespace, e.g. for managed package fields
- **Query batch size**
- **Assignment rules** - turn automatic assignment rules on or off
- **If-Modified-Since** - only return data changed since a date

---

## Error Handling

- **API errors** throw [`ForceApiException`](xref:NetCoreForce.Client.ForceApiException), with the HTTP status code and the Salesforce error codes, messages and fields - see [Handling API Errors](examples.md#handling-api-errors)
- **Login errors** throw [`ForceAuthException`](xref:NetCoreForce.Client.ForceAuthException), with the OAuth error code (e.g. `invalid_grant`) - see [Authentication error handling](auth.md#error-handling)

---

## Security

- **HTTPS only** - credentials and access tokens are only ever sent over HTTPS
- **Credentials kept out of URLs** - client secrets, passwords and tokens are sent in request bodies or headers, never in URLs that could be logged
- **Request values validated** - object and field names, record Ids, API versions and paging URLs are validated, so they can't redirect a request or the access token to another resource or host
- **Query escaping helpers** to prevent SOQL and SOSL injection
- **Isolated JSON settings** - the library isn't affected by an application's global Newtonsoft.Json settings

---

## Connections and Performance

- **Shared, long-lived HttpClient** by default, reusing connections across requests and clients
- **DNS changes picked up** in long-running processes - pooled connections are periodically replaced (.NET 8+ and .NET Framework)
- **Compressed responses** (gzip/deflate)
- **Custom HttpClient and proxy support** - see [Custom HttpClient / Proxy Support](auth.md#custom-httpclient--proxy-support)
- **Async API** - all API calls are asynchronous, with `ConfigureAwait(false)`

---

## Platform Support

- .NET 8, .NET 9 and .NET 10
- .NET Standard 2.0 and 2.1
- .NET Framework 4.6.2, 4.7.2, 4.8 and 4.8.1
