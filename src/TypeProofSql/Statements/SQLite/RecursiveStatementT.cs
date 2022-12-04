using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class RecursiveStatement<T> : RecursiveStatement
        where T : ITable, new()
    {
        public RecursiveStatement() { }
        public RecursiveStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectExpression> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
