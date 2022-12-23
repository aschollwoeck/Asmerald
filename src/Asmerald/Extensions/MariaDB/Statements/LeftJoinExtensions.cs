using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.MariaDB;

namespace Asmerald.MariaDB
{
    public static partial class AsmeraldLeftJoinExtensions
    {
        public static LeftOuterJoinStatement<T, J> LeftJoin<T, J>(this SelectFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new LeftOuterJoinStatement<T, J>(stmt.QueryBuilder);
        }
        public static UpdateConditionalJoinStatement<T, J> LeftJoin<T, J>(this UpdateFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UpdateConditionalJoinStatement<T, J>(stmt.QueryBuilder);
        }
        public static UpdateConditionalJoinStatement<T, J> LeftJoin<T, J>(this UpdateFromSubQueryStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UpdateConditionalJoinStatement<T, J>(stmt.QueryBuilder);
        }
    }
}
