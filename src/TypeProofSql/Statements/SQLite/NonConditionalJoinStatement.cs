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
    public class NonConditionalJoinStatement : JoinStatement
    {
        public NonConditionalJoinStatement(IQueryBuilder queryBuilder, ITable left, ITable right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
