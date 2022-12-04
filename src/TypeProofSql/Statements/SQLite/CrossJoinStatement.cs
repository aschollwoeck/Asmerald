using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class CrossJoinStatement : NonConditionalJoinStatement
    {
        public ITable T { get; private set; }
        public ITable J { get; private set; }
        public CrossJoinStatement() { }
        public CrossJoinStatement(IQueryBuilder queryBuilder, ITable t, ITable j)
            : base(queryBuilder, t, j)
        {
            this.T = t;
            this.J = j;
        }
    }
}
