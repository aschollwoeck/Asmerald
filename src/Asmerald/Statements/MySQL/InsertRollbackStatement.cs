using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class InsertRollbackStatement : RollbackStatement
    {
        public InsertRollbackStatement() { }
        public InsertRollbackStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
