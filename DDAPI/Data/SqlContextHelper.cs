using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OrderApi.DataAccess.Contexts
{
    public static class SqlContextHelper
    {
        public static SqlParameter BuildSqlParameter(string parameterName, object value)
        {
            return new SqlParameter(parameterName, SqlDbType.VarChar) { Value = value };
        }

        public static SqlParameter BuildSqlParameter(DbType dataType, string parameterName, object value)
        {
            switch (dataType)
            {
                case DbType.DateTime when (value == null || Convert.ToDateTime(value) == DateTime.MinValue):
                    value = new DateTime(1900, 1, 1);
                    break;
                case DbType.Int16:
                case DbType.Int32:
                case DbType.Int64:
                case DbType.Decimal:
                    if (value == null)
                        value = 0;
                    break;
                case DbType.Boolean when (value == null):
                    value = 0;
                    break;
                case DbType.String when value == null:
                    value = string.Empty;
                    break;
                case DbType.String when value.ToString().Contains("'"):
                    value = value.ToString().Replace("'", "''");
                    break;
                case DbType.Guid when value == null:
                    value = Guid.Empty;
                    break;
            }

            return new SqlParameter(parameterName, dataType) { Value = value };
        }

        public static string BuildSprocString(string storedProcedure)
        {
            return BuildSprocString("dbo", storedProcedure);
        }
        public static string BuildSprocString(string storedProcedure, SqlParameter parameter)
        {
            return BuildSprocString("dbo", storedProcedure, new List<SqlParameter> { parameter });
        }
        public static string BuildSprocString(string storedProcedure, List<SqlParameter> parameters)
        {
            return BuildSprocString("dbo", storedProcedure, parameters);
        }

        public static string BuildSprocString(string schema, string storedProcedure, List<SqlParameter> parameters = null)
        {
            var sql = new StringBuilder();

            sql.Append($"EXEC {schema}.{storedProcedure}");

            if (parameters != null)
                foreach (var sqlParameter in parameters)
                {
                    sql.Append($" {sqlParameter.ParameterName} = ");
                    switch (sqlParameter.DbType)
                    {
                        case DbType.Boolean:
                            sql.Append((bool)sqlParameter.Value ? 1 : 0);
                            break;
                        case DbType.Currency:
                        case DbType.Decimal:
                        case DbType.Double:
                        case DbType.Int16:
                        case DbType.Int32:
                        case DbType.Int64:
                        case DbType.Single:
                        case DbType.UInt16:
                        case DbType.UInt32:
                        case DbType.UInt64:
                            sql.Append(sqlParameter.Value);
                            break;
                        default:
                            sql.Append($"'{sqlParameter.Value.ToString().Trim()}'");
                            break;
                    }

                    if (parameters.FindIndex(x => x.Equals(sqlParameter)) < parameters.Count - 1)
                    {
                        sql.Append(", ");
                    }
                }

            return sql.ToString();
        }
    }

}
