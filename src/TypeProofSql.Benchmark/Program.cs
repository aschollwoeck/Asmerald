using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using TypeProofSql.SQLite;

namespace TypeProofSql.Benchmark
{
    public class TypeProofSqlTests
    {

        public TypeProofSqlTests()
        {
        }

        [Benchmark]
        public object MultipleWith()
        {
            var dslCtxt = new SQLiteDSLContext();
            var sub = dslCtxt
                .With<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
                .AsSelect(dslCtxt.Select(Tbl_Cards.Id()).From<Tbl_Cards>().QueryBuilder)
                .With(Tbl_With.Id(), Tbl_With.Name())
                .AsSelect(dslCtxt.Select(Tbl_Cards.Id()).From<Tbl_Cards>().QueryBuilder)
                .Select(Tbl_With.Id())
                .From<Tbl_With>()
                .QueryBuilder
                .BuildPreparedStatement();

            return sub;
        }

        [Benchmark]
        public object Update()
        {
            var dslCtxt = new SQLiteDSLContext();
            var et = dslCtxt
                .Update<Tbl_Cards>()
                .Set(Tbl_Cards.Name().Value("hi"))
                .Where(Tbl_Cards.Name().Equal("test"))
                .QueryBuilder
                .BuildPreparedStatement();

            return et;
        }

        [Benchmark]
        public object SelectWhereOrderLimit()
        {
            var dslCtxt = new SQLiteDSLContext();
            var ts = dslCtxt
                .Select(Tbl_Cards.Id(), Tbl_Cards.Name(), Tbl_Cards.Form().As("test"))
                .From<Tbl_Cards>()
                .Where(Tbl_Cards.Id().Greater(10))
                .OrderBy(Tbl_Cards.Id())
                .Limit(50)
                .QueryBuilder
                .BuildPreparedStatement();

            return ts;
        }

        [Benchmark]
        public object WithRecursive()
        {
            var dslCtxt = new SQLiteDSLContext();
            var sub = dslCtxt
                .With()
                .Recursive<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
                .As()
                .Not()
                .Materialized(dslCtxt
                    .Select(Tbl_Cards.Id())
                    .From<Tbl_Cards>()
                    .UnionAll(dslCtxt
                        .Select(Tbl_Cards.Id())
                        .From<Tbl_Cards>()
                        .QueryBuilder)
                    .QueryBuilder)
                .QueryBuilder
                .BuildPreparedStatement();

            return sub;
        }

        [Benchmark]
        public object SelectWhereAndGroupOrder()
        {
            var dslCtxt = new SQLiteDSLContext();
            var sql = dslCtxt
                .Select(Tbl_Cards.Id().As("hello"), Tbl_Cards.Name(), Tbl_Cards.Id().As("int"))
                .From<Tbl_Cards>()
                .Where(Tbl_Cards.Name().Equal("hello"))
                .And(Tbl_Cards.Name().Equal("hello2"))
                .And(Tbl_Cards.Name().In(new[] { "1", "2" }))
                .And(Tbl_Cards.Id().Greater(2))
                .And(Tbl_Cards.Id().IsNull())
                .And(Tbl_Cards.Id().LesserOrEqual(3))
                .Or(Tbl_Cards.Id().Greater(2))
                .GroupBy(Tbl_Cards.Id())
                .OrderBy(Tbl_Cards.Id().Asc(), Tbl_Cards.Id().Desc(), Tbl_Cards.Name().Asc(), Tbl_Cards.Name().Desc())
                .QueryBuilder
                .Build();

            return sql;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}