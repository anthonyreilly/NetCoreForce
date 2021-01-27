// Copyright (c) Microsoft Corporation.  All rights reserved.
// This source code is made available under the terms of the Microsoft Public License (MS-PL)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

namespace NetCoreForce.Linq.Helper
{

    /// <summary>
    /// A default implementation of IQueryable for use with QueryProvider
    /// </summary>
    public class Query<T> : IAsyncQueryable<T>, IOrderedAsyncQueryable<T>
    {
        public Query(IAsyncQueryProvider provider)
            : this(provider, (Type)null)
        {
        }

        public Query(IAsyncQueryProvider provider, Type staticType)
        {
            this.Provider = provider ?? throw new ArgumentNullException(nameof(provider));
            this.Expression = staticType != null ? Expression.Constant(this, staticType) : Expression.Constant(this);
        }


        /// <summary>
        /// This constructor is called by Provider.CreateQuery().
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="expression"></param>
        public Query(IAsyncQueryProvider provider, Expression expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            if (!typeof(IAsyncQueryable<T>).GetTypeInfo().IsAssignableFrom(expression.Type))
            {
                throw new ArgumentOutOfRangeException(nameof(expression));
            }
            this.Provider = provider ?? throw new ArgumentNullException(nameof(provider));
            this.Expression = expression;
        }

        public Type ElementType => typeof(T);

        public Expression Expression { get; }

        public IAsyncQueryProvider Provider { get; }

        public IAsyncEnumerator<T> GetEnumerator()
        {
            return Provider.ExecuteAsync<IAsyncEnumerator<T>>(Expression, CancellationToken.None).GetAwaiter().GetResult();
        }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken token)
        {
            return Provider.ExecuteAsync<IAsyncEnumerator<T>>(Expression, token).GetAwaiter().GetResult();
        }

        public override string ToString()
        {
            if (Provider is SalesforceProviderBase<T>)
            {
                return (Provider as SalesforceProviderBase<T>).ToString(Expression);
            }
            else
            {
                return this.Expression.ToString();
            }
        }
    
    }
}
