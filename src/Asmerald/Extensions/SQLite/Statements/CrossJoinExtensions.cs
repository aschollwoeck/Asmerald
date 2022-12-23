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
    public static partial class TypeProofSqlCrossJoinExtensions
    {
        public static CrossJoinStatement<T, J> CrossJoin<T, J>(this SelectFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new CrossJoinStatement<T, J>(stmt.QueryBuilder);
        }
    }
}
