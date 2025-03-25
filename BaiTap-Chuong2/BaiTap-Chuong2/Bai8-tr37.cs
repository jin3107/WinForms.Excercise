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
    public partial class Bai8_tr37 : Form
    {
        public Bai8_tr37()
        {
            InitializeComponent();
        }

        private void cbTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbTU.SelectedItem.ToString();
            if (selectedItem == "Nước uống")
            {
                lvMenu1.Items.Clear();
                lvMenu1.Items.Add("1");
                lvMenu1.Items[0].SubItems.Add("Cafe");
                lvMenu1.Items[0].SubItems.Add("10000");

                lvMenu1.Items.Add("2");
                lvMenu1.Items[1].SubItems.Add("Cafe-sữa");
                lvMenu1.Items[1].SubItems.Add("12000");

                lvMenu1.Items.Add("3");
                lvMenu1.Items[2].SubItems.Add("Sting");
                lvMenu1.Items[2].SubItems.Add("9000");
            }
            else if (selectedItem == "Sinh tố")
            {
                lvMenu1.Items.Clear();
                lvMenu1.Items.Add("1");
                lvMenu1.Items[0].SubItems.Add("Sinh tố bơ");
                lvMenu1.Items[0].SubItems.Add("15000");

                lvMenu1.Items.Add("2");
                lvMenu1.Items[1].SubItems.Add("Sinh tố dâu");
                lvMenu1.Items[1].SubItems.Add("12000");

                lvMenu1.Items.Add("3");
                lvMenu1.Items[2].SubItems.Add("Sinh tố chuối");
                lvMenu1.Items[2].SubItems.Add("10000");
            }
            else if (selectedItem == "Nước ép")
            {
                lvMenu1.Items.Clear();
                lvMenu1.Items.Add("1");
                lvMenu1.Items[0].SubItems.Add("Nước ép cam");
                lvMenu1.Items[0].SubItems.Add("15000");

                lvMenu1.Items.Add("2");
                lvMenu1.Items[1].SubItems.Add("Nước ép dưa hấu");
                lvMenu1.Items[1].SubItems.Add("12000");

                lvMenu1.Items.Add("3");
                lvMenu1.Items[2].SubItems.Add("Nước ép cà rốt");
                lvMenu1.Items[2].SubItems.Add("10000");
            }
        }

        private void Bai8_tr37_Load(object sender, EventArgs e)
        {
            cbTU.Items.Add("Nước uống");
            cbTU.Items.Add("Sinh tố");
            cbTU.Items.Add("Nước ép");
            cbTU.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btPhai_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMenu1.SelectedItems)
            {
                int soLuong = 1;
                if (int.TryParse(item.SubItems[2].Text, out int donGia))
                {
                    int thanhTien = soLuong * donGia;
                    bool isItemExists = false;

                    foreach (ListViewItem existingItem in lvMenu2.Items)
                    {
                        if (existingItem.Text == item.SubItems[1].Text)
                        {
                            int existingSoLuong = int.Parse(existingItem.SubItems[1].Text);
                            existingSoLuong += soLuong;
                            existingItem.SubItems[1].Text = existingSoLuong.ToString();
                            existingItem.SubItems[2].Text = (existingSoLuong * donGia).ToString();
                            isItemExists = true;
                            break;
                        }
                    }

                    if (!isItemExists)
                    {
                        ListViewItem newItem = new ListViewItem(item.SubItems[1].Text);
                        newItem.SubItems.Add(soLuong.ToString());
                        newItem.SubItems.Add(thanhTien.ToString());
                        lvMenu2.Items.Add(newItem);
                    }
                }
                else
                    MessageBox.Show("Định dạng giá tiền không hợp lệ trong mục đã chọn.");
            }
        }

        private void btTrai_Click(object sender, EventArgs e)
        {
            List<ListViewItem> itemsToRemove = new List<ListViewItem>();
            for (int i = 0; i < lvMenu2.SelectedItems.Count; i++)
            {
                ListViewItem item = lvMenu2.SelectedItems[i];
                int soLuong = int.Parse(item.SubItems[1].Text);
                int donGia = int.Parse(item.SubItems[2].Text) / soLuong;

                if (soLuong > 1)
                {
                    soLuong--;
                    item.SubItems[1].Text = soLuong.ToString();
                    item.SubItems[2].Text = (soLuong * donGia).ToString();
                }
                else
                    itemsToRemove.Add(item);
            }
            foreach (var item in itemsToRemove)
                lvMenu2.Items.Remove(item);
        }

        private void btTT_Click(object sender, EventArgs e)
        {
            int thanhTien = 0;
            for (int i = 0; i < lvMenu2.Items.Count; i++)
            {
                ListViewItem item = lvMenu2.Items[i];
                int donGia = int.Parse(item.SubItems[2].Text);
                thanhTien += donGia; 
            }
            lblTT.Text = thanhTien.ToString() + " VNĐ";
        }
    }
}
