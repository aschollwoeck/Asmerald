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
    public static partial class TypeProofSqlMaterializedExtensions
    {
        public static MaterializedStatement Materialized(this WithNotStatement stmt, IQueryBuilder subQuery)
        {
            return new MaterializedStatement(stmt.QueryBuilder, subQuery);
        }
        public static MaterializedStatement Materialized(this WithAsStatement stmt, IQueryBuilder subQuery)
        {
            return new MaterializedStatement(stmt.QueryBuilder, subQuery);
        }
    }
}
