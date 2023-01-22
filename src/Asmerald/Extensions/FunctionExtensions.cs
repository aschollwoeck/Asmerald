using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using System.Linq;
using Asmerald.Statements.SQLite;
using Asmerald.Extensions;
using Asmerald.Columns;
using Asmerald.Functions;

namespace Asmerald
{
    public static partial class AsmeraldExtensions
    {
        public static EqualConditionalExpression Equal<T>(this IFunction<T> function, T condition)
        {
            return new EqualConditionalExpression(function, condition);
        }

        public static GreaterConditionalExpression Greater<T>(this IFunction<T> function, T condition)
        {
            return new GreaterConditionalExpression(function, condition);
        }

        public static GreaterOrEqualConditionalExpression GreaterOrEqual<T>(this IFunction<T> function, T condition)
        {
            return new GreaterOrEqualConditionalExpression(function, condition);
        }

        public static InConditionalExpression In<T>(this IFunction<T> function, IEnumerable<T> condition)
        {
            return new InConditionalExpression(function, condition);
        }

        public static LesserConditionalExpression Lesser<T>(this IFunction<T> function, T condition)
        {
            return new LesserConditionalExpression(function, condition);
        }

        public static LesserOrEqualConditionalExpression LesserOrEqual<T>(this IFunction<T> function, T condition)
        {
            return new LesserOrEqualConditionalExpression(function, condition);
        }

        public static IsNullConditionalExpression IsNull<T>(this IFunction<T> function)
        {
            return new IsNullConditionalExpression(function);
        }

        public static BetweenConditionalExpression Between<T>(this IFunction<T> function, T minValue, T maxValue)
        {
            return new BetweenConditionalExpression(function, minValue, maxValue);
        }




        public static ISelectExpression Expr(this Int16 v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this Int32 v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this Int64 v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this UInt16 v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this UInt32 v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this UInt64 v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this decimal v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this double v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this string v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this char v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this bool v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this byte v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this byte[] v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this DateTime v)
        {
            return new ScalarExpression(v);
        }
        public static ISelectExpression Expr(this Single v)
        {
            return new ScalarExpression(v);
        }
    }
}
