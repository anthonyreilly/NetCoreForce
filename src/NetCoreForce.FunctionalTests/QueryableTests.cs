using System.Linq;
using System.Threading.Tasks;
using Xunit;
using NetCoreForce.Client.Attributes;
using NetCoreForce.Client.Models;
using NetCoreForce.Linq.Providers.Extensions;
using NetCoreForce.Models;
using Newtonsoft.Json;

namespace NetCoreForce.FunctionalTests
{
    public class QueryableTests : IClassFixture<ForceClientFixture>
    {
        ForceClientFixture forceClientFixture;

        public QueryableTests(ForceClientFixture fixture)
        {
            this.forceClientFixture = fixture;
        }

        [Fact]
        public async Task QuerySingle()
        {
            var client = await forceClientFixture.GetForceClient();

            var singleCase = await client
                    .Query<SfCase>()
                    .Select(c => new SfCase
                    {
                        Id = c.Id,
                        CaseNumber = c.CaseNumber,
                        SystemModstamp = c.SystemModstamp,
                        Account = new SfAccount
                        {
                            Name = c.Account.Name,
                            SystemModstamp = c.Account.SystemModstamp
                        },
                        Contact = new SfContact
                        {
                            Name = c.Contact.Name,
                            SystemModstamp = c.Contact.SystemModstamp
                        }
                    })
                    .FirstOrDefaultAsync();

            Assert.False(singleCase == null);
            Assert.NotNull(singleCase.CaseNumber);
        }

        [Fact]
        public async Task QuerySingleNoResults()
        {
            var client = await forceClientFixture.GetForceClient();

            var singleCase = await client
                .Query<SfCase>()
                .Select(c => new SfCase
                {
                    Id = c.Id,
                    CaseNumber = c.CaseNumber,
                    SystemModstamp = c.SystemModstamp,
                    Account = new SfAccount
                    {
                        Name = c.Account.Name,
                        SystemModstamp = c.Account.SystemModstamp
                    },
                    Contact = new SfContact
                    {
                        Name = c.Contact.Name,
                        SystemModstamp = c.Contact.SystemModstamp
                    }
                })
                .Where(c => c.CaseNumber == "999999")
                .SingleOrDefaultAsync();

            Assert.True(singleCase == null);
        }

        [Fact]
        public async Task Query()
        {
            var client = await forceClientFixture.GetForceClient();
            
            var cases = await client
                .Query<SfCase>()
                .Select(c => new SfCase
                {
                    Id = c.Id,
                    CaseNumber = c.CaseNumber,
                    SystemModstamp = c.SystemModstamp,
                    Account = new SfAccount
                    {
                        Name = c.Account.Name,
                        SystemModstamp = c.Account.SystemModstamp
                    },
                    Contact = new SfContact
                    {
                        Name = c.Contact.Name,
                        SystemModstamp = c.Contact.SystemModstamp
                    }
                })
                .ToListAsync();

            var firstCase = cases[0];

            Assert.False(cases == null);
            Assert.True(cases.Count > 1);
            Assert.NotNull(firstCase.CaseNumber);
        }

        [Fact]
        public async Task QueryNoResults()
        {
            var client = await forceClientFixture.GetForceClient();
            
            var cases = await client
                .Query<SfCase>()
                .Select(c => new SfCase
                {
                    Id = c.Id,
                    CaseNumber = c.CaseNumber,
                    SystemModstamp = c.SystemModstamp,
                    Account = new SfAccount
                    {
                        Name = c.Account.Name,
                        SystemModstamp = c.Account.SystemModstamp
                    },
                    Contact = new SfContact
                    {
                        Name = c.Contact.Name,
                        SystemModstamp = c.Contact.SystemModstamp
                    }
                })
                .Where(c => c.CaseNumber == "999999")
                .ToListAsync();

            Assert.False(cases == null);
            Assert.True(cases.Count == 0);
        }
    }
}