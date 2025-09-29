using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if ((txtHoTen.Text == "") || (txtSDT.Text == ""))
            {
                MessageBox.Show("vui long nhap du thong tin");
                return;
            }
            if (numCSM.Value <= numCSC.Value)
            {
                MessageBox.Show("chi so moi phai lon hon chi so cu");
                return;
            }

            decimal chiSoMoi = numCSM.Value;
            decimal chiSoCu = numCSC.Value;
            decimal soKW = chiSoMoi - chiSoCu;
            if (soKW <= 50)
            {
                cbBac1.Checked = true;
                lblTB1.Text = (numSoKW.Value * 1500).ToString("#,##0");
                lblTongTien.Text = lblTB1.Text;
            }
            else if (soKW > 50 && soKW <= 100)
            {
                cbBac1.Checked = cbBac2.Checked = true;
                lblTB1.Text = (50 * 1500).ToString("#,##0");
                lblTB2.Text = ((soKW - 50) * 2000).ToString("#,##0");
                lblTongTien.Text = (decimal.Parse(lblTB1.Text) + decimal.Parse(lblTB2.Text)).ToString("#,##0");
            }
            else if (soKW > 100 && soKW <= 200)
            {
                cbBac1.Checked = cbBac2.Checked = cbBac3.Checked = true;
                lblTB1.Text = (50 * 1500).ToString("#,##0");
                lblTB2.Text = (50 * 2000).ToString("#,##0");
                lblTB3.Text = ((soKW - 100) * 3000).ToString("#,##0");
                lblTongTien.Text = (decimal.Parse(lblTB1.Text) + decimal.Parse(lblTB2.Text) + decimal.Parse(lblTB3.Text)).ToString("#,##0");
            }
            else if (soKW > 200 && soKW <= 300)
            {
                cbBac1.Checked = cbBac2.Checked = cbBac3.Checked = cbBac4.Checked = true;
                lblTB1.Text = (50 * 1500).ToString("#,##0");
                lblTB2.Text = (50 * 2000).ToString("#,##0");
                lblTB3.Text = (100 * 3000).ToString("#,##0");
                lblTB4.Text = ((soKW - 150) * 2536).ToString("#,##0");
                lblTongTien.Text = (decimal.Parse(lblTB1.Text) + decimal.Parse(lblTB2.Text) + decimal.Parse(lblTB3.Text) + decimal.Parse(lblTB4.Text)).ToString("#,##0");
            }
            else if (soKW > 300 && soKW <= 400)
            {
                cbBac1.Checked = cbBac2.Checked = cbBac3.Checked = cbBac4.Checked = cbBac5.Checked = true;
                lblTB1.Text = (50 * 1500).ToString("#,##0");
                lblTB2.Text = (50 * 2000).ToString("#,##0");
                lblTB3.Text = (100 * 3000).ToString("#,##0");
                lblTB4.Text = (200 * 2536).ToString("#,##0");
                lblTB5.Text = ((soKW - 400) * 2834).ToString("#,##0");
                lblTongTien.Text = (decimal.Parse(lblTB1.Text) + decimal.Parse(lblTB2.Text) + decimal.Parse(lblTB3.Text) + decimal.Parse(lblTB4.Text) + decimal.Parse(lblTB5.Text)).ToString("#,##0");
            }
            else
            {
                cbBac1.Checked = cbBac2.Checked = cbBac3.Checked = cbBac4.Checked = cbBac5.Checked = cbBac6.Checked = true;
                lblTB1.Text = (50 * 1500).ToString("#,##0");
                lblTB2.Text = (50 * 2000).ToString("#,##0");
                lblTB3.Text = (100 * 3000).ToString("#,##0");
                lblTB4.Text = (200 * 2536).ToString("#,##0");
                lblTB5.Text = (300 * 2834).ToString("#,##0");
                lblTB6.Text = ((soKW - 700) * 2927).ToString("#,##0");
                lblTongTien.Text = (decimal.Parse(lblTB1.Text) + decimal.Parse(lblTB2.Text) + decimal.Parse(lblTB3.Text) + decimal.Parse(lblTB4.Text) + decimal.Parse(lblTB5.Text) + decimal.Parse(lblTB6.Text)).ToString("#,##0");
            }
        }
    }
}
