using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dapper;
using System.Linq;
using System.Diagnostics;
using TypeProofSql.SQLite;
using System;
using TypeProofSql.Statements.SQLite;
namespace TypeProofSql.Test
{
    [TestClass]
    public class NotImplementedTest
    {
        [TestMethod]
        public void NotStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new NotStatement());
            qb.Build();
        }
        [TestMethod]
        public void WithStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WithStatement());
            qb.Build();
        }
        [TestMethod]
        public void WithTableStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WithTableStatement());
            qb.Build();
        }
        [TestMethod]
        public void WithTableAdditionalStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WithTableAdditionalStatement());
            qb.Build();
        }
        [TestMethod]
        public void RecursiveStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new RecursiveStatement());
            qb.Build();
        }
        [TestMethod]
        public void MaterializedStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new MaterializedStatement());
            qb.Build();
        }
        [TestMethod]
        public void WithAsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WithAsStatement());
            qb.Build();
        }
        [TestMethod]
        public void WithNotStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WithNotStatement());
            qb.Build();
        }
        [TestMethod]
        public void AsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new AsStatement());
            qb.Build();
        }
        [TestMethod]
        public void AsSelectStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new AsSelectStatement());
            qb.Build();
        }
        [TestMethod]
        public void WithAsSelectStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WithAsSelectStatement());
            qb.Build();
        }
        [TestMethod]
        public void AllStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new AllStatement());
            qb.Build();
        }
        [TestMethod]
        public void SelectStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new SelectStatement());
            qb.Build();
        }
        [TestMethod]
        public void SelectColumnsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new SelectColumnsStatement());
            qb.Build();
        }
        [TestMethod]
        public void DistinctStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DistinctStatement());
            qb.Build();
        }
        [TestMethod]
        public void DistinctColumnsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DistinctColumnsStatement());
            qb.Build();
        }
        [TestMethod]
        public void FromStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new FromStatement());
            qb.Build();
        }
        [TestMethod]
        public void FromSubQueryStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new FromSubQueryStatement());
            qb.Build();
        }
        [TestMethod]
        public void TableAsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new TableAsStatement());
            qb.Build();
        }
        [TestMethod]
        public void JoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new JoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void JoinSubQueryStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new JoinSubQueryStatement());
            qb.Build();
        }
        [TestMethod]
        public void JoinAsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new JoinAsStatement());
            qb.Build();
        }
        [TestMethod]
        public void ConditionalJoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ConditionalJoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void NonConditionalJoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new NonConditionalJoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void CrossJoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new CrossJoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void FullOuterJoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new FullOuterJoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void InnerJoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InnerJoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void LeftOuterJoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new LeftOuterJoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void RightOuterJoinStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new RightOuterJoinStatement());
            qb.Build();
        }
        [TestMethod]
        public void OnStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new OnStatement());
            qb.Build();
        }
        [TestMethod]
        public void OnMultiStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new OnMultiStatement());
            qb.Build();
        }
        [TestMethod]
        public void WhereGroupStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WhereGroupStatement());
            qb.Build();
        }
        [TestMethod]
        public void WhereStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new WhereStatement());
            qb.Build();
        }
        [TestMethod]
        public void AndStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new AndStatement());
            qb.Build();
        }
        [TestMethod]
        public void AndGroupStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new AndGroupStatement());
            qb.Build();
        }
        [TestMethod]
        public void OrStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new OrStatement());
            qb.Build();
        }
        [TestMethod]
        public void OrGroupStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new OrGroupStatement());
            qb.Build();
        }
        [TestMethod]
        public void HavingStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new HavingStatement());
            qb.Build();
        }
        [TestMethod]
        public void GroupByStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new GroupByStatement());
            qb.Build();
        }
        [TestMethod]
        public void OrderByStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new OrderByStatement());
            qb.Build();
        }
        [TestMethod]
        public void CollateStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new CollateStatement());
            qb.Build();
        }
        [TestMethod]
        public void AscStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new AscStatement());
            qb.Build();
        }
        [TestMethod]
        public void DescStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DescStatement());
            qb.Build();
        }
        [TestMethod]
        public void NullsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new NullsStatement());
            qb.Build();
        }
        [TestMethod]
        public void FirstStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new FirstStatement());
            qb.Build();
        }
        [TestMethod]
        public void LastStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new LastStatement());
            qb.Build();
        }
        [TestMethod]
        public void LimitStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new LimitStatement());
            qb.Build();
        }
        [TestMethod]
        public void OffsetStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new OffsetStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertStatement());
            qb.Build();
        }
        [TestMethod]
        public void ReplaceStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ReplaceStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertReplaceStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertReplaceStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertOrStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertOrStatement());
            qb.Build();
        }
        [TestMethod]
        public void AbortStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new AbortStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertAbortStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertAbortStatement());
            qb.Build();
        }
        [TestMethod]
        public void FailStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new FailStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertFailStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertFailStatement());
            qb.Build();
        }
        [TestMethod]
        public void IgnoreStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new IgnoreStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertIgnoreStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertIgnoreStatement());
            qb.Build();
        }
        [TestMethod]
        public void RollbackStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new RollbackStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertRollbackStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertRollbackStatement());
            qb.Build();
        }
        [TestMethod]
        public void IntoStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new IntoStatement());
            qb.Build();
        }
        [TestMethod]
        public void IntoAsStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new IntoAsStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertSelectStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertSelectStatement());
            qb.Build();
        }
        [TestMethod]
        public void InsertValuesStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new InsertValuesStatement());
            qb.Build();
        }
        [TestMethod]
        public void DefaultStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DefaultStatement());
            qb.Build();
        }
        [TestMethod]
        public void DefaultValuesStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DefaultValuesStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateSetStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateSetStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateOrStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateOrStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateAbortStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateAbortStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateFailStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateFailStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateIgnoreStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateIgnoreStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateReplaceStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateReplaceStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateRollbackStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateRollbackStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateFromStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateFromStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpdateWhereStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateWhereStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpsertOnStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertOnStatement());
            qb.Build();
        }
        [TestMethod]
        public void ConflictStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ConflictStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpsertDoStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertDoStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpsertNothingStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertNothingStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpsertUpdateStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertUpdateStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpsertSetStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertSetStatement());
            qb.Build();
        }
        [TestMethod]
        public void UpsertWhereStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertWhereStatement());
            qb.Build();
        }
        [TestMethod]
        public void ReturningStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ReturningStatement());
            qb.Build();
        }
        [TestMethod]
        public void ReturningSelectStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ReturningSelectStatement());
            qb.Build();
        }
        [TestMethod]
        public void ReturningAllStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ReturningAllStatement());
            qb.Build();
        }
        [TestMethod]
        public void DeleteStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteStatement());
            qb.Build();
        }
        [TestMethod]
        public void DeleteFromStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteFromStatement());
            qb.Build();
        }
        [TestMethod]
        public void DeleteWhereStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteWhereStatement());
            qb.Build();
        }
        [TestMethod]
        public void DeleteWhereGroupStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteWhereGroupStatement());
            qb.Build();
        }
        [TestMethod]
        public void SetStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new SetStatement());
            qb.Build();
        }
        [TestMethod]
        public void ValueStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ValueStatement());
            qb.Build();
        }
        [TestMethod]
        public void CompoundStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new CompoundStatement());
            qb.Build();
        }
        [TestMethod]
        public void UnionStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UnionStatement());
            qb.Build();
        }
        [TestMethod]
        public void UnionAllStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new UnionAllStatement());
            qb.Build();
        }
        [TestMethod]
        public void IntersectStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new IntersectStatement());
            qb.Build();
        }
        [TestMethod]
        public void ExceptStatementImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new ExceptStatement());
            qb.Build();
        }
    }
}
