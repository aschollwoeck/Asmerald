using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MariaDB;
using Asmerald.Statements;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldAbsExtensions
    {
        public static AbsFunction Abs(this MariaDBDSLContext stmt, ISelectExpression x)
        {
            return new AbsFunction(x);
        }
        public static AbsFunction Abs(this Int16 x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Int32 x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Int64 x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this UInt16 x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this UInt32 x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this UInt64 x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Decimal x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Double x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this String x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Char x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Boolean x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Byte x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this DateTime x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this Single x)
        {
            return new AbsFunction(x.Expr());
        }
        public static AbsFunction Abs(this ISelectColumn x)
        {
            return new AbsFunction(x);
        }
    }
}
