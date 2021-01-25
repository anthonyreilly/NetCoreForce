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
    public class MockHttpAsyncTests
    {
        [Fact]
        public async Task QueryAsyncInvalidBatchSize()
        {
            HttpClient httpClient = new HttpClient(new MockHttpClientHandler());
            ForceClient client = new ForceClient("https://na15.salesforce.com", "v41.0", "dummyToken", httpClient);

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1000", batchSize: 100);

            ArgumentException ex = await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await foreach (SfContact contact in contactsEnumerable)
                {
                    var result = contact;
                }
            });
            

            // Check that the error message mentions 200 as the minimum value
            Assert.True(ex.Message.Contains("200"));
        }

        [Fact]
        public async void QueryAsync()
        {
            var mockHandler = new MockHttpClientHandler();

            HttpResponseMessage respMsg = MockResponse.GetResponse("querybatch/batch-1.json", HttpStatusCode.OK);
            Uri requestUri = new Uri(@"https://na15.salesforce.com/services/data/v41.0/query?q=SELECT%20Id%20FROM%20Contact%20LIMIT%20800");
            mockHandler.AddMockResponse(requestUri, respMsg);

            HttpResponseMessage respMsg2 = MockResponse.GetResponse("querybatch/batch-2.json", HttpStatusCode.OK);
            Uri requestUri2 = new Uri(@"https://na15.salesforce.com/services/data/v41.0/query/01gC000006QJJ7fIAH-200");
            mockHandler.AddMockResponse(requestUri2, respMsg2);

            HttpResponseMessage respMsg3 = MockResponse.GetResponse("querybatch/batch-3.json", HttpStatusCode.OK);
            Uri requestUri3 = new Uri(@"https://na15.salesforce.com/services/data/v41.0/query/01gC000006QJJ7fIAH-400");
            mockHandler.AddMockResponse(requestUri3, respMsg3);

            HttpResponseMessage respMsg4 = MockResponse.GetResponse("querybatch/batch-4.json", HttpStatusCode.OK);
            Uri requestUri4 = new Uri(@"https://na15.salesforce.com/services/data/v41.0/query/01gC000006QJJ7fIAH-600");
            mockHandler.AddMockResponse(requestUri4, respMsg4);

            HttpClient httpClient = new HttpClient(mockHandler);

            ForceClient client = new ForceClient("https://na15.salesforce.com", "v41.0", "dummyToken", httpClient);

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 800", batchSize: 200);

            List<SfContact> contacts = new List<SfContact>(800);
            await foreach (var contact in contactsEnumerable) 
            {
                contacts.Add(contact);
            }

            Assert.Equal(800, contacts.Count);
            Assert.Equal("003XXXXXXXXXXXXXXX", contacts[0].Id);
            Assert.Equal("003XXXXXXXXXXXXXXX", contacts[799].Id);
        }

    }
}
