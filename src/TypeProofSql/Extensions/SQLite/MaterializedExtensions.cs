using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlMaterializedExtensions
    {
        public static MaterializedStatement Materialized(this AsStatement stmt, IQueryBuilder subQuery)
        {
            return new MaterializedStatement(stmt.QueryBuilder, subQuery);
        }
        public static MaterializedStatement Materialized(this NotStatement stmt, IQueryBuilder subQuery)
        {
            return new MaterializedStatement(stmt.QueryBuilder, subQuery);
        }
        public static MaterializedStatement Materialized(this WithTableStatement stmt, IQueryBuilder subQuery)
        {
            return new MaterializedStatement(stmt.QueryBuilder, subQuery);
        }
        public static MaterializedStatement Materialized(this WithTableAdditionalStatement stmt, IQueryBuilder subQuery)
        {
            return new MaterializedStatement(stmt.QueryBuilder, subQuery);
        }
    }
}
