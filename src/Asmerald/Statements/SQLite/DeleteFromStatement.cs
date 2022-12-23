using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class DeleteFromStatement : FromStatement
    {
        public DeleteFromStatement() { }
        public DeleteFromStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder, table)
        {
        }
    }
}
