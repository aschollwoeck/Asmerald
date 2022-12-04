using System;
using System.Collections.Generic;
using System.Linq;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlRecursiveExtensions
    {
        public static RecursiveStatement<T> Recursive<T>(this WithStatement stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new RecursiveStatement<T>(stmt.QueryBuilder, selectColumns);
        }
    }
}
