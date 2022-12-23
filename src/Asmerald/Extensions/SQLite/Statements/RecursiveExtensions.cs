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
    public static partial class TypeProofSqlRecursiveExtensions
    {
        public static RecursiveStatement<T> Recursive<T>(this WithStatement stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new RecursiveStatement<T>(stmt.QueryBuilder, selectColumns);
        }
    }
}
