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
    public static partial class AsmeraldRecursiveExtensions
    {
        public static RecursiveStatement<T> Recursive<T>(this WithStatement stmt, params ISelectExpression[] selectColumns)
            where T : ITable, new()
        {
            return new RecursiveStatement<T>(stmt.QueryBuilder, selectColumns);
        }
    }
}
