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
    public partial class Bai7_tr36 : Form
    {
        public Bai7_tr36()
        {
            InitializeComponent();
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbbLop.SelectedItem.ToString();
            if (selectedItem == "Cao đẳng 17")
            {
                lstvDSL.Items.Clear();
                lstvDSL.Items.Add("Anh Tuấn");
                lstvDSL.Items[0].SubItems.Add("9");
                lstvDSL.Items[0].SubItems.Add("8");
                lstvDSL.Items[0].SubItems.Add("9");

                lstvDSL.Items.Add("Hoàng Giang");
                lstvDSL.Items[1].SubItems.Add("10");
                lstvDSL.Items[1].SubItems.Add("7");
                lstvDSL.Items[1].SubItems.Add("9");

                lstvDSL.Items.Add("Trâm Anh");
                lstvDSL.Items[2].SubItems.Add("8");
                lstvDSL.Items[2].SubItems.Add("7");
                lstvDSL.Items[2].SubItems.Add("10");
            }
            else if (selectedItem == "Cao đẳng 18")
            {
                lstvDSL.Items.Clear();
                lstvDSL.Items.Add("Hữu Tiến");
                lstvDSL.Items[0].SubItems.Add("7");
                lstvDSL.Items[0].SubItems.Add("8");
                lstvDSL.Items[0].SubItems.Add("9");

                lstvDSL.Items.Add("Thanh Lâm");
                lstvDSL.Items[1].SubItems.Add("5");
                lstvDSL.Items[1].SubItems.Add("4");
                lstvDSL.Items[1].SubItems.Add("6");

                lstvDSL.Items.Add("Yến Như");
                lstvDSL.Items[2].SubItems.Add("4");
                lstvDSL.Items[2].SubItems.Add("7");
                lstvDSL.Items[2].SubItems.Add("7");
            }
        }

        private void Bai7_tr36_Load(object sender, EventArgs e)
        {
            cbbLop.Items.Add("Cao đẳng 17");
            cbbLop.Items.Add("Cao đẳng 18");
            cbbLop.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để cập nhật", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (lstvDSL.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvDSL.SelectedItems[0];
                item.Text = txtHoTen.Text;
                item.SubItems[1].Text = nuLTGB.Value.ToString();
                item.SubItems[2].Text = nuMMT.Value.ToString();
                item.SubItems[3].Text = nuSQL.Value.ToString();
            }
            else
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lstvDSL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDSL.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvDSL.SelectedItems[0];
                txtHoTen.Text = item.Text;
                nuLTGB.Value = Convert.ToInt32(item.SubItems[1].Text);
                nuMMT.Value = Convert.ToInt32(item.SubItems[2].Text);
                nuSQL.Value = Convert.ToInt32(item.SubItems[3].Text);

                string tenSV = item.Text;
                int ltgb = Convert.ToInt32(nuLTGB.Value.ToString());
                int mmt = Convert.ToInt32(nuMMT.Value.ToString());
                int sql = Convert.ToInt32(nuSQL.Value.ToString());
                double dtb = (ltgb + mmt + sql) / 3.0;
                lblSVTB.Text = $"{tenSV} là: {dtb:F2}";
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(nuLTGB.Value.ToString());
            item.SubItems.Add(nuMMT.Value.ToString());
            item.SubItems.Add(nuSQL.Value.ToString());
            lstvDSL.Items.Add(item);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
