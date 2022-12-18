using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class WithTableAdditionalStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public List<ISelectExpression> SelectColumns { get; private set; } = new List<ISelectExpression>();
        public WithTableAdditionalStatement() { }
        public WithTableAdditionalStatement(IQueryBuilder queryBuilder, ITable table, IEnumerable<ISelectExpression> selectColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Table = table;
            this.SelectColumns.AddRange(selectColumns);
        }
    }
}
