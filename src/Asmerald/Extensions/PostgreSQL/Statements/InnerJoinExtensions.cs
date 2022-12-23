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
    public static partial class AsmeraldInnerJoinExtensions
    {
        public static InnerJoinStatement<T, J> InnerJoin<T, J>(this SelectFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new InnerJoinStatement<T, J>(stmt.QueryBuilder);
        }
        public static UpdateConditionalJoinStatement<T, J> InnerJoin<T, J>(this UpdateFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UpdateConditionalJoinStatement<T, J>(stmt.QueryBuilder);
        }
        public static UpdateConditionalJoinStatement<T, J> InnerJoin<T, J>(this UpdateFromSubQueryStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UpdateConditionalJoinStatement<T, J>(stmt.QueryBuilder);
        }
    }
}
