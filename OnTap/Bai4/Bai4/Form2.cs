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

namespace Bai4
{
    public partial class Form2 : Form
    {
        private SqlConnection cn;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=localhost;Initial Catalog=QLNV_1;Integrated Security=True;");
            HienThiListView();
            HienThiGioiTinh();
            HienThiPhongBan();
            HienThiTrinhDo();
        }

        private void HienThiTrinhDo()
        {
            string query = "select TrinhDo from TrinhDo";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTrinhDo.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                cbbTrinhDo.Items.Add(dr[0].ToString());
        }

        private void HienThiPhongBan()
        {
            string query = "select TenPhong from PhongBan";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbPhongBan.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                cbbPhongBan.Items.Add(dr[0].ToString());
        }

        private void HienThiGioiTinh()
        {
            string query = "select distinct GioiTinh from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbGioiTinh.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                cbbGioiTinh.Items.Add(dr[0].ToString());
        }

        private void HienThiListView()
        {
            string query = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstvNhanVien.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(Convert.ToDateTime(dr[3]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                item.SubItems.Add(dr[6].ToString());
                item.SubItems.Add(dr[7].ToString());
                lstvNhanVien.Items.Add(item);
            }
        }

        private void lstvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvNhanVien.SelectedItems.Count > 0)
            {
                string maNhanVien = lstvNhanVien.SelectedItems[0].SubItems[0].Text;
                string query = "select HoTen, GioiTinh, NgaySinh, DiaChi, SDT, " +
                    "(select TenPhong from PhongBan where MaPhong = p.MaPhong) as TenPhong, " +
                    "(select TrinhDo from TrinhDo where MaTD = td.MaTD) as TrinhDo " +
                    "from NhanVien nv, PhongBan p, TrinhDo td " +
                    $"where  nv.MaPhong = p.MaPhong and nv.MaTD = td.MaTD and nv.MaNV = {maNhanVien}";
                HienThiControl(query);
            }
        }

        private void HienThiControl(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            XoaTrangControl();
            foreach (DataRow dr in dt.Rows)
            {
                txtHoTen.Text = dr[0].ToString();
                cbbGioiTinh.Text = dr[1].ToString();
                dtpNgaySinh.Text = dr[2].ToString();
                txtDiaChi.Text = dr[3].ToString();
                txtSDT.Text = dr[4].ToString();
                cbbPhongBan.Text = dr[5].ToString();
                cbbTrinhDo.Text = dr[6].ToString();
            }
        }

        private void XoaTrangControl()
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cbbGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cbbPhongBan.Text = "";
            cbbTrinhDo.Text = "";
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
                string tenPhongBan = cbbPhongBan.Text;
                int maPB = LayMaPB(tenPhongBan);
                string tenTrinhDo = cbbTrinhDo.Text;
                int maTD = LayMaTD(tenTrinhDo);
                ThemDL(maPB, maTD);
                XoaTrangControl();
                HienThiListView();
                btnThem.Text = "Thêm";
                MessageBox.Show("Thêm dữ liệu thành công.");
            }
        }

        private void ThemDL(int maPB, int maTD)
        {
            string query = "INSERT INTO NhanVien (HoTen, GioiTinh, NgaySinh, DiaChi, SDT, MaPhong, MaTD) VALUES(@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @MaPhong, @MaTD)";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@MaPhong", maPB);
            cmd.Parameters.AddWithValue("@MaTD", maTD);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = lstvNhanVien.SelectedItems[0].SubItems[0].Text;
            XoaDL(maNhanVien);
            XoaTrangControl();
        }

        private void XoaDL(string maNhanVien)
        {
            string query = $"delete from NhanVien where MaNV = {maNhanVien}";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNV = lstvNhanVien.SelectedItems[0].SubItems[0].Text;
            string tenPhongBan = cbbPhongBan.Text;
            int maPB = LayMaPB(tenPhongBan);
            string tenTrinhDo = cbbTrinhDo.Text;
            int maTD = LayMaTD(tenTrinhDo);
            CapNhatDL(maNV, maPB, maTD);
            XoaTrangControl();
            HienThiListView();
        }

        private void CapNhatDL(string maNV, int maPB, int maTD)
        {
            string query = "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT, MaPhong = @MaPhong, MaTD = @MaTD WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@MaPhong", maPB);
            cmd.Parameters.AddWithValue("@MaTD", maTD);
            cmd.Parameters.AddWithValue("@MaNV", maNV);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        private int LayMaTD(string tenTrinhDo)
        {
            string maTD = $"select MaTD from TrinhDo where TrinhDo like N'%{tenTrinhDo}%'";
            SqlCommand cmd = new SqlCommand(maTD, cn);
            cn.Open();
            int kq = (int)cmd.ExecuteScalar();
            cn.Close();
            return kq;
        }

        private int LayMaPB(string tenPhongBan)
        {
            string maPB = $"select MaPhong from PhongBan where TenPhong like N'%{tenPhongBan}%'";
            SqlCommand cmd = new SqlCommand(maPB, cn);
            cn.Open();
            int kq = (int)cmd.ExecuteScalar();
            cn.Close();
            return kq;
        }
    }
}
