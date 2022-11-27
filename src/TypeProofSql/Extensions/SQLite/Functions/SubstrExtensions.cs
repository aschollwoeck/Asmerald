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
    public static partial class TypeProofSqlSubstrExtensions
    {
        public static SubstrLengthFunction Substr(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x, y, z);
        }
        public static SubstrLengthFunction Substr(this Int16 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Int32 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Int64 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this UInt16 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this UInt32 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this UInt64 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Decimal x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Double x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this String x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Char x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Boolean x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Byte x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this DateTime x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this Single x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x.Expr(), y, z);
        }
        public static SubstrLengthFunction Substr(this ISelectColumn x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstrLengthFunction(x, y, z);
        }
        public static SubstrFunction Substr(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new SubstrFunction(x, y);
        }
        public static SubstrFunction Substr(this Int16 x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Int32 x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Int64 x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this UInt16 x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this UInt32 x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this UInt64 x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Decimal x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Double x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this String x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Char x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Boolean x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Byte x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this DateTime x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this Single x, ISelectExpression y)
        {
            return new SubstrFunction(x.Expr(), y);
        }
        public static SubstrFunction Substr(this ISelectColumn x, ISelectExpression y)
        {
            return new SubstrFunction(x, y);
        }
    }
}
