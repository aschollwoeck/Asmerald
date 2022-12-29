using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dapper;
using System.Linq;
using System.Diagnostics;
using Asmerald.MariaDB;
using System;
using Asmerald.Statements.MariaDB;
namespace Asmerald.Test.MariaDB
{
    [TestClass]
    public class NotImplementedTest
    {
        [TestMethod]
        public void CallStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new CallStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void NotStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new NotStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WithStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WithStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WithTableStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WithTableStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WithTableAdditionalStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WithTableAdditionalStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void RecursiveStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new RecursiveStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void MaterializedStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new MaterializedStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void AsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new AsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WithAsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WithAsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WithNotStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WithNotStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void AsSelectStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new AsSelectStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WithAsSelectStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WithAsSelectStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void AllStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new AllStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectColumnsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectColumnsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DistinctStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DistinctStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DistinctColumnsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DistinctColumnsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void FromStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new FromStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void FromSubQueryStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new FromSubQueryStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void JoinSubQueryStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new JoinSubQueryStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void JoinAsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new JoinAsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void CrossJoinStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new CrossJoinStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void FullOuterJoinStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new FullOuterJoinStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InnerJoinStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InnerJoinStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void LeftOuterJoinStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new LeftOuterJoinStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void RightOuterJoinStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new RightOuterJoinStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void OnStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new OnStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void OnMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new OnMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WhereGroupStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WhereGroupStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WhereGroupMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WhereGroupMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WhereStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WhereStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void WhereMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new WhereMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectWhereGroupStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectWhereGroupStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectWhereGroupMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectWhereGroupMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectWhereStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectWhereStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectWhereMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectWhereMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectHavingGroupStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectHavingGroupStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectHavingGroupMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectHavingGroupMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectHavingStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectHavingStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SelectHavingMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SelectHavingMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void GroupByStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new GroupByStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void OrderByStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new OrderByStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void CollateStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new CollateStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void AscStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new AscStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DescStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DescStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void NullsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new NullsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void FirstStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new FirstStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void LastStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new LastStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void LimitStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new LimitStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void OffsetStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new OffsetStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void ReplaceStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new ReplaceStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertReplaceStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertReplaceStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertOrStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertOrStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void AbortStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new AbortStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertAbortStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertAbortStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void FailStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new FailStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertFailStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertFailStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void IgnoreStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new IgnoreStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertIgnoreStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertIgnoreStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void RollbackStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new RollbackStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertRollbackStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertRollbackStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void IntoStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new IntoStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void IntoAsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new IntoAsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertSelectStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertSelectStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void InsertValuesStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new InsertValuesStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DefaultStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DefaultStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DefaultValuesStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DefaultValuesStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateSetStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateSetStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateOrStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateOrStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateAbortStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateAbortStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateFailStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateFailStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateIgnoreStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateIgnoreStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateReplaceStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateReplaceStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateRollbackStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateRollbackStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateWhereStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateWhereStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateWhereGroupStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateWhereGroupStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateWhereMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateWhereMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpdateWhereGroupMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpdateWhereGroupMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void ConflictStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new ConflictStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertOnStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertOnStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertConflictStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertConflictStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertConflictSelectColumnsStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertConflictSelectColumnsStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertDoStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertDoStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertNothingStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertNothingStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertUpdateStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertUpdateStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertSetStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertSetStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertWhereStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertWhereStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertWhereGroupStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertWhereGroupStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertWhereGroupMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertWhereGroupMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertWhereMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertWhereMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertConflictWhereStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertConflictWhereStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertConflictWhereGroupStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertConflictWhereGroupStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertConflictWhereGroupMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertConflictWhereGroupMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UpsertConflictWhereMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UpsertConflictWhereMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void ReturningStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new ReturningStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void ReturningSelectStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new ReturningSelectStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void ReturningAllStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new ReturningAllStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DeleteStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DeleteFromStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteFromStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DeleteWhereStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteWhereStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DeleteWhereGroupStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteWhereGroupStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DeleteWhereGroupMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteWhereGroupMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void DeleteWhereMultiStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new DeleteWhereMultiStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void SetStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new SetStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void ValueStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new ValueStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void CompoundStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new CompoundStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UnionStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UnionStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void UnionAllStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new UnionAllStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void IntersectStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new IntersectStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
        [TestMethod]
        public void ExceptStatementImplementTest()
        {
            var qb = new MariaDBDSLContext().QueryBuilder;
            qb.AddStatment(new ExceptStatement());
            AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());
        }
    }
}
