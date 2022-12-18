using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class InsertFailStatement : FailStatement
    {
        public InsertFailStatement() { }
        public InsertFailStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
