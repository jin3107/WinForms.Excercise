using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BS1
{
    public partial class Traffic_lights : Form
    {
        private int tgXanh, tgDo, tgVang, tgHienTai;
        private string den;
        private Timer timerTG = new Timer();

        public Traffic_lights()
        {
            InitializeComponent();
            HinhTron(picXanh);
            HinhTron(picVang);
            HinhTron(picDo);
            timerTG.Interval = 1000;
            timerTG.Tick += OnTimedEvent;
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTGXanh.Text, out tgXanh) ||
                !int.TryParse(txtTGDo.Text, out tgDo))
            {
                MessageBox.Show("Thời gian không hợp lệ. Vui lòng nhập lại", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            tgVang = 5;
            BatDauDoiMauDen();
        }

        private void BatDauDoiMauDen()
        {
            den = "Xanh";
            tgHienTai = tgXanh;
            timerTG.Interval = 1000;
            lblTG.ForeColor = Color.Green;
            CapNhapDen();
            lblTG.Text = tgHienTai.ToString();
            timerTG.Start();
        }

        private void CapNhapDen()
        {
            picXanh.Visible = (den == "Xanh");
            picVang.Visible = (den == "Vang");
            picDo.Visible = (den == "Do");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoiMauDen()
        {
            switch (den)
            {
                case "Xanh":
                    den = "Vang";
                    tgHienTai = tgVang;
                    lblTG.ForeColor = Color.Yellow;
                    break;

                case "Vang":
                    den = "Do";
                    tgHienTai = tgDo;
                    lblTG.ForeColor = Color.Red;
                    break;

                case "Do":
                    den = "Xanh";
                    tgHienTai = tgXanh;
                    lblTG.ForeColor = Color.Green;
                    break;
            }
            CapNhapDen();
            lblTG.Text = tgHienTai.ToString();
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            if (tgHienTai > 1)
                tgHienTai--;
            else
                DoiMauDen();
            lblTG.Text = tgHienTai.ToString();
        }

        private void HinhTron(PictureBox pictureBox)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            pictureBox.Region = new Region(gp);
        }
    }
}
