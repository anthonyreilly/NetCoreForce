using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client;
using NetCoreForce.Client.Attributes;
using NetCoreForce.Client.Models;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class QueryAsyncTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public QueryAsyncTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task QueryAsync()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 3000");

            int count = 0;
            SfContact contact = null;
            await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
            {
                while (await contactsEnumerator.MoveNextAsync())
                {
                    contact = contactsEnumerator.Current;
                    count++;
                }
            }

            // recordcount needs be greater than 2000 to ensure that more than one batch was retrieved
            // and that the async retrieval occurred.
            Assert.True(count > 2000);
            Assert.NotNull(contact.Id);
        }

        [Fact]
        public async Task QueryAsync_small_batchSize()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1000", batchSize: 200);

            int count = 0;
            SfContact contact = null;
            await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
            {
                // Assert.NotNull(contactsEnumerator);

                while (await contactsEnumerator.MoveNextAsync())
                {
                    contact = contactsEnumerator.Current;
                    count++;
#if DEBUG
                    if (count % 200 == 0)
                    {
                        Console.WriteLine("QueryAsync_small_batchSize: processed {0} records", count.ToString());
                    }
#endif
                }
            }

            // recordcount needs be greater than 200 to ensure that more than one batch was retrieved
            // and that the async retrieval occurred.
            Assert.True(count > 200);
            Assert.NotNull(contact.Id);
        }

        [Fact]
        public async Task QueryAsync_single_result()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1");

            int count = 0;
            SfContact contact = null;
            await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
            {
                while (await contactsEnumerator.MoveNextAsync())
                {
                    contact = contactsEnumerator.Current;
                    count++;
                }
            }

            Assert.Equal(1, count);
            Assert.NotNull(contact.Id);
        }

        [Fact]
        public async Task QueryAsync_large_resultset()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var enumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact");

            int count = 0;
            await using (var enumerator = enumerable.GetAsyncEnumerator())
            {
                while (await enumerator.MoveNextAsync())
                {
                    var currentItem = enumerator.Current;
                    count++;
#if DEBUG                    
                    if (count % 1000 == 0)
                    {
                        Console.WriteLine("QueryAsync_large_resultset: processed {0} records", count.ToString());
                    }
#endif
                }
            }

            Assert.True(count > 0);
        }

        [Fact]
        public async Task QueryAsync_valid_result_collection()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var enumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact limit 450", batchSize: 200);

            List<SfContact> results = new List<SfContact>();

            await using (var enumerator = enumerable.GetAsyncEnumerator())
            {
                while (await enumerator.MoveNextAsync())
                {
                    results.Add(enumerator.Current);
                }
            }

            Assert.NotEmpty(results);
            Assert.Equal(450, results.Count);
        }

        [Fact]
        public async Task QueryAsync_custom_batchSize()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 3000", batchSize: 200);

            int count = 0;
            await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
            {
                while (await contactsEnumerator.MoveNextAsync())
                {
                    SfContact contact = contactsEnumerator.Current;
                    count++;
                }
            }

            Assert.True(count > 0);
        }

        [Fact]
        public async Task QueryAsync_invalid_batchsize()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1000", batchSize: 100);

            await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
                {
                    await contactsEnumerator.MoveNextAsync();
                }
            });
        }

        [Fact]
        public async Task QueryAsync_no_results()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact WHERE Name='xyz123foobar'");

            SfContact contact = null;
            await using (IAsyncEnumerator<SfContact> contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
            {
                while (await contactsEnumerator.MoveNextAsync())
                {
                    contact = contactsEnumerator.Current;
                }
            }

            Assert.Null(contact);
        }

        [Fact]
        public async Task QueryAsync_ToList()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            List<SfContact> contacts = await client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1000", batchSize: 200).ToListAsync();

            Assert.NotNull(contacts);
            Assert.NotEmpty(contacts);
        }
    }
}