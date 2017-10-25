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
        //test with empty response content

        [Fact]
        public async void ObjectById()
        {
            var mockHandler = new MockHttpClientHandler();

            HttpResponseMessage respMsg = MockResponse.GetResponse("account.json", HttpStatusCode.OK);

            const string objectId = "001i000002C8QTIAA3";
        
            Uri requestUri = new Uri("https://na15.salesforce.com/services/data/v41.0/sobjects/Account/001i000002C8QTIAA3");

            mockHandler.AddMockResponse(requestUri, respMsg);

            HttpClient httpClient = new HttpClient(mockHandler);

            ForceClient client = new ForceClient("https://na15.salesforce.com", "v41.0", "dummyToken", httpClient);

            SfAccount acct = await client.GetObjectById<SfAccount>("Account", objectId);

            Assert.False(acct == null);

            Assert.Equal(objectId, acct.Id);
            Assert.Equal("NY", acct.BillingAddress.State);
        }

        [Fact]
        public async void QueryNestedObjects()
        {
            var mockHandler = new MockHttpClientHandler();

            HttpResponseMessage respMsg = MockResponse.GetResponse("query_case_result.json", HttpStatusCode.OK);
        
            Uri requestUri = new Uri(@"https://na15.salesforce.com/services/data/v41.0/query?q=SELECT%20Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp%20FROM%20Case");

            mockHandler.AddMockResponse(requestUri, respMsg);

            HttpClient httpClient = new HttpClient(mockHandler);

            ForceClient client = new ForceClient("https://na15.salesforce.com", "v41.0", "dummyToken", httpClient);

            List<SfCase> cases = await client.Query<SfCase>("SELECT Id,CaseNumber,SystemModstamp,Account.Name,Account.SystemModstamp,Contact.Name,Contact.SystemModstamp FROM Case");

            SfCase firstCase = cases[0];

            Assert.False(cases == null);
            Assert.Equal("00001000", cases[0].CaseNumber);
            Assert.Equal("Edge Communications", cases[0].Account.Name);
            Assert.Equal("Rose Gonzalez", cases[0].Contact.Name);
            Assert.Equal(26, cases.Count);
        } 

    }
}
