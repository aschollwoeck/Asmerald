using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class WhereGroupMultiStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ConditionalGroupStatement> ConditionalGroupStatements { get; private set; }
        public WhereGroupMultiStatement() { }
        public WhereGroupMultiStatement(IQueryBuilder queryBuilder, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ConditionalGroupStatements = conditionalGroupStatements;
        }
    }
}
