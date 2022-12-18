using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.Functions.SQLite;
using Germanium.Statements;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlFormatExtensions
    {
        public static FormatFunction Format(this SQLiteDSLContext stmt, string format, params ISelectExpression[] z)
        {
            return new FormatFunction(format, z);
        }
    }
}
