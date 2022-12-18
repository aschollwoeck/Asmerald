using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
