using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;
using System.Linq;

namespace TypeProofSql.Statements.SQLite
{
    public class OnMultiStatement<T, J> : OnMultiStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public OnMultiStatement() { }
        public OnMultiStatement(IQueryBuilder queryBuilder, IEnumerable<(ISelectColumn<T> left, ISelectColumn<J> right)> on)
            : base(queryBuilder, new T(), new J(), on.Select(c => ((ISelectColumn)c.left, (ISelectColumn)c.right)))
        {
        }
    }
}
