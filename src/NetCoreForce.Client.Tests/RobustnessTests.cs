using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// Changes CurrentCulture, so must not run in parallel with other tests
    /// </summary>
    [Collection(GlobalStateCollection.Name)]
    public class CultureTests
    {
        [Theory]
        [InlineData("fi-FI")] // time separator is "."
        [InlineData("th-TH")] // Buddhist calendar - year 2566 for 2023
        public void DateStringsAreCultureInvariant(string cultureName)
        {
            // SOQL date literals must always use the invariant format
            DateTimeOffset dto = new DateTimeOffset(2023, 10, 1, 12, 34, 56, TimeSpan.FromHours(-7));

            CultureInfo previous = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = new CultureInfo(cultureName);

                Assert.Equal("2023-10-01T12:34:56-07:00", dto.ToSfDateString());
                Assert.Equal("2023-10-01T12:34:56-07:00", DateFormats.FullDateString(dto));
                Assert.Equal("2023-10-01T12:34:56-07:00", DateFormats.FullDateString(dto.DateTime, dto.Offset));
                Assert.Equal("2023-10-01", DateFormats.DateOnlyString(dto));
                Assert.Equal("2023-10-01", DateFormats.DateOnlyString(dto.DateTime));
            }
            finally
            {
                CultureInfo.CurrentCulture = previous;
            }
        }
    }

    public class RobustnessTests
    {
        const string InstanceUrl = "https://na15.salesforce.com";
        const string ApiVersion = "v57.0";
        const string Query = "SELECT Id FROM Account";

        [Fact]
        public async Task SendFailureKeepsInnerException()
        {
            JsonClient client = new JsonClient("dummyToken", new HttpClient(new ThrowingHandler()));

            ForceApiException ex = await Assert.ThrowsAsync<ForceApiException>(() => client.HttpGetAsync<object>(new Uri(InstanceUrl)));

            Assert.IsType<HttpRequestException>(ex.InnerException);
        }

        [Fact]
        public async Task QueryRepeatedNextRecordsUrlThrows()
        {
            // a response repeating the same nextRecordsUrl would otherwise loop forever
            const string nextRecordsUrl = "/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000";
            string batch = BatchJson(done: false, nextRecordsUrl: nextRecordsUrl);

            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(InstanceUrl, ApiVersion, Query), HttpStatusCode.OK, batch);
            mockHandler.AddMockResponse(new Uri(InstanceUrl + nextRecordsUrl), HttpStatusCode.OK, batch);

            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            await Assert.ThrowsAsync<ForceApiException>(() => WithinTimeout(() => client.Query<SfAccount>(Query)));
        }

        [Fact]
        public async Task QueryAsyncRepeatedNextRecordsUrlThrows()
        {
            const string nextRecordsUrl = "/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000";
            string batch = BatchJson(done: false, nextRecordsUrl: nextRecordsUrl);

            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(InstanceUrl, ApiVersion, Query), HttpStatusCode.OK, batch);
            mockHandler.AddMockResponse(new Uri(InstanceUrl + nextRecordsUrl), HttpStatusCode.OK, batch);

            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            await Assert.ThrowsAsync<ForceApiException>(() => WithinTimeout(async () =>
            {
                await using (IAsyncEnumerator<SfAccount> enumerator = client.QueryAsync<SfAccount>(Query).GetAsyncEnumerator())
                {
                    while (await enumerator.MoveNextAsync()) { }
                }
            }));
        }

        [Fact]
        public async Task QueryAsyncStopsWhenDone()
        {
            // a nextRecordsUrl in the final batch must not be followed - here it isn't mocked, so following it would throw
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(InstanceUrl, ApiVersion, Query), HttpStatusCode.OK,
                BatchJson(done: true, nextRecordsUrl: "/services/data/v57.0/query/01gXXXXXXXXXXXXXXX-2000"));

            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            var results = new List<SfAccount>();
            await using (IAsyncEnumerator<SfAccount> enumerator = client.QueryAsync<SfAccount>(Query).GetAsyncEnumerator())
            {
                while (await enumerator.MoveNextAsync())
                {
                    results.Add(enumerator.Current);
                }
            }

            Assert.Single(results);
        }

        [Fact]
        public async Task QueryNullRecordsReturnsEmpty()
        {
            var mockHandler = new MockHttpClientHandler();
            mockHandler.AddMockResponse(UriFormatter.Query(InstanceUrl, ApiVersion, Query), HttpStatusCode.OK,
                @"{ ""totalSize"": 0, ""done"": true }");

            ForceClient client = new ForceClient(InstanceUrl, ApiVersion, "dummyToken", new HttpClient(mockHandler));

            List<SfAccount> results = await client.Query<SfAccount>(Query);

            Assert.Empty(results);
        }

        /// <summary>
        /// Fail rather than hang if the paging loop never ends. The mock responses complete synchronously,
        /// so the loop never yields and xunit's own test timeout can't interrupt it.
        /// </summary>
        private static async Task WithinTimeout(Func<Task> action)
        {
            Task task = Task.Run(action);
            if (await Task.WhenAny(task, Task.Delay(TimeSpan.FromSeconds(10))) != task)
            {
                throw new TimeoutException("Paging did not stop - repeated nextRecordsUrl was followed indefinitely");
            }

            await task;
        }

        private static string BatchJson(bool done, string nextRecordsUrl)
        {
            return @"{ ""totalSize"": 4000, ""done"": " + done.ToString().ToLowerInvariant() + @", ""nextRecordsUrl"": """ + nextRecordsUrl + @""",
                       ""records"": [ { ""attributes"": { ""type"": ""Account"" }, ""Id"": ""001XXXXXXXXXXXXXXX"" } ] }";
        }

        private class ThrowingHandler : HttpMessageHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                throw new HttpRequestException("connection failed");
            }
        }
    }
}
