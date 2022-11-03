using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;
using TypeProofSql.Statements;

namespace TypeProofSql.Statements.SQLite
{
    public class InsertValuesStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();
        public InsertValuesStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ValueExpressions.AddRange(valueExpressions);
        }
    }
}
