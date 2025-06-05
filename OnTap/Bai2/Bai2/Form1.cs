using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            CultureInfo info = new CultureInfo("en-US");
            int tongTien = 0;
            foreach (ListViewItem item in lstvDS.Items)
                tongTien += int.Parse(item.SubItems[5].Text, NumberStyles.AllowThousands, info);
            double giamGia = 0;
            if (tongTien > 10000)
                giamGia = tongTien * 0.08;
            else if (tongTien >= 5000)
                giamGia = tongTien * 0.05;
            double tienPT = tongTien - giamGia;
            txtTongTien.Text = tongTien.ToString("N0", info);
            txtGiamGia.Text = giamGia.ToString("N0", info);
            txtTienPT.Text = tienPT.ToString("N0", info);

            GhiFile();
        }

        private void GhiFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    CultureInfo info = new CultureInfo("en-US");

                    writer.WriteLine("DANH SÁCH SÁCH GIÁO KHOA\n");
                    writer.WriteLine("{0,-5} {1,-15} {2,-8} {3,10} {4,10} {5,15}",
                                     "STT", "Tên Sách", "Lớp", "Số Lượng", "Đơn Giá", "Thành Tiền");
                    writer.WriteLine(new string('-', 70)); // gạch ngang

                    foreach (ListViewItem item in lstvDS.Items)
                    {
                        writer.WriteLine("{0,-5} {1,-15} {2,-8} {3,10} {4,10} {5,15}",
                            item.SubItems[0].Text,
                            item.SubItems[1].Text,
                            item.SubItems[2].Text,
                            item.SubItems[3].Text,
                            item.SubItems[4].Text,
                            item.SubItems[5].Text);
                    }

                    writer.WriteLine(new string('-', 70));
                    writer.WriteLine($"Tổng tiền: {txtTongTien.Text}");
                    writer.WriteLine($"Giảm giá: {txtGiamGia.Text}");
                    writer.WriteLine($"Thành tiền: {txtTienPT.Text}");

                }
                MessageBox.Show("Đã ghi file thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbDMS.Items.Clear();
            clbDMS.Items.Add("Cánh diều_SGK_Toán");
            clbDMS.Items.Add("Cánh diều_SGK_KHTN");
            clbDMS.Items.Add("Cánh diều_SGK_Ngữ Văn");
            clbDMS.Items.Add("Cánh diều_SGK_Địa Lý");
            clbDMS.Items.Add("Cánh diều_SGK_Lịch Sử");
            clbDMS.Items.Add("Cánh diều_SGK_Công Nghệ");
            clbDMS.Items.Add("Cánh diều_SGK_Tin Học");
            clbDMS.Items.Add("Cánh diều_SGK_English");

            cbbKhoi.Items.Clear();
            cbbKhoi.Items.Add("Khối 6");
            cbbKhoi.Items.Add("Khối 7");
            cbbKhoi.Items.Add("Khối 8");
            cbbKhoi.Items.Add("Khối 9");

            cbbLop.Items.Clear();
            cbbLop.Items.Add("Lớp 1");
            cbbLop.Items.Add("Lớp 2");
            cbbLop.Items.Add("Lớp 3");
            cbbLop.Items.Add("Lớp 4");
            cbbLop.Items.Add("Lớp 5");
            cbbLop.Items.Add("Lớp 6");
            cbbLop.Items.Add("Lớp 7");
            cbbLop.Items.Add("Lớp 8");
            cbbLop.Items.Add("Lớp 9");
            cbbLop.Items.Add("Lớp 10");
            cbbLop.Items.Add("Lớp 11");
            cbbLop.Items.Add("Lớp 12");
            cbbLop.Items.Add("Lớp 13");
            cbbLop.Items.Add("Lớp 14");
            cbbLop.Items.Add("Lớp 15");
            cbbLop.Items.Add("Lớp 16");
            cbbLop.Items.Add("Lớp 17");
            cbbLop.Items.Add("Lớp 18");
            cbbLop.Items.Add("Lớp 19");
            cbbLop.Items.Add("Lớp 20");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sach = clbDMS.SelectedItem.ToString();
            string ten = LayTen(sach);
            int dg = DonGia(ten);
            int sl = Convert.ToInt32(numSL.Value);
            int thanhTien = dg * sl;

            CultureInfo info = new CultureInfo("en-US");
            ListViewItem item = new ListViewItem((lstvDS.Items.Count + 1).ToString());
            item.SubItems.Add(ten);
            item.SubItems.Add(cbbKhoi.Text.Substring(5) + "/" + cbbLop.Text.Substring(4));
            item.SubItems.Add(sl.ToString());
            item.SubItems.Add(dg.ToString());
            item.SubItems.Add(thanhTien.ToString("N0", info));
            lstvDS.Items.Add(item);
        }

        private int DonGia(string ten)
        {
            switch(ten)
            {
                case "Toán": return 280;
                case "KHTN": return 257;
                case "Ngữ Văn":return 300;
                case "Địa Lý": return 310;
                case "Lịch Sử": return 320;
                case "Công Nghệ":return 340;
                case "Tin Học": return 330;
                case "English": return 360;
                default: return 0;
            }
        }

        private string LayTen(string sach)
        {
            string tenSach = sach.Substring(14);
            return tenSach;
        }
    }
}
