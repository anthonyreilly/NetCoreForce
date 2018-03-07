using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NetCoreForce.Linq.Helper;

namespace NetCoreForce.Linq
{
    public class SalesforceQuery<T> : Query<T>, IAsyncQueryable, IAsyncQueryable<T>, IAsyncEnumerable<T>
    {
        public SalesforceQuery(IAsyncQueryProvider provider) : base(provider) { }
        public SalesforceQuery(IAsyncQueryProvider provider, Type staticType) : base(provider, staticType) { }
        public SalesforceQuery(IAsyncQueryProvider provider, Expression expression) : base(provider, expression) { }
    }
}
