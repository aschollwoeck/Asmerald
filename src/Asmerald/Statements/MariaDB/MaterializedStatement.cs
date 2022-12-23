using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class MaterializedStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IQueryBuilder SubQuery { get; private set; }
        public MaterializedStatement() { }
        public MaterializedStatement(IQueryBuilder queryBuilder, IQueryBuilder subQuery)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.SubQuery = subQuery;
        }
    }
}
