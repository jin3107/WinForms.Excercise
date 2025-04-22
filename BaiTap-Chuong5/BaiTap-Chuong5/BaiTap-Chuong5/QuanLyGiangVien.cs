using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Chuong5
{
    public partial class QuanLyGiangVien : Form
    {
        public QuanLyGiangVien()
        {
            InitializeComponent();
        }

        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            HienThiGiaoVien_ListView();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
        }

        private void HienThiGiaoVien_ListView()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = GiangVien.ThongTinGiangVien();
                lstViewGV.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaGV"].ToString());
                    item.SubItems.Add(row["TenGV"].ToString());
                    bool gioiTinh = Convert.ToBoolean(row["GioiTinh"]);
                    item.SubItems.Add(gioiTinh ? "Nam" : "Nữ");
                    item.SubItems.Add(row["NgaySinh"].ToString());
                    item.SubItems.Add(row["DiaChi"].ToString());
                    item.SubItems.Add(row["SDT"].ToString());
                    lstViewGV.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void lstViewGV_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = lstViewGV.SelectedItems[0].SubItems[0].Text;
            txtHoTen.Text = lstViewGV.SelectedItems[0].SubItems[1].Text;
            cbbGioiTinh.Text = lstViewGV.SelectedItems[0].SubItems[2].Text;
            dtpNgaySinh.Text = lstViewGV.SelectedItems[0].SubItems[3].Text;
            txtDiaChi.Text = lstViewGV.SelectedItems[0].SubItems[4].Text;
            txtSDT.Text = lstViewGV.SelectedItems[0].SubItems[5].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = GiangVien.MaGiaoVien_LonNhat();
            string maGiaoVien = dataTable.Rows[0]["MAGV"].ToString();
            txtMaGV.Text = "GV" + string.Format("{0:000}", Convert.ToInt32(maGiaoVien.Substring(maGiaoVien.Length - 3, 3)) + 1);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            bool gioiTinh = cbbGioiTinh.Text == "Nam";

            try
            {
                GiangVien.ThemGiaoVien(txtMaGV.Text, txtHoTen.Text, gioiTinh, ngaySinh, txtDiaChi.Text, txtSDT.Text);
                MessageBox.Show("Thêm thành công");
                HienThiGiaoVien_ListView();
                txtHoTen.Text = "";
                cbbGioiTinh.Text = "";
                dtpNgaySinh.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            bool gioiTinh = cbbGioiTinh.Text == "Nam";
            try
            {
                GiangVien.CapNhatGiaoVien(txtMaGV.Text, txtHoTen.Text, gioiTinh, ngaySinh, txtDiaChi.Text, txtSDT.Text);
                MessageBox.Show("Cập nhật thành công");
                HienThiGiaoVien_ListView();
                txtHoTen.Text = "";
                cbbGioiTinh.Text = "";
                dtpNgaySinh.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật giảng viên: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    GiangVien.XoaGiaoVien(txtMaGV.Text);
                    MessageBox.Show("Xóa thành công");
                    HienThiGiaoVien_ListView();
                    txtHoTen.Text = "";
                    cbbGioiTinh.Text = "";
                    dtpNgaySinh.Text = "";
                    txtDiaChi.Text = "";
                    txtSDT.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
