using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class WithTableAdditionalStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public IEnumerable<ISelectColumn> SelectColumns { get; private set; }

        public WithTableAdditionalStatement(IQueryBuilder queryBuilder, ITable table, IEnumerable<ISelectColumn> selectColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.Table = table;
            this.SelectColumns = selectColumns;
            this.QueryBuilder.AddStatment(this);
        }
    }

    public class WithTableAdditionalStatement<T> : WithTableAdditionalStatement where T : ITable, new()
    {
        public WithTableAdditionalStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn<T>> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
