
Running the functional tests will require API credentials.  
* Make a copy of the **credentials_example.json** file and rename it to **credentials_dev.json**  
* Update **credentials_dev.json** with the API credentials to your test instance.

These tests will only modify or delete objects they have created as part of the test.  
The tests should clean up after themselves, but a failed test may leave objects in the system.

## Manual-only tests

Due to their long execution times, some tests are manual only and are not run by default:
* **SOSLTests** - each test waits for Salesforce to index its sample records for search, which can take several minutes.

On .NET 8+ and .NET Framework 4.7.2+ (xUnit v3) these tests are marked `Explicit`. Run them individually from Test Explorer, or with:
```
dotnet test -f net10.0 --filter "FullyQualifiedName~SOSLTests" -- xUnit.Explicit=on
```

On .NET Framework 4.6.2 (xUnit v2) `Explicit` is not supported, so these tests are skipped instead. Temporarily remove the `Skip` to run them.