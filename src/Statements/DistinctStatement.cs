using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class DistinctStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public DistinctStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;

            this.QueryBuilder.AddStatment(this);
        }
    }

    public class DistinctColumnsStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public List<ISelectColumn> SelectColumns { get; private set; } = new List<ISelectColumn>();

        public DistinctColumnsStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn> selectColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.SelectColumns.AddRange(selectColumns);

            this.QueryBuilder.AddStatment(this);
        }
    }
}
