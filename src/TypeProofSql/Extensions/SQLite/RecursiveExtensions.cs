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
    public static partial class TypeProofSqlRecursiveExtensions
    {
        public static RecursiveStatement Recursive(this WithStatement stmt, ITable table, params ISelectColumn[] selectColumns)
        {
            return new RecursiveStatement(stmt.QueryBuilder, table, selectColumns);
        }
    }
}
