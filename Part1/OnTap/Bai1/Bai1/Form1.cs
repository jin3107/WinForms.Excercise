using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtnNhom1_CheckedChanged(object sender, EventArgs e)
        {
            clbHocPhan.Items.Clear();
            clbHocPhan.Items.Add("Công nghệ .NET");
            clbHocPhan.Items.Add("Lập trình CSDL");
            clbHocPhan.Items.Add("Phát triển Web");
            clbHocPhan.Items.Add("Lập trình Web");
        }

        private void rdbtnNhom2_CheckedChanged(object sender, EventArgs e)
        {
            clbHocPhan.Items.Clear();
            clbHocPhan.Items.Add("Nhập môn CNPM");
            clbHocPhan.Items.Add("Kiểm chứng PML");
            clbHocPhan.Items.Add("Mã nguồn mở");
            clbHocPhan.Items.Add("Nguyên lý HDH");
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int selectedItem = clbHocPhan.CheckedItems.Count;
            if (selectedItem != 2)
            {
                MessageBox.Show("Vui lòng chọn 2 học phần!", "Thông báo");
                return;
            }

            ListViewItem item = new ListViewItem(txtSTT.Text);
            item.SubItems.Add(txtHoTen.Text);
            if (rdbtnNhom1.Checked)
                item.SubItems.Add("1");
            else
                item.SubItems.Add("2");
            foreach (var hocPhan in clbHocPhan.CheckedItems)
                item.SubItems.Add(hocPhan.ToString());
            lstvDSHP.Items.Add(item);
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(txtSTT.Text);
            txtSTT.Text = (stt + 1).ToString();
            txtHoTen.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (lstvDSHP.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để hủy!", "Thông báo");
                return;
            }

            lstvDSHP.Items.Remove(lstvDSHP.SelectedItems[0]);
            MessageBox.Show("Đã hủy đăng ký học phần thành công!", "Thông báo");
        }
    }
}
