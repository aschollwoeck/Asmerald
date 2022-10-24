using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements.Join
{
    public class CrossJoinStatement<T1, T2> : NonConditionalJoinStatement<T1, T2> where T1 : ITable, new() where T2 : ITable, new()
    {
        public CrossJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
