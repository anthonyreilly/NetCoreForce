using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreForce.Linq.Conventions.Naming;
using NetCoreForce.Linq.Entity;
using NetCoreForce.Models;
using Xunit;

namespace NetCoreForce.Linq.Tests
{
    public class QueryTests
    {
        public SalesforceQuery<T> Query<T>(SelectTypeEnum selectType, out QueryTranslateSalesforceProvider<T> provider)
        {
            provider = new QueryTranslateSalesforceProvider<T>(new ModelGeneratorNamingConvention(), selectType);
            return new SalesforceQuery<T>(provider);
        }

        [Fact]
        public async Task SimpleToListQuery()
        {
            await
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .ToList();
            
            Assert.Equal("SELECT id FROM Case", provider.SOQLCalled);
        }
        
        [Fact]
        public async Task SimpleFirstOrDefaultQuery()
        {
            await
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .FirstOrDefault();
            
            Assert.Equal("SELECT id FROM Case LIMIT 2", provider.SOQLCalled);
        }
        
        
        [Fact]
        public async Task SimpleSingleOrDefaultQuery()
        {
            await
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .SingleOrDefault();
            
            Assert.Equal("SELECT id FROM Case LIMIT 2", provider.SOQLCalled);
        }

        [Fact]
        public async Task SimpleCountQuery()
        {
            await
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Count();
            
            Assert.Equal("SELECT COUNT() FROM Case", provider.SOQLCalled);
        }


        [Fact]
        public void SimpleAllQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectAllAndUseAttachModel, out var provider)
                    .ToString();

            Assert.Equal("SELECT " +
                         "id,caseNumber,contactId,accountId,assetId,parentId,suppliedName,suppliedEmail,suppliedPhone,suppliedCompany," +
                         "type,status,reason,origin,subject,priority,description,ownerId,createdById,lastModifiedById," +
                         "contactPhone,contactMobile,contactEmail,contactFax " +
                         "FROM Case", soql);
        }

        [Fact]
        public void SelectQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Select(c => new SfCase
                    {
                        Id = c.Id,
                        CaseNumber = c.CaseNumber,
                        Description = c.Description
                    })
                    .ToString();

            Assert.Equal("SELECT " +
                         "id,caseNumber,description " +
                         "FROM Case", soql);
        }

        [Fact]
        public void SelectSubEntityQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Select(c => new SfCase
                    {
                        Id = c.Id,
                        CaseNumber = c.CaseNumber,
                        Account = new SfAccount
                        {
                            Id = c.Account.Id,
                            Description = c.Account.Description
                        }
                    })
                    .ToString();

            Assert.Equal("SELECT " +
                         "id,caseNumber,account.id,account.description " +
                         "FROM Case", soql);
        }

        
        [Fact]
        public void SelectSubSubEntityQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Select(c => new SfCase
                    {
                        Id = c.Id,
                        CaseNumber = c.CaseNumber,
                        Account = new SfAccount
                        {
                            Id = c.Account.Id,
                            Description = c.Account.Description,
                            CreatedBy = new SfUser()
                            {
                                Id = c.Account.CreatedBy.Id,
                                AboutMe = c.Account.CreatedBy.AboutMe,
                            }
                        }
                    })
                    .ToString();

            Assert.Equal("SELECT " +
                         "id,caseNumber,account.id,account.description,account.createdBy.id,account.createdBy.aboutMe " +
                         "FROM Case", soql);
        }

        [Fact]
        public void WhereBoolQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Where(x => x.IsClosed == true)
                    .ToString();
            Assert.Equal("SELECT id FROM Case WHERE (isClosed = TRUE)", soql);
        }

        [Fact]
        public void WhereStringQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Where(c => c.ContactEmail == "sample@hotmail.com")
                    .ToString();

            Assert.Equal("SELECT id FROM Case WHERE (contactEmail = 'sample@hotmail.com')", soql);
        }

        [Fact]
        public void WhereStringEscapeQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Where(c => c.Description == "'description with quotes' \n\r\"\\")
                    .ToString();

            Assert.Equal("SELECT id FROM Case WHERE (description = '\\'description with quotes\\' \n\r\\\"\\\\')", soql);
        }

        [Fact]
        public void WhereStringLikeEscapeQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Where(c => c.Description.StartsWith("100%"))
                    .ToString();

            Assert.Equal("SELECT id FROM Case WHERE (description LIKE '100\\%%')", soql);
        }

        [Fact]
        public void TakeQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Take(1)
                    .ToString();

            Assert.Equal("SELECT id FROM Case LIMIT 1", soql);
        }

        [Fact]
        public void TakeWithSingleQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Take(20)
                    .Single();

            //Assert.Equal("SELECT id FROM Case LIMIT 2", soql);
        }

        [Fact]
        public void SkipQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Skip(10)
                    .ToString();

            Assert.Equal("SELECT id FROM Case SKIP 10", soql);
        }

        [Fact]
        public void OrderQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .OrderBy(x => x.Subject)
                    .ToString();

            Assert.Equal("SELECT id FROM Case ORDER BY subject", soql);
        }

        [Fact]
        public void OrderDescendingQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .OrderByDescending(x => x.Subject)
                    .ToString();

            Assert.Equal("SELECT id FROM Case ORDER BY subject DESC", soql);
        }

        [Fact]
        public void IncludesQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Where(x => x.Type.Includes("test1;test2"))
                    .ToString();
            Assert.Equal("SELECT id FROM Case WHERE (type INCLUDES('test1;test2'))", soql);
        }

        [Fact]
        public void ExcludesQuery()
        {
            var soql =
                Query<SfCase>(SelectTypeEnum.SelectIdAndUseAttachModel, out var provider)
                    .Where(x => x.Type.Excludes("test1;test2"))
                    .ToString();
            Assert.Equal("SELECT id FROM Case WHERE (type EXCLUDES('test1;test2'))", soql);
        }
    }
}