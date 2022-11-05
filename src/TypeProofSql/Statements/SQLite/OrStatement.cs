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
        public ConditionalGroupStatement GroupStatement { get; private set; }
        public ConditionalExpression ConditionalExpression { get; private set; }
        public OrStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupStatement, ConditionalExpression conditionalExpression)
            : base(queryBuilder, groupStatement, conditionalExpression)
        {
            this.GroupStatement = groupStatement;
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
