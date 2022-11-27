using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Expressions;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql
{
    internal class SqLiteTransformer : ISqlTransformer
    {
        public Dictionary<string, object> Transform(IStatement statement, StringBuilder builder, ref int paraCount)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (statement is CompoundStatement compoundStatement)
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
                builder.AppendJoin(',', recursiveStatement.SelectColumns.Select(c => this.GetValueName(c)));
                builder.Append(")");
            }
            else if(statement is WithTableStatement withTableStatement)
            {
                builder.Append("WITH ");
                builder.Append(withTableStatement.Table.Name());
                builder.Append("(");
                builder.AppendJoin(',', withTableStatement.SelectColumns.Select(c => this.GetValueName(c)));
                builder.Append(")");
            }
            else if (statement is WithTableAdditionalStatement withTableAddStatement)
            {
                builder.AppendLine(",");
                builder.Append(withTableAddStatement.Table.Name());
                builder.Append("(");
                builder.AppendJoin(',', withTableAddStatement.SelectColumns.Select(c => this.GetValueName(c)));
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
                builder.AppendJoin(", ", selectColStatement.Columns.Select(col =>
                {

                    if (col is AliasColumn alCol)
                    {
                        return this.GetValueName(col) + " AS " + alCol.Alias;
                    }

                    return this.GetValueName(col);
                }));
            }
            else if (statement is DistinctStatement distinctStatement)
            {
                builder.Append("DISTINCT ");
            }
            else if (statement is DistinctColumnsStatement distinctColStatement)
            {
                builder.Append("DISTINCT ");
                builder.AppendJoin(", ", distinctColStatement.Columns.Select(col =>
                {

                    if (col is AliasColumn alCol)
                    {
                        return this.GetValueName(col) + " AS " + alCol.Alias;
                    }

                    return this.GetValueName(col);
                }));
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
            else if(statement is InnerJoinStatement innerJoinStatement)
            {
                builder.AppendLine();
                builder.Append($"INNER JOIN {innerJoinStatement.J.Name()} ");
            }
            else if(statement is CrossJoinStatement crossJoinStatement)
            {
                builder.AppendLine();
                builder.Append($"CROSS JOIN {crossJoinStatement.J.Name()} ");
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
            else if(statement is JoinAsStatement joinAsStatement)
            {
                builder.AppendLine();
                builder.Append($"AS {joinAsStatement.Alias} ");
            }
            else if(statement is JoinSubQueryStatement joinSubQueryStatement)
            {
                //builder.Append($"{joinSubQueryStatement.SubQueryBuilder.buil}");
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
                var cols = valueStatement.ValueExpressions.Select(expr => this.GetValueName(expr.Column));
                var vals = valueStatement.ValueExpressions.Select(expr => expr.Value);

                builder.Append("(");
                builder.AppendJoin(", ", cols);
                builder.Append(") VALUES (");

                List<string> valIdx = new List<string>();
                for (int i = 0; i < vals.Count(); i++)
                {
                    valIdx.Add("@" + paraCount);
                    parameters.Add(paraCount.ToString(), vals.ElementAt(i));
                    paraCount++;
                }

                builder.AppendJoin(", ", valIdx);

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

                    builder.Append(this.GetValueName(setStatement.ValueExpressions.ElementAt(i).Column));
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
            else if (statement is WhereGroupStatement whereGroupStatement)
            {
                builder.AppendLine();
                builder.Append("WHERE ");
                var res = BuildStatementGroup(builder, whereGroupStatement.GroupExpr, paraCount);
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
                builder.Append(String.Join(", ", insertValuesStatement.ValueExpressions.Select(v => this.GetValueName(v.Column))));
                builder.Append(") VALUES (");
                for (int i = 0; i < insertValuesStatement.ValueExpressions.Count; i++)
                {
                    builder.Append($"@{paraCount}");
                    paraCount++;
                    parameters.Add(paraCount.ToString(), insertValuesStatement.ValueExpressions[i].Value);
                    if(i < insertValuesStatement.ValueExpressions.Count - 1)
                    {
                        builder.Append(", ");
                    }
                }
                builder.AppendLine(")");
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

        private string GetValueName(ISelectExpression expression)
        {
            if(expression is ISelectColumn selColumn)
            {
                return selColumn.Name;
            }

            throw new NotImplementedException("Select expression not yet implemented!");
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

            builder.Append(this.GetValueName(condExpr.Column));

            string chrIdent = "";

            switch (condExpr.Column)
            {
                case StringColumn column:
                    chrIdent = "'";
                    break;
                case IntegerColumn column:
                    break;
                default:
                    throw new NotImplementedException($"Column of type '{condExpr.Column.GetType().Name}' is not yet implemented for where clauses!");
            }

            switch (condExpr)
            {
                case EqualConditionalExpression expr:
                    builder.Append(" = @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case InConditionalExpression expr:
                    builder.Append(" IN @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    //builder.Append(" IN (");
                    //var l = ((System.Collections.IEnumerable)condStmt.ConditionalExpression.Value);
                    //builder.AppendJoin(", ", l.Cast<object>().Select(c => $"{chrIdent}{c}{chrIdent}"));
                    //builder.Append(")");
                    break;
                case GreaterConditionalExpression expr:
                    builder.Append(" > @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case GreaterOrEqualConditionalExpression expr:
                    builder.Append(" >= @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case LesserConditionalExpression expr:
                    builder.Append(" < @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case LesserOrEqualConditionalExpression expr:
                    builder.Append(" <= @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condExpr.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
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
