using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class InsertIgnoreStatement : IgnoreStatement
    {
        public InsertIgnoreStatement() { }
        public InsertIgnoreStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
