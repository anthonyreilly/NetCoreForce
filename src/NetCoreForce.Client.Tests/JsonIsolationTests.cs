using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NetCoreForce.Client;
using NetCoreForce.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace NetCoreForce.Client.Tests
{
    /// <summary>
    /// The library must not pick up the host application's global JsonConvert.DefaultSettings.
    /// e.g. a host using TypeNameHandling.Auto/All would otherwise allow "$type" in a response to instantiate arbitrary types.
    /// </summary>
    [Collection(GlobalStateCollection.Name)]
    public class JsonIsolationTests
    {
        const string TypedPayload = @"{ ""value"": { ""$type"": ""NetCoreForce.Client.Tests.JsonIsolationTests+Marker, NetCoreForce.Client.Tests"" } }";

        public class Marker
        {
            public static bool Created;

            public Marker()
            {
                Created = true;
            }
        }

        [Fact]
        public void DeserializeIgnoresGlobalTypeNameHandling()
        {
            WithTypeNameHandlingAll(() =>
            {
                var result = NetCoreForce.Client.JsonSerializer.Deserialize<Dictionary<string, object>>(TypedPayload);

                Assert.False(Marker.Created);
                Assert.IsType<JObject>(result["value"]);
            });
        }

        [Fact]
        public async Task ResponseIgnoresGlobalTypeNameHandling()
        {
            var mockHandler = new MockHttpClientHandler();
            Uri uri = new Uri("https://na15.salesforce.com/services/apexrest/Test");
            mockHandler.AddMockResponse(uri, HttpStatusCode.OK, TypedPayload);

            JsonClient client = new JsonClient("dummyToken", new HttpClient(mockHandler));

            Dictionary<string, object> result = null;
            await WithTypeNameHandlingAllAsync(async () =>
            {
                result = await client.HttpGetAsync<Dictionary<string, object>>(uri);
            });

            Assert.False(Marker.Created);
            Assert.IsType<JObject>(result["value"]);
        }

        [Fact]
        public void SerializeIgnoresGlobalTypeNameHandling()
        {
            WithTypeNameHandlingAll(() =>
            {
                string json = NetCoreForce.Client.JsonSerializer.SerializeForCreate(new SfAccount() { Name = "Test" });

                Assert.DoesNotContain("$type", json);
            });
        }

        private static void WithTypeNameHandlingAll(Action action)
        {
            WithTypeNameHandlingAllAsync(() => { action(); return Task.CompletedTask; }).GetAwaiter().GetResult();
        }

        private static async Task WithTypeNameHandlingAllAsync(Func<Task> action)
        {
            Func<JsonSerializerSettings> previous = JsonConvert.DefaultSettings;
            Marker.Created = false;
            try
            {
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                await action();
            }
            finally
            {
                JsonConvert.DefaultSettings = previous;
            }
        }
    }
}
