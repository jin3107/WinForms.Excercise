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
            int soKm = Convert.ToInt32(txtSoKm.Text);
            if (soKm <= 1)
            {
                double tien = 20000;
                lblMuc1.Visible = true;
                lblMuc1.Text = "Số tiền Mức 1 là: " + tien.ToString("N0", culture);
                lblTongTien.Text = "Số km Tổng tiền phải trả là: " + tien.ToString("#,###", culture);

                lblMuc2.Visible = false;
                lblMuc3.Visible = false;
                lblMuc4.Visible = false;
            }
            if (soKm >= 2 && soKm <= 12)
            {
                double tien = 20000;
                lblMuc1.Visible = true;
                lblMuc1.Text = "Số tiền Mức 1 là: " + tien.ToString("N0", culture);
                if (soKm - 12 > 0)
                {
                    lblMuc2.Visible = true;
                    lblMuc2.Text = "Số tiền Mức 2 là: " + ((soKm - 12) * 16000).ToString("N0", culture);
                    lblTongTien.Text = "Số km Tổng tiền phải trả là: " + (tien + ((soKm - 12) * 16000)).ToString("N0", culture);
                }
                else
                {
                    lblMuc2.Visible = true;
                    lblMuc2.Text = "Số tiền Mức 2 là: " + (soKm * 16000).ToString("N0", culture);
                    lblTongTien.Text = "Số km Tổng tiền phải trả là: " + (tien + (soKm * 16000)).ToString("N0", culture);
                }
                lblMuc3.Visible = false;
                lblMuc4.Visible = false;
            }
            if (soKm >= 13 && soKm <= 25)
            {
                double tien = 20000;
                lblMuc1.Visible = true;
                lblMuc1.Text = "Số tiền Mức 1 là: " + tien.ToString("N0", culture);
                lblMuc2.Visible = true;
                lblMuc2.Text = "Số tiền Mức 2 là: " + (11 * 16000).ToString("N0", culture);
                lblMuc3.Visible = true;
                lblMuc3.Text = "Số tiền Mức 3 là: " + ((soKm - 12) * 15500).ToString("N0", culture);
                lblTongTien.Text = "Số km Tổng tiền phải trả là: " + (tien + (11 * 16000) + ((soKm - 12) * 15500)).ToString("N0", culture);
                lblMuc4.Visible = false;
            }
            if (soKm >= 26)
            {
                double tien = 20000;
                lblMuc1.Visible = true;
                lblMuc1.Text = "Số tiền Mức 1 là: " + tien.ToString("N0", culture);
                lblMuc2.Visible = true;
                lblMuc2.Text = "Số tiền Mức 2 là: " + (11 * 16000).ToString("N0", culture);
                lblMuc3.Visible = true;
                lblMuc3.Text = "Số tiền Mức 3 là: " + (11 * 15500).ToString("N0", culture);
                lblMuc4.Visible = true;
                lblMuc4.Text = "Số tiền Mức 4 là: " + ((soKm - 26) * 13500).ToString("N0", culture);
                lblTongTien.Text = "Số km Tổng tiền phải trả là: " + (tien + (11 * 16000) + (11 * 15500) + ((soKm - 26) * 13500)).ToString("N0", culture);
            }
        }

    }
}
