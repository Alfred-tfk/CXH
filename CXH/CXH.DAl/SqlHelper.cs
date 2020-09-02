using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CXH.Model;
namespace CXH.DAL
{
    public class SqlHelper
    {

        public static string ConnectionString = "server=.;database=cxh;Trusted_Connection=SSPI";
        /// <summary>
        /// 数据库查询
        /// </summary>
        /// <param name="sql">需要执行的sql语句</param>
        /// <returns>返回一个数据集</returns>
        public static DataSet Query(string sql)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            return ds;

        }

        public static int ExcuteSql(string sql)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        
        }
        public static DataSet Query(string sql,SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            return ds;

        }
        public static int ExcuteSql(string sql, SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].Value == null)
                {
                    parameters[i].Value = DBNull.Value;
                }
            }
            cmd.Parameters.AddRange(parameters);
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;

        }
    }
}
