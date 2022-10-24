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
    public class FromSubQueryStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IQueryBuilder SubQueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public FromSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder, ITable table)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.SubQueryBuilder = subQueryBuilder;
            this.Table = table;
        }
    }
}
