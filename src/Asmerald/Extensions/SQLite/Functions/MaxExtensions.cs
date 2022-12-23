using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlMaxExtensions
    {
        public static MaxAggregateFunction Max(this SQLiteDSLContext stmt, params ISelectExpression[] x)
        {
            return new MaxAggregateFunction(x);
        }
        public static MaxFunction Max(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new MaxFunction(x);
        }
        public static MaxFunction Max(this Int16 x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Int32 x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Int64 x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this UInt16 x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this UInt32 x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this UInt64 x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Decimal x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Double x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this String x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Char x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Boolean x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Byte x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this DateTime x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this Single x)
        {
            return new MaxFunction(x.Expr());
        }
        public static MaxFunction Max(this ISelectColumn x)
        {
            return new MaxFunction(x);
        }
    }
}
