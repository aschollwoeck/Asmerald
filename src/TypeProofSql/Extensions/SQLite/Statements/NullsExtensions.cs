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
    public static partial class TypeProofSqlNullsExtensions
    {
        public static NullsStatement Nulls(this OrderByStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
        public static NullsStatement Nulls(this CollateStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
        public static NullsStatement Nulls(this AscStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
        public static NullsStatement Nulls(this DescStatement stmt)
        {
            return new NullsStatement(stmt.QueryBuilder);
        }
    }
}
