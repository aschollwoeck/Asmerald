using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateSetStatement<T> : UpdateSetStatement
        where T : ITable, new()
    {
        public UpdateSetStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
            : base(queryBuilder, new T(), valueExpressions)
        {
        }
    }
}
