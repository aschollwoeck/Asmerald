using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class UpdateFailStatement<T> : UpdateAbortStatement
        where T : ITable, new()
    {
        public UpdateFailStatement() { }
        public UpdateFailStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
