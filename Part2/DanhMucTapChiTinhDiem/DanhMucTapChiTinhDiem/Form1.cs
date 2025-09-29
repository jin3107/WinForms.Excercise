using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhMucTapChiTinhDiem
{
    public partial class frmDMTC : Form
    {
        private DataTable dt;

        public frmDMTC()
        {
            InitializeComponent();
            ComboboxLoai();
            BatTat(true);
        }

        private void ComboboxLoai()
        {
            cbbLoai.Items.Clear();
            cbbLoai.Items.Add("Kỷ yếu");
            cbbLoai.Items.Add("Tạp chí");
        }

        private void AddData(TapChi tc)
        {
            DataRow row = dt.NewRow();
            row["STT"] = tc.STT;
            row["TenTapChi"] = tc.TenTapChi;
            row["Loai"] = tc.Loai;
            row["CQXuatBan"] = tc.CQXuatBan;
            row["Diem"] = tc.Diem;
            dt.Rows.Add(row);
        }

        private void CreateData()
        {
            dt = new DataTable("DMTapChi");
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("TenTapChi", typeof(string));
            dt.Columns.Add("Loai", typeof(string));
            dt.Columns.Add("CQXuatBan", typeof(string));
            dt.Columns.Add("Diem", typeof(double));
        }

        private void BatTat(bool gt)
        {
            btnGhi.Enabled = !gt;
            btnKhong.Enabled = !gt;
            btnThem.Enabled = gt;
            btnCapNhat.Enabled = gt;
            btnHuy.Enabled = gt;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            TapChi tc = new TapChi(int.Parse(txtSTT.Text), txtTenTC.Text, cbbLoai.Text, txtCQXB.Text, double.Parse(txtDiem.Text));
            row["STT"] = tc.STT;
            row["TenTapChi"] = tc.TenTapChi;
            row["Loai"] = tc.Loai;
            row["CQXuatBan"] = tc.CQXuatBan;
            row["Diem"] = tc.Diem;
            dt.Rows.Add(row);
            BatTat(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTat(false);
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtSTT.Text = "";
            txtTenTC.Text = "";
            txtCQXB.Text = "";
            txtDiem.Text = "";
            cbbLoai.Text = "";
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            BatTat(true);
        }

        private void dtgvDMTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvDMTC.Rows[e.RowIndex];

                txtSTT.Text = row.Cells["STT"].Value?.ToString();
                txtTenTC.Text = row.Cells["TenTapChi"].Value?.ToString();
                cbbLoai.Text = row.Cells["Loai"].Value?.ToString();
                txtCQXB.Text = row.Cells["CQXuatBan"].Value?.ToString();
                txtDiem.Text = row.Cells["Diem"].Value?.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dtgvDMTC.CurrentRow != null)
            {
                DataGridViewRow row = dtgvDMTC.CurrentRow;

                row.Cells["STT"].Value = int.Parse(txtSTT.Text);
                row.Cells["TenTapChi"].Value = txtTenTC.Text;
                row.Cells["Loai"].Value = cbbLoai.Text;
                row.Cells["CQXuatBan"].Value = txtCQXB.Text;
                row.Cells["Diem"].Value = double.Parse(txtDiem.Text);

                BatTat(true);
            }
            else
                MessageBox.Show("Chưa chọn dòng nào để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dtgvDMTC.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    dtgvDMTC.Rows.RemoveAt(dtgvDMTC.CurrentRow.Index);
            }
            else
                MessageBox.Show("Chưa chọn dòng nào để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmDMTC_Load(object sender, EventArgs e)
        {
            CreateData();
            TapChi tc = new TapChi(1, "Công dân và Khuyến học", "Tạp chí", "Trung Ương hội khuyến học Việt Nam", 0.25);
            AddData(tc);
            dtgvDMTC.DataSource = dt;
        }
    }
}
