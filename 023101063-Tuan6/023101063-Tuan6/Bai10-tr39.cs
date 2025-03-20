using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023101063_Tuan6
{
    public partial class Bai10_tr39 : Form
    {
        public Bai10_tr39()
        {
            InitializeComponent();
        }

        private void Bai10_tr39_Load(object sender, EventArgs e)
        {
            tvwDSSach.Nodes.Add("Tin học");
            tvwDSSach.Nodes[0].Nodes.Add("Lập trình giao diện");
            tvwDSSach.Nodes[0].Nodes.Add("Mạng máy tính");
            tvwDSSach.Nodes[0].Nodes.Add("Cơ sở dữ liệu");

            tvwDSSach.Nodes.Add("Thiếu nhi");
            tvwDSSach.Nodes[1].Nodes.Add("Tấm cám");
            tvwDSSach.Nodes[1].Nodes.Add("Thánh Gióng");
        }

        private void tvwDSSach_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chon = tvwDSSach.SelectedNode.Text;
            if (chon == "Tin học")
            {
                lvwDSSach.Items.Clear();
                lvwDSSach.Items.Add("Lập trình giao diện");
                lvwDSSach.Items[0].SubItems.Add("Phương Linh");
                lvwDSSach.Items[0].SubItems.Add("35000");
                
                lvwDSSach.Items.Add("Mạng máy tính");
                lvwDSSach.Items[1].SubItems.Add("Minh Khánh");
                lvwDSSach.Items[1].SubItems.Add("45000");
                
                lvwDSSach.Items.Add("Cơ sở dữ liệu");
                lvwDSSach.Items[2].SubItems.Add("Thiên Trang");
                lvwDSSach.Items[2].SubItems.Add("30000");
                
            }
            else if (chon == "Thiếu nhi")
            {
                lvwDSSach.Items.Clear();
                lvwDSSach.Items.Add("Tấm Cám");
                lvwDSSach.Items[0].SubItems.Add("Chuyện cổ tích");
                lvwDSSach.Items[0].SubItems.Add("25000");
                
                lvwDSSach.Items.Add("Thánh Gióng");
                lvwDSSach.Items[1].SubItems.Add("Chuyện cổ tích");
                lvwDSSach.Items[1].SubItems.Add("40000");
            }
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            string chon = tvwDSSach.SelectedNode.Text;
            int thanhTien = 0;
            foreach (ListViewItem item in lvwDSSach.Items)
            {
                int donGia = int.Parse(item.SubItems[2].Text);
                thanhTien += donGia;
            }
            lblT.Text = thanhTien.ToString();
        }
    }
}
