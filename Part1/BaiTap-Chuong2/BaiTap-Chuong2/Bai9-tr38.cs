using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Chuong2
{
    public partial class Bai9_tr38: Form
    {
        public Bai9_tr38()
        {
            InitializeComponent();
        }

        private void Bai9_tr38_Load(object sender, EventArgs e)
        {
            cbbLoaiMonAn.Items.Add("Việt Nam");
            cbbLoaiMonAn.Items.Add("Hàn Quốc");
            cbbLoaiMonAn.Items.Add("Trung Quốc");
            cbbLoaiMonAn.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbbLoaiMonAn.SelectedItem.ToString();
            if (selectedItem == "Việt Nam")
            {
                clbChiTietMonAn.Items.Clear();
                clbChiTietMonAn.Items.Add("Gỏi cuốn");
                clbChiTietMonAn.Items.Add("Bánh lan");
                clbChiTietMonAn.Items.Add("Bún thịt nướng");
                clbChiTietMonAn.Items.Add("Gà hấp chao");
            }
            else if (selectedItem == "Hàn Quốc")
            {
                clbChiTietMonAn.Items.Clear();
                clbChiTietMonAn.Items.Add("Su si");
                clbChiTietMonAn.Items.Add("Canh rong biển");
                clbChiTietMonAn.Items.Add("Kim chi");
                clbChiTietMonAn.Items.Add("Cơm trộn");
            }
            else if (selectedItem == "Trung Quốc")
            {
                clbChiTietMonAn.Items.Clear();
                clbChiTietMonAn.Items.Add("Mì vịt tiềm");
                clbChiTietMonAn.Items.Add("Mì xào giòn");
                clbChiTietMonAn.Items.Add("Bánh canh vịt");
                clbChiTietMonAn.Items.Add("Hột vịt lộn");
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            if (nuSoLuong.Value == -1)
            {
                MessageBox.Show("Vui lòng chọn số lượng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbChiTietMonAn.CheckedItems.Count > 0)
            {
                foreach (var item in clbChiTietMonAn.CheckedItems)
                {
                    string monAn = item.ToString();
                    bool daTonTai = false;
                    foreach(ListViewItem lvItem in lstvCacMonAn.Items)
                    {
                        if (lvItem.Text == monAn)
                        {
                            int soLuongMoi = int.Parse(lvItem.SubItems[1].Text) + (int)nuSoLuong.Value;
                            lvItem.SubItems[1].Text = soLuongMoi.ToString();
                            daTonTai = true;
                            break;
                        }
                    }

                    if (!daTonTai)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.ToString());
                        listViewItem.SubItems.Add(nuSoLuong.Value.ToString());
                        lstvCacMonAn.Items.Add(listViewItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn it nhất 1 món ăn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btBoChon_Click(object sender, EventArgs e)
        {
            if (clbChiTietMonAn.CheckedItems.Count > 0)
            {
                List<ListViewItem> itemToRemove = new List<ListViewItem>();
                foreach (var item in clbChiTietMonAn.CheckedItems)
                {
                    string monAn = item.ToString();
                    foreach (ListViewItem lvItem in lstvCacMonAn.Items)
                    {
                        if (lvItem.Text == monAn)
                        {
                            int soLuongMoi = int.Parse(lvItem.SubItems[1].Text) - (int)nuSoLuong.Value;
                            if (soLuongMoi <= 0)
                                itemToRemove.Add(lvItem);
                            else
                                lvItem.SubItems[1].Text = soLuongMoi.ToString();
                            break;
                        }
                    }

                }
                foreach (ListViewItem item in itemToRemove)
                {
                    lstvCacMonAn.Items.Remove(item); 
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 món ăn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btTaoMoi_Click(object sender, EventArgs e)
        {
            if (lstvCacMonAn.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn tạo mới không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    lstvCacMonAn.Items.Clear(); 
            }
            else
                MessageBox.Show("Danh sách đang trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
