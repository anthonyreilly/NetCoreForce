---
title: "Salesforce OAuth Authentication in .NET"
_description: "How to log in to the Salesforce REST API from .NET and C# with NetCoreForce, using the OAuth 2.0 Client Credentials, JWT Bearer, Web Server, refresh token, and Username-Password flows."
---

# Authentication

NetCoreForce supports several Salesforce OAuth 2.0 flows. There are two ways to use them:

- Call [`AuthenticationClient`](xref:NetCoreForce.Client.AuthenticationClient) directly. It performs the OAuth flow and stores the result in [`AccessInfo`](xref:NetCoreForce.Client.AuthenticationClient.AccessInfo) (an [`AccessTokenResponse`](xref:NetCoreForce.Client.Models.AccessTokenResponse)). You then build a [`ForceClient`](xref:NetCoreForce.Client.ForceClient) from that access token yourself.
- Use one of `ForceClient`'s constructors or factory methods that perform the login and initialize the client in a single step.

All `AuthenticationClient` flow methods throw a [`ForceAuthException`](xref:NetCoreForce.Client.ForceAuthException) on failure — see [Error Handling](#error-handling) below.

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

## JWT Bearer Flow

Server-to-server authentication as a specific, approved user, with no client secret or password. The application signs a short-lived JWT with a private key, and Salesforce verifies it with the matching certificate uploaded to the external client app or connected app. See Salesforce's [OAuth 2.0 JWT Bearer Flow for Server-to-Server Integration](https://help.salesforce.com/s/articleView?id=xcloud.remoteaccess_oauth_jwt_flow.htm).

**Setup:**
1. Create a private key and certificate, e.g. with OpenSSL:
   ```
   openssl req -x509 -newkey rsa:2048 -nodes -keyout server.key -out server.crt -days 365 -subj "/CN=your-app"
   ```
   The certificate can't be larger than 4 KB.
2. Create an [external client app](https://help.salesforce.com/s/articleView?id=xcloud.external_client_apps.htm) with OAuth enabled - creating new connected apps is restricted as of Spring '26, though existing connected apps still work.
3. Enable the JWT bearer flow and upload `server.crt`. In a connected app, this is the **Use digital signatures** setting.
4. Add the **refresh_token** scope (*Perform requests at any time*), plus the scopes the integration needs - at least one standard scope other than `refresh_token`, e.g. **api**. Scopes can't be requested in the JWT; they come from the app.
5. Approve the user, either:
   - set **Permitted Users** to *Admin approved users are pre-authorized*, and add the integration user's profile or a permission set, or
   - with *All users may self-authorize*, have the user approve the app once through another flow, e.g. the [Web Server Flow](#web-server-authorization-code-flow).
6. Keep `server.key` secret and out of source control, e.g. in a secrets store or a file readable only by the application.

Via the `ForceClient` factory method, with a PEM key file:
```csharp
using (RSA privateKey = RsaPrivateKey.FromPemFile("server.key"))
{
    ForceClient client = await ForceClient.FromJwtBearerAsync("your-client-id", "integration.user@example.com", privateKey, "https://login.salesforce.com/services/oauth2/token");
}
```

Or via `AuthInfo`, which reads the key from `PrivateKeyFile`:
```csharp
AuthInfo authInfo = new AuthInfo
{
    AuthMethod = AuthInfo.AuthMethodType.JwtBearer,
    ClientId = "your-client-id",
    Username = "integration.user@example.com",
    PrivateKeyFile = "server.key",
    TokenRequestEndpoint = "https://login.salesforce.com/services/oauth2/token"
};

ForceClient client = new ForceClient(authInfo);
```

Or with [`AuthenticationClient.JwtBearerAsync`](xref:NetCoreForce.Client.AuthenticationClient.JwtBearerAsync(System.String,System.String,System.Security.Cryptography.RSA,System.String,System.String)) directly:
```csharp
AuthenticationClient auth = new AuthenticationClient();
using (RSA privateKey = RsaPrivateKey.FromPemFile("server.key"))
{
    await auth.JwtBearerAsync("your-client-id", "integration.user@example.com", privateKey, "https://login.salesforce.com/services/oauth2/token");
}

ForceClient client = new ForceClient(auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);
```

The key can be any `RSA` instance. [`RsaPrivateKey.FromPem`](xref:NetCoreForce.Client.RsaPrivateKey) and `FromPemFile` load an unencrypted PKCS#8 (`BEGIN PRIVATE KEY`) or PKCS#1 (`BEGIN RSA PRIVATE KEY`) PEM key on every supported framework. For a password-protected key, use a .pfx/.p12 file:
```csharp
using (X509Certificate2 certificate = new X509Certificate2("server.pfx", "pfx-password"))
using (RSA privateKey = certificate.GetRSAPrivateKey())
{
    ForceClient client = await ForceClient.FromJwtBearerAsync("your-client-id", "integration.user@example.com", privateKey, "https://login.salesforce.com/services/oauth2/token");
}
```

**Audience:** the JWT's `aud` claim defaults to:
- the site URL for an Experience Cloud site token endpoint (`*.my.site.com`), e.g. `https://your-domain.my.site.com/customers` for `https://your-domain.my.site.com/customers/services/oauth2/token`
- `https://test.salesforce.com` when the token endpoint is `test.salesforce.com` or a sandbox My Domain (`*.sandbox.my.salesforce.com`)
- otherwise `https://login.salesforce.com`

For a site on another domain, pass the site URL as `audience` (or set `AuthInfo.Audience`).

**Experience Cloud sites:** a site user logs in through the site's token endpoint. The token response includes the site URL and ID, in `AccessInfo.SfdcSiteUrl` and `SfdcSiteId` - Connect REST API resources need the site ID. To send API requests through the site, use the site URL as the instance URL:
```csharp
AuthenticationClient auth = new AuthenticationClient();
using (RSA privateKey = RsaPrivateKey.FromPemFile("server.key"))
{
    await auth.JwtBearerAsync("your-client-id", "site.user@example.com", privateKey, "https://your-domain.my.site.com/customers/services/oauth2/token");
}

ForceClient client = new ForceClient(auth.AccessInfo.SfdcSiteUrl ?? auth.AccessInfo.InstanceUrl, auth.ApiVersion, auth.AccessInfo.AccessToken);
```

Use the site's base URL (e.g. `https://your-domain.my.site.com/customers`), not a page URL such as `.../customers/s/`. Requests and query paging stay under the site path.

> [!NOTE]
> Query paging and composite requests through a site URL are covered by unit tests, but haven't been verified against a live Experience Cloud site.

> [!NOTE]
> This flow does not return a refresh token. Call it again for a new access token when the current one expires. Each call creates a new JWT with a unique ID (`jti` claim), which Salesforce uses to reject a replayed JWT.

Common errors, from the `ForceAuthException.ErrorCode`:
- `invalid_app_access` - the user isn't approved for the app: check the Permitted Users setting and the user's profile or permission sets.
- `invalid_request` with a message about the `refresh_token` scope - add the **refresh_token** scope to the app.
- `invalid_grant` - one of:
  - the user hasn't approved the app (when users self-authorize)
  - the private key doesn't match the certificate uploaded to the app
  - *Audience validation failed* - use `https://test.salesforce.com` for a sandbox, or the site URL for Experience Cloud
  - the system clock is more than about 5 minutes slow - the JWT expires 2 minutes after it's created, and Salesforce allows 3 minutes for clock skew
- `invalid_client_id` - the client ID (consumer key) is wrong.
- `inactive_user` / `inactive_org` - the user is inactive, or the org is locked, closed or suspended.

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

## HTTPS Required

Token endpoints and instance URLs must be HTTPS, including the `instance_url` returned by the token endpoint - an `http://` URL throws an `ArgumentException`, so credentials and the access token are never sent in cleartext.

---

## Custom HttpClient / Proxy Support

Both `AuthenticationClient` and `ForceClient` accept an optional `httpClient` parameter for scenarios needing a custom `HttpClient`, e.g. a proxy. [`HttpClientFactory.CreateHttpClient`](xref:NetCoreForce.Client.HttpClientFactory.CreateHttpClient(System.Boolean,System.String)) can build one configured for a proxy:
```csharp
HttpClient proxyClient = HttpClientFactory.CreateHttpClient(true, "http://your-proxy:8080");

ForceClient client = new ForceClient("your-client-id", "your-client-secret", "your-username", "your-password", "https://login.salesforce.com/services/oauth2/token", httpClient: proxyClient);
```

The caller owns an `HttpClient` passed in this way - disposing `ForceClient`, `JsonClient` or `AuthenticationClient` does not dispose it, so a single long-lived instance can be shared across clients. Clients built by `HttpClientFactory.CreateHttpClient` periodically replace their pooled connections so DNS changes are picked up; if you build your own `HttpClient`, configure that yourself (e.g. `SocketsHttpHandler.PooledConnectionLifetime`).

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

---

## Username-Password Flow

> [!WARNING]
> The OAuth Username-Password flow is deprecated and Salesforce recommends against using it. It is blocked by default in orgs created in Summer '23 or later, and admins can disable it in any org (Setup > OAuth and OpenID Connect Settings > *Allow OAuth Username-Password Flows*), so it may not be available in your org. For new integrations, use the [Client Credentials Flow](#client-credentials-flow) or [JWT Bearer Flow](#jwt-bearer-flow) for server-to-server access, or the [Web Server Flow](#web-server-authorization-code-flow) when a user logs in.

The application holds the user's credentials directly and exchanges them for an access token.

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
> This flow does not return a refresh token — see [Refreshing an Access Token](#refreshing-an-access-token).
