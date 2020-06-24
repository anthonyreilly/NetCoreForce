extern alias rxasync;
using NetCoreForce.Linq.Conventions.Naming;
using NetCoreForce.Linq.Entity;
using NetCoreForce.Linq.Providers;
using rxasync.System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreForce.Linq.Tests
{
    public class QueryTranslateSalesforceProvider<T> : NullSalesforceProvider<T>
    {
        public string SOQLCalled { get; private set; }

        #region Overrides of SalesforceProviderBase<T>

        public QueryTranslateSalesforceProvider(ISalesforceNamingConvention namingConvention, SelectTypeEnum selectType = SelectTypeEnum.SelectIdAndUseAttachModel) : base(namingConvention, selectType)
        {
        }

        protected override Task<int> ProduceCountAsync(string cmd)
        {
            SOQLCalled = cmd;

            return base.ProduceCountAsync(cmd);
        }

        protected override IAsyncEnumerator<T> ProduceAsyncEnumerator(string cmd)
        {
            SOQLCalled = cmd;
            
            return base.ProduceAsyncEnumerator(cmd);
        }
        #endregion
    }
}