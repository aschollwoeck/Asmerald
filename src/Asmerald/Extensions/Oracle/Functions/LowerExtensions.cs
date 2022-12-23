using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldLowerExtensions
    {
        public static LowerFunction Lower(this OracleDSLContext stmt, ISelectExpression x)
        {
            return new LowerFunction(x);
        }
        public static LowerFunction Lower(this Int16 x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Int32 x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Int64 x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this UInt16 x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this UInt32 x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this UInt64 x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Decimal x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Double x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this String x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Char x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Boolean x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Byte x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this DateTime x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this Single x)
        {
            return new LowerFunction(x.Expr());
        }
        public static LowerFunction Lower(this ISelectColumn x)
        {
            return new LowerFunction(x);
        }
    }
}
