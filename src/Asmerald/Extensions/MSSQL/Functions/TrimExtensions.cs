using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldTrimExtensions
    {
        public static TrimFunction Trim(this MSSQLDSLContext stmt, ISelectExpression x)
        {
            return new TrimFunction(x);
        }
        public static TrimFunction Trim(this Int16 x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Int32 x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Int64 x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this UInt16 x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this UInt32 x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this UInt64 x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Decimal x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Double x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this String x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Char x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Boolean x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Byte x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this DateTime x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this Single x)
        {
            return new TrimFunction(x.Expr());
        }
        public static TrimFunction Trim(this ISelectColumn x)
        {
            return new TrimFunction(x);
        }
        public static TrimYFunction Trim(this MSSQLDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new TrimYFunction(x, y);
        }
        public static TrimYFunction Trim(this Int16 x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Int32 x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Int64 x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this UInt16 x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this UInt32 x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this UInt64 x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Decimal x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Double x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this String x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Char x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Boolean x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Byte x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this DateTime x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this Single x, ISelectExpression y)
        {
            return new TrimYFunction(x.Expr(), y);
        }
        public static TrimYFunction Trim(this ISelectColumn x, ISelectExpression y)
        {
            return new TrimYFunction(x, y);
        }
    }
}
