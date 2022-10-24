using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;
using TypeProofSql.Statements;

namespace TypeProofSql.Statements.SQLite
{
    public class LeftOuterJoinStatement<T1, T2> : ConditionalJoinStatement<T1, T2>
        where T1 : ITable, new()
        where T2 : ITable, new()
    {
        public LeftOuterJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
