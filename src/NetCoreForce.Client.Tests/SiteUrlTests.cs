using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Enumerations;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json.Linq;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// An Experience Cloud site URL has a path, e.g. https://example.my.site.com/customers - requests must stay under it
    /// </summary>
    public class SiteUrlTests
    {
        const string SiteUrl = "https://example.my.site.com/customers";
        const string ApiVersion = "v57.0";
        const string Query = "SELECT Id FROM Account";

        [Fact]
        public async Task QueryPagesUnderSitePath()
        {
            const string nextRecordsUrl = "/customers/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000";

            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(SiteUrl, ApiVersion, Query), HttpStatusCode.OK, BatchJson(false, nextRecordsUrl));
            mockHandler.AddMockResponse(new Uri("https://example.my.site.com/customers/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000"), HttpStatusCode.OK, BatchJson(true, null));

            ForceClient client = new ForceClient(SiteUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));
            List<SfAccount> accounts = await client.Query<SfAccount>(Query);

            Assert.Equal(2, accounts.Count);
            Assert.Equal("/customers/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000", mockHandler.LastRequestUri.AbsolutePath);
        }

        [Fact]
        public async Task QueryNextRecordsUrlOffSitePathThrows()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(SiteUrl, ApiVersion, Query), HttpStatusCode.OK,
                BatchJson(false, "/other/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000"));

            ForceClient client = new ForceClient(SiteUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            await Assert.ThrowsAsync<ForceApiException>(() => client.Query<SfAccount>(Query));
            Assert.StartsWith("/customers/services/data/", mockHandler.LastRequestUri.AbsolutePath);
        }

        [Fact]
        public async Task CompositeRequestUnderSitePath()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri("https://example.my.site.com/customers/services/data/v57.0/composite"), HttpStatusCode.OK, @"{ ""compositeResponse"": [] }");

            ForceClient client = new ForceClient(SiteUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));
            await client.ExecuteCompositeRecords(new List<CompositeSObject>
            {
                new CompositeSObject { Type = "Account", Method = CompositeMethod.Write, ReferenceId = "newAccount", SObject = new SfAccount { Name = "Acme" } }
            });

            // only the composite request itself goes to the site path - subrequest URLs stay /services/data/..., as the Composite resource specifies
            Assert.Equal("/customers/services/data/v57.0/composite", mockHandler.LastRequestUri.AbsolutePath);
            JObject body = JObject.Parse(mockHandler.LastRequestContent);
            Assert.Equal("/services/data/v57.0/sobjects/Account", (string)body["compositeRequest"][0]["url"]);
        }

        [Fact]
        public async Task GetObjectByIdUnderSitePath()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri("https://example.my.site.com/customers/services/data/v57.0/sobjects/Account/001XXXXXXXXXXXXXXX"), HttpStatusCode.OK,
                @"{ ""attributes"": { ""type"": ""Account"" }, ""Id"": ""001XXXXXXXXXXXXXXX"", ""Name"": ""Acme"" }");

            ForceClient client = new ForceClient(SiteUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));
            SfAccount account = await client.GetObjectById<SfAccount>("Account", "001XXXXXXXXXXXXXXX");

            Assert.Equal("Acme", account.Name);
        }

        [Fact]
        public async Task VersionsUnderSitePath()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri("https://example.my.site.com/customers/services/data"), HttpStatusCode.OK,
                @"[ { ""label"": ""Spring '23"", ""url"": ""/services/data/v57.0"", ""version"": ""57.0"" } ]");

            ForceClient client = new ForceClient(SiteUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            List<SalesforceVersion> versions = await client.GetAvailableRestApiVersions();
            Assert.Single(versions);
            Assert.True(client.TestConnection());
        }

        [Fact]
        public async Task SiteHostRootIsUnchanged()
        {
            // the site's host root also works for API requests, and behaves like any instance URL without a path
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri("https://example.my.site.com/services/data/v57.0/sobjects/Account/001XXXXXXXXXXXXXXX"), HttpStatusCode.OK,
                @"{ ""attributes"": { ""type"": ""Account"" }, ""Id"": ""001XXXXXXXXXXXXXXX"", ""Name"": ""Acme"" }");

            ForceClient client = new ForceClient("https://example.my.site.com", ApiVersion, "dummyToken", new HttpClient(mockHandler));
            SfAccount account = await client.GetObjectById<SfAccount>("Account", "001XXXXXXXXXXXXXXX");

            Assert.Equal("Acme", account.Name);
        }

        [Fact]
        public async Task JwtBearerSiteTokenEndpoint()
        {
            // a site user logs in via the site's token endpoint, and the JWT audience defaults to the site URL
            const string siteTokenEndpoint = "https://example.my.site.com/customers/services/oauth2/token";
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(new Uri(siteTokenEndpoint), HttpStatusCode.OK, @"{
                ""access_token"": ""jwtAccessToken"",
                ""instance_url"": ""https://example.my.salesforce.com"",
                ""token_type"": ""Bearer"",
                ""sfdc_site_url"": ""https://example.my.site.com/customers"",
                ""sfdc_site_id"": ""0DMXXXXXXXXXXXXXXX""
            }");

            using (RSA key = RSA.Create())
            {
                ForceClient client = await ForceClient.FromJwtBearerAsync("CLIENTID", "user@example.org", key, siteTokenEndpoint, httpClient: new HttpClient(mockHandler));

                Assert.Equal(new Uri(siteTokenEndpoint), mockHandler.LastRequestUri);
                Assert.Equal(SiteUrl, client.AccessInfo.SfdcSiteUrl);
            }

            string assertion = null;
            foreach (string pair in mockHandler.LastRequestContent.Split('&'))
            {
                string[] parts = pair.Split('=');
                if (parts[0] == "assertion") assertion = WebUtility.UrlDecode(parts[1]);
            }

            string claimsBase64 = assertion.Split('.')[1].Replace('-', '+').Replace('_', '/');
            claimsBase64 = claimsBase64.PadRight(claimsBase64.Length + (4 - claimsBase64.Length % 4) % 4, '=');
            JObject claims = JObject.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(claimsBase64)));
            Assert.Equal(SiteUrl, (string)claims["aud"]);
        }

        private static string BatchJson(bool done, string nextRecordsUrl)
        {
            string next = nextRecordsUrl == null ? "" : @", ""nextRecordsUrl"": """ + nextRecordsUrl + @"""";
            return @"{ ""totalSize"": 2, ""done"": " + done.ToString().ToLowerInvariant() + next + @",
                       ""records"": [ { ""attributes"": { ""type"": ""Account"" }, ""Id"": ""001XXXXXXXXXXXXXXX"" } ] }";
        }
    }
}
