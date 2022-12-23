using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class UpdateIgnoreStatement<T> : UpdateIgnoreStatement
        where T : ITable, new()
    {
        public UpdateIgnoreStatement() { }
        public UpdateIgnoreStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
