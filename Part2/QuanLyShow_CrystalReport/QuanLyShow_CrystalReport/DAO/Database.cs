using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShow_CrystalReport.DAO
{
    public class Database
    {
        public SqlConnection connection;
        public SqlDataAdapter dataAdapter;

        public Database(string svName, string dbName)
        {
            try
            {
                connection = new SqlConnection($"Data Source={svName};Initial Catalog={dbName};Integrated Security=True");
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch
            {
                MessageBox.Show("Kết nối CSDL không thành công!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ExcuteQuery(string sql)
        {
            DataTable dataTable = new DataTable();
            dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public string FindBy(string sql)
        {
            Object result;
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            result = cmd.ExecuteScalar();
            if (connection.State == ConnectionState.Open)
                connection.Close();

            return result?.ToString() ?? "";
        }
    }
}
