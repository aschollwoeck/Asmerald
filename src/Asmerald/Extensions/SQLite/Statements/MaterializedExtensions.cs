using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.SQLite;

namespace Asmerald.SQLite
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
