using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldUpperExtensions
    {
        public static UpperFunction Upper(this MySQLDSLContext stmt, ISelectExpression x)
        {
            return new UpperFunction(x);
        }
        public static UpperFunction Upper(this Int16 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Int32 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Int64 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this UInt16 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this UInt32 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this UInt64 x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Decimal x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Double x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this String x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Char x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Boolean x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Byte x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this DateTime x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this Single x)
        {
            return new UpperFunction(x.Expr());
        }
        public static UpperFunction Upper(this ISelectColumn x)
        {
            return new UpperFunction(x);
        }
    }
}
