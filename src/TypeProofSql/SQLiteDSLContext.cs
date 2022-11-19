using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;

namespace TypeProofSql
{
    public class SQLiteDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public SQLiteDSLContext()
        {
            this.QueryBuilder = new SQLiteQueryBuilder();
        }

        public SQLiteDSLContext SubQuery()
        {
            return new SQLiteDSLContext();
        }
    }
}
