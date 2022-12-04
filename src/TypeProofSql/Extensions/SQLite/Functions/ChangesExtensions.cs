using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlChangesExtensions
    {
        public static ChangesFunction Changes(this SQLiteDSLContext stmt)
        {
            return new ChangesFunction();
        }
    }
}
