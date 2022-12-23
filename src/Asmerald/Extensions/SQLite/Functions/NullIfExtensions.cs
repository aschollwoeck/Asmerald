using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlNullIfExtensions
    {
        public static NullIfFunction NullIf(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new NullIfFunction(x, y);
        }
        public static NullIfFunction NullIf(this Int16 x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Int32 x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Int64 x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this UInt16 x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this UInt32 x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this UInt64 x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Decimal x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Double x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this String x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Char x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Boolean x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Byte x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this DateTime x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this Single x, ISelectExpression y)
        {
            return new NullIfFunction(x.Expr(), y);
        }
        public static NullIfFunction NullIf(this ISelectColumn x, ISelectExpression y)
        {
            return new NullIfFunction(x, y);
        }
    }
}
