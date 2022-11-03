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
        public static FromStatement From(this SelectColumnsStatement stmt, ITable table)
        {
            return new FromStatement(stmt.QueryBuilder, table);
        }
        public static FromStatement From(this AllStatement stmt, ITable table)
        {
            return new FromStatement(stmt.QueryBuilder, table);
        }
        public static FromStatement From(this DistinctColumnsStatement stmt, ITable table)
        {
            return new FromStatement(stmt.QueryBuilder, table);
        }
        public static UpdateFrom<T>Statement From<T>(this UpdateSetStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateFrom<T>Statement(stmt.QueryBuilder);
        }
        public static DeleteFrom<T>Statement From<T>(this DeleteStatement stmt)
            where T : ITable, new()
        {
            return new DeleteFrom<T>Statement(stmt.QueryBuilder);
        }
    }
}
