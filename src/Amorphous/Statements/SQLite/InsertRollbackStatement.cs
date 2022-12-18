using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
