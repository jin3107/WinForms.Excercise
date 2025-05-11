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

namespace BT_BS6
{
    public partial class BT_BS6 : Form
    {
        private SqlConnection connection;

        public BT_BS6()
        {
            InitializeComponent();
        }

        private void BT_BS6_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLNV;Integrated Security=True;");
            HienThiCheckListBox();
        }

        private void HienThiCheckListBox()
        {
            clbDanhMuc.Items.Clear();
            string query = "SELECT TENVITRI FROM VITRIVL";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                clbDanhMuc.Items.Add(dr[0].ToString());
            }
        }

        private void clbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenViTri = clbDanhMuc.SelectedItem.ToString();
            lblLKNV.Text = $"Danh sách nhân viên ở vị trí {tenViTri}";
            string query = $"SELECT MAVT, TENVITRI, MUCLUONG FROM VITRIVL WHERE TENVITRI LIKE N'%{tenViTri}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtMaVT.Text = dt.Rows[0][0].ToString();
                txtTenVT.Text = dt.Rows[0][1].ToString();
                txtLuong.Text = dt.Rows[0][2].ToString();
            }
            string newQuery = "SELECT Hoten, TenPhong, Mucluong " +
                "FROM NHANVIEN nv, PHANCONG pc, PHONGBAN pb, VITRIVL vt " +
                $"WHERE nv.MaNV = pc.MaNV AND nv.MaPhong = pb.MaPhong AND vt.MaVT = pc.MaVT AND Tenvitri LIKE N'%{tenViTri}%'";
            HienThiListView(newQuery);
        }

        private void HienThiListView(string newQuery)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(newQuery, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lstvNhanVien.Items.Clear();
            int stt = 1;
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                lstvNhanVien.Items.Add(item);
                stt++;
            }
        }

        private void rdbtnTang_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Hoten, TenPhong, Mucluong " +
                "FROM NHANVIEN nv, PHANCONG pc, PHONGBAN pb, VITRIVL vt " +
                "WHERE nv.MaNV = pc.MaNV AND nv.MaPhong = pb.MaPhong AND vt.MaVT = pc.MaVT AND Tenvitri LIKE N'%%' " +
                "ORDER BY MUCLUONG";
            HienThiListView(query);
        }

        private void rdbtnGiam_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Hoten, TenPhong, Mucluong " +
                "FROM NHANVIEN nv, PHANCONG pc, PHONGBAN pb, VITRIVL vt " +
                "WHERE nv.MaNV = pc.MaNV AND nv.MaPhong = pb.MaPhong AND vt.MaVT = pc.MaVT AND Tenvitri LIKE N'%%' " +
                "ORDER BY MUCLUONG DESC";
            HienThiListView(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                Xoa();
                btnThem.Text = "Ghi";
            }
            else
            {
                Luu();
                MessageBox.Show("Đã ghi xong.", "Thông báo");
                HienThiCheckListBox();
                btnThem.Text = "Thêm";
            }
        }

        private void Luu()
        {
            string query = $"INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'{txtMaVT.Text}', N'{txtTenVT.Text}', {txtLuong.Text})";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Xoa()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtLuong.Clear();
            txtMaVT.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhat();
            MessageBox.Show("Đã cập nhật xong.", "Thông báo");
            HienThiCheckListBox();
        }

        private void CapNhat()
        {
            string query = $"UPDATE VITRIVL SET TENVITRI = N'{txtTenVT.Text}', MUCLUONG = '{txtLuong.Text}' WHERE MAVT = '{txtMaVT.Text}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaDL();
            MessageBox.Show("Đã xóa xong.", "Thông báo");
            HienThiCheckListBox();
        }

        private void XoaDL()
        {
            string query = $"DELETE FROM VITRIVL WHERE MAVT = N'{txtMaVT.Text}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
