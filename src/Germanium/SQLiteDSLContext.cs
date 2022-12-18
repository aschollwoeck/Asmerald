using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Expressions;
using Germanium.QueryBuilders;
using Germanium.Statements;

namespace Germanium
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
