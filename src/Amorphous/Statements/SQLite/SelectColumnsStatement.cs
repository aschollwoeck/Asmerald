using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class SelectColumnsStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ISelectExpression> Columns { get; private set; } = new List<ISelectExpression>();
        public SelectColumnsStatement() { }
        public SelectColumnsStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectExpression> columns)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Columns.AddRange(columns);
        }
    }
}
