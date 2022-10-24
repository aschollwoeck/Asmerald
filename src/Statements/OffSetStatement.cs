using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class OffSetStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public int Offset { get; private set; }

        public OffSetStatement(IQueryBuilder queryBuilder, int offset)
        {
            this.QueryBuilder = queryBuilder;
            this.Offset = offset;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
