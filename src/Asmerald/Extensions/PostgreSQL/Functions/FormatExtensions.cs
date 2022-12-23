using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.PostgreSQL;
using Asmerald.Statements;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldFormatExtensions
    {
        public static FormatFunction Format(this PostgreSQLDSLContext stmt, string format, params ISelectExpression[] z)
        {
            return new FormatFunction(format, z);
        }
    }
}
