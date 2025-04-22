using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTap_Chuong5
{
    public class KetNoiCSDL
    {
        private static SqlConnection connection = new SqlConnection();

        public static void MoKetNoi()
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=QLGV;Integrated Security=True";
                connection.ConnectionString = connectionString;
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối CSQL không thành công!");
            }
        }

        public static void DongKetNoi()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Đóng kết nối CSQL không thành công!");
            }
        }

        public static DataTable ExcuteQuery(string query)
        {
            MoKetNoi();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            DongKetNoi();
            return dataTable;
        }

        public static void ExcuteNonQuery(string query)
        {
            MoKetNoi();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
