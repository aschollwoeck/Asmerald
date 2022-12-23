using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class RecursiveStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public List<ISelectExpression> SelectColumns { get; private set; } = new List<ISelectExpression>();
        public RecursiveStatement() { }
        public RecursiveStatement(IQueryBuilder queryBuilder, ITable table, IEnumerable<ISelectExpression> selectColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Table = table;
            this.SelectColumns.AddRange(selectColumns);
        }
    }
}
