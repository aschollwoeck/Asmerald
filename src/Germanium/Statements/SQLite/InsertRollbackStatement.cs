using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
