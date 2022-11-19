using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class WhereStatement : IStatement
    {
        public ConditionalExpression ConditionalExpression { get; private set; }

        public IQueryBuilder QueryBuilder { get; private set; }

        public WhereStatement() { }
        public WhereStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
        {
            this.QueryBuilder = queryBuilder;
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
