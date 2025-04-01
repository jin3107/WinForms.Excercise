using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BS5
{
    public partial class BT_BS5 : Form
    {
        public BT_BS5()
        {
            InitializeComponent();
        }

        private void BT_BS5_Load(object sender, EventArgs e)
        {
            tvPhanLoai.Nodes.Clear();
            tvPhanLoai.Nodes.Add("Dầu gội");
            tvPhanLoai.Nodes[0].Nodes.Add("Header & Shoulder");
            tvPhanLoai.Nodes[0].Nodes.Add("Panteen");
            tvPhanLoai.Nodes[0].Nodes.Add("Clear");
            tvPhanLoai.Nodes[0].Nodes.Add("Sunsilk");

            tvPhanLoai.Nodes.Add("Dầu xả");
            tvPhanLoai.Nodes[1].Nodes.Add("Panteen");
            tvPhanLoai.Nodes[1].Nodes.Add("TRESemmé");
            tvPhanLoai.Nodes[1].Nodes.Add("L'Oréal Paris Elseve");
            tvPhanLoai.Nodes[1].Nodes.Add("Dove");

            tvPhanLoai.Nodes.Add("Sữa tắm");
            tvPhanLoai.Nodes[2].Nodes.Add("Life boy");
            tvPhanLoai.Nodes[2].Nodes.Add("Lux");
            tvPhanLoai.Nodes[2].Nodes.Add("Palmolive");
            tvPhanLoai.Nodes[2].Nodes.Add("Dove");
        }

        private void tvPhanLoai_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedItems = tvPhanLoai.SelectedNode.Text;
            if (selectedItems == "Dầu gội")
            {
                lbSanPham.Items.Clear();
                lbSanPham.Items.Add("Header & Shoulder");
                lbSanPham.Items.Add("Panteen");
                lbSanPham.Items.Add("Clear");
                lbSanPham.Items.Add("Sunsilk");
            }
            if (selectedItems == "Dầu xả")
            {
                lbSanPham.Items.Clear();
                lbSanPham.Items.Add("Panteen");
                lbSanPham.Items.Add("TRESemmé");
                lbSanPham.Items.Add("L'Oréal Paris Elseve");
                lbSanPham.Items.Add("Dove");

            }
            if (selectedItems == "Sữa tắm")
            {
                lbSanPham.Items.Clear();
                lbSanPham.Items.Add("Life boy");
                lbSanPham.Items.Add("Lux");
                lbSanPham.Items.Add("Palmolive");
                lbSanPham.Items.Add("Dove");
            }
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            int selectedItems = lbSanPham.SelectedItems.Count;
            if (selectedItems > 0)
            {
                foreach (var item in lbSanPham.SelectedItems)
                {
                    var tenSanPham = item.ToString();
                    var loaiSanPham = tvPhanLoai.SelectedNode.Text;
                    bool tonTai = false;
                    foreach (ListViewItem sanPhamTonTai in lvDonHang.Items)
                    {
                        var tenSanPhamTonTai = sanPhamTonTai.SubItems[1].Text;
                        var loaiSanPhamTonTai = sanPhamTonTai.SubItems[3].Text;
                        if (tenSanPham == tenSanPhamTonTai && loaiSanPham == loaiSanPhamTonTai)
                        {
                            int soLuong = int.Parse(sanPhamTonTai.SubItems[2].Text);
                            sanPhamTonTai.SubItems[2].Text = (soLuong + 1).ToString();
                            tonTai = true;
                            break;
                        }
                    }

                    if (!tonTai)
                    {
                        int stt = lvDonHang.Items.Count + 1;
                        ListViewItem newItem = new ListViewItem(stt.ToString());
                        newItem.SubItems.Add(tenSanPham);
                        newItem.SubItems.Add("1");
                        newItem.SubItems.Add(loaiSanPham);
                        lvDonHang.Items.Add(newItem);
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn ít nhất 1 loại và ít nhất 1 sản phẩm.", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int selectedItems = lvDonHang.SelectedItems.Count;
            List<ListViewItem> sanPhamCanXoa = new List<ListViewItem>();
            if (selectedItems > 0)
            {
                foreach (ListViewItem item in lvDonHang.SelectedItems)
                {
                    int soLuong = int.Parse(item.SubItems[2].Text);
                    soLuong -= 1;
                    item.SubItems[2].Text = soLuong.ToString();
                    if (soLuong == 0)
                        sanPhamCanXoa.Add(item);
                }
                foreach (var item in sanPhamCanXoa)
                {
                    lvDonHang.Items.Remove(item);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn ít nhất 1 loại và ít nhất 1 sản phẩm.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            // Cách 1 theo đề
            //int tongSoLuongSanPham = 0, tongSoLoai = 0;
            //List<ListViewItem> loai = new List<ListViewItem>();
            //foreach (ListViewItem item in lvDonHang.Items)
            //{
            //    int soLuong = int.Parse(item.SubItems[2].Text);
            //    tongSoLuongSanPham += soLuong;

            //    loai.Add(item);
            //    tongSoLoai = loai.Count;
            //}

            // Cách 2 đáp án chuẩn
            int tongSoLuongSanPham = 0;
            string loaiSanPham = tvPhanLoai.SelectedNode.Text;
            List<string> dsLoai = new List<string>();
            foreach (ListViewItem item in lvDonHang.Items)
            {
                tongSoLuongSanPham += int.Parse(item.SubItems[2].Text);
                dsLoai.Add(item.SubItems[3].Text);
            }
            lblTSLuong.Text = "Tổng số lượng: " + tongSoLuongSanPham.ToString();
            lblTSLoai.Text = "Tổng số loại: " + dsLoai.Distinct().Count();
        }
    }
}
