using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldLikelihoodExtensions
    {
        public static LikelihoodFunction Likelihood(this MSSQLDSLContext stmt, ISelectExpression x, ISelectExpression y)
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
