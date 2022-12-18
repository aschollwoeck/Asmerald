using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class UpdateSetStatement<T> : UpdateSetStatement
        where T : ITable, new()
    {
        public UpdateSetStatement() { }
        public UpdateSetStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
            : base(queryBuilder, new T(), valueExpressions)
        {
        }
    }
}
