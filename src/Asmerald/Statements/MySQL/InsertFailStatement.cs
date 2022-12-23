using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
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
