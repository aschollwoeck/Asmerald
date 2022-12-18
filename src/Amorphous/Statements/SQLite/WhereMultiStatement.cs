using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class WhereMultiStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ConditionalStatement> ConditionalStatements { get; private set; }
        public WhereMultiStatement() { }
        public WhereMultiStatement(IQueryBuilder queryBuilder, List<ConditionalStatement> conditionalStatements)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ConditionalStatements = conditionalStatements;
        }
    }
}
