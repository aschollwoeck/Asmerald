using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class DeleteFromStatement<T> : FromStatement<T>
        where T : ITable, new()
    {
        public DeleteFromStatement() { }
        public DeleteFromStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
