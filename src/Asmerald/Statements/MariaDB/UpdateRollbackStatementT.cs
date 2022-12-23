using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class UpdateRollbackStatement<T> : UpdateRollbackStatement
        where T : ITable, new()
    {
        public UpdateRollbackStatement() { }
        public UpdateRollbackStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
