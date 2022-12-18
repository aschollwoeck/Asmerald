using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlFormatExtensions
    {
        public static FormatFunction Format(this SQLiteDSLContext stmt, string format, params ISelectExpression[] z)
        {
            return new FormatFunction(format, z);
        }
    }
}
