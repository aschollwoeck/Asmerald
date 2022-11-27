using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Functions.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlRoundExtensions
    {
        public static RoundFunction Round(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new RoundFunction(x);
        }
        public static RoundFunction Round(this Int16 x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Int32 x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Int64 x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this UInt16 x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this UInt32 x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this UInt64 x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Decimal x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Double x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this String x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Char x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Boolean x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Byte x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this DateTime x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this Single x)
        {
            return new RoundFunction(x.Expr());
        }
        public static RoundFunction Round(this ISelectColumn x)
        {
            return new RoundFunction(x);
        }
        public static RoundDigitsFunction Round(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x, y);
        }
        public static RoundDigitsFunction Round(this Int16 x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Int32 x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Int64 x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this UInt16 x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this UInt32 x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this UInt64 x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Decimal x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Double x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this String x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Char x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Boolean x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Byte x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this DateTime x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this Single x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x.Expr(), y);
        }
        public static RoundDigitsFunction Round(this ISelectColumn x, ISelectExpression y)
        {
            return new RoundDigitsFunction(x, y);
        }
    }
}
