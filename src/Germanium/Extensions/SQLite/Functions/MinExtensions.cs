using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.Functions.SQLite;
using Germanium.Statements;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlMinExtensions
    {
        public static MinAggregateFunction Min(this SQLiteDSLContext stmt, params ISelectExpression[] x)
        {
            return new MinAggregateFunction(x);
        }
        public static MinFunction Min(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new MinFunction(x);
        }
        public static MinFunction Min(this Int16 x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Int32 x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Int64 x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this UInt16 x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this UInt32 x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this UInt64 x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Decimal x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Double x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this String x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Char x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Boolean x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Byte x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this DateTime x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this Single x)
        {
            return new MinFunction(x.Expr());
        }
        public static MinFunction Min(this ISelectColumn x)
        {
            return new MinFunction(x);
        }
    }
}
