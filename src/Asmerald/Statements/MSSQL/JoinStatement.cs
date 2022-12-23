using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class JoinStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Left { get; private set; }
        public ITable Right { get; private set; }
        public JoinStatement() { }
        public JoinStatement(IQueryBuilder queryBuilder, ITable left, ITable right)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Left = left;
            this.Right = right;
        }
    }
}
