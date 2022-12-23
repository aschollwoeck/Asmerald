using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlIfNullExtensions
    {
        public static IfNullFunction IfNull(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new IfNullFunction(x, y);
        }
        public static IfNullFunction IfNull(this Int16 x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Int32 x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Int64 x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this UInt16 x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this UInt32 x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this UInt64 x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Decimal x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Double x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this String x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Char x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Boolean x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Byte x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this DateTime x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this Single x, ISelectExpression y)
        {
            return new IfNullFunction(x.Expr(), y);
        }
        public static IfNullFunction IfNull(this ISelectColumn x, ISelectExpression y)
        {
            return new IfNullFunction(x, y);
        }
    }
}
