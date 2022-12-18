using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class UpdateAbortStatement<T> : UpdateAbortStatement
        where T : ITable, new()
    {
        public UpdateAbortStatement() { }
        public UpdateAbortStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
