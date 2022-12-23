using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MySQL;
using Asmerald.Statements;

namespace Asmerald.MySQL
{
    public static partial class AsmeraldReplaceExtensions
    {
        public static ReplaceFunction Replace(this MySQLDSLContext stmt, ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x, y, z);
        }
        public static ReplaceFunction Replace(this Int16 x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Int32 x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Int64 x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this UInt16 x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this UInt32 x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this UInt64 x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Decimal x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Double x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this String x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Char x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Boolean x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Byte x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this DateTime x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this Single x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x.Expr(), y, z);
        }
        public static ReplaceFunction Replace(this ISelectColumn x, ISelectExpression y, ISelectExpression z)
        {
            return new ReplaceFunction(x, y, z);
        }
    }
}
