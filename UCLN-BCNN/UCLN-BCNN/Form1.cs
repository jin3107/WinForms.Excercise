namespace UCLN_BCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxKetQua.ReadOnly = true;
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSoThuNhat.Text) || string.IsNullOrWhiteSpace(textBoxSoThuHai.Text))
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất và số thứ hai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soThuNhat = int.Parse(textBoxSoThuNhat.Text);
            int soThuHai = int.Parse(textBoxSoThuHai.Text);
            int ketQua = 0;
            if (radioButtonUCLN.Checked)
                ketQua = UCLN(soThuNhat, soThuHai);
            else if (radioButtonBCNN.Checked)
                ketQua = BCNN(soThuNhat, soThuHai);
            textBoxKetQua.Text = ketQua.ToString();
        }

        private void buttonBoQua_Click(object sender, EventArgs e)
        {
            textBoxSoThuNhat.Clear();
            textBoxSoThuHai.Clear();
            textBoxKetQua.Clear();
            if (radioButtonBCNN.Checked || radioButtonUCLN.Checked)
            {
                radioButtonBCNN.Checked = false;
                radioButtonUCLN.Checked = false;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
    }
}
