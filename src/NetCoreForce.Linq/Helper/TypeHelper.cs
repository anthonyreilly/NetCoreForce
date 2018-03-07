// Copyright (c) Microsoft Corporation.  All rights reserved.
// This source code is made available under the terms of the Microsoft Public License (MS-PL)

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace NetCoreForce.Linq.Helper
{
    /// <summary>
    /// Type related helper methods
    /// </summary>
    public static class TypeHelper
    {
        public static Type FindIEnumerable(Type seqType)
        {
            if (seqType == null || seqType == typeof(string))
                return null;
            
            if (seqType.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(seqType.GetElementType());
            
            var seqTypeInfo = seqType.GetTypeInfo();
            if (seqTypeInfo.IsGenericType)
            {
                foreach (var arg in seqTypeInfo.GetGenericArguments())
                {
                    var ienum = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (ienum.GetTypeInfo().IsAssignableFrom(seqType))
                        return ienum;
                }
            }
            
            var ifaces = seqTypeInfo.GetInterfaces();
            if (ifaces != null && ifaces.Length > 0)
            {
                foreach (var iface in ifaces)
                {
                    var ienum = FindIEnumerable(iface);
                    if (ienum != null) 
                        return ienum;
                }
            }

            if (seqTypeInfo.BaseType != null && seqTypeInfo.BaseType != typeof(object))
                return FindIEnumerable(seqTypeInfo.BaseType);

            return null;
        }

        public static Type GetSequenceType(Type elementType)
        {
            return typeof(IEnumerable<>).MakeGenericType(elementType);
        }

        public static Type GetElementType(Type seqType)
        {
            var ienum = FindIEnumerable(seqType);

            if (ienum == null) 
                return seqType;

            return ienum.GetTypeInfo().GetGenericArguments()[0];
        }

        public static bool IsNullableType(Type type)
        {
            return type != null && type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        public static bool IsNullAssignable(Type type)
        {
            return !type.GetTypeInfo().IsValueType || IsNullableType(type);
        }

        public static Type GetNonNullableType(Type type)
        {
            if (IsNullableType(type))
            {
                return type.GetTypeInfo().GetGenericArguments()[0];
            }
            return type;
        }

        public static Type GetNullAssignableType(Type type)
        {
            if (!IsNullAssignable(type))
            {
                return typeof(Nullable<>).MakeGenericType(type);
            }
            return type;
        }

        public static ConstantExpression GetNullConstant(Type type)
        {
            return Expression.Constant(null, GetNullAssignableType(type));
        }

        public static Type GetMemberType(MemberInfo mi)
        {
            switch (mi)
            {
                case FieldInfo fi:
                    return fi.FieldType;

                case PropertyInfo pi:
                    return pi.PropertyType;

                case EventInfo ei:
                    return ei.EventHandlerType;

                case MethodInfo meth:
                    return meth.ReturnType;

                default:
                    return null;
            }
        }

        public static object GetDefault(Type type)
        {
            var isNullable = !type.GetTypeInfo().IsValueType || IsNullableType(type);

            if (!isNullable)
                return Activator.CreateInstance(type);

            return null;
        }

        public static bool IsReadOnly(MemberInfo member)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                    return (((FieldInfo)member).Attributes & FieldAttributes.InitOnly) != 0;

                case MemberTypes.Property:
                    var pi = (PropertyInfo)member;
                    return !pi.CanWrite || pi.GetSetMethod() == null;

                case MemberTypes.Constructor:
                case MemberTypes.Event:
                case MemberTypes.Method:
                case MemberTypes.TypeInfo:
                case MemberTypes.Custom:
                case MemberTypes.NestedType:
                case MemberTypes.All:
                default:
                    return true;
            }
        }

        public static bool IsInteger(Type type)
        {
            var nnType = GetNonNullableType(type);
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;

                case TypeCode.Boolean:
                case TypeCode.Char:
                case TypeCode.DateTime:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Empty:
                case TypeCode.Object:
                case TypeCode.Single:
                case TypeCode.String:
                default:
                    return false;        
            }
        }
    }
}
