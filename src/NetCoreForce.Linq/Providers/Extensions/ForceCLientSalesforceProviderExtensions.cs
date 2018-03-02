using NetCoreForce.Client;
using NetCoreForce.Linq.Conventions.Naming;
using NetCoreForce.Linq.Entity;

namespace NetCoreForce.Linq.Providers.Extensions
{
    public static class ForceCLientSalesforceProviderExtensions
    {
        public static SalesforceQuery<T> Query<T>(this ForceClient client, SelectTypeEnum selectType = SelectTypeEnum.SelectAllAndUseAttachModel, ISalesforceNamingConvention namingConvention = null) where T : class
        {
            return new SalesforceQuery<T>(new ForceClientSalesforceProvider<T>(client, namingConvention ?? new ModelGeneratorNamingConvention()));
        }
    }
}