using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.PostgreSQL;
using Asmerald.Statements;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldHexExtensions
    {
        public static HexFunction Hex(this PostgreSQLDSLContext stmt, ISelectExpression z)
        {
            return new HexFunction(z);
        }
        public static HexFunction Hex(this Int16 z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Int32 z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Int64 z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this UInt16 z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this UInt32 z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this UInt64 z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Decimal z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Double z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this String z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Char z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Boolean z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Byte z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this DateTime z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this Single z)
        {
            return new HexFunction(z.Expr());
        }
        public static HexFunction Hex(this ISelectColumn z)
        {
            return new HexFunction(z);
        }
    }
}
