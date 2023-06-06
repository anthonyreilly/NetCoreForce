using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreForce.Client;
using Xunit;
using NetCoreForce.Models;

namespace NetCoreForce.Client.Tests
{
    public class MockHttpTests
    {
        private ForceClient CreateMockClient(
            string instanceUrl,
            string apiVersion,
            string requestUrl,
            string responseFilename,
            HttpStatusCode responseCode)
        {
            var mockHandler = new MockHttpClientHandler();

            HttpResponseMessage respMsg = MockResponse.GetResponse(responseFilename, responseCode);

            Uri requestUri = new Uri(requestUrl);

            mockHandler.AddMockResponse(requestUri, respMsg);

            var httpClient = new HttpClient(mockHandler);

            return new ForceClient(instanceUrl, apiVersion, "dummyToken", httpClient);
        }

        [Fact]
        public async void ObjectById()
        {
            ForceClient client = CreateMockClient(
                "https://na15.salesforce.com",
                "v57.0",
                "https://na15.salesforce.com/services/data/v57.0/sobjects/Account/001i000002C8QTIAA3",
                "account.json",
                HttpStatusCode.OK);

            const string objectId = "001i000002C8QTIAA3";

            SfAccount acct = await client.GetObjectById<SfAccount>("Account", objectId);

            Assert.False(acct == null);

            Assert.Equal(objectId, acct.Id);
            Assert.Equal("NY", acct.BillingAddress.State);
        }

        [Fact]
        public async void QueryNestedObjects()
        {
            ForceClient client = CreateMockClient(
                "https://na15.salesforce.com",
                "v57.0",
                "https://na15.salesforce.com/services/data/v57.0/query?q=SELECT%20Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp%20FROM%20Case",
                "query_case_result.json",
                HttpStatusCode.OK);

            List<SfCase> cases = await client.Query<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case");

            SfCase firstCase = cases[0];

            Assert.False(cases == null);
            Assert.Equal("00001000", cases[0].CaseNumber);
            Assert.Equal("Edge Communications", cases[0].Account.Name);
            Assert.Equal("Rose Gonzalez", cases[0].Contact.Name);
            Assert.Equal(26, cases.Count);
        }

        [Fact]
        public async void QueryNoResults()
        {
            ForceClient client = CreateMockClient(
                "https://na15.salesforce.com",
                "v57.0",
                "https://na15.salesforce.com/services/data/v57.0/query?q=SELECT%20Id%20FROM%20Case",
                "query_empty_result.json",
                HttpStatusCode.OK);

            List<SfCase> cases = await client.Query<SfCase>("SELECT Id FROM Case");

            Assert.NotNull(cases);
            Assert.Empty(cases);
        }

        [Fact]
        public async void QuerySingleObject()
        {
            ForceClient client = CreateMockClient(
                "https://na15.salesforce.com",
                "v57.0",
                "https://na15.salesforce.com/services/data/v57.0/query?q=SELECT%20Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp%20FROM%20Case%20WHERE%20CaseNumber%20%3D%20%2700001000%27",
                "query_case_single_result.json",
                HttpStatusCode.OK);

            SfCase singleCase = await client.QuerySingle<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case WHERE CaseNumber = '00001000'");

            Assert.False(singleCase == null);
            Assert.Equal("00001000", singleCase.CaseNumber);
            Assert.Equal("Edge Communications", singleCase.Account.Name);
            Assert.Equal("Rose Gonzalez", singleCase.Contact.Name);
        }

        [Fact]
        public async void QuerySingleObjectFail()
        {
            ForceClient client = CreateMockClient(
                "https://na15.salesforce.com",
                "v57.0",
                "https://na15.salesforce.com/services/data/v57.0/query?q=SELECT%20Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp%20FROM%20Case%20WHERE%20CaseNumber%20LIKE%20%270000%25%27",
                "query_case_result.json",
                HttpStatusCode.OK);

            Exception ex = await Assert.ThrowsAsync<Exception>(
                async () => await client.QuerySingle<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case WHERE CaseNumber LIKE '0000%'")
            );

            Assert.NotNull(ex);
        }

        [Fact]
        public async void QuerySingleObjectNoResults()
        {
            ForceClient client = CreateMockClient(
                "https://na15.salesforce.com",
                "v57.0",
                "https://na15.salesforce.com/services/data/v57.0/query?q=SELECT%20Id%20FROM%20Case%20WHERE%20CaseNumber%20LIKE%20%270000%25%27",
                "query_empty_result.json",
                HttpStatusCode.OK);

            var c = await client.QuerySingle<SfCase>("SELECT Id FROM Case WHERE CaseNumber LIKE '0000%'");

            Assert.Null(c);
        }

        [Fact]
        public async void CountQuery()
        {
            ForceClient client = CreateMockClient(
                "https://na15.salesforce.com",
                "v57.0",
                "https://na15.salesforce.com/services/data/v57.0/query?q=SELECT%20COUNT()%20FROM%20Case",
                "count_query.json",
                HttpStatusCode.OK);

            int count = await client.CountQuery("SELECT COUNT() FROM Case");

            await Assert.ThrowsAsync<ForceApiException>(
                async () => await client.CountQuery("SELECT COUNT(Id) FROM Case")
            );

            await Assert.ThrowsAsync<ForceApiException>(
                async () => await client.CountQuery("SELECT COUNT(Id) CaseCount FROM Case")
            );

            Assert.Equal(26, count);
        }

    }
}
