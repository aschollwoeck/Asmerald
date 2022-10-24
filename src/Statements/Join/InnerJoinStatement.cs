﻿using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements.Join
{
    public class InnerJoinStatement<T1, T2> : ConditionalJoinStatement<T1, T2> where T1 : ITable, new() where T2 : ITable, new()
    {
        public InnerJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }

        public InnerJoinStatement(IQueryBuilder queryBuilder, IEnumerable<(ISelectColumn<T1> col1, ISelectColumn<T2> col2)> on)
            : base(queryBuilder, on)
        {

        }
    }
}
