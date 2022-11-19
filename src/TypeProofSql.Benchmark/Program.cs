using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Dapper;
using test.testna;
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
                .AsSelect(dslCtxt.Select(TblCards.Id()).From<TblCards>().QueryBuilder)
                .With(Tbl_With.Id(), Tbl_With.Name())
                .AsSelect(dslCtxt.Select(TblCards.Id()).From<TblCards>().QueryBuilder)
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
                .Update<TblCards>()
                .Set(TblCards.Name().Value("hi"))
                .Where(TblCards.Name().Equal("test"))
                .QueryBuilder
                .BuildPreparedStatement();

            return et;
        }

        [Benchmark]
        public object SelectWhereOrderLimit()
        {
            var dslCtxt = new SQLiteDSLContext();
            var ts = dslCtxt
                .Select(TblCards.Id(), TblCards.Name(), TblCards.Form().As("test"))
                .From<TblCards>()
                .Where(TblCards.Id().Greater(10))
                .OrderBy(TblCards.Id())
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
                    .Select(TblCards.Id())
                    .From<TblCards>()
                    .UnionAll(dslCtxt
                        .Select(TblCards.Id())
                        .From<TblCards>()
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
                .Select(TblCards.Id().As("hello"), TblCards.Name(), TblCards.Id().As("int"))
                .From<TblCards>()
                .Where(TblCards.Name().Equal("hello")
                .And(TblCards.Name().Equal("hello2"))
                .And(TblCards.Name().In(new[] { "1", "2" }))
                .And(TblCards.Id().Greater(2))
                .And(TblCards.Id().IsNull())
                .And(TblCards.Id().LesserOrEqual(3))
                .Or(TblCards.Id().Greater(2)))
                .GroupBy(TblCards.Id())
                .OrderBy(TblCards.Id().Asc(), TblCards.Id().Desc(), TblCards.Name().Asc(), TblCards.Name().Desc())
                .QueryBuilder
                .Build();

            return sql;
        }
    }

    public class PerformanceComparison
    {
        private IDbConnection dbConnection;

        public PerformanceComparison()
        {
            this.dbConnection = new Microsoft.Data.Sqlite.SqliteConnection(@"Data Source=C:\Users\Alexander\Desktop\Digillection\digillection.sqlite3;");
            this.dbConnection.Open();
        }

        [Benchmark(Baseline = true)]
        public object DapperRaw()
        {
            return this.dbConnection.Query("SELECT Id, Name, Form as 'test' FROM cards WHERE id > @idGr ORDER BY Id LIMIT @limit", 
                param: new { idGr = 10, limit  = 50})
                .ToList();
        }

        [Benchmark]
        public object TypeSafeSql()
        {
            var dslCtxt = new SQLiteDSLContext();
            var ts = dslCtxt
                .Select(TblCards.Id(), TblCards.Name(), TblCards.Form().As("test"))
                .From<TblCards>()
                .Where(TblCards.Id().Greater(10))
                .OrderBy(TblCards.Id())
                .Limit(50)
                .QueryBuilder
                .BuildPreparedStatement();

            return this.dbConnection.Query(ts.Statement, 
                param: ts.Parameters)
                .ToList();
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