using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class UpdateIgnoreStatement : IgnoreStatement
    {
        public ITable Table { get; private set; }
        public UpdateIgnoreStatement() { }
        public UpdateIgnoreStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}
