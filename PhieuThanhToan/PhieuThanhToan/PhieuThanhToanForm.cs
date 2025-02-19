using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhieuThanhToan
{
    public partial class PhieuThanhToanForm : Form
    {
        public PhieuThanhToanForm()
        {
            InitializeComponent();
        }

        private void textBoxTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTenKhachHang.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tong = 0;
                if (checkBoxCaoVoi.Checked)
                    tong += 100000;
                if (checkBoxTayRang.Checked)
                    tong += 1200000;
                if (checkBoxChupHinhRang.Checked)
                    tong += 200000;
                tong += Convert.ToInt32(numericUpDownTramRang.Value) * 80000;
                labelKetQua.Text = string.Format($"{tong:#,##0}") + "VNĐ";
            }
        }

        private void checkBoxCaoVoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTayRang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChupHinhRang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
