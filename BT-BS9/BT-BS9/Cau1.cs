using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BS9
{
    public partial class Cau1 : Form
    {
        private int cotton = 150, jean = 180, kaki = 200, cucAo = 200, chiMay = 220, dayThun = 250, dayKeo20 = 240, dayKeo60 = 230;

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            foreach (ListViewItem item in lstvDSTK.Items)
            {
                tongTien += int.Parse(item.SubItems[5].Text);
            }
            double giamGia = 0;
            if (tongTien > 10000)
            {
                giamGia = tongTien * 0.05;
            }
            else if (tongTien >= 5000)
            {
                giamGia = tongTien * 0.03;
            }
            double tienPhaiTra = tongTien - giamGia;
            txtTongTien.Text = tongTien.ToString("N0");
            txtGiamGia.Text = giamGia.ToString("N0");
            txtTienPhaiTra.Text = tienPhaiTra.ToString("N0");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sanPham = lstbDMSP.SelectedItem.ToString();
            int donGia = GiaSanPham(sanPham);
            int soLuong = (int)numSoLuong.Value;
            int thanhTien = soLuong * donGia;
            ListViewItem item = new ListViewItem((lstvDSTK.Items.Count + 1).ToString());
            item.SubItems.Add(cbbPhanXuong.Text + "/" + cbbChuyen.Text);
            item.SubItems.Add(sanPham);
            item.SubItems.Add(soLuong.ToString());
            item.SubItems.Add(donGia.ToString());
            item.SubItems.Add(thanhTien.ToString());
            lstvDSTK.Items.Add(item);
        }

        private int GiaSanPham(string sanPham)
        {
            if (sanPham == "Vải cotton")
                return cotton;
            else if (sanPham == "Vải jean")
                return jean;
            else if (sanPham == "Vải kaki")
                return kaki;
            else if (sanPham == "Cúc áo")
                return cucAo;
            else if (sanPham == "Chỉ may")
                return chiMay;
            else if (sanPham == "Dây thun")
                return dayThun;
            else if (sanPham == "Dây kéo 20cm")
                return dayKeo20;
            else if (sanPham == "Dây kéo 60cm")
                return dayKeo60;
            return 0;
        }

        public Cau1()
        {
            InitializeComponent();
        }

        private void Cau1_Load(object sender, EventArgs e)
        {
            HienThiListBox();
            HienThiComboboxPhanXuong();
            HienThiComboboxChuyen();
        }

        private void HienThiComboboxChuyen()
        {
            cbbChuyen.Items.Clear();
            cbbChuyen.Items.Add("1");
            cbbChuyen.Items.Add("2");
            cbbChuyen.Items.Add("3");
            cbbChuyen.Items.Add("4");
        }

        private void HienThiComboboxPhanXuong()
        {
            cbbPhanXuong.Items.Clear();
            cbbPhanXuong.Items.Add("A");
            cbbPhanXuong.Items.Add("B");
            cbbPhanXuong.Items.Add("C");
            cbbPhanXuong.Items.Add("D");
            cbbPhanXuong.Items.Add("E");
            cbbPhanXuong.Items.Add("F");
        }

        private void HienThiListBox()
        {
            lstbDMSP.Items.Clear();
            lstbDMSP.Items.Add("Vải cotton");
            lstbDMSP.Items.Add("Vải jean");
            lstbDMSP.Items.Add("Vải kaki");
            lstbDMSP.Items.Add("Cúc áo");
            lstbDMSP.Items.Add("Chỉ may");
            lstbDMSP.Items.Add("Dây thun");
            lstbDMSP.Items.Add("Dây kéo 20cm");
            lstbDMSP.Items.Add("Dây kéo 60cm");
        }
    }
}
