using System;
using System.Drawing.Drawing2D;

namespace DenGiaoThong
{
    public partial class DenGiaoThongForm : Form
    {
        private int tgDenXanh, tgDenVang, tgDenDo, tgHienTai;
        private string denHienTai;
        private System.Windows.Forms.Timer timer;

        public DenGiaoThongForm()
        {
            InitializeComponent();
            HinhTron(pictureBoxXanh);
            HinhTron(pictureBoxDo);
            HinhTron(pictureBoxVang);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += OnTimedEvent!;
        }

        private void buttonHienThi_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTgXanh.Text, out tgDenXanh) ||
                !int.TryParse(textBoxTgDo.Text, out tgDenDo))
            {
                MessageBox.Show("Thời gian không hợp lệ. Vui lòng nhập lại", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            tgDenVang = 5;
            BatDauDoiMauDen();
        }

        private void BatDauDoiMauDen()
        {
            denHienTai = "Xanh";
            tgHienTai = tgDenXanh;
            labelTG.ForeColor = Color.Green;
            CapNhatMauDen();
            labelTG.Text = tgHienTai.ToString();
            timer.Start();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBoxDen_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxXanh_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxVang_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxDo_Click(object sender, EventArgs e)
        {
            
        }

        private void HinhTron(PictureBox pictureBox)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
            pictureBox.Region = new Region(gp);
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            if (tgHienTai > 0)
            {
                tgHienTai--;
            }
            else
            {
                DoiMauDen();
            }
            labelTG.Text = tgHienTai.ToString();
        }

        private void DoiMauDen()
        {
            switch (denHienTai)
            {
                case "Xanh":
                    denHienTai = "Vang";
                    tgHienTai = tgDenVang;
                    labelTG.ForeColor = Color.Yellow;
                    break;
                case "Vang":
                    denHienTai = "Do";
                    tgHienTai = tgDenDo;
                    labelTG.ForeColor = Color.Red;
                    break;
                case "Do":
                    denHienTai = "Xanh";
                    tgHienTai = tgDenXanh;
                    labelTG.ForeColor = Color.Green;
                    break;
            }
            CapNhatMauDen();
            labelTG.Text = tgHienTai.ToString();
        }

        private void CapNhatMauDen()
        {
            pictureBoxXanh.Visible = (denHienTai == "Xanh");
            pictureBoxVang.Visible = (denHienTai == "Vang");
            pictureBoxDo.Visible = (denHienTai == "Do");
        }

        private void DenGiaoThongForm_Load(object sender, EventArgs e)
        {

        }

        private void labelTG_Click(object sender, EventArgs e)
        {

        }
    }
}
