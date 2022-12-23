using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldLengthExtensions
    {
        public static LengthFunction Length(this OracleDSLContext stmt, ISelectExpression x)
        {
            return new LengthFunction(x);
        }
        public static LengthFunction Length(this Int16 x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Int32 x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Int64 x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this UInt16 x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this UInt32 x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this UInt64 x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Decimal x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Double x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this String x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Char x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Boolean x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Byte x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this DateTime x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this Single x)
        {
            return new LengthFunction(x.Expr());
        }
        public static LengthFunction Length(this ISelectColumn x)
        {
            return new LengthFunction(x);
        }
    }
}
