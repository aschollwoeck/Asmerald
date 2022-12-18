using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class OnStatement<T, J> : OnStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public OnStatement() { }
        public OnStatement(IQueryBuilder queryBuilder, ISelectColumn<T> left, ISelectColumn<J> right)
            : base(queryBuilder, new T(), new J(), left, right)
        {
        }
    }
}
