using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldCoalesceExtensions
    {
        public static CoalesceFunction Coalesce(this MSSQLDSLContext stmt, ISelectExpression x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x, y, z);
        }
        public static CoalesceFunction Coalesce(this Int16 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Int32 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Int64 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this UInt16 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this UInt32 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this UInt64 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Decimal x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Double x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this String x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Char x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Boolean x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Byte x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this DateTime x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Single x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this ISelectColumn x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x, y, z);
        }
    }
}
