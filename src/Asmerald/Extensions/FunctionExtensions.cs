using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using System.Linq;
using Asmerald.Statements.SQLite;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Asmerald.Extensions;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
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
