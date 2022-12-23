using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class FromSubQueryStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IQueryBuilder SubQueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public FromSubQueryStatement() { }
        public FromSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder, ITable table)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.SubQueryBuilder = subQueryBuilder;
            this.Table = table;
        }
    }
}
