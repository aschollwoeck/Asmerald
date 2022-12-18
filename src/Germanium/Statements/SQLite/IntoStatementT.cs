using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class IntoStatement<T> : IntoStatement
        where T : ITable, new()
    {
        public IntoStatement() { }
        public IntoStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
