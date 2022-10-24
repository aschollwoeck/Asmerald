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
    public static partial class TypeProofSqlInnerJoinExtensions
    {
        public static InnerJoinStatement<T1, T2> InnerJoin<T1, T2>(this FromStatement stmt)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new InnerJoinStatement<T1, T2>(stmt.QueryBuilder);
        }
        public static InnerJoinStatement<T1, T2> InnerJoin<T1, T2>(this NonConditionalJoinStatement stmt)
            where T1 : ITable, new()
            where T2 : ITable, new()
        {
            return new InnerJoinStatement<T1, T2>(stmt.QueryBuilder);
        }
    }
}
