namespace NetCoreForce.Client.Models
{
    public enum OAuthScope
    {
        /// <summary>
        /// Allows access to the current, logged-in user’s account using APIs, such as REST API and Bulk API. This value also includes chatter_api, which allows access to Chatter REST API resources.
        /// </summary>
        api,

        /// <summary>
        /// Allows access to Chatter REST API resources only.
        /// </summary>
        chatter_api,

        /// <summary>
        /// Allows access to the custom permissions in an organization associated with the connected app, and shows whether the current user has each permission enabled.
        /// </summary>
        custom_permissions,

        /// <summary>
        /// Allows access to all data accessible by the logged-in user, and encompasses all other scopes. full does not return a refresh token. You must explicitly request the refresh_token scope to get a refresh token.
        /// </summary>
        full,

        /// <summary>
        /// Allows access to the identity URL service. You can request profile, email, address, or phone, individually to get the same result as using id; they are all synonymous.
        /// </summary>
        id,

        /// <summary>
        /// Allows access to the current, logged in user’s unique identifier for OpenID Connect apps. The openid scope can be used in the OAuth 2.0 user-agent flow and the OAuth 2.0 Web server authentication flow to get back a signed ID token conforming to the OpenID Connect specifications in addition to the access token.
        /// </summary>
        openid,

        /// <summary>
        /// Allows a refresh token to be returned if you are eligible to receive one. This lets the app interact with the user’s data while the user is offline, and is synonymous with requesting offline_access.
        /// </summary>
        refresh_token,

        /// <summary>
        /// Allows access to Visualforce pages.
        /// </summary>
        visualforce,

        /// <summary>
        /// Allows the ability to use the access_token on the Web. This also includes visualforce, allowing access to Visualforce pages.
        /// </summary>
        web
    }
}