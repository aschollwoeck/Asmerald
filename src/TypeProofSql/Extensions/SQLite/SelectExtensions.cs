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
        public static SelectStatement Select(this UnionStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this UnionAllStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
        public static SelectStatement Select(this ExceptStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }
    }
}
