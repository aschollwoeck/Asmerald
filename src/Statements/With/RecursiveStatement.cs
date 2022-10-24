using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class RecursiveStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public IEnumerable<ISelectColumn> SelectColumns { get; private set; }

        public RecursiveStatement(IQueryBuilder queryBuilder, ITable table, IEnumerable<ISelectColumn> selectColumns)
        {
            this.QueryBuilder = queryBuilder;
            this.Table = table;
            this.SelectColumns = selectColumns;
            this.QueryBuilder.AddStatment(this);
        }
    }

    public class RecursiveStatement<T> : RecursiveStatement where T : ITable, new()
    {
        public RecursiveStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn<T>> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
