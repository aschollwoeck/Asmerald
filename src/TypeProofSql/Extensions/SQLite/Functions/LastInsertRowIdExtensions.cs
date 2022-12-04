using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Functions.SQLite;
using TypeProofSql.Statements;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlLastInsertRowIdExtensions
    {
        public static LastInsertRowIdFunction LastInsertRowId(this SQLiteDSLContext stmt)
        {
            return new LastInsertRowIdFunction();
        }
    }
}
