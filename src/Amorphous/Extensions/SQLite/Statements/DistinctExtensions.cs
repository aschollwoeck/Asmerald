using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlDistinctExtensions
    {
        public static DistinctStatement Distinct(this SelectStatement stmt)
        {
            return new DistinctStatement(stmt.QueryBuilder);
        }
        public static DistinctColumnsStatement Distinct(this SelectStatement stmt, params ISelectExpression[] columns)
        {
            return new DistinctColumnsStatement(stmt.QueryBuilder, columns);
        }
    }
}
