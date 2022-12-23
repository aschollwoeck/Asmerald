using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class OnStatement<T, J> : OnStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public OnStatement() { }
        public OnStatement(IQueryBuilder queryBuilder, ISelectColumn<T> left, ISelectColumn<J> right)
            : base(queryBuilder, new T(), new J(), left, right)
        {
        }
    }
}
