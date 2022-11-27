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
    public static partial class TypeProofSqlRTrimExtensions
    {
        public static RTrimFunction RTrim(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new RTrimFunction(x);
        }
        public static RTrimFunction RTrim(this Int16 x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Int32 x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Int64 x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this UInt16 x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this UInt32 x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this UInt64 x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Decimal x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Double x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this String x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Char x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Boolean x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Byte x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this DateTime x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this Single x)
        {
            return new RTrimFunction(x.Expr());
        }
        public static RTrimFunction RTrim(this ISelectColumn x)
        {
            return new RTrimFunction(x);
        }
        public static RTrimYFunction RTrim(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new RTrimYFunction(x, y);
        }
        public static RTrimYFunction RTrim(this Int16 x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Int32 x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Int64 x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this UInt16 x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this UInt32 x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this UInt64 x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Decimal x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Double x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this String x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Char x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Boolean x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Byte x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this DateTime x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this Single x, ISelectExpression y)
        {
            return new RTrimYFunction(x.Expr(), y);
        }
        public static RTrimYFunction RTrim(this ISelectColumn x, ISelectExpression y)
        {
            return new RTrimYFunction(x, y);
        }
    }
}
