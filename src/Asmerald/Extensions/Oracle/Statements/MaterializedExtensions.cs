using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.Oracle;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldMaterializedExtensions
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
