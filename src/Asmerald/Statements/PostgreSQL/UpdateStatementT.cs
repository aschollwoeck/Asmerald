using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class UpdateStatement<T> : UpdateStatement
        where T : ITable, new()
    {
        public UpdateStatement() { }
        public UpdateStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
