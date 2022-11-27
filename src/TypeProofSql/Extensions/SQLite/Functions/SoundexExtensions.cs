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
    public static partial class TypeProofSqlSoundexExtensions
    {
        public static SoundexFunction Soundex(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new SoundexFunction(x);
        }
    }
}
