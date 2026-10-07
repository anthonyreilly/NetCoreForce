using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;
#if !XUNIT_V3
using Xunit.Abstractions;
#endif
using NetCoreForce.Client;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;

namespace NetCoreForce.FunctionalTests
{
    /// <summary>
    /// Error responses and blob downloads - responses are disposed once read, so these check that real
    /// error details, status codes and blob content still come through
    /// </summary>
    public class ErrorHandlingTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;
        ITestOutputHelper output;

        public ErrorHandlingTests(ForceClientFixture fixture, ITestOutputHelper output)
        {
            this.forceClientFixture = fixture;
            this.output = output;
        }

        [Fact]
        public async Task MalformedQueryKeepsStatusAndErrorCode()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            ForceApiException ex = await Assert.ThrowsAsync<ForceApiException>(
                async () => await client.Query<SfAccount>("SELECT FROM Account")
            );

            Assert.Equal(HttpStatusCode.BadRequest, ex.HttpStatusCode);
            Assert.NotEmpty(ex.Errors);
            Assert.Equal("MALFORMED_QUERY", ex.Errors[0].ErrorCode);
        }

        [Fact]
        public async Task BlobRetrieveNotFoundKeepsStatus()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            // well formed ContentVersion ID that doesn't exist
            ForceApiException ex = await Assert.ThrowsAsync<ForceApiException>(
                async () => await client.BlobRetrieveStream("ContentVersion", "068000000000000AAA", "VersionData")
            );

            Assert.Equal(HttpStatusCode.NotFound, ex.HttpStatusCode);
        }

        [Fact]
        public async Task BlobRetrieveRoundTrip()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            byte[] content = Encoding.UTF8.GetBytes("NetCoreForce functional test " + Guid.NewGuid().ToString());

            SfContentVersion newVersion = new SfContentVersion()
            {
                Title = "NetCoreForce Test " + Guid.NewGuid().ToString(),
                PathOnClient = "netcoreforce_test.txt",
                VersionData = Convert.ToBase64String(content)
            };

            CreateResponse createResp = await client.CreateRecord<SfContentVersion>(SfContentVersion.SObjectTypeName, newVersion);
            string contentDocumentId = null;

            try
            {
                SfContentVersion version = await client.GetObjectById<SfContentVersion>(SfContentVersion.SObjectTypeName, createResp.Id, new System.Collections.Generic.List<string> { "Id", "ContentDocumentId" });
                contentDocumentId = version.ContentDocumentId;

                byte[] retrieved;
                using (Stream stream = await client.BlobRetrieveStream(SfContentVersion.SObjectTypeName, createResp.Id, "VersionData"))
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    await stream.CopyToAsync(memoryStream);
                    retrieved = memoryStream.ToArray();
                }

                Assert.Equal(content, retrieved);
            }
            finally
            {
                // a ContentVersion can't be deleted directly - deleting its ContentDocument removes all versions
                if (!string.IsNullOrEmpty(contentDocumentId))
                {
                    await TestRecords.DeleteAsync(client, SfContentDocument.SObjectTypeName, new[] { contentDocumentId }, output);
                }
            }
        }
    }
}
