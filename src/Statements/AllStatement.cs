using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class AllStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public AllStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;

            this.QueryBuilder.AddStatment(this);
        }
    }
}
