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
    public static partial class TypeProofSqlLikelihoodExtensions
    {
        public static LikelihoodFunction Likelihood(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new LikelihoodFunction(x, y);
        }
        public static LikelihoodFunction Likelihood(this Int16 x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Int32 x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Int64 x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this UInt16 x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this UInt32 x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this UInt64 x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Decimal x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Double x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this String x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Char x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Boolean x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Byte x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this DateTime x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this Single x, ISelectExpression y)
        {
            return new LikelihoodFunction(x.Expr(), y);
        }
        public static LikelihoodFunction Likelihood(this ISelectColumn x, ISelectExpression y)
        {
            return new LikelihoodFunction(x, y);
        }
    }
}
