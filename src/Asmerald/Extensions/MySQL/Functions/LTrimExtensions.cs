using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldLTrimExtensions
    {
        public static LTrimFunction LTrim(this MySQLDSLContext stmt, ISelectExpression x)
        {
            return new LTrimFunction(x);
        }
        public static LTrimFunction LTrim(this Int16 x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Int32 x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Int64 x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this UInt16 x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this UInt32 x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this UInt64 x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Decimal x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Double x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this String x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Char x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Boolean x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Byte x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this DateTime x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this Single x)
        {
            return new LTrimFunction(x.Expr());
        }
        public static LTrimFunction LTrim(this ISelectColumn x)
        {
            return new LTrimFunction(x);
        }
        public static LTrimYFunction LTrim(this MySQLDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new LTrimYFunction(x, y);
        }
        public static LTrimYFunction LTrim(this Int16 x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Int32 x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Int64 x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this UInt16 x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this UInt32 x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this UInt64 x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Decimal x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Double x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this String x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Char x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Boolean x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Byte x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this DateTime x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this Single x, ISelectExpression y)
        {
            return new LTrimYFunction(x.Expr(), y);
        }
        public static LTrimYFunction LTrim(this ISelectColumn x, ISelectExpression y)
        {
            return new LTrimYFunction(x, y);
        }
    }
}
