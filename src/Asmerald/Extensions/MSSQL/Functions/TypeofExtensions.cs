using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldTypeofExtensions
    {
        public static TypeofFunction Typeof(this MSSQLDSLContext stmt, ISelectExpression x)
        {
            return new TypeofFunction(x);
        }
        public static TypeofFunction Typeof(this Int16 x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Int32 x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Int64 x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this UInt16 x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this UInt32 x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this UInt64 x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Decimal x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Double x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this String x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Char x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Boolean x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Byte x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this DateTime x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this Single x)
        {
            return new TypeofFunction(x.Expr());
        }
        public static TypeofFunction Typeof(this ISelectColumn x)
        {
            return new TypeofFunction(x);
        }
    }
}
