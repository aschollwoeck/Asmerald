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
    public static partial class TypeProofSqlAllExtensions
    {
        public static AllStatement All(this SelectStatement stmt)
        {
            return new AllStatement(stmt.QueryBuilder);
        }
        public static AllStatement All(this DistinctStatement stmt)
        {
            return new AllStatement(stmt.QueryBuilder);
        }
        public static ReturningAllStatement All(this ReturningStatement stmt)
        {
            return new ReturningAllStatement(stmt.QueryBuilder);
        }
    }
}
