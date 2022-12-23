using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class UpdateFromStatement<T> : FromStatement
        where T : ITable, new()
    {
        public UpdateFromStatement() { }
        public UpdateFromStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
