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
    public class UpdateSetStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();
        public UpdateSetStatement(IQueryBuilder queryBuilder, ITable table, IEnumerable<ValueExpression> valueExpressions)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Table = table;
            this.ValueExpressions.AddRange(valueExpressions);
        }
    }
}
