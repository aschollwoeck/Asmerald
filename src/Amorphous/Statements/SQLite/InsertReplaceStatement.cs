using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class InsertReplaceStatement : ReplaceStatement
    {
        public InsertReplaceStatement() { }
        public InsertReplaceStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
