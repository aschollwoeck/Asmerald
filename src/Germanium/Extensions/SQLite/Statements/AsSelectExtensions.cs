using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.QueryBuilders;
using Germanium.Statements;
using Germanium.Statements.SQLite;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlAsSelectExtensions
    {
        public static WithAsSelectStatement<T> AsSelect<T>(this RecursiveStatement<T> stmt, IQueryBuilder subQuery)
            where T : ITable, new()
        {
            return new WithAsSelectStatement<T>(stmt.QueryBuilder, subQuery);
        }
        public static WithAsSelectStatement<T> AsSelect<T>(this WithTableStatement<T> stmt, IQueryBuilder subQuery)
            where T : ITable, new()
        {
            return new WithAsSelectStatement<T>(stmt.QueryBuilder, subQuery);
        }
    }
}
