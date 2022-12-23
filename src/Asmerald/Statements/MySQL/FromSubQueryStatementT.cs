using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class FromSubQueryStatement<T> : FromSubQueryStatement
        where T : ITable, new()
    {
        public FromSubQueryStatement() { }
        public FromSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
            : base(queryBuilder, subQueryBuilder, new T())
        {
        }
    }
}
