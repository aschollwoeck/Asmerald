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
    public static partial class TypeProofSqlWhereExtensions
    {
        public static UpdateWhereStatement Where<T>(this UpdateSetStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateWhereStatement(stmt.QueryBuilder, new T());
        }
        public static UpdateWhereStatement Where<T>(this UpdateFrom<T> stmt)
            where T : ITable, new()
        {
            return new UpdateWhereStatement(stmt.QueryBuilder, new T());
        }
        public static UpsertWhereStatement Where(this UpsertSetStatement stmt)
        {
            return new UpsertWhereStatement(stmt.QueryBuilder);
        }
        public static DeleteWhereStatement Where<T>(this DeleteFrom<T> stmt)
            where T : ITable, new()
        {
            return new DeleteWhereStatement(stmt.QueryBuilder, new T());
        }
        public static DeleteWhereGroupStatement Where<T>(this DeleteFrom<T> stmt)
            where T : ITable, new()
        {
            return new DeleteWhereGroupStatement(stmt.QueryBuilder, new T());
        }
    }
}
