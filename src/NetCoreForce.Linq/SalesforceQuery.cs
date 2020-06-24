extern alias rxasync;
using System;
using System.Linq;
using System.Linq.Expressions;
using NetCoreForce.Linq.Helper;
using rxasync.System.Collections.Generic;

namespace NetCoreForce.Linq
{
    public class SalesforceQuery<T> : Query<T>, IAsyncQueryable, IAsyncQueryable<T>, IAsyncEnumerable<T>, IOrderedAsyncQueryable<T>, IOrderedAsyncQueryable
    {
        public SalesforceQuery(IAsyncQueryProvider provider) : base(provider) { }
        public SalesforceQuery(IAsyncQueryProvider provider, Type staticType) : base(provider, staticType) { }
        public SalesforceQuery(IAsyncQueryProvider provider, Expression expression) : base(provider, expression) { }
    }
}
