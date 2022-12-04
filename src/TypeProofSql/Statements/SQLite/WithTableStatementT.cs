using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class WithTableStatement<T> : WithTableStatement
        where T : ITable, new()
    {
        public WithTableStatement() { }
        public WithTableStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectExpression> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
