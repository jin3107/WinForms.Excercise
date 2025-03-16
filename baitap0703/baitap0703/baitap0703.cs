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

namespace baitap0703
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbDSKH.Items.Clear();
            lblBac1KW.Text = "";
            lblBac2KW.Text = "";
            lblBac3KW.Text = "";
            lblTT.Text = "";
        }

        private void btTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTenKH.Text) || string.IsNullOrWhiteSpace(txtSoDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nuChiSoMoi.Value <= nuChiSoCu.Value)
            {
                MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal chiSoMoi = nuChiSoMoi.Value;
            decimal chiSoCu = nuChiSoCu.Value;
            decimal soKW = chiSoMoi - chiSoCu;
            nuSoKW.Value = soKW;

            if (soKW == 0)
            {
                MessageBox.Show("Số kWh tiêu thụ phải lớn hơn 0.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cbBac1.Checked = false;
            cbBac2.Checked = false;
            cbBac3.Checked = false;
            decimal bac1 = 0, bac2 = 0, bac3 = 0;
            decimal tongTien = 0;
            if (soKW <= 50)
                bac1 = soKW * 1500;
            else
            {
                bac1 = 50 * 1500;
                cbBac1.Checked = true;
            }
            if (soKW > 50)
            {
                if (soKW <= 100)
                    bac2 = (soKW - 50) * 2000;
                else
                    bac2 = 50 * 2000;
                cbBac2.Checked = true;
            }
            if (soKW > 100)
            {
                bac3 = (soKW - 100) * 3000;
                cbBac3.Checked = true;
            }

            tongTien = bac1 + bac2 + bac3;
            CultureInfo culture = new CultureInfo("en-US");
            lblBac1KW.Text = bac1.ToString("N0", culture);
            lblBac2KW.Text = bac2.ToString("N0", culture);
            lblBac3KW.Text = bac3.ToString("N0", culture);
            lblTT.Text = tongTien.ToString("N0", culture);
        }

        private void btKHM_Click(object sender, EventArgs e)
        {
            lbDSKH.Items.Add($"Họ tên: {txtHoTenKH.Text}");
            lbDSKH.Items.Add($"Số điện thoại: {txtSoDT.Text}");
            lbDSKH.Items.Add($"Chỉ số điện tiêu thụ: {nuSoKW.Value}");
            lbDSKH.Items.Add($"Tổng tiền phải trả: {lblTT.Text} VNĐ");
            lbDSKH.Items.Add("");

            txtHoTenKH.Clear();
            txtSoDT.Clear();
            nuChiSoCu.Value = 0;
            nuChiSoMoi.Value = 0;
            nuSoKW.Value = 0;
            lblBac1KW.Text = "0";
            lblBac2KW.Text = "0";
            lblBac3KW.Text = "0";
            lblTT.Text = "0";
            cbBac1.Checked = false;
            cbBac2.Checked = false;
            cbBac3.Checked = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
