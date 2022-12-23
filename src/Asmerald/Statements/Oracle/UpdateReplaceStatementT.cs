using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class UpdateReplaceStatement<T> : UpdateReplaceStatement
        where T : ITable, new()
    {
        public UpdateReplaceStatement() { }
        public UpdateReplaceStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
