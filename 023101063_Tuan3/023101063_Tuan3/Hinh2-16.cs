using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023101063_Tuan3
{
    public partial class Hinh2_16 : Form
    {
        public Hinh2_16()
        {
            InitializeComponent();
        }

        private void checkBoxInDam_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMauChu.Font = new Font(textBoxMauChu.Font, textBoxMauChu.Font.Style ^ FontStyle.Bold);
        }

        private void checkBoxInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMauChu.Font = new Font(textBoxMauChu.Font, textBoxMauChu.Font.Style ^ FontStyle.Italic);
        }

        private void checkBoxGachChan_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxMauChu.Font = new Font(textBoxMauChu.Font, textBoxMauChu.Font.Style ^ FontStyle.Underline);
        }

        private void radioButtonVNI_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMauChu.Font = new Font(radioButtonVNI.Text, textBoxMauChu.Font.Size, textBoxMauChu.Font.Style);
            textBoxMauChu.ForeColor = Color.Red;
        }

        private void radioButtonTNR_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMauChu.Font = new Font(radioButtonTNR.Text, textBoxMauChu.Font.Size, textBoxMauChu.Font.Style);
            textBoxMauChu.ForeColor = Color.Blue;
        }

        private void radioButtonArial_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMauChu.Font = new Font(radioButtonArial.Text, textBoxMauChu.Font.Size, textBoxMauChu.Font.Style);
            textBoxMauChu.ForeColor = Color.Green;
        }

        private void numericUpDownCoChu_ValueChanged(object sender, EventArgs e)
        {
            textBoxMauChu.Font = new Font(textBoxMauChu.Font.FontFamily, (float)numericUpDownCoChu.Value, textBoxMauChu.Font.Style);
        }
    }
}
