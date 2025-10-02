using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySach.DAO
{
    public class Database
    {
        public SqlConnection cn;
        public SqlDataAdapter da;

        public Database(string serverName, string dbName)
        {
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=" + dbName + ";Integrated Security=True";
            cn = new SqlConnection(connectionString);
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }

        public DataTable LayDL(string sql)
        {
            da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ThucThi(SqlCommand cmd)
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi không thành công.\n\n Cụ thể: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }
    }
}
