using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlFormatExtensions
    {
        public static FormatFunction Format(this SQLiteDSLContext stmt, string format, params ISelectExpression[] z)
        {
            return new FormatFunction(format, z);
        }
    }
}
