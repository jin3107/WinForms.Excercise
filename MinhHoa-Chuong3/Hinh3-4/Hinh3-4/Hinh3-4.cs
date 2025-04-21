using System;
using System.Windows.Forms;
using System.IO;

namespace Hinh3_4
{
    public partial class Hinh3_4 : Form
    {
        public Hinh3_4()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtTongCong.Clear();
            double tongTien = 0.0;
            if (cbCaoVoi.Checked)
                tongTien += 100000;
            if (cbTayTrang.Checked)
                tongTien += 1200000;
            if (cbChupHinhRang.Checked)
                tongTien += 200000;
            if (nuTramRang.Value > 0)
                tongTien += (double)nuTramRang.Value * 80000;
            txtTongCong.Text = tongTien.ToString("N0");
            txtTenKH.ReadOnly = true;
            txtTongCong.ReadOnly = true;
        }

        private void btnKHMoi_Click(object sender, EventArgs e)
        {
            string khachHang = txtTenKH.Text + "_" + txtTongCong.Text; 
            lbDSKH.Items.Add(khachHang);
            txtTenKH.Clear();
            txtTongCong.Clear();
            cbCaoVoi.Checked = false;
            cbChupHinhRang.Checked = false;
            cbTayTrang.Checked = false;
            nuTramRang.Value = 1;
            txtTenKH.ReadOnly = false;
            txtTongCong.ReadOnly = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lbDSKH.SelectedItem != null)
            {
                string khachHang = txtTenKH.Text + "_" + txtTongCong.Text;
                int selectedIndex = lbDSKH.SelectedIndex;
                lbDSKH.Items[selectedIndex] = khachHang;
                txtTenKH.Clear();
                txtTongCong.Clear();
                cbCaoVoi.Checked = false;
                cbChupHinhRang.Checked = false;
                cbTayTrang.Checked = false;
                nuTramRang.Value = 1;
                txtTenKH.ReadOnly = false;
                txtTongCong.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbDSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDSKH.SelectedItem != null)
            {
                string khachHang = lbDSKH.SelectedItem.ToString();
                string[] khachHangInfo = khachHang.Split('_');
                txtTenKH.Text = khachHangInfo[0];
                txtTongCong.Text = khachHangInfo[1];
                txtTenKH.ReadOnly = false;
                txtTongCong.ReadOnly = false;
            }
            else
            {
                txtTenKH.Clear();
                txtTongCong.Clear();
                txtTenKH.ReadOnly = false;
                txtTongCong.ReadOnly = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = Application.StartupPath + "\\khachhang.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var item in lbDSKH.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Đã lưu danh sách khách hàng vào file khachhang.txt", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
