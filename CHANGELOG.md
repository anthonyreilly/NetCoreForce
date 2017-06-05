# Changelog

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