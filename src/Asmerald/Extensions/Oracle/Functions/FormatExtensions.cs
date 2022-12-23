using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldFormatExtensions
    {
        public static FormatFunction Format(this OracleDSLContext stmt, string format, params ISelectExpression[] z)
        {
            return new FormatFunction(format, z);
        }
    }
}
