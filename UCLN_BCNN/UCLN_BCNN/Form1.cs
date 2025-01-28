using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCLN_BCNN
{
    public partial class frmUCLNBCNN : Form
    {
        public frmUCLNBCNN()
        {
            InitializeComponent();
        }

        private void frmUCLNBCNN_Load(object sender, EventArgs e)
        {
            KetQuaTextBox.ReadOnly = true;
        }

        private void NhapGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void UCLNRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BCNNRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SoThuNhatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoThuHaiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KetQuaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SoThuNhatTextBox.Text) || string.IsNullOrWhiteSpace(SoThuHaiTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất và số thứ hai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soThuNhat = int.Parse(SoThuNhatTextBox.Text);
            int soThuHai = int.Parse(SoThuHaiTextBox.Text);
            int ketQua = 0;
            if (UCLNRadioButton.Checked)
            {
                ketQua = TimUCLN(soThuNhat, soThuHai);
            }
            else if (BCNNRadioButton.Checked)
            {
                ketQua = TimBCNN(soThuNhat, soThuHai);
            }
            KetQuaTextBox.Text = ketQua.ToString();
        }

        private void BoQuaButton_Click(object sender, EventArgs e)
        {
            SoThuNhatTextBox.Clear();
            SoThuHaiTextBox.Clear();
            KetQuaTextBox.Clear();
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int TimUCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int TimBCNN(int a, int b)
        {
            return (a * b) / TimUCLN(a, b);
        }
    }
}
