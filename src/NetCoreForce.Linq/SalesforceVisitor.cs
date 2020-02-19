using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using NetCoreForce.Linq.Conventions.Naming;
using NetCoreForce.Linq.Entity;
using NetCoreForce.Linq.Extensions;

namespace NetCoreForce.Linq
{
    public class SalesforceVisitor : Helper.ExpressionVisitor
    {
        public ISalesforceNamingConvention NamingConvention { get; }

        public SalesforceVisitor(ISalesforceNamingConvention namingConvention, SelectTypeEnum selectType)
        {
            NamingConvention = namingConvention;
            SelectType = selectType;
            SelectByExpression = new List<string>();
            OrderByExpression = new List<string>();
            QueryType = QueryTypeEnum.Enumerator;
            WhereExpression = new List<string>();
        }

        public QueryTypeEnum QueryType {get; set; }

        protected List<string> WhereExpression { get; }

        protected List<string> OrderByExpression { get; }

        protected List<string> SelectByExpression { get; }

        public Type ElementType { get; set; }


        private string _objectTypeName;
        protected string ObjectTypeName => _objectTypeName = _objectTypeName ?? NamingConvention.GetObjectTypeName(ElementType);

        
        protected int? Take { get; set; }
        protected int? Skip { get; set; }


        protected SelectTypeEnum SelectType;


        internal string Translate(Expression expression)
        {
            this.Visit(expression);
            return Translate();
        }

        private string Translate()
        {
            var sb = new StringBuilder();
            string selectString;

            if (QueryType == QueryTypeEnum.Any || QueryType == QueryTypeEnum.Count)
            {
                selectString = "COUNT()";
            }
            else
            {
                TranslateSelect();
                selectString = string.Join(",", SelectByExpression.ToArray());
            }

            sb.AppendFormat("SELECT {0} FROM {1}", selectString, ObjectTypeName);

            if (WhereExpression.Any())
                sb.AppendFormat(" WHERE {0}", string.Join(" AND ", WhereExpression.ToArray()));

            if (OrderByExpression.Any())
                sb.AppendFormat(" ORDER BY {0}", string.Join(",", OrderByExpression.ToArray()));

            if (Take != null)
                sb.AppendFormat(" LIMIT {0}", Take.Value.ToString(CultureInfo.InvariantCulture));

            if (Skip != null)
                sb.AppendFormat(" SKIP {0}", Skip.Value.ToString(CultureInfo.InvariantCulture));

            return sb.ToString();
        }

        private void TranslateSelect()
        {
            //if SelectAll, get all property names
            if (SelectType == SelectTypeEnum.SelectAllAndUseAttachModel ||
                SelectType == SelectTypeEnum.SelectAllAndUseReplaceModel)
            {
                //if ReplaceModel and has selected, return
                if (SelectType == SelectTypeEnum.SelectAllAndUseReplaceModel &&
                   SelectByExpression.Any())
                { return; }

                //if AttachModel or has not selected, add all properties
                foreach (var property in NamingConvention.GetAllPropertyNames(ElementType))
                {
                    if (SelectByExpression.Contains(property)) { continue; }
                    SelectByExpression.Add(property);
                }
            }

            if (SelectType == SelectTypeEnum.SelectIdAndUseAttachModel ||
                SelectType == SelectTypeEnum.SelectIdAndUseReplaceModel)
            {
                //if ReplaceModel and has selected, return
                if (SelectType == SelectTypeEnum.SelectIdAndUseReplaceModel &&
                    SelectByExpression.Any())
                { return; }

                //if AttachModel or has not selected, add "id"
//                foreach (var property in ObjectNameProvider.GetAllPropertyNames(ElementType))
//                {
                    if (!SelectByExpression.Contains("id", StringComparer.OrdinalIgnoreCase))
                        SelectByExpression.Add("id");
//                }
            }
        }

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            #region Method On Querable

            if (m.Method.DeclaringType == typeof(Queryable) || (m.Method.DeclaringType == typeof(AsyncQueryable)))
            {
                var methodName = m.Method.Name;

                switch (methodName)
                {
                    case nameof(AsyncQueryable.Take):
                        Take = (int) ((m.Arguments[1] as ConstantExpression).Value);
                        this.Visit(m.Arguments[0]);
                        break;

                    case nameof(AsyncQueryable.Skip):
                        Skip = (int) ((m.Arguments[1] as ConstantExpression).Value);
                        this.Visit(m.Arguments[0]);
                        break;
#if NETSTANDARD2_1
                    case nameof(AsyncQueryable.FirstAsync):
                    case nameof(AsyncQueryable.FirstOrDefaultAsync):
                    case nameof(AsyncQueryable.SingleAsync):
                    case nameof(AsyncQueryable.SingleOrDefaultAsync):
#else
                    case nameof(AsyncQueryable.First):
                    case nameof(AsyncQueryable.FirstOrDefault):
                    case nameof(AsyncQueryable.Single):
                    case nameof(AsyncQueryable.SingleOrDefault):
#endif

                        QueryType = (QueryTypeEnum) Enum.Parse(typeof(QueryTypeEnum), methodName);
                        Take = 2;
                        if (m.Arguments.Count > 1)
                        {
                            WhereExpression.Insert(0, (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString());
                        }

                        this.Visit(m.Arguments[0]);
                        break;
#if NETSTANDARD2_1
                    case nameof(AsyncQueryable.ToListAsync):
                        QueryType = QueryTypeEnum.List;

                        this.Visit(m.Arguments[0]);

                        break;

                    case nameof(AsyncQueryable.AnyAsync):
                    case nameof(AsyncQueryable.CountAsync):
#else
                    case nameof(AsyncQueryable.ToList):
                        QueryType = QueryTypeEnum.List;

                        this.Visit(m.Arguments[0]);

                        break;

                    case nameof(AsyncQueryable.Any):
                    case nameof(AsyncQueryable.Count):
#endif
                        QueryType = (QueryTypeEnum) Enum.Parse(typeof(QueryTypeEnum), methodName);
                        if (m.Arguments.Count > 1)
                        {
                            WhereExpression.Insert(0, (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString());
                        }

                        this.Visit(m.Arguments[0]);
                        break;

                    case nameof(AsyncQueryable.Select):
                        this.Visit(m.Arguments[1]);
                        this.Visit(m.Arguments[0]);
                        break;

                    case nameof(AsyncQueryable.Where):
                        WhereExpression.Insert(0, (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString());
                        this.Visit(m.Arguments[0]);
                        break;

                    case nameof(AsyncQueryable.OrderBy):
                    {
                        if (this.Visit(m.Arguments[1]) is ConstantExpression constantExpression)
                        {
                            OrderByExpression.Insert(0, constantExpression.Value.ToString());
                        }

                        this.Visit(m.Arguments[0]);
                        break;
                    }

                    case nameof(AsyncQueryable.OrderByDescending):
                    {
                        if (this.Visit(m.Arguments[1]) is ConstantExpression constantExpression)
                        {
                            OrderByExpression.Insert(0, constantExpression.Value.ToString() + " DESC");
                        }

                        this.Visit(m.Arguments[0]);
                        break;
                    }


                    default:
                    {
                        break;
                    }
                }
            }

            #endregion
            #region Method On string

            else if (m.Method.DeclaringType == typeof(string))
            {
                switch (m.Method.Name)
                {
                    case nameof(string.Contains):
                    {
                        var result = string.Format("({0} LIKE '%{1}%')",
                            (this.Visit(m.Object) as ConstantExpression).Value.ToString(),
                            (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString().Trim('\'').Replace("%", "\\%"));
                        
                        return Expression.Constant(result);
                    }

                    case nameof(string.StartsWith):
                    {
                        var result = string.Format("({0} LIKE '{1}%')",
                            (this.Visit(m.Object) as ConstantExpression).Value.ToString(),
                            (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString().Trim('\'').Replace("%", "\\%"));
                        
                        return Expression.Constant(result);
                    }

                    case nameof(string.EndsWith):
                    {
                        var result = string.Format("({0} LIKE '%{1}')",
                            (this.Visit(m.Object) as ConstantExpression).Value.ToString(),
                            (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString().Trim('\'').Replace("%", "\\%"));
                        
                        return Expression.Constant(result);
                    }
                }
            }

            else if (m.Method.DeclaringType == typeof(StringExtensions))
            {
                switch (m.Method.Name)
                {
                    case nameof(StringExtensions.Includes):
                    {
                        var result = string.Format("({0} INCLUDES('{1}'))",
                            (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString(),
                            (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString().Trim('\'').Replace("%", "\\%"));

                        return Expression.Constant(result);
                    }
                    case nameof(StringExtensions.Excludes):
                    {
                        var result = string.Format("({0} EXCLUDES('{1}'))",
                            (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString(),
                            (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString().Trim('\'').Replace("%", "\\%"));

                        return Expression.Constant(result);
                    }
                }
            }

            #endregion

            return m;
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            switch (u.NodeType)
            {
                case ExpressionType.Quote:
                    return this.Visit(u.Operand);
                case ExpressionType.Not:
                    return Expression.Constant((this.Visit(u.Operand) as ConstantExpression).Value + " = false");
                default:
                    throw new NotSupportedException(string.Format("The unary operator '{0}' is not supported", u.NodeType));
            }
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            var sb = new StringBuilder();
            sb.Append("(");

            sb.Append((this.Visit(b.Left) as ConstantExpression).Value);

            switch (b.NodeType)
            {
                case ExpressionType.Add:
                    sb.Append(" + ");
                    break;
                case ExpressionType.Subtract:
                    sb.Append(" - ");
                    break;
                case ExpressionType.AndAlso:
                    sb.Append(" AND ");
                    break;
                case ExpressionType.OrElse:
                    sb.Append(" OR ");
                    break;
                case ExpressionType.Equal:
                    sb.Append(" = ");
                    break;
                case ExpressionType.NotEqual:
                    sb.Append(" <> ");
                    break;
                case ExpressionType.LessThan:
                    sb.Append(" < ");
                    break;
                case ExpressionType.LessThanOrEqual:
                    sb.Append(" <= ");
                    break;
                case ExpressionType.GreaterThan:
                    sb.Append(" > ");
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    sb.Append(" >= ");
                    break;
                default:
                    throw new NotSupportedException(string.Format("The binary operator '{0}' is not supported", b.NodeType));
            }

            sb.Append((this.Visit(b.Right) as ConstantExpression).Value);
            sb.Append(")");
            return Expression.Constant(sb.ToString());
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            switch (c.Value)
            {
                case IQueryable queryable:
                    ElementType = queryable.ElementType;
                    return c;

                case IAsyncQueryable asyncQueryable:
                    ElementType = asyncQueryable.ElementType;
                    return c;

                case string str:

                    var escapedString = str
                                .Replace("\\", "\\\\")
                                .Replace("\"", "\\\"")
                                .Replace("'", "\\\'");

                    return Expression.Constant($"'{escapedString}'");

                case null:
                    return Expression.Constant("NULL");
                
                case SalesforceDate date:
                    return Expression.Constant(date.ToString());
            }


            switch (c.Value)
            {
                case string str:
                    return Expression.Constant(string.Format("'{0}'", str));

                case DateTime dateTime:
                    return Expression.Constant(dateTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.ffffZ"));

                case DateTimeOffset dateTimeOffset:
                    return Expression.Constant(dateTimeOffset.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.ffffZ"));

                case object o:
                    throw new NotSupportedException($"The constant for '{o}' ({o.GetType().Name}) is not supported");
                
                default:
                    return Expression.Constant(c.Value.ToString());
            }
        }

        protected override Expression VisitMemberAccess(MemberExpression m)
        {
            var memberName = NamingConvention.GetMemberName(m);
            return Expression.Constant(memberName);
        }

        protected override Expression VisitLambda(LambdaExpression lambda)
        {
            return this.Visit(lambda.Body);
        }

        protected override Expression VisitMemberInit(MemberInitExpression init)
        {
            foreach (MemberAssignment binding in init.Bindings)
            {
                if (binding.Expression is MemberExpression)
                {
                    var memberName = (this.Visit(binding.Expression) as ConstantExpression).Value.ToString();
                    SelectByExpression.Add(memberName);
                }
                else
                {
                    this.Visit(binding.Expression);
                }
            }
            return init;
        }

        #region Overrides of ExpressionVisitor

        protected override Expression VisitMemberAndExpression(MemberInfo member, Expression expression)
        {
            if (expression is MemberExpression)
            {
                var memberName = (this.Visit(expression) as ConstantExpression).Value.ToString();
                
                if (!SelectByExpression.Contains(memberName))
                    SelectByExpression.Add(memberName);
            }
            else
            {
                this.Visit(expression);
            }

            return expression;
        }

        #endregion
    }
}
