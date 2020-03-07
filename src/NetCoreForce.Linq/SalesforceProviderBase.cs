using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using NetCoreForce.Linq.Conventions.Naming;
using NetCoreForce.Linq.Entity;
using NetCoreForce.Linq.Helper;

namespace NetCoreForce.Linq
{
    public abstract class SalesforceProviderBase<T> : IAsyncQueryProvider
    {
        protected SalesforceProviderBase(ISalesforceNamingConvention namingConvention, SelectTypeEnum selectType = SelectTypeEnum.SelectIdAndUseAttachModel)
        {
            NamingConvention = namingConvention;
            SelectType = selectType;
        }

        public ISalesforceNamingConvention NamingConvention { get; }
        public SelectTypeEnum SelectType { get; }
        
        public object Execute(Expression expression, CancellationToken token)
        {
            var visitor = new SalesforceVisitor(NamingConvention, SelectType);
            var cmd = visitor.Translate(PartialEvaluator.Eval(expression));
            switch (visitor.QueryType)
            {
                case QueryTypeEnum.FirstOrDefaultAsync:
                    return ProduceAsyncEnumerable(cmd).FirstOrDefaultAsync(token);
                case QueryTypeEnum.FirstAsync:
                    return ProduceAsyncEnumerable(cmd).FirstAsync(token);
                case QueryTypeEnum.SingleAsync:
                    return ProduceAsyncEnumerable(cmd).SingleAsync(token);
                case QueryTypeEnum.SingleOrDefaultAsync:
                    return ProduceAsyncEnumerable(cmd).SingleOrDefaultAsync(token);
                case QueryTypeEnum.CountAsync:
                    return ProduceCountAsync(cmd);
                case QueryTypeEnum.AnyAsync:
                    return ProduceCountAsync(cmd);
                case QueryTypeEnum.ListAsync:
                    return ProduceAsyncEnumerable(cmd).ToListAsync(token);
//                    var argument = typeof(TResult).GetGenericArguments()[0];
//
//                    var method = GetType().GetMethod("ProduceAsyncEnumerable", BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(argument);
//                    var asyncEnumerable = method.Invoke(this, new object[]{cmd});
//
//
//                    var enumerabletype = typeof(IAsyncEnumerable<>).MakeGenericType(argument);
//                    var toList = GetGenericMethod(typeof(AsyncEnumerable), "ToList", typeof(IAsyncEnumerable<>)).MakeGenericMethod(argument);
//
//                    var result = (Task<TResult>) toList.Invoke(null, new [] {asyncEnumerable});
//
//                    MethodInfo GetGenericMethod(Type type, string name, params Type[] argumentTypes)
//                    {
//                        var methods = type.GetTypeInfo().GetMember("ToList").OfType<MethodInfo>().ToList();
//
//                        return methods.FirstOrDefault(m =>
//                        {
//                            var parameters = m.GetParameters();
//
//                            if (parameters.Length != argumentTypes.Length)
//                                return false;
//
//                            for (var i = 0; i < parameters.Length; i++)
//                            {
//                                var parameterType = parameters[i].ParameterType;
//
//                                if (parameterType.IsGenericType)
//                                    parameterType = parameterType.GetGenericTypeDefinition();
//
//                                if (parameterType != argumentTypes[i])
//                                    return false;
//                            }
//
//                            return true;
//                        });
//                    }

                case QueryTypeEnum.Enumerator:
                default:
                    return ProduceAsyncEnumerator(cmd, token);
            }
        }
        

        protected abstract ValueTask<int> ProduceCountAsync(string cmd);

        protected IAsyncEnumerable<T> ProduceAsyncEnumerable(string cmd)
            => AsyncEnumerable.Create(token => ProduceAsyncEnumerator(cmd, token));

        protected abstract IAsyncEnumerator<T> ProduceAsyncEnumerator(string cmd, CancellationToken token);

        public string ToString(Expression expression)
        {
            var visitor = new SalesforceVisitor(NamingConvention, SelectType);
            return visitor.Translate(PartialEvaluator.Eval(expression));
        }

        #region Implementation of IAsyncQueryProvider

        IAsyncQueryable<TElement> IAsyncQueryProvider.CreateQuery<TElement>(Expression expression)
        {
            return new Query<TElement>(this, expression);
        }

        public ValueTask<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken token) 
        {
            var result = Execute(expression, token);
            return (ValueTask<TResult>) result;
        }
        
        #endregion
    }
}
