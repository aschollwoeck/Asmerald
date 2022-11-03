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
    public static partial class TypeProofSqlCrossJoinExtensions
    {
        public static NonConditionalJoinStatement<T1, T2> CrossJoin<T1, T2, T>(this FromStatement<T> stmt)
            where T1 : ITable, new()
            where T2 : ITable, new()
            where T : ITable, new()
        {
            return new NonConditionalJoinStatement<T1, T2>(stmt.QueryBuilder, new T());
        }
    }
}
