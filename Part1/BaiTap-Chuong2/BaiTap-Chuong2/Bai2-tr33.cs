using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Chuong2
{
    public partial class Bai2_tr33 : Form
    {
        public Bai2_tr33()
        {
            InitializeComponent();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxHoTen.Focus();
            }
            else if (textBoxSoThich.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sở thích", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSoThich.Focus();
            }
            else if (dateTimePickerNgaySinh.Value == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerNgaySinh.Focus();
            }
            else
            {
                MessageBox.Show("Họ tên: " + textBoxHoTen.Text + 
                    "\nNgày sinh: " + dateTimePickerNgaySinh.Text + 
                    "\nSở thích: " + textBoxSoThich.Text, 
                    "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
