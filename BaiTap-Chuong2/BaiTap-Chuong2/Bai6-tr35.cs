using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Chuong2
{ 
    public partial class Bai6_tr35: Form
    {
        public Bai6_tr35()
        {
            InitializeComponent();
            txtTenXe.ReadOnly = true;
            txtMauSac.ReadOnly = true;
            txtDonGia.ReadOnly = true;
        }

        private void btTT_Click(object sender, EventArgs e)
        {
            if (cbbLoaiXe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại xe", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDonGia.Text, out int donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuong = Convert.ToInt32(nuSoLuong.Value);
            if (soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int thanhTien = donGia * soLuong;
            lblT.Text = thanhTien.ToString("N0", new CultureInfo("en-US"));
        }

        private void Bai6_tr35_Load(object sender, EventArgs e)
        {
            cbbLoaiXe.Items.Add("Vision");
            cbbLoaiXe.Items.Add("Click");
            cbbLoaiXe.Items.Add("SH mode");
            cbbLoaiXe.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbbLoaiXe.SelectedItem.ToString();
            if (selectedItem == "Vision")
            {
                Clear();
                txtTenXe.Text = "Vision";
                txtMauSac.Text = "Xanh";
                txtDonGia.Text = "35000000";
            }
            else if (selectedItem == "Click")
            {
                Clear();
                txtTenXe.Text = "Click";
                txtMauSac.Text = "Trắng";
                txtDonGia.Text = "42000000";
            }
            else if (selectedItem == "SH mode")
            {
                Clear();
                txtTenXe.Text = "SH mode";
                txtMauSac.Text = "Đỏ";
                txtDonGia.Text = "50000000";
            }
        }

        private void Clear()
        {
            txtTenXe.Clear();
            txtMauSac.Clear();
            txtDonGia.Clear();
            nuSoLuong.Value = 0;
        }
    }
}
