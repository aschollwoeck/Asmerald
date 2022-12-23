using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.PostgreSQL;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldDistinctExtensions
    {
        public static DistinctStatement Distinct(this SelectStatement stmt)
        {
            return new DistinctStatement(stmt.QueryBuilder);
        }
        public static DistinctColumnsStatement Distinct(this SelectStatement stmt, params ISelectExpression[] columns)
        {
            return new DistinctColumnsStatement(stmt.QueryBuilder, columns);
        }
    }
}
