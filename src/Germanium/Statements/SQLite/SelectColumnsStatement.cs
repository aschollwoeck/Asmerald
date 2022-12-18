using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
