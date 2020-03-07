using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NetCoreForce.Linq.Conventions.Naming;
using NetCoreForce.Linq.Entity;

namespace NetCoreForce.Linq.Providers
{
    public class NullSalesforceProvider<T> : SalesforceProviderBase<T>
    {
        #region Overrides of SalesforceProviderBase<T>

        public NullSalesforceProvider(ISalesforceNamingConvention namingConvention, SelectTypeEnum selectType = SelectTypeEnum.SelectIdAndUseAttachModel) : base(namingConvention, selectType)
        {
        }

        protected override ValueTask<int> ProduceCountAsync(string cmd)
        {
            return new ValueTask<int>();
        }

        protected override IAsyncEnumerator<T> ProduceAsyncEnumerator(string cmd, CancellationToken token)
        {
            return AsyncEnumerable.Empty<T>().GetAsyncEnumerator(token);
        }
        #endregion
    }
}