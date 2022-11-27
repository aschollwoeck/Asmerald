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
    public static partial class TypeProofSqlLikeExtensions
    {
        public static LikeFunction Like(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new LikeFunction(x, y);
        }
        public static LikeFunction Like(this Int16 x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Int32 x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Int64 x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this UInt16 x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this UInt32 x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this UInt64 x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Decimal x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Double x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this String x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Char x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Boolean x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Byte x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this DateTime x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this Single x, ISelectExpression y)
        {
            return new LikeFunction(x.Expr(), y);
        }
        public static LikeFunction Like(this ISelectColumn x, ISelectExpression y)
        {
            return new LikeFunction(x, y);
        }
    }
}
