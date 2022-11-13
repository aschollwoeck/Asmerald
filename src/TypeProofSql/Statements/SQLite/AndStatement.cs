using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class AndStatement : ConditionalStatement
    {
        public ConditionalExpression ConditionalExpression { get; private set; }
        public AndStatement() { }
        public AndStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
