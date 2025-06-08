using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || numToan.Value == -1 || numNguVan.Value == -1 || numNgoaiNgu.Value == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HienThiListView();
        }

        private void HienThiListView()
        {
            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(numToan.Value.ToString());
            item.SubItems.Add(numNguVan.Value.ToString());
            item.SubItems.Add(numNgoaiNgu.Value.ToString());

            decimal diemTB = (numToan.Value + numNguVan.Value + numNgoaiNgu.Value) / 3;
            item.SubItems.Add(Math.Round(diemTB, 2).ToString());

            if (diemTB >= 9)
                item.SubItems.Add("Xuất sắc");
            if (diemTB >= 8)
                item.SubItems.Add("Giỏi");
            if (diemTB >= 7)
                item.SubItems.Add("Khá");
            if (diemTB >= 5)
                item.SubItems.Add("Trung bình");
            if (diemTB < 5)
                item.SubItems.Add("Yếu");

            lstvDSHS.Items.Add(item);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int xuatSac = 0, gioi = 0, kha = 0, trungBinh = 0, yeu = 0;
            foreach (ListViewItem item in lstvDSHS.Items)
            {
                string xepLoai = item.SubItems[5].Text;
                switch (xepLoai)
                {
                    case "Xuất sắc":
                        xuatSac++;
                        break;
                    case "Giỏi":
                        gioi++;
                        break;
                    case "Khá":
                        kha++;
                        break;
                    case "Trung bình":
                        trungBinh++;
                        break;
                    case "Yếu":
                        yeu++;
                        break;
                }
            }
            lblXuatSac.Text = $"Tổng số học sinh xếp loại Xuất sắc là: {xuatSac}";
            lblGioi.Text = $"Tổng số học sinh xếp loại Giỏi là: {gioi}";
            lblKha.Text = $"Tổng số học sinh xếp loại Khá là: {kha}";
            lblTrungBinh.Text = $"Tổng số học sinh Trung bình là: {trungBinh}";
            lblYeu.Text = $"Tổng số học sinh xếp loại Yếu là: {yeu}";
        }
    }
}
