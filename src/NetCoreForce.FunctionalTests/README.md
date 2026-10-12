
Running the functional tests will require API credentials.  
* Make a copy of the **credentials_example.json** file and rename it to **credentials_dev.json**  
* Update **credentials_dev.json** with the API credentials to your test instance.

These tests will only modify or delete objects they have created as part of the test.  
The tests should clean up after themselves, but a failed test may leave objects in the system.

## Org and connected app requirements

Some tests depend on the org or connected app:
* **AuthenticationClientTests.IntrospectTokenAsync_ActiveToken** - the connected app must be allowed to introspect tokens (e.g. enable "Introspect All Tokens"), otherwise Salesforce reports a valid token as inactive and the test fails. Uses `tokenIntrospectionEndpoint` from the credentials file, or the org's instance URL if not set.
* **AuthenticationClientTests.TokenRefreshAsync** - needs a `refreshToken` in the credentials file, obtained separately (e.g. via the Web Server flow). Skipped if not set.
* **AuthenticationClientTests.JwtBearerAsync** and **ForceClient_JwtBearer** - need a `privateKeyFile` in the credentials file (a relative path is resolved against the test output directory). Skipped if not set. To set up:
  1. Create a key and self-signed certificate: `openssl req -x509 -newkey rsa:2048 -nodes -keyout server.key -out server.crt -days 365 -subj "/CN=netcoreforce-test"`
  2. In the external client app (or existing connected app - new connected apps are restricted as of Spring '26), enable the JWT bearer flow and upload `server.crt`. In a connected app this is "Use digital signatures"
  3. Make sure the app's OAuth scopes include `refresh_token` and `api` - the JWT bearer flow fails with `invalid_request` without `refresh_token`
  4. Set the app's Permitted Users to "Admin approved users are pre-authorized", and add the test user's profile or a permission set
  5. Set `privateKeyFile` to the path of `server.key`. Keep the key out of the repo - `*.key` and `*.pem` are gitignored
  6. For a sandbox, set `tokenRequestEndpoint` to `https://test.salesforce.com/services/oauth2/token` (the audience defaults to match), or set `audience` explicitly
* **AuthenticationClientTests.JwtBearerAsync_UnregisteredKey** - signs with a random key, so runs without the above setup and only checks Salesforce rejects it with an OAuth error.
* **QueryTests.QueryMultipleBatchesMatchesCount** - needs more than 2000 Contact records to exercise query paging. Skipped otherwise.

## Manual-only tests

Due to their long execution times, some tests are manual only and are not run by default:
* **SOSLTests** - each test waits for Salesforce to index its sample records for search, which can take several minutes.
* **MetadataNameTests** - describes every queryable object in the org (hundreds of API calls), to check the ModelGenerator's name validation doesn't reject any real object, field or relationship name.

On .NET 8+ and .NET Framework 4.7.2+ (xUnit v3) these tests are marked `Explicit`. Run them individually from Test Explorer, or with:
```
dotnet test -f net10.0 --filter "FullyQualifiedName~SOSLTests" -- xUnit.Explicit=on
```

On .NET Framework 4.6.2 (xUnit v2) `Explicit` is not supported, so these tests are skipped instead. Temporarily remove the `Skip` to run them.

## Manual checks

These can't be automated as tests:
* **ModelGenerator end to end** - generate all objects against the org, then compile the output in a scratch project:
  ```
  export NETCOREFORCE_CLIENT_SECRET=your_client_secret
  dotnet run --project src/NetCoreForce.ModelGenerator -- generate --auth-method ClientCredentials --client-id your_client_id --token-request-endpoint https://your-domain.my.salesforce.com/services/oauth2/token -o all -c -r -n Test.Models -d /tmp/models
  ```
  Also run it once without the environment variable, to check the client secret prompt doesn't echo the input.
* **Connection lifetime / DNS changes** - pooled connections are replaced every 2 minutes so DNS changes are picked up. Testing this needs a long-running process and a DNS change, so it's covered by the unit tests of the handler configuration instead.