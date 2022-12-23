using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldUnlikelyExtensions
    {
        public static UnlikelyFunction Unlikely(this OracleDSLContext stmt, ISelectExpression x)
        {
            return new UnlikelyFunction(x);
        }
        public static UnlikelyFunction Unlikely(this Int16 x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Int32 x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Int64 x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this UInt16 x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this UInt32 x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this UInt64 x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Decimal x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Double x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this String x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Char x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Boolean x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Byte x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this DateTime x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this Single x)
        {
            return new UnlikelyFunction(x.Expr());
        }
        public static UnlikelyFunction Unlikely(this ISelectColumn x)
        {
            return new UnlikelyFunction(x);
        }
    }
}
