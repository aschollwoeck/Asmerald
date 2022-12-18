using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
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
