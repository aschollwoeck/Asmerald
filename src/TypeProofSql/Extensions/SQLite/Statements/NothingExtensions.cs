using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlNothingExtensions
    {
        public static UpsertNothingStatement Nothing(this UpsertDoStatement stmt)
        {
            return new UpsertNothingStatement(stmt.QueryBuilder);
        }
    }
}
