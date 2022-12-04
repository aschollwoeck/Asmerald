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
    public static partial class TypeProofSqlFromExtensions
    {
        public static SelectFromStatement<T> From<T>(this SelectColumnsStatement stmt)
            where T : ITable, new()
        {
            return new SelectFromStatement<T>(stmt.QueryBuilder);
        }
        public static SelectFromStatement<T> From<T>(this AllStatement stmt)
            where T : ITable, new()
        {
            return new SelectFromStatement<T>(stmt.QueryBuilder);
        }
        public static SelectFromStatement<T> From<T>(this DistinctColumnsStatement stmt)
            where T : ITable, new()
        {
            return new SelectFromStatement<T>(stmt.QueryBuilder);
        }
        public static DeleteFromStatement<T> From<T>(this DeleteStatement stmt)
            where T : ITable, new()
        {
            return new DeleteFromStatement<T>(stmt.QueryBuilder);
        }
    }
}
