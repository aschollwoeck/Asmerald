using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class NonConditionalJoinStatement<T, J> : NonConditionalJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public NonConditionalJoinStatement() { }
        public NonConditionalJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
