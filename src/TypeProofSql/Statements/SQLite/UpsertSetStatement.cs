using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpsertSetStatement : SetStatement
    {
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();
        public UpsertSetStatement() { }
        public UpsertSetStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
            : base(queryBuilder, valueExpressions)
        {
            this.ValueExpressions.AddRange(valueExpressions);
        }
    }
}
