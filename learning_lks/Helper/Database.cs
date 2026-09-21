using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_lks.Helper
{

    public static class Database
    {
        private static readonly string ConnStr =
            ConfigurationManager.ConnectionStrings["LKS_2026"].ConnectionString;


        public static SqlConnection GetConnection() => new SqlConnection(ConnStr);

        // select database
        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

        
    }

        // Insert
    public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }


        // count
        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            } 
        }


        public static SqlParameter P(string name, object value) =>
            new SqlParameter(name, value ?? DBNull.Value);

        // connecction test
        public static bool CheckConnection(out string error)
        {
            try
            {
                using (var conn = GetConnection()) {
                    conn.Open();
                    error = null;
                    return true;
                }

            } catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

    } 

    }
