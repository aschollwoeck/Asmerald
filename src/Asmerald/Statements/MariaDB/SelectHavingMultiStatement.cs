using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class SelectHavingMultiStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ConditionalStatement> ConditionalStatements { get; private set; }
        public SelectHavingMultiStatement() { }
        public SelectHavingMultiStatement(IQueryBuilder queryBuilder, List<ConditionalStatement> conditionalStatements)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ConditionalStatements = conditionalStatements;
        }
    }
}
