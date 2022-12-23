using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.MariaDB;
using Asmerald.Statements;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldFormatExtensions
    {
        public static FormatFunction Format(this MariaDBDSLContext stmt, string format, params ISelectExpression[] z)
        {
            return new FormatFunction(format, z);
        }
    }
}
