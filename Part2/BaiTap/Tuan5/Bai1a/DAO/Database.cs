using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan5.Bai1a.DAO
{
    public class Database
    {
        SqlConnection cn;
        SqlDataAdapter da;

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
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
