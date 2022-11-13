using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class OrStatement : ConditionalStatement
    {
        public ConditionalExpression ConditionalExpression { get; private set; }
        public OrStatement() { }
        public OrStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
