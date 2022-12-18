using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class WithNotStatement : NotStatement
    {
        public WithNotStatement() { }
        public WithNotStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
