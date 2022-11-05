using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class NonConditionalJoinStatement : JoinStatement
    {
        public NonConditionalJoinStatement(IQueryBuilder queryBuilder, ITable left, ITable right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
