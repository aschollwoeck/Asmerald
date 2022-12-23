using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.SQLite;
using Asmerald.Statements;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlCharExtensions
    {
        public static CharFuncFunction Char(this SQLiteDSLContext stmt, ISelectExpression x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1, x2, xn);
        }
        public static CharFuncFunction Char(this Int16 x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Int32 x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Int64 x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this UInt16 x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this UInt32 x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this UInt64 x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Decimal x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Double x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this String x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Char x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Boolean x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Byte x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this DateTime x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this Single x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1.Expr(), x2, xn);
        }
        public static CharFuncFunction Char(this ISelectColumn x1, ISelectExpression x2, params ISelectExpression[] xn)
        {
            return new CharFuncFunction(x1, x2, xn);
        }
    }
}
