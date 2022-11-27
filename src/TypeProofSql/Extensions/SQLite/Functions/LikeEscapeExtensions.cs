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
    public static partial class TypeProofSqlLikeEscapeExtensions
    {
        public static LikeEscapeFunction LikeEscape(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x, y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Int16 x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Int32 x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Int64 x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this UInt16 x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this UInt32 x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this UInt64 x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Decimal x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Double x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this String x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Char x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Boolean x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Byte x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this DateTime x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this Single x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x.Expr(), y, z);
        }
        public static LikeEscapeFunction LikeEscape(this ISelectColumn x, ISelectExpression y, ISelectExpression z)
        {
            return new LikeEscapeFunction(x, y, z);
        }
    }
}
