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
    public static partial class TypeProofSqlFromExtensions
    {
        public static FromStatement<T> From<T>(this SelectStatement stmt)
            where T : ITable, new()
        {
            return new FromStatement<T>(stmt.QueryBuilder);
        }
        public static FromStatement<T> From<T>(this SelectColumnsStatement stmt)
            where T : ITable, new()
        {
            return new FromStatement<T>(stmt.QueryBuilder);
        }
        public static FromStatement<T> From<T>(this DistinctColumnsStatement stmt)
            where T : ITable, new()
        {
            return new FromStatement<T>(stmt.QueryBuilder);
        }
        public static FromStatement<T> From<T>(this AllStatement stmt)
            where T : ITable, new()
        {
            return new FromStatement<T>(stmt.QueryBuilder);
        }
        public static FromStatement<T> From<T>(this DeleteStatement stmt)
            where T : ITable, new()
        {
            return new FromStatement<T>(stmt.QueryBuilder);
        }
    }
}
