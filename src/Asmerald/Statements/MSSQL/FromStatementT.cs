using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class FromStatement<T> : FromStatement
        where T : ITable, new()
    {
        public FromStatement() { }
        public FromStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
