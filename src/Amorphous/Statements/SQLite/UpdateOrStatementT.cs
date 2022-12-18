using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class UpdateOrStatement<T> : UpdateOrStatement
        where T : ITable, new()
    {
        public UpdateOrStatement() { }
        public UpdateOrStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
