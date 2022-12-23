using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class UpdateAbortStatement<T> : UpdateAbortStatement
        where T : ITable, new()
    {
        public UpdateAbortStatement() { }
        public UpdateAbortStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
