using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class OffsetStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public int Offset { get; private set; }
        public OffsetStatement() { }
        public OffsetStatement(IQueryBuilder queryBuilder, int offset)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Offset = offset;
        }
    }
}
