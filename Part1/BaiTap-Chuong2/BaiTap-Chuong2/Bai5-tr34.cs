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
    public partial class Bai5_tr34: Form
    {
        public Bai5_tr34()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMon.Focus();
                return;
            }
            if (rbtMonAn.Checked)
                DanhSachMonAn.Items.Add(txtTenMon.Text);
            else
                DanhSachNuocUong.Items.Add(txtTenMon.Text);
            txtTenMon.Clear();
        }

        private void btPhai_Click(object sender, EventArgs e)
        {
            int soDongDuocChon = DanhSachMonAn.SelectedItems.Count;
            for (int i = 0; i < soDongDuocChon; i++)
            {
                DanhSachNuocUong.Items.Add(DanhSachMonAn.SelectedItems[0]);
                DanhSachMonAn.Items.Remove(DanhSachMonAn.SelectedItems[0]);
            }
        }

        private void btTrai_Click(object sender, EventArgs e)
        {
            int soDongDuocChon = DanhSachNuocUong.SelectedItems.Count;
            for (int i = 0; i < soDongDuocChon; i++)
            {
                DanhSachMonAn.Items.Add(DanhSachNuocUong.SelectedItems[0]);
                DanhSachNuocUong.Items.Remove(DanhSachNuocUong.SelectedItems[0]);
            }
        }
    }
}
