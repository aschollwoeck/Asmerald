using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class InsertStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public InsertStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;

            this.QueryBuilder.AddStatment(this);
        }
    }
}
