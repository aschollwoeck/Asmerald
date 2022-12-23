using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldLikeEscapeExtensions
    {
        public static LikeEscapeFunction LikeEscape(this MySQLDSLContext stmt, ISelectExpression x, ISelectExpression y, ISelectExpression z)
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
