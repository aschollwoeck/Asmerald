using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class UnionAllStatement : IStatement, IQueryBuilderContainer
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IQueryBuilder SubQueryBuilder { get; private set; }

        public UnionAllStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.SubQueryBuilder = subQueryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
