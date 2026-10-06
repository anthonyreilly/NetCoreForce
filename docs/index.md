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

## Library Targets

The primary target is .NET Standard 2.0 to provide the widest possible support.
- .NET Standard 2.0 for widest possible support including .NET Framework 4.6.2+
- .NET Standard 2.1 for newer .NET Core versions

For more info on .NET Standard compatibility [see the Microsoft documentation here](https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0)

Full target list
- .NET Standard 2.0
- .NET Standard 2.1
- .NET 8.0
- .NET 9.0
- .NET 10.0
- .NET Framework 4.6.2
- .NET Framework 4.7.2
- .NET Framework 4.8
- .NET Framework 4.8.1

All possible frameworks are specifically targeted so that conditional compilation can be done where required.

Full tested support is for .NET 8.0 - 10.0 as tooling and tests target those.
Legacy .NET Frameworks are partially tested.

## NuGet Packages
* [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/) - the Salesforce REST API client
* [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/) - pre-generated models for standard Salesforce objects
* [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/) - .NET CLI tool to generate models for your org, including custom objects and fields

### [CHANGELOG](https://github.com/anthonyreilly/NetCoreForce/blob/main/CHANGELOG.md)

[GitHub Repository](https://github.com/anthonyreilly/NetCoreForce)

CI main:
[![CI](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml)
CI dev:
[![CI](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml/badge.svg?branch=dev)](https://github.com/anthonyreilly/NetCoreForce/actions/workflows/ci.yml)

## Projects in this solution
* [NetCoreForce.Client](https://github.com/anthonyreilly/NetCoreForce/tree/main/src/NetCoreForce.Client)
    - Main library
* [NetCoreForce.Client.Tests](https://github.com/anthonyreilly/NetCoreForce/tree/main/src/NetCoreForce.Client.Tests)
    - Unit tests (offline/mocked)
* [NetCoreForce.FunctionalTests](https://github.com/anthonyreilly/NetCoreForce/tree/main/src/NetCoreForce.FunctionalTests)
    - Online Unit tests (Needs valid login credentials)
* [NetCoreForce.ModelGenerator](https://github.com/anthonyreilly/NetCoreForce/tree/main/src/NetCoreForce.ModelGenerator)
    - Check [README](https://github.com/anthonyreilly/NetCoreForce/blob/main/src/NetCoreForce.ModelGenerator/README.md) for docs
    - Optional custom dotnet-cli tool for code generation of custom objects/fields.
* [NetCoreForce.Models](https://github.com/anthonyreilly/NetCoreForce/tree/main/src/NetCoreForce.Models)
    - Check [README](https://github.com/anthonyreilly/NetCoreForce/blob/main/src/NetCoreForce.Models/README.md) for docs
    - Optional library with a set of pre-generated standard models
* [SampleConsole](https://github.com/anthonyreilly/NetCoreForce/tree/main/src/SampleConsole)
    - A simple .NET console app to demonstrate the library.

## Designed to minimize dependencies
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) (JSON Serialization)
* [System.Text.Encodings.Web](https://www.nuget.org/packages/System.Text.Encodings.Web) (URL formatting)
* [Microsoft.Bcl.AsyncInterfaces](https://www.nuget.org/packages/Microsoft.Bcl.AsyncInterfaces/)
    - Only included in .NET Standard 2.0 and .NET Framework targets
    - Provides await using, async disposables

(Migration from Newtonsoft.Json to System.Text.Json is planned)

Feedback and suggestions welcome.

Licensed under the MIT license.
