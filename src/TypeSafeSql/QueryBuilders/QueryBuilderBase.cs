using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Statements;

namespace TypeProofSql.QueryBuilders
{
    public abstract class QueryBuilderBase : IQueryBuilder
    {
        public IQueryBuilder QueryBuilder => this;

        private List<IStatement> _statements = new List<IStatement>();

        private readonly ISqlTransformer sqlTransformer;

        public QueryBuilderBase(ISqlTransformer sqlTransformer)
        {
            this.sqlTransformer = sqlTransformer;
        }

        public string Build()
        {
            StringBuilder builder = new StringBuilder();
            int paraCount = 0;
            foreach (var stmt in this._statements)
            {
                this.sqlTransformer.Transform(stmt, builder, ref paraCount);
            }
            this._statements = new List<IStatement>();

            return builder.ToString();
        }

        public void AddStatment(IStatement statement)
        {
            this._statements.Add(statement);
        }

        public IPreparedStatement BuildPreparedStatement()
        {
            StringBuilder builder = new StringBuilder();

            var dic = this.sqlTransformer.Transform(this._statements, builder);
            this._statements = new List<IStatement>();

            //Dictionary<string, object> dic = new Dictionary<string, object>();
            //int paraCount = 0;
            //foreach (var stmt in this._statements)
            //{
            //    var para = this.sqlTransformer.Transform(stmt, builder, ref paraCount);
            //    dic.AddRange(para);
            //}

            return new PreparedStatement(builder.ToString(), dic);
        }
    }
}
