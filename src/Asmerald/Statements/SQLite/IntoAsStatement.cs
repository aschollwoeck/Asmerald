using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class IntoAsStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public string Alias { get; private set; }
        public IntoAsStatement() { }
        public IntoAsStatement(IQueryBuilder queryBuilder, string alias)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Alias = alias;
        }
    }
}
