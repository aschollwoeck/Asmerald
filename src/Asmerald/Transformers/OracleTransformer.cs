using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;
using Asmerald.Statements.Oracle;

namespace Asmerald
{
    internal class OracleTransformer : ISqlTransformer
    {
        public Dictionary<string, object> Transform(IStatement statement, StringBuilder builder, ref int paraCount)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (statement is BeginSPStatement beginSPStatement)
            {
                builder.AppendLine("BEGIN ");
                builder.Append($"{beginSPStatement.Sp.Name()}(");
                bool bPara = false;
                foreach (var (k, v) in beginSPStatement.Sp.GetParameters())
                {
                    if (bPara)
                    {
                        builder.Append(", ");
                    }

                    builder.Append($"@{paraCount}");
                    parameters.Add(paraCount.ToString(), v);
                    paraCount++;

                    bPara = true;
                }
                builder.AppendLine(")");
            }
            else if(statement is EndStatement endStatement)
            {
                builder.AppendLine("END");
            }
            else if (statement is CompoundStatement compoundStatement)
            {
                builder.AppendLine();
                if (statement is UnionAllStatement unionAllStatement)
                {
                    builder.Append("UNION ALL ");
                }
                else if (statement is UnionStatement unionStatement)
                {
                    builder.AppendLine("UNION ");
                }
                else if (statement is IntersectStatement intersectStatement)
                {
                    builder.AppendLine("INTERSECT ");
                }
                else if (statement is ExceptStatement exceptStatement)
                {
                    builder.AppendLine("EXCEPT ");
                }

                builder.AppendLine();
                var uPrepStmt = compoundStatement.SubQueryBuilder.BuildPreparedStatement();
                builder.Append(uPrepStmt.Statement);

                paraCount += uPrepStmt.Parameters.Count;
                parameters.AddRange(uPrepStmt.Parameters);
            }
            else if (statement is WithStatement withStatement)
            {
                builder.Append("WITH ");
            }
            else if (statement is RecursiveStatement recursiveStatement)
            {
                builder.Append("RECURSIVE ");
                builder.Append(recursiveStatement.Table.Name());
                builder.Append("(");
                for (int i = 0; i < recursiveStatement.SelectColumns.Count; i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, recursiveStatement.SelectColumns[i], paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
                builder.Append(")");
            }
            else if(statement is WithTableStatement withTableStatement)
            {
                builder.Append("WITH ");
                builder.Append(withTableStatement.Table.Name());
                builder.Append("(");
                for (int i = 0; i < withTableStatement.SelectColumns.Count; i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, withTableStatement.SelectColumns[i], paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
                builder.Append(")");
            }
            else if (statement is WithTableAdditionalStatement withTableAddStatement)
            {
                builder.AppendLine(",");
                builder.Append(withTableAddStatement.Table.Name());
                builder.Append("(");
                for (int i = 0; i < withTableAddStatement.SelectColumns.Count; i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, withTableAddStatement.SelectColumns[i], paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
                builder.Append(")");
            }
            else if(statement is AsStatement asStatement)
            {
                builder.Append(" AS ");
            }
            else if(statement is NotStatement notStatement)
            {
                builder.Append(" NOT ");
            }
            else if(statement is MaterializedStatement materializedStatement)
            {
                builder.Append(" MATERIALIZED (");
                builder.AppendLine();

                // TODO: Need to provide paraCount to build statement
                var mPrepStmt = materializedStatement.SubQuery.BuildPreparedStatement();
                builder.Append(mPrepStmt.Statement);

                paraCount += mPrepStmt.Parameters.Count;
                parameters.AddRange(mPrepStmt.Parameters);

                builder.Append(")");
            }
            else if(statement is AsSelectStatement asSelectStatement)
            {
                builder.Append(" AS (");
                builder.AppendLine();

                // TODO: Need to provide paraCount to build statement
                var mPrepStmt = asSelectStatement.SubQuery.BuildPreparedStatement();
                builder.Append(mPrepStmt.Statement);

                paraCount += mPrepStmt.Parameters.Count;
                parameters.AddRange(mPrepStmt.Parameters);

                builder.Append(")");
            }
            else if (statement is WithAsSelectStatement withAsSelectStatement)
            {
                builder.Append(" AS (");
                builder.AppendLine();

                // TODO: Need to provide paraCount to build statement
                var mPrepStmt = withAsSelectStatement.SubQuery.BuildPreparedStatement();
                builder.Append(mPrepStmt.Statement);

                paraCount += mPrepStmt.Parameters.Count;
                parameters.AddRange(mPrepStmt.Parameters);

                builder.Append(")");
            }
            else if(statement is SelectStatement selectStatement)
            {
                builder.Append("SELECT ");
            }
            else if (statement is SelectColumnsStatement selectColStatement)
            {
                builder.Append("SELECT ");

                for (int i = 0; i < selectColStatement.Columns.Count; i++)
                {
                    if(i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, selectColStatement.Columns[i], paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
            }
            else if (statement is DistinctStatement distinctStatement)
            {
                builder.Append("DISTINCT ");
            }
            else if (statement is DistinctColumnsStatement distinctColStatement)
            {
                builder.Append("DISTINCT ");
                for (int i = 0; i < distinctColStatement.Columns.Count; i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, distinctColStatement.Columns[i], paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
            }
            else if (statement is AllStatement allStatement)
            {
                builder.Append("* ");
            }
            else if(statement is DeleteStatement deleteStatement)
            {
                builder.Append("DELETE");

            }
            else if(statement is FromStatement fromStatement)
            {
                builder.AppendLine();
                builder.Append("FROM ");
                builder.Append(fromStatement.Table.Name());
            }
            else if (statement is FromSubQueryStatement fromSubQueryStatement)
            {
                builder.Append("FROM (");
                builder.AppendLine();

                // TODO: Need to provide paraCount to build statement
                var mPrepStmt = fromSubQueryStatement.SubQueryBuilder.BuildPreparedStatement();
                builder.Append(mPrepStmt.Statement);

                paraCount += mPrepStmt.Parameters.Count;
                parameters.AddRange(mPrepStmt.Parameters);

                builder.Append(")");
            }
            else if(statement is OnStatement onStatement)
            {
                builder.Append($"ON {onStatement.Left.Name} = {onStatement.Right.Name}");
            }
            else if(statement is OnMultiStatement onMultiStatement)
            {
                builder.Append($"ON (");
                builder.Append(String.Join(" AND ", onMultiStatement.On.Select(o => $"{o.left.Name} = {o.right.Name}")));
                builder.Append(")");
            }
            else if(statement is ConditionalJoinStatement conditionalJoinStatement)
            {
                if (statement is InnerJoinStatement innerJoinStatement)
                {
                    builder.AppendLine();
                    builder.Append($"INNER JOIN {innerJoinStatement.J.Name()} ");
                }
                else if (statement is FullOuterJoinStatement fullOuterJoinStatement)
                {
                    builder.AppendLine();
                    builder.Append($"FULL OUTER JOIN {fullOuterJoinStatement.J.Name()} ");
                }
                else if (statement is LeftOuterJoinStatement leftOuterJoinStatement)
                {
                    builder.AppendLine();
                    builder.Append($"LEFT OUTER JOIN {leftOuterJoinStatement.J.Name()} ");
                }
                else if (statement is RightOuterJoinStatement rightOuterJoinStatement)
                {
                    builder.AppendLine();
                    builder.Append($"RIGHT OUTER JOIN {rightOuterJoinStatement.J.Name()} ");
                }
                else
                {
                    throw new NotImplementedException($"ConditionalJoinStatement of type '{statement.GetType().Name}' not yet implemented!");
                }
            }
            else if (statement is NonConditionalJoinStatement nonConditionalJoinStatement)
            {
                if (statement is CrossJoinStatement crossJoinStatement)
                {
                    builder.AppendLine();
                    builder.Append($"CROSS JOIN {crossJoinStatement.J.Name()} ");
                }
                else
                {
                    throw new NotImplementedException($"NonConditionalJoinStatement of type '{statement.GetType().Name}' not yet implemented!");
                }
            }
            else if(statement is JoinAsStatement joinAsStatement)
            {
                builder.AppendLine();
                builder.Append($"AS {joinAsStatement.Alias} ");
            }
            else if(statement is JoinSubQueryStatement joinSubQueryStatement)
            {
                //builder.Append($"{joinSubQueryStatement.SubQueryBuilder.buil}");
                builder.AppendLine();
                var uPrepStmt = joinSubQueryStatement.SubQueryBuilder.BuildPreparedStatement();
                builder.Append(uPrepStmt.Statement);

                paraCount += uPrepStmt.Parameters.Count;
                parameters.AddRange(uPrepStmt.Parameters);
            }
            else if(statement is InsertStatement insertStatement)
            {
                builder.Append("INSERT ");
            }
            else if(statement is InsertOrStatement insertOrStatement)
            {
                builder.Append("OR ");
            }
            else if(statement is IntoStatement intoStatement)
            {
                builder.Append(" INTO ");
                builder.Append(intoStatement.Table.Name());
            }
            else if(statement is ValueStatement valueStatement)
            {
                builder.Append("(");
                for (int i = 0; i < valueStatement.ValueExpressions.Count(); i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, valueStatement.ValueExpressions.ElementAt(i).Column, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }

                builder.Append(") VALUES (");

                for (int i = 0; i < valueStatement.ValueExpressions.Count(); i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    builder.Append("@" + paraCount);
                    parameters.Add(paraCount.ToString(), valueStatement.ValueExpressions.ElementAt(i).Value);
                    paraCount++;
                }

                builder.Append(")");
            }
            else if(statement is UpdateStatement updateStatement)
            {
                builder.Append("UPDATE ");
                builder.Append(updateStatement.Table.Name());
            }
            else if(statement is UpdateOrStatement updateOrStatement)
            {
                builder.Append("OR ");
            }
            else if(statement is SetStatement setStatement)
            {
                builder.AppendLine();
                builder.Append("SET ");
                for (int i = 0; i < setStatement.ValueExpressions.Count(); i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, setStatement.ValueExpressions.ElementAt(i).Column, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(" = @" + paraCount);
                    parameters.Add(paraCount.ToString(), setStatement.ValueExpressions.ElementAt(i).Value);
                    paraCount++;
                }
            }
            else if(statement is WhereStatement whereStatement)
            {
                builder.AppendLine();
                builder.Append("WHERE ");

                if(whereStatement.ConditionalExpression != null)
                {
                    var res = BuildExpression(builder, whereStatement.ConditionalExpression, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                }

                //foreach (var condStmt in whereStatement.conditionalStatements)
                //{
                //    var res = BuildStatement(builder, condStmt, paraCount);
                //    paraCount = res.paraCount;
                //    parameters.AddRange(res.parameters);
                //}

                //foreach (var condGroup in whereStatement.conditionalGroupStatements)
                //{
                //    var res = BuildStatementGroup(builder, condGroup, paraCount);
                //    paraCount = res.paraCount;
                //    parameters.AddRange(res.parameters);
                //}
            }
            else if(statement is WhereMultiStatement whereMultiStatement)
            {
                builder.AppendLine();
                builder.AppendLine("WHERE ");
                foreach (var condStmt in whereMultiStatement.ConditionalStatements)
                {
                    var res = BuildStatement(builder, condStmt, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
            }
            else if (statement is SelectHavingMultiStatement selectHavingMultiStatement)
            {
                builder.AppendLine();
                builder.AppendLine("HAVING ");
                foreach (var condStmt in selectHavingMultiStatement.ConditionalStatements)
                {
                    var res = BuildStatement(builder, condStmt, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
            }
            else if (statement is WhereGroupStatement whereGroupStatement)
            {
                builder.AppendLine();
                builder.Append("WHERE ");
                var res = BuildStatementGroup(builder, whereGroupStatement.GroupExpr, paraCount);
                paraCount = res.paraCount;
                parameters.AddRange(res.parameters);
            }
            else if (statement is SelectHavingGroupStatement selectHavingGroupStatement)
            {
                builder.AppendLine();
                builder.Append("HAVING ");
                var res = BuildStatementGroup(builder, selectHavingGroupStatement.GroupExpr, paraCount);
                paraCount = res.paraCount;
                parameters.AddRange(res.parameters);
            }
            else if (statement is WhereGroupMultiStatement whereGroupMultiStatement)
            {
                builder.AppendLine();
                builder.Append("WHERE ");

                foreach (var condGroup in whereGroupMultiStatement.ConditionalGroupStatements)
                {
                    var res = BuildStatementGroup(builder, condGroup, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
            }
            else if (statement is ConditionalGroupStatement conditionalGroupStatement)
            {
                builder.AppendLine();
                foreach (var condStmt in conditionalGroupStatement.conditionalStatements)
                {
                    var res = BuildStatement(builder, condStmt, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }

                foreach (var condGroup in conditionalGroupStatement.conditionalGroupStatements)
                {
                    var res = BuildStatementGroup(builder, condGroup, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
            }
            else if (statement is ConditionalStatement conditionalStatement)
            {
                var res = BuildStatement(builder, conditionalStatement, paraCount);
                paraCount = res.paraCount;
                parameters.AddRange(res.parameters);
            }
            else if(statement is GroupByStatement groupByStatement)
            {
                builder.AppendLine();
                builder.Append("GROUP BY ");
                builder.AppendJoin(", ", groupByStatement.GroupByColumns.Select(col => col.Name()));
            }
            else if(statement is SelectHavingStatement selectHavingStatement)
            {
                builder.AppendLine();
                builder.Append("HAVING ");

                if (selectHavingStatement.ConditionalExpression != null)
                {
                    var res = BuildExpression(builder, selectHavingStatement.ConditionalExpression, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }

                //foreach (var condStmt in selectHavingStatement.conditionalStatements)
                //{
                //    var res = BuildStatement(builder, condStmt, paraCount);
                //    paraCount = res.paraCount;
                //    parameters.AddRange(res.parameters);
                //}

                //foreach (var condGroup in selectHavingStatement.conditionalGroupStatements)
                //{
                //    var res = BuildStatementGroup(builder, condGroup, paraCount);
                //    paraCount = res.paraCount;
                //    parameters.AddRange(res.parameters);
                //}
            }
            else if(statement is OrderByStatement orderByStatement) 
            {
                builder.AppendLine();
                builder.Append("ORDER BY ");
                builder.AppendJoin(", ", orderByStatement.OrderByColumns.Select(col =>
                {
                    if (col is OrderByAscColumn)
                    {
                        return col.Name() + " ASC";
                    }
                    else if (col is OrderByDescColumn)
                    {
                        return col.Name() + " DESC";
                    }
                    else if (col is IOrderByColumn)
                    {
                        return col.Name();
                    }
                    else
                    {
                        throw new NotImplementedException($"Order By column of type '{col.GetType().Name}' not yet implemented!");
                    }
                }));
            }
            else if(statement is LimitStatement limitStatement)
            {
                builder.AppendLine();
                builder.Append("LIMIT @" + paraCount);
                parameters.Add(paraCount.ToString(), limitStatement.Limit);
                paraCount++;
            }
            else if(statement is OffsetStatement offSetStatement)
            {
                builder.AppendLine();
                builder.Append("OFFSET @" + paraCount);
                parameters.Add(paraCount.ToString(), offSetStatement.Offset);
                paraCount++;
            }
            else if(statement is AbortStatement abortStatement)
            {
                builder.AppendLine("ABORT ");
            }
            else if(statement is AscStatement ascStatement)
            {
                builder.Append("ASC ");
            }
            else if(statement is CollateStatement collateStatement)
            {
                builder.Append("COLLATE ");
            }
            else if(statement is ConflictStatement conflictStatement)
            {
                builder.Append("CONFLICT ");
            }
            else if(statement is DefaultStatement defaultStatement)
            {
                builder.Append("DEFAULT ");
            }
            else if(statement is DefaultValuesStatement defaultValuesStatement)
            {
                builder.Append("VALUES ");
            }
            else if(statement is DescStatement descStatement)
            {
                builder.Append("DESC ");
            }
            else if(statement is FailStatement failStatement)
            {
                builder.AppendLine("FAIL ");
            }
            else if(statement is FirstStatement firstStatement)
            {
                builder.Append("FIRST ");
            }
            else if(statement is IgnoreStatement ignoreStatement)
            {
                builder.Append("IGNORE ");
            }
            else if(statement is LastStatement lastStatement)
            {
                builder.Append("LAST ");
            }
            else if(statement is NullsStatement nullsStatement)
            {
                builder.Append("NULLS ");
            }
            else if(statement is ReplaceStatement replaceStatement)
            {
                builder.Append("REPLACE ");
            }
            else if(statement is ReturningAllStatement returningAllStatement)
            {
                builder.Append("* ");
            }
            else if(statement is ReturningStatement returningStatement)
            {
                builder.Append("RETURNING ");
            }
            else if(statement is RollbackStatement rollbackStatement)
            {
                builder.Append("ROLLBACK ");
            }
            else if(statement is IntoAsStatement intoAsStatement)
            {
                builder.AppendLine($"As {intoAsStatement.Alias}");
            }
            else if(statement is InsertValuesStatement insertValuesStatement)
            {
                builder.Append("(");
                for (int i = 0; i < insertValuesStatement.ValueExpressions.Count(); i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    var res = this.GetValueName(builder, insertValuesStatement.ValueExpressions.ElementAt(i).Column, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }

                builder.Append(") VALUES (");

                for (int i = 0; i < insertValuesStatement.ValueExpressions.Count(); i++)
                {
                    if (i > 0)
                    {
                        builder.Append(", ");
                    }

                    builder.Append("@" + paraCount);
                    parameters.Add(paraCount.ToString(), insertValuesStatement.ValueExpressions.ElementAt(i).Value);
                    paraCount++;
                }

                builder.Append(")");
            }
            else if(statement is UpsertDoStatement upsertDoStatement)
            {
                builder.Append("DO ");
            }
            else if(statement is UpsertNothingStatement upsertNothingStatement)
            {
                builder.Append("NOTHING ");
            }
            else if(statement is UpsertOnStatement upsertOnStatement)
            {
                builder.Append("ON ");
            }
            else if(statement is UpsertSetStatement upsertSetStatement)
            {
                // TODO
                //builder.Append(upsertSetStatement.)
            }
            else if(statement is UpsertUpdateStatement upsertUpdateStatement)
            {
                builder.Append("UPDATE ");
            }
            else
            {
                throw new NotImplementedException($"Statement of type '{statement.GetType().Name}' not yet implemented!");
            }

            return parameters;
        }

        private (int paraCount, Dictionary<string, object> parameters) GetValueName(StringBuilder builder, ISelectExpression expression, int paraCount)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (expression is ISelectColumn selColumn)
            {
                if (selColumn is AliasColumn alCol)
                {
                    builder.Append($"{selColumn.Name} AS {alCol.Alias}");
                }
                else
                {
                    builder.Append(selColumn.Name);
                }
            }
            else if(expression is IFunction function)
            {
                if(function is AbsFunction absFunction)
                {
                    builder.Append($"abs(");
                    var res = this.GetValueName(builder, absFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is ChangesFunction changesFunction)
                {
                    builder.Append("changes()");
                }
                else if(function is CharFuncFunction charFunction)
                {
                    List<ISelectExpression> le = new List<ISelectExpression>();
                    if (charFunction.X1 != null) le.Add(charFunction.X1);
                    if (charFunction.X2 != null) le.Add(charFunction.X2);
                    le.AddRange(charFunction.Xn);

                    builder.Append($"char(");
                    for (int i = 0; i < le.Count; i++)
                    {
                        if(i > 0)
                        {
                            builder.Append(", ");
                        }

                        var res = this.GetValueName(builder, le[i], paraCount);
                        paraCount = res.paraCount;
                        parameters.AddRange(res.parameters);
                    }
                    builder.Append(")");
                }
                else if(function is CoalesceFunction coalesceFunction)
                {
                    builder.Append($"coalesece(");
					var res = this.GetValueName(builder, coalesceFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is DateFuncFunction dateFunction)
                {
                    builder.Append($"date(");
					var res = this.GetValueName(builder, dateFunction.Value, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append($"), { String.Join(", ", dateFunction.Modifier)})");
                }
                else if(function is DateTimeFuncFunction dateTimeFunction)
                {
                    builder.Append($"datetime(");
					var res = this.GetValueName(builder, dateTimeFunction.Value, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append($"), { String.Join(", ", dateTimeFunction.Modifier)})");
                }
                else if(function is FormatFunction formatFunction)
                {
                    builder.Append($"format({formatFunction.Format}, ");
                    for (int i = 0; i < formatFunction.Z.Count; i++)
                    {
                        builder.Append(", ");

                        var res = this.GetValueName(builder, formatFunction.Z[i], paraCount);
                        paraCount = res.paraCount;
                        parameters.AddRange(res.parameters);
                    }
                    builder.Append(")");
                }
                else if(function is GlobFunction globFunction)
                {
                    builder.Append($"glob(");
					var res = this.GetValueName(builder, globFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(",");

                    res = this.GetValueName(builder, globFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is HexFunction hexFunction)
                {
                    builder.Append($"hex(");
					var res = this.GetValueName(builder, hexFunction.Z, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is IfNullFunction ifNullFunction)
                {
                    builder.Append($"ifnull(");
					var res = this.GetValueName(builder, ifNullFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                    
                    builder.Append(", ");
					res = this.GetValueName(builder, ifNullFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is IifFunction iifFunction)
                {
                    var res = BuildExpression(builder, iifFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    builder.Append($"iif({iifFunction.X}, ");
					res = this.GetValueName(builder, iifFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, iifFunction.Z, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is InstrFunction instrFunction)
                {
                    builder.Append($"instr(");
					var res = this.GetValueName(builder, instrFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, instrFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is JulianDayFunction julianDayFunction)
                {
                    builder.Append($"julianday(");
					var res = this.GetValueName(builder, julianDayFunction.Value, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                    
                    builder.Append($", { String.Join(", ", julianDayFunction.Modifier)})");
                }
                else if(function is LastInsertRowIdFunction lastInsertRowIdFunction)
                {
                    builder.Append("last_insert_rowid()");
                }
                else if(function is LengthFunction lengthFunction)
                {
                    builder.Append($"length(");
					var res = this.GetValueName(builder, lengthFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is LikeFunction likeFunction)
                {
                    builder.Append($"like(");
					var res = this.GetValueName(builder, likeFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, likeFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is LikeEscapeFunction likeEscapeFunction)
                {
                    builder.Append($"like(");
					var res = this.GetValueName(builder, likeEscapeFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, likeEscapeFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, likeEscapeFunction.Z, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is LikelihoodFunction likelihoodFunction)
                {
                    builder.Append($"likelihood(");
					var res = this.GetValueName(builder, likelihoodFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    res = this.GetValueName(builder, likelihoodFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is LikelyFunction likelyFunction)
                {
                    builder.Append($"likely(");
					var res = this.GetValueName(builder, likelyFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is LowerFunction lowerFunction)
                {
                    builder.Append($"lower(");
					var res = this.GetValueName(builder, lowerFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is LTrimFunction lTrimFunction)
                {
                    builder.Append($"ltrim(");
					var res = this.GetValueName(builder, lTrimFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is LTrimYFunction lTrimYFunction)
                {
                    builder.Append($"ltrim(");
					var res = this.GetValueName(builder, lTrimYFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, lTrimYFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is MaxFunction maxFunction)
                {
                    builder.Append($"max(");
					var res = this.GetValueName(builder, maxFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is MinFunction minFunction)
                {
                    builder.Append($"min(");
					var res = this.GetValueName(builder, minFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is NullIfFunction nullIfFunction)
                {
                    builder.Append($"nullif(");
					var res = this.GetValueName(builder, nullIfFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, nullIfFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is QuoteFunction quoteFunction)
                {
                    builder.Append($"quote(");
					var res = this.GetValueName(builder, quoteFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is RandomblobFunction randomblobFunction)
                {
                    builder.Append($"randomblob({randomblobFunction.N})");
                }
                else if(function is RandomFunction randomFunction)
                {
                    builder.Append($"random()");
                }
                else if(function is ReplaceFunction replaceFunction)
                {
                    builder.Append($"replace(");
					var res = this.GetValueName(builder, replaceFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, replaceFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, replaceFunction.Z, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is RoundDigitsFunction roundDigitsFunction)
                {
                    builder.Append($"round(");
					var res = this.GetValueName(builder, roundDigitsFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, roundDigitsFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is RoundFunction roundFunction)
                {
                    builder.Append($"round(");
					var res = this.GetValueName(builder, roundFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is RTrimFunction rTrimFunction)
                {
                    builder.Append($"rtrim(");
					var res = this.GetValueName(builder, rTrimFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is RTrimYFunction rTrimYFunction)
                {
                    builder.Append($"rtrim(");
					var res = this.GetValueName(builder, rTrimYFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, rTrimYFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is SignFunction signFunction)
                {
                    builder.Append($"sign(");
					var res = this.GetValueName(builder, signFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is SoundexFunction soundexFunction)
                {
                    builder.Append($"soundex(");
					var res = this.GetValueName(builder, soundexFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is StrftimeFunction strftimeFunction)
                {
                    builder.Append($"strftime({strftimeFunction.Format}, ");
					var res = this.GetValueName(builder, strftimeFunction.Value, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append($", { String.Join(", ", strftimeFunction.Modifier)})");
                }
                else if(function is SubstrFunction substrFunction)
                {
                    builder.Append($"substr(");
					var res = this.GetValueName(builder, substrFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, substrFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is SubstrLengthFunction substrLengthFunction)
                {
                    builder.Append($"substr(");
					var res = this.GetValueName(builder, substrLengthFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, substrLengthFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, substrLengthFunction.Z, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if (function is SubstringFunction substringFunction)
                {
                    builder.Append($"substring(");
					var res = this.GetValueName(builder, substringFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, substringFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if (function is SubstringLengthFunction substringLengthFunction)
                {
                    builder.Append($"substring(");
					var res = this.GetValueName(builder, substringLengthFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, substringLengthFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, substringLengthFunction.Z, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is TimeFuncFunction timeFunction)
                {
                    builder.Append($"time(");
					var res = this.GetValueName(builder, timeFunction.Value, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append($", { String.Join(", ", timeFunction.Modifier)})");
                }
                else if(function is TotalChangesFunction totalChangesFunction)
                {
                    builder.Append("total_changes()");
                }
                else if(function is TrimFunction trimFunction)
                {
                    builder.Append($"trim(");
					var res = this.GetValueName(builder, trimFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is TrimYFunction trimYFunction)
                {
                    builder.Append($"trim(");
					var res = this.GetValueName(builder, trimYFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(", ");

                    res = this.GetValueName(builder, trimYFunction.Y, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is TypeofFunction typeofFunction)
                {
                    builder.Append($"typeof(");
					var res = this.GetValueName(builder, typeofFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is UnicodeFunction unicodeFunction)
                {
                    builder.Append($"unicode(");
					var res = this.GetValueName(builder, unicodeFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is UnlikelyFunction unlikelyFunction)
                {
                    builder.Append($"unlikely(");
					var res = this.GetValueName(builder, unlikelyFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is UpperFunction upperFunction)
                {
                    builder.Append($"upper(");
					var res = this.GetValueName(builder, upperFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else if(function is ZeroblobFunction zeroblobFunction)
                {
                    builder.Append($"zeroblob(");
					var res = this.GetValueName(builder, zeroblobFunction.X, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);

                    builder.Append(")");
                }
                else
                {
                    throw new NotImplementedException($"Function '{function}' not implemented!");
                }
            }
            else
            {
                throw new NotImplementedException("Select expression not yet implemented!");
            }

            return (paraCount, parameters);
        }

        private (int paraCount, Dictionary<string, object> parameters) BuildStatementGroup(StringBuilder builder, ConditionalGroupStatement condGroupStmt, int paraCount)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            
            switch (condGroupStmt)
            {
                case AndGroupStatement stmt:
                    builder.Append(" AND ");
                    break;
                case OrGroupStatement stmt:
                    builder.Append(" OR ");
                    break;
                default:
                    break;
            }

            if (condGroupStmt.conditionalStatements.Count > 0)
            {
                builder.Append("(");
                foreach (var condStmt in condGroupStmt.conditionalStatements)
                {
                    var res = BuildStatement(builder, condStmt, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
                builder.Append(")");
            }

            foreach (var g in condGroupStmt.conditionalGroupStatements)
            {
                var res = BuildStatementGroup(builder, g, paraCount);
                paraCount = res.paraCount;
                parameters.AddRange(res.parameters);
            }

            return (paraCount, parameters);
        }

        private (int paraCount, Dictionary<string, object> parameters) BuildExpression(StringBuilder builder, ConditionalExpression condExpr, int paraCount)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            var res = this.GetValueName(builder, condExpr.Column, paraCount);
            paraCount = res.paraCount;
            parameters.AddRange(res.parameters);

            //string chrIdent = "";

            //switch (condExpr.Column)
            //{
            //    case StringColumn column:
            //        chrIdent = "'";
            //        break;
            //    case IntegerColumn column:
            //        break;
            //    default:
            //        throw new NotImplementedException($"Column of type '{condExpr.Column.GetType().Name}' is not yet implemented for where clauses!");
            //}

            switch (condExpr)
            {
                case EqualConditionalExpression expr:
                    builder.Append(" = @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    break;
                case InConditionalExpression expr:
                    builder.Append(" IN @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    break;
                case GreaterConditionalExpression expr:
                    builder.Append(" > @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    break;
                case GreaterOrEqualConditionalExpression expr:
                    builder.Append(" >= @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    break;
                case LesserConditionalExpression expr:
                    builder.Append(" < @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    break;
                case LesserOrEqualConditionalExpression expr:
                    builder.Append(" <= @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    break;
                case IsNullConditionalExpression expr:
                    builder.Append(" IS NULL");
                    break;
                case BetweenConditionalExpression expr:
                    builder.Append(" BETWEEN @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), expr.MinValue);
                    builder.Append(" AND @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), expr.MaxValue);
                    paraCount++;
                    break;
                default:
                    throw new NotImplementedException($"ConditionalExpression of type '{condExpr.GetType().Name}' is not yet implemented for where clauses!");
            }

            return (paraCount, parameters);
        }

        private (int paraCount, Dictionary<string, object> parameters) BuildStatement(StringBuilder builder, ConditionalStatement condStmt, int paraCount)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            builder.AppendLine();

            switch (condStmt)
            {
                case AndStatement stmt:
                    builder.Append(" AND ");
                    break;
                case OrStatement stmt:
                    builder.Append(" OR ");
                    break;
                default:
                    break;
            }

            return BuildExpression(builder, condStmt.ConditionalExpression, paraCount);
        }

        public Dictionary<string, object> Transform(IEnumerable<IStatement> statement, StringBuilder builder)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            int paraCount = 0;
            foreach (var stmt in statement)
            {
                var para = this.Transform(stmt, builder, ref paraCount);
                dic.AddRange(para);
            }

            return dic;
        }
    }
}
