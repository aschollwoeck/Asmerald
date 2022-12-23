using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class UpdateOrStatement<T> : UpdateOrStatement
        where T : ITable, new()
    {
        public UpdateOrStatement() { }
        public UpdateOrStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
