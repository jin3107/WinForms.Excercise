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
using QuanLySinhVien.DAO;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.GUI
{
    public partial class DMSV : Form
    {
        private Database db;
        private DataTable dt;
        private int i = 0;

        public DMSV()
        {
            InitializeComponent();
        }

        private void DMSV_Load(object sender, EventArgs e)
        {
            db = new Database("RAINY", "QLSV");
            DataTable dt = db.LayDL("Select MaSV, Ho, Ten, NgaySinh, Phai From SinhVien_New");
            HienThiListView(dt);
            BatTat(true);
        }

        private void BatTat(bool gt)
        {
            btnGhi.Enabled = !gt;
            btnKhong.Enabled = !gt;
            btnThem.Enabled = gt;
            btnCapNhat.Enabled = gt;
            btnHuy.Enabled = gt;
        }

        private void HienThiListView(DataTable dt)
        {
            lstvDMSV.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = CreateItem(dr);
                lstvDMSV.Items.Add(item);
            }
        }

        private ListViewItem CreateItem(DataRow dr)
        {
            i++;
            ListViewItem item = new ListViewItem(i.ToString());
            item.SubItems.Add(dr[0].ToString());
            item.SubItems.Add(dr[1].ToString() + " " + dr[2].ToString());
            if (dr[4].ToString() == "True")
                item.SubItems.Add("Nam");
            else
                item.SubItems.Add("Nữ");
            item.SubItems.Add(DateTime.Parse(dr[3].ToString()).ToShortDateString());
            return item;
        }

        private void lstvDMSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDMSV.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvDMSV.SelectedItems[0];
                string hoTen = (item.SubItems[2].Text ?? "").Trim();
                string ten = "", ho = "";
                if (hoTen.Length > 0)
                {
                    var parts = hoTen.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    ten = parts[parts.Length - 1];
                    ho = string.Join(" ", parts.Take(parts.Length - 1));
                }

                txtMaSV.Text = item.SubItems[1].Text;
                txtHoLot.Text = ho;
                txtTen.Text = ten;
                dtpNgaySinh.Value = DateTime.Parse(item.SubItems[4].Text);
                if (item.SubItems[3].Text == "Nam")
                    cbbPhai.Checked = true;
                else
                    cbbPhai.Checked = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTat(false);
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtMaSV.Text = "";
            txtHoLot.Text = "";
            txtTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cbbPhai.Checked = false;
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            BatTat(true);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien(txtMaSV.Text, txtHoLot.Text, txtTen.Text, dtpNgaySinh.Value, cbbPhai.Checked);
            string sql = "Insert into SinhVien_New(MaSV, Ho, Ten, NgaySinh, Phai) values(@MaSV, @Ho, @Ten, @NgaySinh, @Phai)";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaSV", sinhVien.MaSV);
                cmd.Parameters.AddWithValue("@Ho", sinhVien.HoLot);
                cmd.Parameters.AddWithValue("@Ten", sinhVien.Ten);
                cmd.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                cmd.Parameters.AddWithValue("@Phai", sinhVien.Phai);

                try
                {
                    db.ThucThi(cmd);
                    MessageBox.Show("Đã ghi dữ liệu thành công", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dt = db.LayDL("Select MaSV, Ho, Ten, NgaySinh, Phai From SinhVien_New");
                    i = 0;
                    HienThiListView(dt);
                    BatTat(true);
                    XoaTrang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu không thành công\n\n Cụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien(txtMaSV.Text, txtHoLot.Text, txtTen.Text, dtpNgaySinh.Value, cbbPhai.Checked);
            string sql = "Update SinhVien_New Set Ho = @Ho, Ten = @Ten, NgaySinh = @NgaySinh, Phai = @Phai Where MaSV = @MaSV";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaSV", sinhVien.MaSV);
                cmd.Parameters.AddWithValue("@Ho", sinhVien.HoLot);
                cmd.Parameters.AddWithValue("@Ten", sinhVien.Ten);
                cmd.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                cmd.Parameters.AddWithValue("@Phai", sinhVien.Phai);

                try
                {
                    db.ThucThi(cmd);
                    MessageBox.Show("Đã cập nhật dữ liệu thành công", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dt = db.LayDL("Select MaSV, Ho, Ten, NgaySinh, Phai From SinhVien_New");
                    i = 0;
                    HienThiListView(dt);
                    BatTat(true);
                    XoaTrang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật dữ liệu không thành công\n\n Cụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien(txtMaSV.Text, txtHoLot.Text, txtTen.Text, dtpNgaySinh.Value, cbbPhai.Checked);
            string sql = "Delete SinhVien_New Where MaSV = @MaSV";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaSV", sinhVien.MaSV);

                try
                {
                    db.ThucThi(cmd);
                    MessageBox.Show("Đã xoá dữ liệu thành công", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dt = db.LayDL("Select MaSV, Ho, Ten, NgaySinh, Phai From SinhVien_New");
                    i = 0;
                    HienThiListView(dt);
                    BatTat(true);
                    XoaTrang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá dữ liệu không thành công\n\n Cụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
