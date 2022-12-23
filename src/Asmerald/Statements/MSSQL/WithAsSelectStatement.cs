using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class WithAsSelectStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public IQueryBuilder SubQuery { get; private set; }
        public WithAsSelectStatement() { }
        public WithAsSelectStatement(IQueryBuilder queryBuilder, ITable table, IQueryBuilder subQuery)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Table = table;
            this.SubQuery = subQuery;
        }
    }
}
