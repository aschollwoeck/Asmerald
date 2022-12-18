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
    public static partial class TypeProofSqlFromExtensions
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
