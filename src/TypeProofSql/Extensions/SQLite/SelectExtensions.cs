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
    public static partial class TypeProofSqlSelectExtensions
    {
        public static SelectStatement Select(this SQLiteDSLContext stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select(this SQLiteDSLContext stmt, params ISelectColumn[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectStatement Select(this AsSelectStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select(this AsSelectStatement stmt, params ISelectColumn[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectStatement Select(this MaterializedStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select(this MaterializedStatement stmt, params ISelectColumn[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
        public static SelectStatement Select(this CompoundStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectColumnsStatement Select(this CompoundStatement stmt, params ISelectColumn[] columns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, columns);
        }
    }
}
