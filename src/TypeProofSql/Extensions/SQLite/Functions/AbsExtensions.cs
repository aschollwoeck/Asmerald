using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Functions.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlAbsExtensions
    {
        public static AbsFunction Abs(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new AbsFunction(x);
        }

        public static AbsFunction Abs<T, Tbl>(this IColumn<T, Tbl> column) 
            where Tbl : ITable
        {
            return new AbsFunction(column);
        }
    }
}
