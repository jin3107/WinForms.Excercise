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

namespace BT_BS2
{
    public partial class Taxi : Form
    {
        public Taxi()
        {
            InitializeComponent();
        }

        private void Taxi_Load(object sender, EventArgs e)
        {
            lblMuc1.Visible = false;
            lblMuc2.Visible = false;
            lblMuc3.Visible = false;    
            lblMuc4.Visible = false;
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoKm.Text))
            {
                MessageBox.Show("Vui lòng nhập số km", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TinhTienTheoMuc();
        }

        private void TinhTienTheoMuc()
        {
            CultureInfo culture = new CultureInfo("en-US");
            double soKm = Convert.ToDouble(txtSoKm.Text);
            double tien1 = 0, tien2 = 0, tien3 = 0, tien4 = 0, tongTien = 0;
            lblMuc1.Visible = false;
            lblMuc2.Visible = false;
            lblMuc3.Visible = false;
            lblMuc4.Visible = false;
            if (soKm > 0)
            {
                tien1 = 20000;
                lblMuc1.Visible = true;
                lblMuc1.Text = "Số tiền Mức 1 là: " + tien1.ToString("N0", culture);
            }
            if (soKm > 1)
            {
                double kmTier2 = Math.Min(soKm - 1, 11);
                tien2 = kmTier2 * 16000;
                lblMuc2.Visible = true;
                lblMuc2.Text = "Số tiền Mức 2 là: " + tien2.ToString("N0", culture);
            }
            if (soKm > 12)
            {
                double kmTier3 = Math.Min(soKm - 12, 13);
                tien3 = kmTier3 * 15500;
                lblMuc3.Visible = true;
                lblMuc3.Text = "Số tiền Mức 3 là: " + tien3.ToString("N0", culture);
            }
            if (soKm > 25)
            {
                double kmTier4 = soKm - 25;
                tien4 = kmTier4 * 13500;
                lblMuc4.Visible = true;
                lblMuc4.Text = "Số tiền Mức 4 là: " + tien4.ToString("N0", culture);
            }
            tongTien = tien1 + tien2 + tien3 + tien4;
            lblTongTien.Text = "Số km Tổng tiền phải trả là: " + tongTien.ToString("N0", culture);
        }
    }
}
