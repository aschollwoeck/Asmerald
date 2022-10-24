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
    public static partial class TypeProofSqlOrderByExtensions
    {
        public static OrderByStatement OrderBy(this FromStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this GroupByStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
        public static OrderByStatement OrderBy(this WhereStatement stmt, params IOrderByColumn[] orderByColumns)
        {
            return new OrderByStatement(stmt.QueryBuilder, orderByColumns);
        }
    }
}
