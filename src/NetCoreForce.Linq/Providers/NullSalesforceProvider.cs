extern alias rxasync;
using System.Threading.Tasks;
using NetCoreForce.Linq.Conventions.Naming;
using NetCoreForce.Linq.Entity;
using rxasync.System.Collections.Generic;
using rxasync.System.Linq;

namespace NetCoreForce.Linq.Providers
{
    public class NullSalesforceProvider<T> : SalesforceProviderBase<T>
    {
        #region Overrides of SalesforceProviderBase<T>

        public NullSalesforceProvider(ISalesforceNamingConvention namingConvention, SelectTypeEnum selectType = SelectTypeEnum.SelectIdAndUseAttachModel) : base(namingConvention, selectType)
        {
        }

        protected override Task<int> ProduceCountAsync(string cmd)
        {
            return Task.FromResult(0);
        }

        protected override IAsyncEnumerator<T> ProduceAsyncEnumerator(string cmd)
        {
            return AsyncEnumerable.Empty<T>().GetEnumerator();
        }
        #endregion
    }
}