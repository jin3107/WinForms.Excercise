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
            txtNoiDung.Clear();
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
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DanhSachCacNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DanhSachCacNuoc.SelectedItems.Count > 0)
            {
                txtNoiDung.Text = DanhSachCacNuoc.SelectedItem.ToString();
            }
        }
    }
}
