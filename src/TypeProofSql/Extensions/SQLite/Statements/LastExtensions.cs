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
    public static partial class TypeProofSqlLastExtensions
    {
        public static LastStatement Last(this NullsStatement stmt)
        {
            return new LastStatement(stmt.QueryBuilder);
        }
    }
}
