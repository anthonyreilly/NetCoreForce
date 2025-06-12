---
_layout: landing
---



* [ForceClient](~/api/NetCoreForce.Client.ForceClient.yml)
    -[NetcoreForce.Client](~/api/NetCoreForce.Client.yml)


# NetCoreForce 

## A .NET Salesforce REST API integration library
*This project is not offered, sponsored, or endorsed by Salesforce.*

Targets .NET Standard 2.0 - this means it will be generally compatible with .NET Framework 4.6.1+ and .NET Core 2.0+  
For more info on .NET Standard 2.0 compatiblity [see the Microsoft documentation here](https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0)

Full tested support is for .NET Core 6.0 - 9.0 as tooling and tests target those.

![NuGet Downloads](https://img.shields.io/nuget/dt/NetCoreForce.Client)

[GitHub Repository](https://github.com/anthonyreilly/NetCoreForce)  

### NuGet Packages
* [NetCoreForce.Client](https://www.nuget.org/packages/NetCoreForce.Client/)
* [NetCoreForce.Models](https://www.nuget.org/packages/NetCoreForce.Models/)
* [NetCoreForce.ModelGenerator](https://www.nuget.org/packages/NetCoreForce.ModelGenerator/)

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



### Designed to minimize dependencies:
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) (JSON Serialization)
* [System.Text.Encodings.Web](https://www.nuget.org/packages/System.Text.Encodings.Web) (URL formatting)
* [Microsoft.Bcl.AsyncInterfaces](https://www.nuget.org/packages/Microsoft.Bcl.AsyncInterfaces/)
    - Only included in .netstandard2.0, .netcoreapp2.0 targets
    - Provides await using, async disposables

(Migration from Newtonsoft.Json to System.Text.Json is planned)

Feedback and suggestions welcome.

Licensed under the MIT license.


