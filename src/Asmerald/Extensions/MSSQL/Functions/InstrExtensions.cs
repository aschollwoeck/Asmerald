using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldInstrExtensions
    {
        public static InstrFunction Instr(this MSSQLDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new InstrFunction(x, y);
        }
        public static InstrFunction Instr(this Int16 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Int32 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Int64 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this UInt16 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this UInt32 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this UInt64 x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Decimal x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Double x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this String x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Char x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Boolean x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Byte x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this DateTime x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this Single x, ISelectExpression y)
        {
            return new InstrFunction(x.Expr(), y);
        }
        public static InstrFunction Instr(this ISelectColumn x, ISelectExpression y)
        {
            return new InstrFunction(x, y);
        }
    }
}
