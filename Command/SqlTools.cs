using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication5.Command
{
    public class SqlTools
    {
        /// <summary>
        /// 单例模式
        /// </summary>
        private static SqlConnection GloblasqlConnection = null;

        private static void conntiConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["xaotag"].ConnectionString;
            if (GloblasqlConnection == null)
            {
                GloblasqlConnection = new SqlConnection(conn);
            }
        }

        /// <summary>
        /// 执行sql语句 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int commandBySql(string sql)
        {
            conntiConnection();
            SqlConnection sqlConnection = GloblasqlConnection;
            SqlCommand scd = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            int flag = scd.ExecuteNonQuery();
            sqlConnection.Close();
            return flag;
        }
        /// <summary>
        /// 查询语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet SqlDataSet(string sql)
        {
            conntiConnection();
            SqlDataAdapter data = new SqlDataAdapter(sql, GloblasqlConnection);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }
    }
}