using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
