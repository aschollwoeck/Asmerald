using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class UpdateFailStatement<T> : UpdateAbortStatement
        where T : ITable, new()
    {
        public UpdateFailStatement() { }
        public UpdateFailStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
