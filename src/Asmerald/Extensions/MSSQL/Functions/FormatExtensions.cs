using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MSSQL;
using Asmerald.Statements;

namespace Asmerald.MSSQL
{
    public static partial class AsmeraldFormatExtensions
    {
        public static FormatFunction Format(this MSSQLDSLContext stmt, string format, params ISelectExpression[] z)
        {
            return new FormatFunction(format, z);
        }
    }
}
