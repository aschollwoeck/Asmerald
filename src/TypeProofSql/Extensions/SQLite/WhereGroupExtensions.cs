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
    public static partial class TypeProofSqlWhereGroupExtensions
    {
        public static ConditionalGroupStatement WhereGroup(this FromStatement stmt)
        {
            return new ConditionalGroupStatement(stmt.QueryBuilder);
        }
        public static ConditionalGroupStatement WhereGroup(this OnStatement stmt)
        {
            return new ConditionalGroupStatement(stmt.QueryBuilder);
        }
        public static ConditionalGroupStatement WhereGroup(this OnMultiStatement stmt)
        {
            return new ConditionalGroupStatement(stmt.QueryBuilder);
        }
        public static ConditionalGroupStatement WhereGroup(this NonConditionalJoinStatement stmt)
        {
            return new ConditionalGroupStatement(stmt.QueryBuilder);
        }
    }
}
