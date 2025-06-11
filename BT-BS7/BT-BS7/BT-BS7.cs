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

namespace BT_BS7
{
    public partial class BT_BS7 : Form
    {
        private SqlConnection connection;

        public BT_BS7()
        {
            InitializeComponent();
        }

        private void BT_BS7_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = QLTHUVIEN; Integrated Security = True;");
            HienThiListView();
            HienThiComboBox();
        }

        private void HienThiComboBox()
        {
            string query = "SELECT * FROM BANGCAP";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbbBangCap.Items.Add(row[1].ToString());
            }
        }

        private void HienThiListView()
        {
            string query = " SELECT NV.MaNhanVien, NV.HoTenNhanVien, NV.NgaySinh, NV.DiaChi, NV.DienThoai, BC.TenBangCap " +
                "FROM NHANVIEN NV, BANGCAP BC " +
                "WHERE NV.MaBangCap = BC.MaBangCap";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            lstvTTC.Items.Clear();
            foreach (DataRow nhanVien in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(nhanVien["MaNhanVien"].ToString());
                item.SubItems.Add(nhanVien["HoTenNhanVien"].ToString());
                item.SubItems.Add(nhanVien["NgaySinh"].ToString());
                item.SubItems.Add(nhanVien["DiaChi"].ToString());
                item.SubItems.Add(nhanVien["DienThoai"].ToString());
                item.SubItems.Add(nhanVien["TenBangCap"].ToString());
                lstvTTC.Items.Add(item);
            }
        }

        private void lstvTTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvTTC.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvTTC.SelectedItems[0];
                txtHoTen.Text = item.SubItems[1].Text;
                dtpNgaySinh.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtDienThoai.Text = item.SubItems[4].Text;
                cbbBangCap.Text = item.SubItems[5].Text;
            }
        }

        private void cbbBangCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bangCap = cbbBangCap.SelectedItem.ToString();
            string query = "SELECT NV.MaNhanVien, NV.HoTenNhanVien, NV.NgaySinh, NV.DiaChi, NV.DienThoai, BC.TenBangCap " +
                "FROM NHANVIEN NV, BANGCAP BC " +
                $"WHERE NV.MaBangCap = BC.MaBangCap AND TENBANGCAP LIKE N'%{bangCap}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            lstvTTC.Items.Clear();
            foreach (DataRow nhanVien in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(nhanVien["MaNhanVien"].ToString());
                item.SubItems.Add(nhanVien["HoTenNhanVien"].ToString());
                item.SubItems.Add(nhanVien["NgaySinh"].ToString());
                item.SubItems.Add(nhanVien["DiaChi"].ToString());
                item.SubItems.Add(nhanVien["DienThoai"].ToString());
                item.SubItems.Add(nhanVien["TenBangCap"].ToString());
                lstvTTC.Items.Add(item);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearDL();
        }

        private void ClearDL()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cbbBangCap.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            HienThiListView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string bangCap = cbbBangCap.Text;
                KTBangCapTonTai(bangCap);
                int maBangCap = LayMaBangCap(bangCap);
                ThemNhanVien(maBangCap);
                ClearDL();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void KTBangCapTonTai(string bangCap)
        {
            string checkBangCapQuery = $"SELECT COUNT(*) FROM BANGCAP WHERE TenBangCap = N'{bangCap}'";
            SqlCommand checkCommand = new SqlCommand(checkBangCapQuery, connection);
            connection.Open();
            int bangCapExists = (int)checkCommand.ExecuteScalar();
            if (bangCapExists == 0)
            {
                string insertBangCapQuery = $"INSERT INTO BANGCAP (TenBangCap) VALUES (N'{bangCap}')";
                SqlCommand insertBangCapCommand = new SqlCommand(insertBangCapQuery, connection);
                insertBangCapCommand.ExecuteNonQuery();
            }
        }

        private int LayMaBangCap(string bangCap)
        {
            string getMaBangCapQuery = $"SELECT MaBangCap FROM BANGCAP WHERE TenBangCap = N'{bangCap}'";
            SqlCommand getMaBangCapCommand = new SqlCommand(getMaBangCapQuery, connection);
            return (int)getMaBangCapCommand.ExecuteScalar();
        }

        private void ThemNhanVien(int maBangCap)
        {
            string insertNhanVienQuery = $"INSERT INTO NHANVIEN (HoTenNhanVien, NgaySinh, DiaChi, DienThoai, MaBangCap) " +
                                         $"VALUES (N'{txtHoTen.Text}', '{dtpNgaySinh.Value.ToShortDateString()}', N'{txtDiaChi.Text}', '{txtDienThoai.Text}', {maBangCap})";
            SqlCommand insertNhanVienCommand = new SqlCommand(insertNhanVienQuery, connection);
            insertNhanVienCommand.ExecuteNonQuery();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtHoTen.Text;
            int maNhanVien = LayMaNhanVien(tenNhanVien);
            string deleteQuery = $"DELETE FROM NHANVIEN WHERE MaNhanVien = '{maNhanVien}'";
            try
            {
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                connection.Open();
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private int LayMaNhanVien(string tenNhanVien)
        {
            string query = $"SELECT MaNhanVien FROM NHANVIEN WHERE HoTenNhanVien = N'{tenNhanVien}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            int maNhanVien = (int)cmd.ExecuteScalar();
            connection.Close();
            return maNhanVien;
        }
    }
}
