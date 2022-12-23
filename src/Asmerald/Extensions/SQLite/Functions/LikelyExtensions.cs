using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlLikelyExtensions
    {
        public static LikelyFunction Likely(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new LikelyFunction(x);
        }
        public static LikelyFunction Likely(this Int16 x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Int32 x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Int64 x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this UInt16 x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this UInt32 x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this UInt64 x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Decimal x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Double x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this String x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Char x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Boolean x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Byte x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this DateTime x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this Single x)
        {
            return new LikelyFunction(x.Expr());
        }
        public static LikelyFunction Likely(this ISelectColumn x)
        {
            return new LikelyFunction(x);
        }
    }
}
