using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023101063_Tuan4
{
    public partial class Bai4_tr33 : Form
    {
        public Bai4_tr33()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
                MessageBox.Show("Vui lòng nhập nội dung", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DanhSachCacNuoc.Items.Add(txtNoiDung.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int soDongDuocChon = DanhSachCacNuoc.SelectedItems.Count;
            for (int i = 0; i < soDongDuocChon; i++)
                DanhSachCacNuoc.Items.Remove(DanhSachCacNuoc.SelectedItems[0]);
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DanhSachCacNuoc.SelectedIndex != -1)
                DanhSachCacNuoc.Items[DanhSachCacNuoc.SelectedIndex] = txtNoiDung.Text;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
