# Changelog

### 2025-06-10 v5.0.0

* feat: branched off and removed LINQ project, as it is unlikely to become production ready in the new future
* test: updated functional test in NullValueTests to avoid duplicate error on create
* test: updated packages, updated deprecated async void methods
* build, test, and target updates
    - Set library targets to .NET Standard 2.0 & 2.1, .NET Core 3.1, .NET 6.0-9.0, .NET Framework 4.6.2, 4.7.2, 4.8
    - Tests target .NET Core 6.0-9.0

### 2025-02-24 v5.0.0-Beta

* feat: Add ConfigureAwait(false) to await calls (PR #71 jtsai-osa)
* feat: Pass through HttpClient from ForceClient to AuthenticationClient (PR #76 saithis)
* feat: Add more composite endpoints. Add token introspection. Add call for custom APEX code (PR #72 phess101)
* build: Add .NET 9 build targets

### 2024-05-24 v4.1.0

* fix: Update PicklistValue.Validfor to byte[]

### 2024-03-29 v4.1.0-Beta

* feat: added .net8.0 build and test targets
* feat: add client credentials flow
* fix: Add field CalculatedFormula to SObjectFieldMetadata
* fix: Add field AdditionalData to ErrorResponse

### 2023-06-06 v4.0.0

* feat: add FieldsToNull and IngoreNulls options to control null field serialization and to allow explicitly setting fields to null
* chore: updated older API references to v57.0
* feat: updated pregenerated models to API v57.0
* test: updated CreateMultiple test
* build: updated package references to latest
* build: update GitHub actions to latest
* build: clean up EOL framework warnings, add conditional includes for .net6.0 and older builds

### 2023-01-26 v4.0.0 Beta2

* feat: Partial sObjectTree API resource support - added CreateMultipleRecords to create multiple records in a single request
    - see https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/dome_composite_sobject_tree_flat.htm
* feat: updated ExternalIdInsertAndUpdate to return new UpsertResponse object that adds the Created flag
    - this includes a minor breaking change, as this method originally returned a CreateResponse object. Calls can be updated to use the UpsertResponse object without any further breaking changes as it is inherited from the CreateResponse object.
* feat: added .net 7 build and test target
* feat: added BlobRetrieveStream() to download blob data attached to records
* fix: update Newtonsoft.json to v13 
* fix: Syntax error in error message generator
* feat: Update ForceClient to use static shared HttpClient by default, unless custom instance is specified
* feat: Add FieldsToNull parameter to updates to allow explicitly setting fields to null. (Note: this requries both setting the value itself to null, in addition to adding the property name to the list)

### 2022-01-13 v3.1.0

* feat: add .NET 6 support
* build: add net6.0 build and test targets
* build: on MacOS only target .net6.0 (Workaround for issues developing muti-arch on M1 processor machines)
* chore: remove unnecessary exception catching and re-throws

### 2021-05-07 v3.0.1

* Fix: incorrect URI when calling organization limits, make URI formatting more consistent
* ci: Add missing URI formatting tests
* Dependabot: Bump System.Text.Encodings.Web from 5.0.0 -> 5.0.1

### 2021-02-09 v3.0.0

* v3 release, no changes from Beta2

### 2021-01-28 v3.0.0 Beta2

* NetCoreForce.Client: Removed System.Interactive.Async dependency
    - Migrated to use native async streams
    - netstandard2.0 client support via Microsoft.Bcl.AsyncInterfaces
* NetCoreForce.Client: QueryAsyncEnumerator(), can be replaced by calling GetAsyncEnumerator() on the results of QueryAsync()

### 2021-01-27 v3.0.0 Beta

This a major update, and introduces several breaking changes. It resolves several compatibilty issues with newer .net core versions.

* Drops support for netstandard 1.x
    - If you require 1.x support, you will need to remain on NetCoreForce 2.x
* Libraries target netstandard2.0 and netstandard2.1
* Tests and apps target netcoreapp2.1 and netcoreapp3.1
* Updated System.Interactive.Async from v3 to v5
    - When using the asynchronous batch processing features, you will need update to the async versions of the method calls, For example:
        - GetEnumerator -> GetAsyncEnumerator
        - ToList -> To ListAsync
        - SingleOrDefault -> SingleOrDefaultAsync
        - MoveNext -> MoveNextAsync
    - When upgrading, you'll get a clear compiler error that the method isn't available, and switching to the one that has "async" in the method name should then compile.
* Added Microsoft.Bcl.AsyncInterfaces to provide async disposable support for .netstandard2.0 targets

* Converted NetCoreForce.ModelGenerator to be packaged as a global .NET CLI tool.
    - See the [ReadMe](src/NetCoreForce.Models/README.md) for additional details.

### 2021-01-01 v2.7.0

* Client: Added support for updating multiple objects
* Client: Added backwards-compatible serialization contract resolver to allow inclusion of object ID on patch requests
* Linq: Added support for filtering on booleans
* Client: Added support for NetStandard2.1 (netcoreapp3.x)
* Models: Update standard models to SF API v50 - Winter '21
* ModelGenerator: Fixed issue where API version in config file was being ignored, and default of v44 was used instead
* Build: streamline build targets to use variables from build.props

### 2019-12-17 v2.6.0

* Fix: Failure to handle/parse HTTP 300 - multiple choices response when update finds multiple external IDs
* Fix: Error message formatting in JsonClient - was prepending "unable to parse" message on all ForceApiExceptions
* Client: Added SObjectUri model object to parse returned object URIs
* Client: Added Sforce-Call-Options header support
* Linq: Added IOrderedAsyncQueryable to SalesforceQuery
* Linq: Fixed broken OrderBy/OrderByDescending by adding required interfaces; Added unit tests for OrderBy/OrderByDescending
* Linq: Added missing SelectType parameter in force client extension
* Linq: Added include/exclude for multi-picklist support

### 2018-11-18 v2.5.0

* Fix: Implemeneted missing ForceClient.TestConnection() functionality. Now does a simple call to an instance's Versions resource to test connectivity and that the API is responding.
* Minor breaking change: Removed SalesforceVersions model object, since it did not match array of versions objects returned by the Versions resource. Use List<SalesforceVersion> instead.
* Client: Added ForceClient.GetAvailableRestApiVersions() to retrieve the available REST API versions on the current instance using the Versions resource.
* Client (internal): Added the deserializeResponse option to the JsonClient, to optionally deserialize response content. Primarily for testing purposes or cases where the returned content can be ignored for performance reasons.
* Update default API version to v44.0

### 2018-10-09 v2.4.0

* Update InsertOrUpdateRecord<T> operation to return a CreateReponse object to indicate if a new object was created, or an existing object was updated.

### 2018-09-18 v2.3.0

* Add "Insert or Update (Upsert) a Record Using an External ID" operation, using the SObject Rows by External ID resource. For details on usage see https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/resources_sobject_upsert.htm
* Minor breaking change: Changed IssuedAt property of AccessTokenResponse from string to long? since the value is a Unix epoch datetime. Added IssuedAtDateTime property for easy date conversion.

### 2018-04-17 v2.2.0

* Add optional parameter on CreateRecord and UpdateRecord to include custom headers. the HeaderFormatter class can be used to include some standard SFDC options, e.g. HeaderFormatter.SforceAutoAssign(false) to set the Assignment Rule Header for Case objects.
* Keeping QuerySingle<T> method and behavior of returning null on no results, no longer marked as obsolete

### 2018-03-08 v2.1.0

* Exposed ForceClient.QueryAsyncEnumerator that returns IAsyncEnumerator<T>
* Added ForceClient.CountQuery - executes a "SELECT COUNT() FROM ..." query that returns the number of rows that match the filtering conditions. Note that COUNT() returns its result in the query results totalSize value, and this method will not work with a query that uses COUNT(fieldName), since those queries return their results in typical recordsets.
* Added an alpha release of NetCoreForce.Linq, a LINQ-to-SOQL query provider

### 2018-03-05 v2.0.0

* v2.0.0 release

### 2018-03-02 v2.0.0-rc4

* Added asynchronous query batch processing (QueryAsync<T>) based on IAsyncEnumerable/Ix.NET extensions. Modified from [PR #1](https://github.com/anthonyreilly/NetCoreForce/pull/1)
* Marked QuerySingle<T> as obsolete: should use standard LINQ Single() instead.

### 2018-02-27 v2.0.0-rc3

* Added synchronous Username and Password login flow to AuthenticationClient

### 2018-02-24 v2.0.0-rc2

* Fix incorrect build target for ModelGenerator
* Migrate ModelGenerator from deprecated Microsoft.Extensions.CommandLineUtils package to McMaster.Extensions.CommandLineUtils.

### 2018-02-23 v2.0.0-rc1

#### This release is to update the build targets and adjust dependencies.
#### Breaking Change: Will no longer be compatible with .NET Standard 1.3 projects, now supporting 1.6 and 2.0

* Updated .netstandard1.3 targets to .netstandard1.6
* Added multi-targeted build & nuget packaging for .netstandard1.6 and .netstandard2.0
* Updated .netcoreapp1.1 targets to .netcoreapp2.0 for non-published assemblies:
    - NetCoreForce.Client.Tests
    - NetCoreForce.FunctionalTests
    - NetCoreForce.SampleConsole
* Removed dependency on Microsoft.AspNetCore.WebUtilities by including QueryHelpers class directly in project from ASP.NET Core source. Replaced with a reference to System.Text.Encodings.Web, which is a much lighter dependency for projects not already referencing ASP.NET Core.
* Otherwise no functional changes from v1.3.0

### 2017-12-12 v1.3.0
* Regenerate generic models against new default SFDC dev org
* ModelGenerator: HTML escape field labels in case of reserved characters, e.g. "&";
* ModelGenerator: add exception to ignore ContentBody non-queryable, non-serializable type in reference fields
* Add basic test for SOQL nested subqueries

### 2017-12-11 v1.2.3
* Fixed incorrect type mapping in ModelGenerator: SFDC "Date" now creates nullable DateTime? model object properties - was previously creating string properties.

### 2017-10-27 v1.2.2
* Added **QuerySingle<T>** convenience method when only a single record is expected from a SOQL query. Will throw an exception if multiple records are returned, to avoid risk of ignoring unknown query results.
* Added additional mocked and functional query tests

### 2017-10-27 v1.2.1
* Enabled XML Documentation/Intellisense support in build output

### 2017-10-25 v1.2.0
* ModelGenerator: Fixed ability to generate all objects at once, and clarified option in console prompts - specifying "all" as the object name will include all available objects in the output.
* Client: Update default client SFDC API version to v57.0
* Models: Regenerated sample models againt SFDC API v57.0
* Update SFDC API references in test cases and documentation to v57.0

### 2017-10-11 v1.1.0
* Update ModelGenerator from netcoreapp1.0 to netcoreapp1.1, fixes crash with 1.0 runtime on MacOS 10.13

### 2017-08-30 v1.0.0
* Initial release

### 2017-07-11 v0.5.1-Beta
* Rebuild to troubleshoot NuGet issue, no code changes 

### 2017-07-11 v0.5.0-Beta
* Fixed issue with processing large query results - client was incorrectly processing the NextRecordsUrl 

### 2017-06-16 v0.4.0-Beta
Updates to Model Generator CLI tool
* No longer removing "__c" suffix from custom object names and field names
* Properly merge config file options with command line arguments when both are supplied

### 2017-06-05 v0.3.0-Beta
Updates to Model Generator CLI tool - existing config scheme was unfriendly, esp. when getting the package from NuGet.
* Local json file for config info is now optional.
* Added interactive prompt to ask for required options when not supplied in args or config file.
* Updated config file model to include additional paramters & options
* Added options to load and save config files based on provided parameters.

### 2017-05-15 v0.2.0-Beta
* Fixed SOSL search methods to return **SearchResult** types. Split into **Search** and **Search\<T\>**:
    * **Search** Generic SOSL search, returns **SearchResult\<SObjectGeneric\>** for when no RETURNING type is specified
    * **Search\<T\>** SOSL search with a RETURNING clause to deserialize the results to a specific type - **SearchResult\<T\>**
* *Breaking Change:* Moved the **SFTypeConverter** utility class and the **FieldType** enum into the ModelGenerator assembly. Neither are comprehensive enough for production use, but are needed for code generation.
* Misc. internal cleanup

### 2017-05-03 v0.1.0-Beta1
* Initial public beta, out of private alpha