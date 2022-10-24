using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements.Join
{
    public class NonConditionalJoinStatement : JoinStatement
    {
        public NonConditionalJoinStatement(IQueryBuilder queryBuilder, ITable left, ITable right)
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
            : base(queryBuilder, left, right)
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
        {
        }
    }

    public class NonConditionalJoinStatement<T1, T2> : NonConditionalJoinStatement where T1 : ITable, new() where T2 : ITable, new()
    {
        public NonConditionalJoinStatement(IQueryBuilder queryBuilder)
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
#pragma warning disable CS8625 // Ein NULL-Literal kann nicht in einen Non-Nullable-Verweistyp konvertiert werden.
            : base(queryBuilder, new T1(), new T2())
#pragma warning restore CS8625 // Ein NULL-Literal kann nicht in einen Non-Nullable-Verweistyp konvertiert werden.
#pragma warning restore CS8604 // Mögliches Nullverweisargument.
        {
        }
    }
}
