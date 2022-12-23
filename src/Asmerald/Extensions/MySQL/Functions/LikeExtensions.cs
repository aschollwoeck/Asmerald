using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldLikeExtensions
    {
        public static LikeFunction Like(this MySQLDSLContext stmt, ISelectExpression x, ISelectExpression y)
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
