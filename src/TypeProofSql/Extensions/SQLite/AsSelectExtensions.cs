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
    public static partial class TypeProofSqlAsSelectExtensions
    {
        public static WithAsSelectStatement<T> AsSelect<T>(this RecursiveStatement<T> stmt)
            where T : ITable, new()
        {
            return new WithAsSelectStatement<T>(stmt.QueryBuilder);
        }
        public static WithAsSelectStatement<T> AsSelect<T>(this WithTableStatement<T> stmt)
            where T : ITable, new()
        {
            return new WithAsSelectStatement<T>(stmt.QueryBuilder);
        }
    }
}
