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
    public class WhereStatement : ConditionalGroupStatement
    {
        public ConditionalExpression ConditionalExpression { get; private set; }
        public WhereStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder)
        {
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
