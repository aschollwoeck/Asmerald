using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlUnicodeExtensions
    {
        public static UnicodeFunction Unicode(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new UnicodeFunction(x);
        }
        public static UnicodeFunction Unicode(this Int16 x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Int32 x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Int64 x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this UInt16 x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this UInt32 x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this UInt64 x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Decimal x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Double x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this String x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Char x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Boolean x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Byte x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this DateTime x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this Single x)
        {
            return new UnicodeFunction(x.Expr());
        }
        public static UnicodeFunction Unicode(this ISelectColumn x)
        {
            return new UnicodeFunction(x);
        }
    }
}
