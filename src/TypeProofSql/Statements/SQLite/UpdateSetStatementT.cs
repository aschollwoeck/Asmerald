using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
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
