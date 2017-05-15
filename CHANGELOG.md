# Changelog

### 2017-05-15 v0.2.0-Beta
* Fixed SOSL search methods to return **SearchResult** types. Split into **Search** and **Search\<T\>**:
    * **Search** Generic SOSL search, returns **SearchResult\<SObjectGeneric\>** for when no RETURNING type is specified
    * **Search\<T\>** SOSL search with a RETURNING clause to deserialize the results to a specific type - **SearchResult\<T\>**
* *Breaking Change:* Moved the **SFTypeConverter** utility class and the **FieldType** enum into the ModelGenerator assembly. Neither are comprehensive enough for production use, but are needed for code generation.
* Misc. internal cleanup

### 2017-05-03 v0.1.0-Beta1
* Initial public beta, out of private alpha