using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class HavingStatement : ConditionalGroupStatement
    {
        public ConditionalExpression ConditionalExpression { get; private set; }
        public HavingStatement() { }
        public HavingStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
