# Authentication

NetCoreForce supports several Salesforce OAuth 2.0 flows. There are two ways to use them:

- Call [`AuthenticationClient`](xref:NetCoreForce.Client.AuthenticationClient) directly. It performs the OAuth flow and stores the result in [`AccessInfo`](xref:NetCoreForce.Client.AuthenticationClient.AccessInfo) (an [`AccessTokenResponse`](xref:NetCoreForce.Client.Models.AccessTokenResponse)). You then build a [`ForceClient`](xref:NetCoreForce.Client.ForceClient) from that access token yourself.
- Use one of `ForceClient`'s constructors or factory methods that perform the login and initialize the client in a single step.

All `AuthenticationClient` flow methods throw a [`ForceAuthException`](xref:NetCoreForce.Client.ForceAuthException) on failure — see [Error Handling](#error-handling) below.

---

## Username-Password Flow

The simplest flow for server-to-server integrations where the application can hold the user's credentials directly.

One-step, via the [`ForceClient(AuthInfo)`](xref:NetCoreForce.Client.ForceClient.%23ctor(NetCoreForce.Client.Models.AuthInfo)) constructor:
```csharp
AuthInfo authInfo = new AuthInfo
{
    ClientId = "your-client-id",
    ClientSecret = "your-client-secret",
    Username = "your-username",
    Password = "your-password",
    TokenRequestEndpoint = "https://login.salesforce.com/services/oauth2/token"
};

ForceClient client = new ForceClient(authInfo);
```

Or without building an [`AuthInfo`](xref:NetCoreForce.Client.Models.AuthInfo) object:
```csharp
ForceClient client = new ForceClient("your-client-id", "your-client-secret", "your-username", "your-password", "https://login.salesforce.com/services/oauth2/token");
```

If you need the raw token response first (e.g. to inspect or persist it), use [`AuthenticationClient.UsernamePasswordAsync`](xref:NetCoreForce.Client.AuthenticationClient.UsernamePasswordAsync(System.String,System.String,System.String,System.String,System.String)) and build the client from the result:
```csharp
AuthenticationClient auth = new AuthenticationClient();
await auth.UsernamePasswordAsync("your-client-id", "your-client-secret", "your-username", "your-password", "https://login.salesforce.com/services/oauth2/token");

ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);
```

A synchronous [`UsernamePassword`](xref:NetCoreForce.Client.AuthenticationClient.UsernamePassword(System.String,System.String,System.String,System.String,System.String)) overload is also available if you can't use `async`/`await`.

> [!NOTE]
> This flow does not return a refresh token — see [Refreshing an Access Token](#refreshing-an-access-token) below.

---

## Client Credentials Flow

Server-to-server authentication with no end user involved, using only the connected app's Consumer Key/Secret.

Via the `ForceClient` factory method:
```csharp
ForceClient client = await ForceClient.FromClientCredentialsAsync("your-client-id", "your-client-secret", "https://your-domain.my.salesforce.com/services/oauth2/token");
```

Or via `AuthInfo`:
```csharp
AuthInfo authInfo = new AuthInfo
{
    AuthMethod = AuthInfo.AuthMethodType.ClientCredentials,
    ClientId = "your-client-id",
    ClientSecret = "your-client-secret",
    TokenRequestEndpoint = "https://your-domain.my.salesforce.com/services/oauth2/token"
};

ForceClient client = new ForceClient(authInfo);
```

Or with `AuthenticationClient` directly:
```csharp
AuthenticationClient auth = new AuthenticationClient();
await auth.ClientCredentialsAsync("your-client-id", "your-client-secret", "https://your-domain.my.salesforce.com/services/oauth2/token");
```

> [!NOTE]
> Client Credentials flow may require the org's specific My Domain token endpoint (`https://your-domain.my.salesforce.com/services/oauth2/token`) rather than the generic `https://login.salesforce.com/services/oauth2/token` endpoint used by the other flows.

---

## Web Server (Authorization Code) Flow

Used when an end user needs to log in and grant consent interactively via a browser. This is a two-step flow.

**Step 1:** Redirect the user to a consent URL, built with [`UriFormatter.WebServerAuthenticationUrl`](xref:NetCoreForce.Client.UriFormatter.WebServerAuthenticationUrl(System.String,System.String,System.String,NetCoreForce.Client.Models.DisplayTypes,System.Boolean,System.String,System.String)):
```csharp
Uri consentUrl = UriFormatter.WebServerAuthenticationUrl(
    loginUrl: "https://login.salesforce.com/services/oauth2/authorize",
    clientId: "your-client-id",
    redirectUrl: "https://your-app.example.com/callback");

// redirect the user's browser to consentUrl
```

**Step 2:** After the user approves, Salesforce redirects back to `redirectUrl` with a `code` query parameter. Exchange it for an access token with [`AuthenticationClient.WebServerAsync`](xref:NetCoreForce.Client.AuthenticationClient.WebServerAsync(System.String,System.String,System.String,System.String,System.String)):
```csharp
AuthenticationClient auth = new AuthenticationClient();
await auth.WebServerAsync("your-client-id", "your-client-secret", "https://your-app.example.com/callback", code);

ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);
```

Unlike the Username-Password flow, this flow does return a refresh token, available at `auth.AccessInfo.RefreshToken`.

---

## Token Introspection

Check whether an access token is still valid with [`AuthenticationClient.IntrospectTokenAsync`](xref:NetCoreForce.Client.AuthenticationClient.IntrospectTokenAsync(System.String,System.String,System.String,System.String)):
```csharp
AuthenticationClient auth = new AuthenticationClient();
IntrospectTokenResponse introspectResponse = await auth.IntrospectTokenAsync(accessToken, "your-client-id", "your-client-secret");

if (introspectResponse.Active)
{
    // token is still valid
}
```

Returns an [`IntrospectTokenResponse`](xref:NetCoreForce.Client.Models.IntrospectTokenResponse) — see [`Active`](xref:NetCoreForce.Client.Models.IntrospectTokenResponse.Active) for the validity flag, plus `Scope`, `ClientId`, `Username`, and expiry-related fields.

---

## Refreshing an Access Token

If you have a refresh token (obtained via the [Web Server Flow](#web-server-authorization-code-flow)), use [`AuthenticationClient.TokenRefreshAsync`](xref:NetCoreForce.Client.AuthenticationClient.TokenRefreshAsync(System.String,System.String,System.String,System.String)) to get a new access token without re-prompting the user:
```csharp
AuthenticationClient auth = new AuthenticationClient();
await auth.TokenRefreshAsync(refreshToken, "your-client-id", "your-client-secret");

ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);
```

> [!NOTE]
> The Username-Password flow does not return a refresh token, so this only applies to tokens obtained via the Web Server flow.

---

## Using a Pre-Existing Access Token

If authentication was already handled elsewhere (e.g. a token cached from a previous session), initialize `ForceClient` directly from the instance URL and access token, skipping any login call:
```csharp
ForceClient client = new ForceClient(instanceUrl, apiVersion, accessToken);
```

---

## Custom HttpClient / Proxy Support

Both `AuthenticationClient` and `ForceClient` accept an optional `httpClient` parameter for scenarios needing a custom `HttpClient`, e.g. a proxy. [`HttpClientFactory.CreateHttpClient`](xref:NetCoreForce.Client.HttpClientFactory.CreateHttpClient(System.Boolean,System.String)) can build one configured for a proxy:
```csharp
HttpClient proxyClient = HttpClientFactory.CreateHttpClient(true, "http://your-proxy:8080");

ForceClient client = new ForceClient("your-client-id", "your-client-secret", "your-username", "your-password", "https://login.salesforce.com/services/oauth2/token", httpClient: proxyClient);
```

---

## Error Handling

All `AuthenticationClient` flow methods throw a [`ForceAuthException`](xref:NetCoreForce.Client.ForceAuthException) if authentication fails, with `ErrorCode` (e.g. `invalid_grant`) and `HttpStatusCode` properties:
```csharp
try
{
    await auth.UsernamePasswordAsync("your-client-id", "your-client-secret", "your-username", "your-password", "https://login.salesforce.com/services/oauth2/token");
}
catch (ForceAuthException ex)
{
    Console.WriteLine($"{ex.ErrorCode}: {ex.Message}");
}
```
