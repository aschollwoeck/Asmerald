using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql
{
    public class SQLiteDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public SQLiteDSLContext()
        {
            this.QueryBuilder = new SQLiteQueryBuilder();
        }
    }
}
