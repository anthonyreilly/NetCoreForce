using NetCoreForce.Client;
using NetCoreForce.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

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
        public async Task QueryAsyncEnumerator()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 3000");

            int count = 0;
            SfContact contact = null;
            await using (var contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
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
        public async Task QueryAsyncEnumeratorSmallBatch()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1000", batchSize: 200);

            int count = 0;
            SfContact contact = null;
            await using (var contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
            {
                // Assert.NotNull(contactsEnumerator);
                
                while (await contactsEnumerator.MoveNextAsync())
                {
                    contact = contactsEnumerator.Current;
                    count++;
#if DEBUG
                    if (count % 200 == 0)
                    {
                        Console.WriteLine("QueryAsyncEnumeratorSmallBatch: processed {0} records", count.ToString());
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
        public async Task QueryAsyncEnumeratorSingle()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1");

            int count = 0;
            SfContact contact = null;
            await using (var contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
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
        public async Task QueryAsyncEnumeratorLarge()
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
                        Console.WriteLine("QueryAsyncEnumeratorLarge: processed {0} records", count.ToString());
                    }
#endif
                }
            }

            Assert.True(count > 0);
        }

        [Fact]
        public async Task QueryAsyncEnumeratorCustombBatchSize()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 3000", batchSize: 200);

            int count = 0;
            await using (var contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
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
        public async Task QueryAsyncInvalidBatchSize()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1000", batchSize: 100);

            Assert.Throws<ArgumentException>(() =>
            {
                var contactsEnumerator = contactsEnumerable.GetAsyncEnumerator();
            });

            await Assert.ThrowsAsync<ArgumentException>(async () =>
            {
                await using (var contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
                {
                    await contactsEnumerator.MoveNextAsync();
                }
            });
        }

        [Fact]
        public async Task QueryAsyncEnumeratorNoResults()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contactsEnumerable = client.QueryAsync<SfContact>("SELECT Id FROM Contact WHERE Name='xyz123foobar'");

            SfContact contact = null;
            await using (var contactsEnumerator = contactsEnumerable.GetAsyncEnumerator())
            {
                while (await contactsEnumerator.MoveNextAsync())
                {
                    contact = contactsEnumerator.Current;
                }
            }

            Assert.Null(contact);
        }

        public async Task QueryAsyncToList()
        {
            ForceClient client = await forceClientFixture.GetForceClient();

            var contacts = await client.QueryAsync<SfContact>("SELECT Id FROM Contact LIMIT 1000", batchSize: 200).ToListAsync();

            Assert.NotNull(contacts);
            Assert.NotEmpty(contacts);
        }
    }
}