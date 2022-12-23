using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.Oracle;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldFromExtensions
    {
        public static SelectFromStatement<T> From<T>(this SelectColumnsStatement stmt)
            where T : ITable, new()
        {
            return new SelectFromStatement<T>(stmt.QueryBuilder);
        }
        public static SelectFromStatement<T> From<T>(this AllStatement stmt)
            where T : ITable, new()
        {
            return new SelectFromStatement<T>(stmt.QueryBuilder);
        }
        public static SelectFromStatement<T> From<T>(this DistinctColumnsStatement stmt)
            where T : ITable, new()
        {
            return new SelectFromStatement<T>(stmt.QueryBuilder);
        }
        public static DeleteFromStatement<T> From<T>(this DeleteStatement stmt)
            where T : ITable, new()
        {
            return new DeleteFromStatement<T>(stmt.QueryBuilder);
        }
    }
}
