using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlRandomExtensions
    {
        public static RandomFunction Random(this SQLiteDSLContext stmt)
        {
            return new RandomFunction();
        }
    }
}
