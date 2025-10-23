using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5.TreeView.DAO
{
    public class Database
    {
        public SqlConnection cn;
        public SqlDataAdapter da;

        public Database(string svName, string dbName)
        {
            cn = new SqlConnection($"Data Source={svName};Initial Catalog={dbName};Integrated Security=True");
        }

        public DataTable LayDL(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            return dt;
        }

        public void ThucThi(SqlCommand cmd)
        {
            cn.Open(); ;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public string Tim(string sql)
        {
            Object result;
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            result = cmd.ExecuteScalar();
            cn.Close();
            return result.ToString();
        }
    }
}
