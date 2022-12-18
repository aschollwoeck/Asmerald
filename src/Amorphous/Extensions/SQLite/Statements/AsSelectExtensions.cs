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
