using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace Asmerald.Generate.Generators.Database
{
    public class OracleDatabaseSchemeLoader : IDatabaseSchemeLoader, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public OracleDatabaseSchemeLoader(GenerateConfiguration config)
        {
            _dbConnection = new OracleConnection(config.ConnectionString);
            _dbConnection.Open();
        }

        public List<DatabaseSchema> LoadTables()
        {
            return _dbConnection
                .Query<DatabaseSchema>($@"
                    SELECT 
                        'table' as {nameof(DatabaseSchema.Type)}, 
                        table_name as {nameof(DatabaseSchema.Name)}, 
                        table_name as {nameof(DatabaseSchema.TableName)}, 
                        '' as {nameof(DatabaseSchema.Sql)}
                    FROM all_tables
                    UNION
                    SELECT
                        'view' as {nameof(DatabaseSchema.Type)}, 
                        view_name as {nameof(DatabaseSchema.Name)}, 
                        view_name as {nameof(DatabaseSchema.TableName)}, 
                        '' as {nameof(DatabaseSchema.Sql)}
                    FROM all_views")
                .ToList();
        }

        public List<TableSchema> LoadColumns(string table)
        {
            return _dbConnection
                .Query<TableSchema>($@"
                    SELECT 
                      COLUMN_ID as {nameof(TableSchema.Cid)}, 
                      COLUMN_NAME as {nameof(TableSchema.Name)}, 
                      DATA_DEFAULT as {nameof(TableSchema.DfltValue)}, 
                      NULLABLE as {nameof(TableSchema.Notnull)}, 
                      DATA_TYPE as {nameof(TableSchema.Type)}
                    FROM all_tab_columns
                    WHERE TABLE_NAME = :table
                    ",
                    new { table = table })
                .ToList();
        }

        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }

        public List<StoredProcedureSchema> LoadStoredProcedures()
        {
            Dictionary<string, StoredProcedureSchema> res = new Dictionary<string, StoredProcedureSchema>();

            _dbConnection
                .Query<StoredProcedureSchema, StoredProcedureSchema.ParameterSchema, StoredProcedureSchema>($@"
                    select proc.owner as {nameof(StoredProcedureSchema.Schema)},
                            proc.object_name as {nameof(StoredProcedureSchema.Name)},
                            args.position AS [{nameof(StoredProcedureSchema.ParameterSchema.Id)}],
                            args.argument_name [{nameof(StoredProcedureSchema.ParameterSchema.Name)}],
                            args.in_out AS [{nameof(StoredProcedureSchema.ParameterSchema.IsOutput)}],
                            args.data_type AS [{nameof(StoredProcedureSchema.ParameterSchema.Type)}],
                            args.data_length [{nameof(StoredProcedureSchema.ParameterSchema.MaxLength)}],
                            args.default_value AS [{nameof(StoredProcedureSchema.ParameterSchema.DefaultValue)}],
                            0 as IsNullable AS [{nameof(StoredProcedureSchema.ParameterSchema.IsNullable)}]
                    from sys.all_procedures proc
                    left join sys.all_arguments args
                        on proc.object_id = args.object_id
                    where proc.owner not in ('ANONYMOUS','CTXSYS','DBSNMP','EXFSYS',
                                'MDSYS', 'MGMT_VIEW','OLAPSYS','OWBSYS','ORDPLUGINS', 'ORDSYS',
                                'OUTLN', 'SI_INFORMTN_SCHEMA','SYS','SYSMAN','SYSTEM', 'TSMSYS',
                                'WK_TEST', 'WKSYS', 'WKPROXY','WMSYS','XDB','APEX_040000', 
                                'APEX_PUBLIC_USER','DIP', 'FLOWS_30000','FLOWS_FILES','MDDATA',
                                'ORACLE_OCM', 'XS$NULL', 'SPATIAL_CSW_ADMIN_USR', 'LBACSYS',
                                'SPATIAL_WFS_ADMIN_USR', 'PUBLIC', 'APEX_040200')
                            and object_type = 'PROCEDURE'
                    order by proc.owner,
                                proc.object_name,
                                args.position
                    ",
                    (sp, p) =>
                    {
                        var key = $"{sp.Schema}.{sp.Name}";
                        if (res.ContainsKey(key) == false)
                        {
                            res.Add(key, sp);
                            if (p != null && String.IsNullOrEmpty(p.Name) == false)
                            {
                                sp.Parameters.Add(p);
                            }
                        }
                        else
                        {
                            if (p != null && String.IsNullOrEmpty(p.Name) == false)
                            {
                                res[key].Parameters.Add(p);
                            }
                        }

                        return sp;
                    })
                .ToList();

            return res
                .Values
                .ToList();
        }

        public List<FunctionSchema> LoadFunctions()
        {
            throw new NotImplementedException();
        }
    }
}
