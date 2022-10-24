using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements.Join
{
    public class ConditionalJoinStatement<T1, T2> : JoinStatement<T1, T2> where T1 : ITable, new() where T2 : ITable, new()
    {
        public List<(ISelectColumn<T1> col1, ISelectColumn<T2> col2)> JoinExpressions { get; private set; } = new List<(ISelectColumn<T1> col1, ISelectColumn<T2> col2)>();

        public ConditionalJoinStatement(IQueryBuilder queryBuilder)
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
            : base(queryBuilder, new T1(), new T2())
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
        {
        }

        public ConditionalJoinStatement(IQueryBuilder queryBuilder, IEnumerable<(ISelectColumn<T1> col1, ISelectColumn<T2> col2)> on)
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
            : base(queryBuilder, new T1(), new T2())
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
        {
            this.JoinExpressions.AddRange(on);
        }
    }
}
