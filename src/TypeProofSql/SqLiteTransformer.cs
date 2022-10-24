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

            if (statement is UnionAllStatement unionAllStatement)
            {
                builder.AppendLine();
                builder.Append("UNION ALL ");
                builder.AppendLine();

                // TODO: Need to provide paraCount to build statement
                var uPrepStmt = unionAllStatement.SubQueryBuilder.BuildPreparedStatement();
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
                builder.AppendJoin(',', recursiveStatement.SelectColumns.Select(c => c.Name));
                builder.Append(")");
            }
            else if(statement is WithTableStatement withTableStatement)
            {
                builder.Append("WITH ");
                builder.Append(withTableStatement.Table.Name());
                builder.Append("(");
                builder.AppendJoin(',', withTableStatement.SelectColumns.Select(c => c.Name));
                builder.Append(")");
            }
            else if (statement is WithTableAdditionalStatement withTableAddStatement)
            {
                builder.AppendLine(",");
                builder.Append(withTableAddStatement.Table.Name());
                builder.Append("(");
                builder.AppendJoin(',', withTableAddStatement.SelectColumns.Select(c => c.Name));
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
                        return col.Name + " AS " + alCol.Alias;
                    }

                    return col.Name;
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
                        return col.Name + " AS " + alCol.Alias;
                    }

                    return col.Name;
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
            else if(statement is InsertStatement insertStatement)
            {
                builder.Append("INSERT");
            }
            else if(statement is IntoStatement intoStatement)
            {
                builder.Append(" INTO ");
                builder.Append(intoStatement.Table.Name());
            }
            else if(statement is ValueStatement valueStatement)
            {
                var cols = valueStatement.ValueExpressions.Select(expr => expr.Column.Name());
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

                    builder.Append(setStatement.ValueExpressions.ElementAt(i).Column.Name());
                    builder.Append(" = @" + paraCount);
                    parameters.Add(paraCount.ToString(), setStatement.ValueExpressions.ElementAt(i).Value);
                    paraCount++;
                }
            }
            else if(statement is WhereStatement whereStatement)
            {
                builder.AppendLine();
                builder.Append("WHERE ");

                foreach (var condStmt in whereStatement.conditionalStatements)
                {
                    var res = BuildStatement(builder, condStmt, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }

                foreach (var condGroup in whereStatement.conditionalGroupStatements)
                {
                    var res = BuildStatementGroup(builder, condGroup, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
            }
            else if(statement is GroupByStatement groupByStatement)
            {
                builder.AppendLine();
                builder.Append("GROUP BY ");
                builder.AppendJoin(", ", groupByStatement.GroupByColumns.Select(col => col.Name()));
            }
            else if(statement is HavingStatement havingStatement)
            {
                builder.AppendLine();
                builder.Append("HAVING ");

                foreach (var condStmt in havingStatement.conditionalStatements)
                {
                    var res = BuildStatement(builder, condStmt, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }

                foreach (var condGroup in havingStatement.conditionalGroupStatements)
                {
                    var res = BuildStatementGroup(builder, condGroup, paraCount);
                    paraCount = res.paraCount;
                    parameters.AddRange(res.parameters);
                }
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
            else
            {
                throw new NotImplementedException($"Statement of type '{statement.GetType().Name}' not yet implemented!");
            }

            return parameters;
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

            builder.Append(condStmt.ConditionalExpression.Column.Name());

            string chrIdent = "";

            switch (condStmt.ConditionalExpression.Column)
            {
                case StringColumn column:
                    chrIdent = "'";
                    break;
                case IntegerColumn column:
                    break;
                default:
                    throw new NotImplementedException($"Column of type '{condStmt.ConditionalExpression.Column.GetType().Name}' is not yet implemented for where clauses!");
            }

            switch (condStmt.ConditionalExpression)
            {
                case EqualConditionalExpression expr:
                    builder.Append(" = @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condStmt.ConditionalExpression.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case InConditionalExpression expr:
                    builder.Append(" IN @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condStmt.ConditionalExpression.Value);
                    paraCount++;
                    //builder.Append(" IN (");
                    //var l = ((System.Collections.IEnumerable)condStmt.ConditionalExpression.Value);
                    //builder.AppendJoin(", ", l.Cast<object>().Select(c => $"{chrIdent}{c}{chrIdent}"));
                    //builder.Append(")");
                    break;
                case GreaterConditionalExpression expr:
                    builder.Append(" > @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condStmt.ConditionalExpression.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case GreaterOrEqualConditionalExpression expr:
                    builder.Append(" >= @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condStmt.ConditionalExpression.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case LesserConditionalExpression expr:
                    builder.Append(" < @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condStmt.ConditionalExpression.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case LesserOrEqualConditionalExpression expr:
                    builder.Append(" <= @");
                    builder.Append(paraCount);
                    parameters.Add(paraCount.ToString(), condStmt.ConditionalExpression.Value);
                    paraCount++;
                    //builder.Append($"{chrIdent}{condStmt.ConditionalExpression.Value}{chrIdent}");
                    break;
                case IsNullConditionalExpression expr:
                    builder.Append(" IS NULL");
                    break;
                default:
                    throw new NotImplementedException($"ConditionalExpression of type '{condStmt.ConditionalExpression.GetType().Name}' is not yet implemented for where clauses!");
            }

            return (paraCount, parameters);
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
