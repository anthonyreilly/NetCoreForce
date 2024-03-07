using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using NetCoreForce.Client.Models;

namespace NetCoreForce.Client
{
    public class AuthenticationClient : IDisposable
    {
        private string DefaultApiVersion { get { return "v57.0"; } }
        public string ApiVersion { get; set; }

        /// <summary>
        /// The access token response from a successful authentication.
        /// </summary>
        /// <returns><see cref="AccessTokenResponse" /></returns>
        public AccessTokenResponse AccessInfo { get; private set; }

        private const string UserAgent = "netcoreforce-client";
        private const string TokenRequestEndpointUrl = "https://login.salesforce.com/services/oauth2/token";
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initialize the AuthenticationClient with the libary's default Salesforce API version, and default HttpClient
        /// <para>See the DefaultApiVersion property</para>
        /// </summary>
        public AuthenticationClient() : this(null, null) { }

        /// <summary>
        /// Initialize the AuthenticationClient with the specified Salesforce API version and/or HttpClient
        /// </summary>
        /// <param name="apiVersion">Target Salesforce API version</param>
        /// <param name="httpClient">Custom HttpClient (Optional)</param>
        public AuthenticationClient(string apiVersion = null, HttpClient httpClient = null)
        {
            if (!string.IsNullOrEmpty(apiVersion))
            {
                ApiVersion = apiVersion;
            }
            else
            {
                ApiVersion = DefaultApiVersion;
            }

            _httpClient = httpClient ?? new HttpClient();
        }

        /// <summary>
        /// Authenticate using the "Username and Password" auth flow, synchronously
        /// <para>Uses a default Token request endpoint URL: https://login.salesforce.com/services/oauth2/token</para>
        /// </summary>
        /// <param name="clientId">Client ID, a.k.a. Consumer Key</param>
        /// <param name="clientSecret">Client Secret, a.k.a. Consumer Secret</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <exception cref="ForceAuthException">Thrown if the authentication fails</exception>
        public void UsernamePassword(string clientId, string clientSecret, string username, string password)
        {
            UsernamePassword(clientId, clientSecret, username, password, TokenRequestEndpointUrl);
        }

        /// <summary>
        /// Authenticate using the "Username and Password" auth flow, synchronously
        /// <para>Uses a default Token request endpoint URL: https://login.salesforce.com/services/oauth2/token</para>
        /// </summary>
        /// <param name="clientId">Client ID, a.k.a. Consumer Key</param>
        /// <param name="clientSecret">Client Secret, a.k.a. Consumer Secret</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="tokenRequestEndpointUrl">Token request endpoint URL, e.g. https://login.salesforce.com/services/oauth2/token</param>
        /// <exception cref="ForceAuthException">Thrown if the authentication fails</exception>
        public void UsernamePassword(string clientId, string clientSecret, string username, string password, string tokenRequestEndpointUrl)
        {
            try
            {
                var task = UsernamePasswordAsync(clientId, clientSecret, username, password, tokenRequestEndpointUrl);
                task.Wait();
            }
            catch (AggregateException ex)
            {
                // Will typically be a single ForceAuthException exception - unwrap and throw
                if (ex.InnerException != null && ex.InnerExceptions != null && ex.InnerExceptions.Count == 1)
                {
                    throw ex.InnerException;
                }

                //otherwise throw the original AggregateException as-is
                throw;
            }

        }

        /// <summary>
        /// Authenticate using the "Username and Password" auth flow
        /// <para>Uses a default Token request endpoint URL: https://login.salesforce.com/services/oauth2/token</para>
        /// </summary>
        /// <param name="clientId">Client ID, a.k.a. Consumer Key</param>
        /// <param name="clientSecret">Client Secret, a.k.a. Consumer Secret</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <exception cref="ForceAuthException">Thrown if the authentication fails</exception>
        public Task UsernamePasswordAsync(string clientId, string clientSecret, string username, string password)
        {
            return UsernamePasswordAsync(clientId, clientSecret, username, password, TokenRequestEndpointUrl);
        }

        /// <summary>
        /// Authenticate using the "Username and Password" auth flow
        /// </summary>
        /// <param name="clientId">Client ID, a.k.a. Consumer Key</param>
        /// <param name="clientSecret">Client Secret, a.k.a. Consumer Secret</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="tokenRequestEndpointUrl">Token request endpoint URL, e.g. https://login.salesforce.com/services/oauth2/token</param>
        /// <exception cref="ForceAuthException">Thrown if the authentication fails</exception>
        public async Task UsernamePasswordAsync(string clientId, string clientSecret, string username, string password, string tokenRequestEndpointUrl)
        {
#if DEBUG
            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException("clientId", "Client ID is null or empty");
            if (string.IsNullOrEmpty(clientSecret)) throw new ArgumentNullException("clientSecret", "Client Secret is null or empty");
            if (string.IsNullOrEmpty(username)) throw new ArgumentNullException("username", "Username is null or empty");
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException("password", "Password is null or empty");
            if (string.IsNullOrEmpty(tokenRequestEndpointUrl)) throw new ArgumentNullException("tokenRequestEndpointUrl", "Token Request Endpoint is null or empty");
            if (!Uri.IsWellFormedUriString(tokenRequestEndpointUrl, UriKind.Absolute)) throw new FormatException("Invalid tokenRequestEndpointUrl");

            var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(tokenRequestEndpointUrl),
                Content = content
            };

            request.Headers.UserAgent.ParseAdd(string.Concat(UserAgent, "/", ApiVersion));

            var responseMessage = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var response = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (responseMessage.IsSuccessStatusCode)
            {
                this.AccessInfo = JsonConvert.DeserializeObject<AccessTokenResponse>(response);
            }
            else if (responseMessage.StatusCode == HttpStatusCode.NotFound)
            {
                // Unable to reach the auth/token url
                throw new ForceAuthException(Error.Unknown.ToString(), "Error reaching Login URL", responseMessage.StatusCode);
            }
            else
            {
                var errorResponse = JsonConvert.DeserializeObject<AuthErrorResponse>(response);
                throw new ForceAuthException(errorResponse.Error, errorResponse.ErrorDescription, responseMessage.StatusCode);
            }
#if DEBUG
            sw.Stop();
            Debug.WriteLine(string.Format("Login completed in {0}ms", sw.ElapsedMilliseconds.ToString()));
#endif
            return;
        }

        /// <summary>
        /// Web Server OAuth Authentication Flow
        /// <para>https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/intro_understanding_web_server_oauth_flow.htm</para>
        /// </summary>
        /// <param name="clientId">The Consumer Key from the connected app definition.</param>
        /// <param name="clientSecret">The Consumer Secret from the connected app definition. Required unless the Require Secret for Web Server Flow setting is not enabled in the connected app definition.</param>
        /// <param name="redirectUri">The Callback URL from the connected app definition.</param>
        /// <param name="code">Authorization code the consumer must use to obtain the access and refresh tokens.</param>
        /// <param name="tokenRequestEndpointUrl">Salesforce token request endpoint</param>
        /// <returns><see cref="AccessTokenResponse" /></returns>
        public async Task WebServerAsync(string clientId, string clientSecret, string redirectUri, string code, string tokenRequestEndpointUrl = TokenRequestEndpointUrl)
        {
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException("clientId");
            if (string.IsNullOrEmpty(clientSecret)) throw new ArgumentNullException("clientSecret");
            if (string.IsNullOrEmpty(redirectUri)) throw new ArgumentNullException("redirectUri");
            if (!Uri.IsWellFormedUriString(redirectUri, UriKind.Absolute)) throw new FormatException("redirectUri");
            if (string.IsNullOrEmpty(code)) throw new ArgumentNullException("code");
            if (string.IsNullOrEmpty(tokenRequestEndpointUrl)) throw new ArgumentNullException("tokenRequestEndpointUrl");
            if (!Uri.IsWellFormedUriString(tokenRequestEndpointUrl, UriKind.Absolute)) throw new FormatException("tokenRequestEndpointUrl");

            var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "authorization_code"),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                    new KeyValuePair<string, string>("redirect_uri", redirectUri),
                    new KeyValuePair<string, string>("code", code)
                });

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(tokenRequestEndpointUrl),
                Content = content
            };

            request.Headers.UserAgent.ParseAdd(string.Concat(UserAgent, "/", ApiVersion));

            var responseMessage = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var response = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (responseMessage.IsSuccessStatusCode)
            {
                this.AccessInfo = JsonConvert.DeserializeObject<AccessTokenResponse>(response);
            }
            else
            {
                try
                {
                    var errorResponse = JsonConvert.DeserializeObject<AuthErrorResponse>(response);
                    throw new ForceAuthException(errorResponse.Error, errorResponse.ErrorDescription, responseMessage.StatusCode);
                }
                catch (Exception ex)
                {
                    throw new ForceAuthException("Unknown", ex.Message, responseMessage.StatusCode);
                }

            }
        }

        /// <summary>
        /// Obtain a new access token using a refresh token
        /// </summary>
        /// <param name="refreshToken">The refresh token the client application already received.</param>
        /// <param name="clientId">The Consumer Key from the connected app definition.</param>
        /// <param name="clientSecret">The Consumer Secret from the connected app definition. Required unless the Require Secret for Web Server Flow setting is not enabled in the connected app definition.</param>
        /// <param name="tokenRequestEndpointUrl"></param>
        /// <returns></returns>
        public async Task TokenRefreshAsync(string refreshToken, string clientId, string clientSecret = "", string tokenRequestEndpointUrl = TokenRequestEndpointUrl)
        {
            var uri = UriFormatter.RefreshTokenUrl(
                tokenRequestEndpointUrl,
                refreshToken,
                clientId,
                clientSecret);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = uri
            };

            request.Headers.UserAgent.ParseAdd(string.Concat(UserAgent, "/", ApiVersion));

            var responseMessage = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var response = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (responseMessage.IsSuccessStatusCode)
            {
                this.AccessInfo = JsonConvert.DeserializeObject<AccessTokenResponse>(response);
                this.AccessInfo.RefreshToken = refreshToken; //not included in reponse
            }
            else
            {
                var errorResponse = JsonConvert.DeserializeObject<AuthErrorResponse>(response);
                throw new ForceAuthException(errorResponse.Error, errorResponse.ErrorDescription, responseMessage.StatusCode);
            }
        }

        /// <summary>
        /// Client credentials OAuth Authentication Flow
        /// <para>https://help.salesforce.com/s/articleView?id=sf.remoteaccess_oauth_client_credentials_flow.htm</para>
        /// </summary>
        /// <param name="clientId">The Consumer Key from the connected app definition.</param>
        /// <param name="clientSecret">The Consumer Secret from the connected app definition. Required unless the Require Secret for Web Server Flow setting is not enabled in the connected app definition.</param>
        /// <param name="tokenRequestEndpointUrl">Salesforce token request endpoint</param>
        /// <returns><see cref="AccessTokenResponse" /></returns>
        public async Task ClientCredentialsAsync(string clientId, string clientSecret,string tokenRequestEndpointUrl = TokenRequestEndpointUrl)
        {
            if (string.IsNullOrEmpty(clientId)) throw new ArgumentNullException("clientId");
            if (string.IsNullOrEmpty(clientSecret)) throw new ArgumentNullException("clientSecret");
            if (string.IsNullOrEmpty(tokenRequestEndpointUrl)) throw new ArgumentNullException("tokenRequestEndpointUrl");
            if (!Uri.IsWellFormedUriString(tokenRequestEndpointUrl, UriKind.Absolute)) throw new FormatException("tokenRequestEndpointUrl");

            var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                });

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(tokenRequestEndpointUrl),
                Content = content
            };

            request.Headers.UserAgent.ParseAdd(string.Concat(UserAgent, "/", ApiVersion));

            var responseMessage = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var response = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (responseMessage.IsSuccessStatusCode)
            {
                this.AccessInfo = JsonConvert.DeserializeObject<AccessTokenResponse>(response);
            }
            else
            {
                try
                {
                    var errorResponse = JsonConvert.DeserializeObject<AuthErrorResponse>(response);
                    throw new ForceAuthException(errorResponse.Error, errorResponse.ErrorDescription, responseMessage.StatusCode);
                }
                catch (Exception ex)
                {
                    throw new ForceAuthException("Unknown", ex.Message, responseMessage.StatusCode);
                }

            }
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}