using QuanLyDanhMucNhanVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDanhMucNhanVien
{
    public partial class Form1 : Form
    {
        Database db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Database("Rainy", "CongTy");
            SangMo(true);
            LoadTreeView();
            LoadComboboxNgach();
            LoadComboboxBac();
        }

        private void LoadComboboxNgach()
        {
            DataTable dt = db.ExcuteQuery("Select DISTINCT Ngach From BacNgach");
            cbbNgach.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbbNgach.Items.Add(dr["Ngach"].ToString());
            }
        }

        private void LoadComboboxBac()
        {
            DataTable dt = db.ExcuteQuery("Select DISTINCT Bac From BacNgach");
            cbbBac.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbbBac.Items.Add(dr["Bac"].ToString());
            }
        }

        private void LoadTreeView()
        {
            tvwPhongBan.Nodes.Clear();
            DataTable dt = db.ExcuteQuery("Select MaPhong, TenPhong From PhongBan");
            cbbPhongBan.DataSource = dt;
            cbbPhongBan.DisplayMember = "TenPhong";
            cbbPhongBan.ValueMember = "MaPhong";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TreeNode n = new TreeNode();
                n.Text = dt.Rows[i][1].ToString();
                n.Tag = dt.Rows[i][0].ToString();
                n.ImageIndex = 0;
                DataTable dt1 = db.ExcuteQuery($"Select MaNV, TenNV From NhanVien Where MaPhong = '{n.Tag.ToString()}'");
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    TreeNode m = new TreeNode();
                    m.Text = "NV: " + dt1.Rows[j][1].ToString();
                    m.Tag = dt1.Rows[j][0].ToString();
                    m.ImageIndex = 1;
                    n.Nodes.Add(m);
                }
                tvwPhongBan.Nodes.Add(n);
            }
        }

        private void SangMo(bool v)
        {
            btnThem.Enabled = v;
            btnCapNhat.Enabled = v;
            btnHuy.Enabled = v;
            btnGhi.Enabled = !v;
        }

        private void tvwPhongBan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode n = tvwPhongBan.SelectedNode;
            if (n.Parent == null)
            {
                string maPhong = n.Tag.ToString();
                DataTable dtnv = db.ExcuteQuery("Select MaNV, TenNV, TenCongViec, NgayTuyen, GioiTinh " +
                    "From NhanVien " +
                    $"Where MaPhong = '{maPhong}'");
                dgvNhanVien.DataSource = dtnv;

                try
                {
                    string truongPhong = db.FindBy("Select TenNV From NhanVien nv, PhongBan pb " +
                        $"Where pb.MaPhong = nv.MaPhong and pb.MaPhong = '{maPhong}' and nv.MaQL is null");
                    txtTruongPhong.Text = truongPhong;
                } catch
                {
                    txtTruongPhong.Text = "";
                }

                int tongSoNV = dtnv.Rows.Count;
                lblTongSo.Text = $"Tổng số nhân viên phòng {n.Text} là: {tongSoNV}";
            }
            else
            {
                string maNV = tvwPhongBan.SelectedNode.Tag.ToString();
                string sql = "Select nv.MaNV, TenNV, TenCongViec, nv.Ngach, NgayTuyen, GioiTinh, pb.TenPhong, bl.Bac, HeSoLuong " +
                    "From NhanVien nv, BacNgach bl, PhongBan pb " +
                    $"Where nv.Bac = bl.Bac and nv.Ngach = bl.Ngach and nv.MaPhong = pb.MaPhong and nv.MaNV = '{maNV}'";

                DataTable dt = db.ExcuteQuery(sql);

                if (dt.Rows.Count > 0)
                    HienThiControl(dt.Rows[0]);
            }
        }

        private void HienThiControl(DataRow row)
        {
            txtMaNV.Text = row["MaNV"].ToString();
            txtHoTen.Text = row["TenNV"].ToString();
            txtTenCV.Text = row["TenCongViec"].ToString();
            cbbNgach.Text = row["Ngach"].ToString();
            dtpNgayTuyen.Value = Convert.ToDateTime(row["NgayTuyen"]);
            cbbPhongBan.Text = row["TenPhong"].ToString();
            cbbBac.Text = row["Bac"].ToString();
            txtHeSoLuong.Text = row["HeSoLuong"].ToString();
            rbtnNam.Checked = Convert.ToBoolean(row["GioiTinh"]);
            rbtnNu.Checked = !Convert.ToBoolean(row["GioiTinh"]);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SangMo(false);
            XoaTrangControl();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void XoaTrangControl()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtTenCV.Text = "";
            cbbNgach.Text = "";
            cbbBac.Text = "";
            txtHeSoLuong.Text = "";
            cbbPhongBan.SelectedIndex = -1;
            rbtnNam.Checked = true;
            dtpNgayTuyen.Value = DateTime.Now;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool gioiTinh = rbtnNam.Checked;
                string maPhong = cbbPhongBan.SelectedValue.ToString();
                string sql = "Update NhanVien Set TenNV = @TenNV, TenCongViec = @TenCV, Ngach = @Ngach, " +
                    "Bac = @Bac, NgayTuyen = @NgayTuyen, GioiTinh = @GioiTinh, MaPhong = @MaPhong " +
                    "Where MaNV = @MaNV";

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, db.connection);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@TenCV", txtTenCV.Text);
                cmd.Parameters.AddWithValue("@Ngach", cbbNgach.Text);
                cmd.Parameters.AddWithValue("@Bac", cbbBac.Text);
                cmd.Parameters.AddWithValue("@NgayTuyen", dtpNgayTuyen.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                db.ExecuteNonQuery(cmd);
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = $"Delete From NhanVien Where MaNV = '{txtMaNV.Text}'";
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, db.connection);
                    db.ExecuteNonQuery(cmd);

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrangControl();
                    LoadTreeView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool gioiTinh = rbtnNam.Checked;
                string maPhong = cbbPhongBan.SelectedValue.ToString();

                string sql = "Insert Into NhanVien(MaNV, TenNV, TenCongViec, Ngach, Bac, NgayTuyen, GioiTinh, MaPhong) " +
                    "Values(@MaNV, @TenNV, @TenCV, @Ngach, @Bac, @NgayTuyen, @GioiTinh, @MaPhong)";

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, db.connection);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@TenCV", txtTenCV.Text);
                cmd.Parameters.AddWithValue("@Ngach", cbbNgach.Text);
                cmd.Parameters.AddWithValue("@Bac", cbbBac.Text);
                cmd.Parameters.AddWithValue("@NgayTuyen", dtpNgayTuyen.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                db.ExecuteNonQuery(cmd);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                SangMo(true);
                XoaTrangControl();
                LoadTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbNgach_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimHeSoLuong();
        }

        private void cbbBac_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimHeSoLuong();
        }

        private void TimHeSoLuong()
        {
            if (!string.IsNullOrEmpty(cbbNgach.Text) && !string.IsNullOrEmpty(cbbBac.Text))
            {
                // Kiểm tra xem TenCongViec có phải là Giảng viên không
                if (string.IsNullOrEmpty(txtTenCV.Text) || !txtTenCV.Text.ToLower().Contains("giảng viên"))
                {
                    txtHeSoLuong.Text = "";
                    //MessageBox.Show("Chức năng này chỉ áp dụng cho Giảng viên!", "Thông báo",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tìm hệ số lương từ bảng BacNgach dựa trên Ngạch và Bậc
                string sql = $"Select HeSoLuong From BacNgach Where Ngach = N'{cbbNgach.Text}' And Bac = '{cbbBac.Text}'";
                string heSoLuong = db.FindBy(sql);

                if (!string.IsNullOrEmpty(heSoLuong))
                {
                    txtHeSoLuong.Text = heSoLuong;
                }
                else
                {
                    txtHeSoLuong.Text = "";
                    MessageBox.Show("Không tìm thấy hệ số lương cho ngạch và bậc này!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
