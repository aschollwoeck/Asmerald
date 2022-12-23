using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dapper;
using System.Linq;
using System.Diagnostics;
using Asmerald.MSSQL;
using System;
using test.testna;

namespace Asmerald.Test.MSSQL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
    //        var dbConnection = new Microsoft.Data.Sqlite.SqliteConnection(@"Data Source=C:\Users\Alexander\Desktop\Digillection\digillection.sqlite3;");
    //        dbConnection.Open();

    //        var res2 = dbConnection.Query("SELECT Id, Name, Form as 'test' FROM cards WHERE id > @idGr ORDER BY Id LIMIT @limit",
    //param: new { idGr = 10, limit = 50 })
    //.ToList();

    //        int c = 100;

    //        Stopwatch sw = Stopwatch.StartNew();
    //        for (int i = 0; i < c; i++)
    //        {
    //            var res = dbConnection.Query("SELECT Id, Name, Form as 'test' FROM cards WHERE id > @idGr ORDER BY Id LIMIT @limit",
    //                param: new { idGr = 10, limit = 50 })
    //                .ToList();
    //        }
    //        sw.Stop();
    //        Console.WriteLine(sw.ElapsedMilliseconds / c);

            //sw = Stopwatch.StartNew();
            //for (int i = 0; i < c; i++)
            //{
            //    var dslCtxt = new SQLiteDSLContext();
            //    var ts = dslCtxt
            //        .Select(Tbl_Cards.Id(), Tbl_Cards.Name(), Tbl_Cards.Form().As("test"))
            //        .From<Tbl_Cards>()
            //        .Where(Tbl_Cards.Id().Greater(10))
            //        .OrderBy(Tbl_Cards.Id())
            //        .Limit(50)
            //        .QueryBuilder
            //        .BuildPreparedStatement();

            //    var res = dbConnection.Query(ts.Statement,
            //        param: ts.Parameters)
            //        .ToList();
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds / c);

            //var sql = new Table1()
            //.Select(new Table1.Column1().As("hello"), new Table1.Column1())
            //.ToSqlString();
        }

        [TestMethod]
        public void QueriesTest()
        {
            Asmerald.MSSQLDSLContext dslCtxt = new MSSQLDSLContext();

            // Functions
            dslCtxt.Abs((-2).Expr());
            dslCtxt.Abs("hi".Expr());
            dslCtxt.Abs(TblCards.Id());
            dslCtxt.Abs(TblCards.Name());
            dslCtxt.Replace(TblCards.Name(), "hi".Expr(), "servus".Expr());

            (-2).Abs();

            TblCards.Id().Abs();

            var tsdf = dslCtxt
                .Select(
                    dslCtxt.Abs(TblCards.Id()))
                .From<TblCards>()
                .QueryBuilder
                .Build();

            // Statements

            var sql2 = dslCtxt
                .Select()
                .All()
                .From<TblCards>()
                .Where(
                        TblCards.Id("c").Greater(1)
                        .And(TblCards.Id("c").Greater(10)).Group()
                    .And(TblCards.Name("c").Equal("hi")))
                .QueryBuilder
                .Build();
            Console.WriteLine(sql2);

            var qall = dslCtxt
                .Select()
                .Distinct()
                .All()
                .From<TblCards>()
                .QueryBuilder
                .BuildPreparedStatement();

            var et = dslCtxt
                .Update<TblCards>()
                .Set<TblCards>(new[] { TblCards.Name().Value("hi") })
                .Where(TblCards.Name().Equal("test"))
                .QueryBuilder
                .BuildPreparedStatement();

            var ts = dslCtxt
                .Select(TblCards.Id(), TblCards.Name(), TblCards.Form().As("test"))
                .From<TblCards>()
                .Where(TblCards.Id().Greater(10))
                .OrderBy(TblCards.Id())
                .Limit(50)
                .QueryBuilder
                .BuildPreparedStatement();

            var pppp = dslCtxt
                .With()
                .Recursive<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
                .As()
                .Not()
                .Materialized(dslCtxt
                    .SubQuery()
                    .Select()
                    .Distinct(TblCards.Id())
                    .From<TblCards>()
                    .UnionAll(dslCtxt
                        .SubQuery()
                        .Select(TblCards.Id())
                        .From<TblCards>()
                        .QueryBuilder)
                    .QueryBuilder)
                .QueryBuilder
                .BuildPreparedStatement();

            var sub = dslCtxt
                .With()
                .Recursive<Tbl_With>(Tbl_With.Id())
                .As()
                .Not()
                .Materialized(dslCtxt
                    .SubQuery()
                    .Select()
                    .Distinct(TblCards.Id())
                    .From<TblCards>()
                    .UnionAll(dslCtxt
                        .SubQuery()
                        .Select(TblCards.Id())
                        .From<TblCards>()
                        .QueryBuilder)
                    .QueryBuilder)
                .QueryBuilder
                .BuildPreparedStatement();

            System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 1; i++)
            {
                sub = dslCtxt
                    .With<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
                    .AsSelect(dslCtxt.SubQuery().Select(TblCards.Id()).From<TblCards>().QueryBuilder)
                    .With<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
                    .AsSelect(dslCtxt.SubQuery().Select(TblCards.Id()).From<TblCards>().QueryBuilder)
                    .Select(Tbl_With.Id())
                    .From<Tbl_With>()
                    .QueryBuilder
                    .BuildPreparedStatement();
            }
            stopwatch.Stop();

            //using (Microsoft.Data.Sqlite.SqliteConnection sqliteConnection = new Microsoft.Data.Sqlite.SqliteConnection(@"Data Source=C:\Users\Alexander\Desktop\Digillection\digillection.sqlite3;"))
            //{
            //    var dapRes = sqliteConnection.Query(ts.Statement, param: ts.Parameters);
            //}


            var sql = dslCtxt
                .Select(new Table1.Column1().As("hello"), new Table1.Column1(), new Table1.Column2().As("int"))
                .From<Table1>()
                .Where(new Table1.Column1().Equal("hello")
                .And(new Table1.Column1().Equal("hello2"))
                .And(new Table1.Column1().In(new[] { "1", "2" }))
                .And(new Table1.Column2().Greater(2))
                .And(new Table1.Column2().IsNull())
                .And(new Table1.Column2().LesserOrEqual(3))
                .Or(new Table1.Column2().Greater(2)))
                .GroupBy(new Table1.Column1())
                .OrderBy(new Table1.Column1().Asc(), new Table1.Column1().Desc(), new Table1.Column2().Asc(), new Table1.Column2().Desc())
                .QueryBuilder
                .Build();
            Console.WriteLine(sql);

            var stmt = dslCtxt
                .Select()
                .All()
                .From<TblCards>()
                .InnerJoin<TblCards, TblPacks>()
                .On(TblCards.Pack_id(), TblPacks.Id())
                .Where(TblCards.Attribute().Equal("s")
                    .And(TblCards.Form().Equal("c"))
                    .Group()
                    .And(TblCards.Id().Equal(1)
                    .And(TblCards.Id().Equal(2))))
                .Limit(20)
                .Offset(5)
                .QueryBuilder
                .BuildPreparedStatement();
            Console.WriteLine(sql);

            sql = dslCtxt
                .Select(new Table1.Column2().Count())
                .QueryBuilder
                .Build();
            Console.WriteLine(sql);

            var g1 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").Group()).QueryBuilder.Build();

            var g2 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b"))).QueryBuilder.Build();

            var g3 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("b"))).QueryBuilder.Build();

            var g4 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b")).And(TblCards.Attribute().Equal("c"))).QueryBuilder.Build();

            var g0 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b")).Or(TblCards.Attribute().Equal("c"))).QueryBuilder.Build();

            var g5 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("b")).And(TblCards.Attribute().Equal("c"))).QueryBuilder.Build();

            var g6 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("b")).Or(TblCards.Attribute().Equal("c"))).QueryBuilder.Build();

            var g7 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b")).Group()
                .Or(TblCards.Attribute().Equal("s"))).QueryBuilder.Build();

            var g8 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b")).Group()
                .Or(TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("c")))).QueryBuilder.Build();

            var g9 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b")).Group()
                .Or(TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("c")).Group()
                    .And(TblCards.Attribute().Equal("s")))).QueryBuilder.Build();

            var g10 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b")).Group()
                .Or(TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("c")).Group()
                    .And(TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("s"))))).QueryBuilder.Build();

            var g11 = dslCtxt.Select().All().From<TblCards>().Where(
            TblCards.Attribute().Equal("s").And(TblCards.Attribute().Equal("b")).Group()
                .Or(TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("c")).Group()
                    .And(TblCards.Attribute().Equal("s").Or(TblCards.Attribute().Equal("s")).Group()))).QueryBuilder.Build();

            var g = dslCtxt
                .Select()
                .All()
                .From<TblCards>()
                .Where(
                    TblCards.Attribute().Equal("s")
                    .And(TblCards.Form().Equal("c"))
                    .Group()
                    .And(TblCards.Id().Equal(1)
                    .And(TblCards.Id().Equal(2))))
                .QueryBuilder
                .Build();


            sql = dslCtxt
                .Delete()
                .From<Table1>()
                .QueryBuilder
                .Build();
            Console.WriteLine(sql);

            sql = dslCtxt
                .Insert()
                .Into<Table1>()
                .Values(new Table1.Column1().Value("hi"), new Table1.Column2().Value(234))
                .QueryBuilder
                .Build();
            Console.WriteLine(sql);

            sql = dslCtxt
                .Update<Table1>()
                .Set(new Table1.Column1().Value("update"), new Table1.Column2().Value(234))
                .Where(new Table1.Column1().Equal("new"))
                .QueryBuilder
                .Build();
            Console.WriteLine(sql);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            stopwatch.Restart();
            var val = 2;
            var sql3 = "SELECT column1 as hello, column1, column2 as int FROM Table1 WHERE column1 = 'hello'" + val;

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            Console.WriteLine(sql);
        }
    }
}