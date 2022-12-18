using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class FromSubQueryStatement<T> : FromSubQueryStatement
        where T : ITable, new()
    {
        public FromSubQueryStatement() { }
        public FromSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
            : base(queryBuilder, subQueryBuilder, new T())
        {
        }
    }
}
