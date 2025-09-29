using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BS3
{
    public partial class VolumeOfPrism : Form
    {
        private ToaDoDiem A = new ToaDoDiem(), B = new ToaDoDiem(), C = new ToaDoDiem(), D = new ToaDoDiem();

        public VolumeOfPrism()
        {
            InitializeComponent();
        }

        private void btNhapDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtX_A.Text) || string.IsNullOrWhiteSpace(txtY_A.Text)
                || string.IsNullOrWhiteSpace(txtX_B.Text) || string.IsNullOrWhiteSpace(txtY_B.Text)
                || string.IsNullOrWhiteSpace(txtX_C.Text) || string.IsNullOrWhiteSpace(txtY_C.Text)
                || string.IsNullOrWhiteSpace(txtX_D.Text) || string.IsNullOrWhiteSpace(txtY_D.Text) || string.IsNullOrWhiteSpace(txtChieuCaoLT.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhapDiem();
        }

        private void NhapDiem()
        {
            double xA = double.Parse(txtX_A.Text);
            double yA = double.Parse(txtY_A.Text);
            double xB = double.Parse(txtX_B.Text);
            double yB = double.Parse(txtY_B.Text);
            double xC = double.Parse(txtX_C.Text);
            double yC = double.Parse(txtY_C.Text);
            double xD = double.Parse(txtX_D.Text);
            double yD = double.Parse(txtY_D.Text);
            double chieuCao = double.Parse(txtChieuCaoLT.Text);

            A = new ToaDoDiem(xA, xB);
            B = new ToaDoDiem(xB, yB);
            C = new ToaDoDiem(xC, yC);
            D = new ToaDoDiem(xD, yD);

            double dienTichTamGiac = DienTichHinhTamGiacABC(A, B, C) + DienTichHinhTamGiacACD(A, C, D);
            double theTich = dienTichTamGiac * chieuCao;
            lblTT.Text = "Thể tích của lăng trụ là:          " + theTich.ToString();
        }

        private void btDoDaiDoan_Click(object sender, EventArgs e)
        {
            lblDoDaiAB.Text = "Độ dài đoạn AB:          " + DoanThang(A, B).ToString("0.00");
            lblDoDaiBC.Text = "Độ dài đoạn BC:          " + DoanThang(B, C).ToString("0.00");
            lblDoDaiAC.Text = "Độ dài đoạn AC:          " + DoanThang(A, C).ToString("0.00");
        }

        private double DoanThang(ToaDoDiem a, ToaDoDiem b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        private double DienTichHinhTamGiacACD(ToaDoDiem a, ToaDoDiem c, ToaDoDiem d)
        {
            double kq = 0;
            double AC, CD, AD, p;

            AC = DoanThang(a, c);
            CD = DoanThang(c, d);
            AD = DoanThang(a, d);
            p = (AC + CD + AD) / 2;
            kq = Math.Sqrt(p * (p - AC) * (p - CD) * (p - AD));
            return kq;
        }

        private double DienTichHinhTamGiacABC(ToaDoDiem a, ToaDoDiem b, ToaDoDiem c)
        {
            double kq = 0;
            double AB, BC, AC, p;

            AB = DoanThang(a, b);
            BC = DoanThang(b, c);
            AC = DoanThang(a, c);
            p = (AB + BC + AC) / 2;
            kq = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            return kq;
        }
    }
}
