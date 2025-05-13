using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BT_BS8
{
    public partial class BT_BS8 : Form
    {
        private SqlConnection connection;

        public BT_BS8()
        {
            InitializeComponent();
        }

        private void BT_BS8_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLCD;Integrated Security=True;");
            HienThiListBoxTinh();
            HienThiCombobox();

            string dsChienDich = "SELECT TenCD FROM CHIENDICH";
            HienThiListBoxChienDich(dsChienDich);
        }

        private void HienThiCombobox()
        {
            string query = "SELECT TenTC FROM TOCHUC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbTCTH.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbbTCTH.Items.Add(dr[0].ToString());
            }
        }

        private void HienThiListBoxTinh()
        {
            string query = "SELECT TINH FROM DIADIEM";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lstbDSTinh.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                lstbDSTinh.Items.Add(item[0].ToString());
            }
        }

        private void lstbDSTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinh = lstbDSTinh.SelectedItem.ToString();
            string query = "SELECT Hoatdongchinh, Trangthai " +
                "FROM TRIENKHAICHIENDICH TK, DIADIEM DD " + 
                $"WHERE TK.MaDD = DD.MaDD AND DD.Tinh LIKE N'{tinh}'";
            HienThiListView(query);

            string newQuery = "SELECT TenCD, Mota, Ngaybd, Ngaykt, MaTC " +
                "FROM CHIENDICH CD, TRIENKHAICHIENDICH TK, DIADIEM DD " +
                $"WHERE CD.MaCD = TK.MaCD AND TK.MaDD = DD.MaDD AND DD.Tinh LIKE N'{tinh}'";
            HienThiDataGridView(newQuery);
        }

        private void HienThiListBoxChienDich(string dsChienDich)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(dsChienDich, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lstbDSChienDich.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                lstbDSChienDich.Items.Add(item[0].ToString());
            }
        }

        private void HienThiDataGridView(string newQuery)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(newQuery, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCCCD.DataSource = null;
            dgvCCCD.DataSource = dt;
        }

        private void HienThiListView(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lstvHoatDongChinh.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                ListViewItem listItem = new ListViewItem(item[0].ToString());
                listItem.SubItems.Add(item[1].ToString());
                lstvHoatDongChinh.Items.Add(listItem);
            }
        }

        private void lstvHoatDongChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvHoatDongChinh.SelectedItems.Count > 0)
            {
                string hoatDongChinh = lstvHoatDongChinh.SelectedItems[0].SubItems[0].Text;
                string query = "SELECT TK.MaCD, CD.TenCD, CD.Mota, CD.Ngaybd, CD.Ngaykt, " +
                               "(SELECT TenTC FROM TOCHUC WHERE MaTC = CD.MaTC) AS TenTC " +
                               "FROM CHIENDICH CD, TRIENKHAICHIENDICH TK " +
                               $"WHERE CD.MaCD = TK.MaCD AND TK.Hoatdongchinh = N'{hoatDongChinh}'";
                HienTriTrenControl(query);
            }
        }

        private void HienTriTrenControl(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                txtMaChienDich.Text = item[0].ToString();
                txtTenChienDich.Text = item[1].ToString();
                txtMoTa.Text = item[2].ToString();
                dtpNgayBD.Text = item[3].ToString();
                dtpNgayKT.Text = item[4].ToString();
                cbbTCTH.Text = item[5].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                XoaTrangControl();
                btnThem.Text = "Ghi";
            }
            else
            {
                string tenToChuc = cbbTCTH.Text;
                int maToChuc = LayMaToChuc(tenToChuc);
                LuuDL(maToChuc);
                XoaTrangControl();
                btnThem.Text = "Thêm";
                MessageBox.Show("Ghi thành công");

                string dsChienDich = "SELECT TenCD FROM CHIENDICH";
                HienThiListBoxChienDich(dsChienDich);
            }
        }

        private int LayMaToChuc(string tenToChuc)
        {
            string toChuc = $"SELECT MATC FROM TOCHUC WHERE TENTC LIKE N'{tenToChuc}'";
            SqlCommand cmd = new SqlCommand(toChuc, connection);
            connection.Open();
            int result = (int)cmd.ExecuteScalar();
            connection.Close();
            return result;
        }

        //private void LuuDL(int maToChuc)
        //{
        //    string query = $"INSERT INTO CHIENDICH (TenCD, Mota, Ngaybd, Ngaykt, MaTC) VALUES(N'{txtTenChienDich.Text}', N'{txtMoTa.Text}', '{dtpNgayBD.Value.ToShortDateString()}', '{dtpNgayKT.Value.ToShortDateString()}', {maToChuc})";
        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    connection.Open();
        //    cmd.ExecuteNonQuery();
        //    connection.Close();
        //}

        private void LuuDL(int maToChuc)
        {
            string query = "INSERT INTO CHIENDICH (TenCD, Mota, Ngaybd, Ngaykt, MaTC) VALUES (@TenCD, @Mota, @Ngaybd, @Ngaykt, @MaTC)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@TenCD", txtTenChienDich.Text);
                cmd.Parameters.AddWithValue("@Mota", txtMoTa.Text);
                cmd.Parameters.AddWithValue("@Ngaybd", dtpNgayBD.Value);
                cmd.Parameters.AddWithValue("@Ngaykt", dtpNgayKT.Value);
                cmd.Parameters.AddWithValue("@MaTC", maToChuc);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void XoaTrangControl()
        {
            txtMaChienDich.Text = "";
            txtTenChienDich.Text = "";
            txtMoTa.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
            cbbTCTH.Text = "";
            txtMaChienDich.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string toChuc = cbbTCTH.Text;
                int maTC = LayMaToChuc(toChuc);
                connection.Close();
                CapNhatDL(maTC);
                connection.Close();
                MessageBox.Show("Cập nhật thành công");
                string dsChienDich = "SELECT TenCD FROM CHIENDICH";
                HienThiListBoxChienDich(dsChienDich);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void CapNhatDL(int maTC)
        {
            string query = $"UPDATE CHIENDICH SET TenCD = N'{txtTenChienDich.Text}', Mota = N'{txtMoTa.Text}', " +
                          $"Ngaybd = '{dtpNgayBD.Value.ToShortDateString()}', Ngaykt = '{dtpNgayKT.Value.ToShortDateString()}', " +
                          $"MaTC = {maTC} WHERE MaCD = '{txtMaChienDich.Text}'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCD = txtMaChienDich.Text;
            XoaDL(maCD);
            XoaTrangControl();

            string dsChienDich = "SELECT TenCD FROM CHIENDICH";
            HienThiListBoxChienDich(dsChienDich);
        }

        private void XoaDL(string maCD)
        {
            // Trước hết cần xóa trong bảng TRIENKHAICHIENDICH
            string queryTrienKhai = $"DELETE FROM TRIENKHAICHIENDICH WHERE MaCD = '{maCD}'";
            SqlCommand cmdTrienKhai = new SqlCommand(queryTrienKhai, connection);
            connection.Open();
            cmdTrienKhai.ExecuteNonQuery();
            connection.Close();

            // Sau đó xóa trong bảng CHIENDICH
            string queryChienDich = $"DELETE FROM CHIENDICH WHERE MaCD = '{maCD}'";
            SqlCommand cmdChienDich = new SqlCommand(queryChienDich, connection);
            connection.Open();
            cmdChienDich.ExecuteNonQuery();
            connection.Close();
        }

        private void lstbDSChienDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chienDich = lstbDSChienDich.SelectedItem.ToString();
            string query = "SELECT TenCD, Mota, Ngaybd, Ngaykt, MaTC " +
                "FROM CHIENDICH CD, TRIENKHAICHIENDICH TK, DIADIEM DD " +
                $"WHERE CD.MaCD = TK.MaCD AND TK.MaDD = DD.MaDD AND CD.TenCD LIKE N'{chienDich}'";
            HienThiDataGridView(query);

            if (lstbDSChienDich.SelectedItems.Count > 0)
            {
                string newQuery = "SELECT TK.MaCD, CD.TenCD, CD.Mota, CD.Ngaybd, CD.Ngaykt, " +
                              "(SELECT TenTC FROM TOCHUC WHERE MaTC = CD.MaTC) AS TenTC " +
                              "FROM CHIENDICH CD, TRIENKHAICHIENDICH TK " +
                              $"WHERE CD.MaCD = TK.MaCD AND CD.TenCD = N'{chienDich}'";
                HienTriTrenControl(newQuery);
            }
        }
    }
}
