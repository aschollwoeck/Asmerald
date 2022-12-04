using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlSubstringExtensions
    {
        public static SubstringLengthFunction Substring(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x, y, z);
        }
        public static SubstringLengthFunction Substring(this Int16 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Int32 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Int64 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this UInt16 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this UInt32 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this UInt64 x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Decimal x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Double x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this String x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Char x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Boolean x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Byte x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this DateTime x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this Single x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x.Expr(), y, z);
        }
        public static SubstringLengthFunction Substring(this ISelectColumn x, ISelectExpression y, ISelectExpression z)
        {
            return new SubstringLengthFunction(x, y, z);
        }
        public static SubstringFunction Substring(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new SubstringFunction(x, y);
        }
        public static SubstringFunction Substring(this Int16 x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Int32 x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Int64 x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this UInt16 x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this UInt32 x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this UInt64 x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Decimal x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Double x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this String x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Char x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Boolean x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Byte x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this DateTime x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this Single x, ISelectExpression y)
        {
            return new SubstringFunction(x.Expr(), y);
        }
        public static SubstringFunction Substring(this ISelectColumn x, ISelectExpression y)
        {
            return new SubstringFunction(x, y);
        }
    }
}
