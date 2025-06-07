using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BS10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double tongTien = 0.0;
            double soM = 0.0;
            double bac1 = 6300, bac2 = 12100, bac3 = 13600, bac4 = 17900;
            lstvBangKeCT.Items.Clear();

            if (!double.TryParse(txtSoM.Text, out soM) || soM < 0)
            {
                MessageBox.Show("Vui lòng nhập số m\u00B3 hợp lệ", "Lỗi");
                return;
            }

            // Bậc 1: 0-4
            if (soM >= 0 && soM <= 4)
            {
                double muc1 = soM;
                double tien1 = muc1 * bac1;
                tongTien += tien1;
                HienThiListView("Bậc 1", muc1, bac1, tien1);
            }
            // Bậc 2: 4-6
            else if (soM <= 6)
            {
                double muc1 = 4;
                double muc2 = soM - 4;
                double tien1 = muc1 * bac1;
                double tien2 = muc2 * bac2;
                tongTien += tien1 + tien2;
                HienThiListView("Bậc 1", muc1, bac1, tien1);
                HienThiListView("Bậc 2", muc2, bac2, tien2);
            }
            // Bậc 3: 6-10
            else if (soM <= 10)
            {
                double muc1 = 4;
                double muc2 = 2;
                double muc3 = soM - 6;
                double tien1 = muc1 * bac1;
                double tien2 = muc2 * bac2;
                double tien3 = muc3 * bac3;
                tongTien += tien1 + tien2 + tien3;

                HienThiListView("Bậc 1", muc1, bac1, tien1);
                HienThiListView("Bậc 2", muc2, bac2, tien2);
                HienThiListView("Bậc 3", muc3, bac3, tien3);
            }
            // Bậc 4: Trên 10
            else
            {
                double muc1 = 4;
                double muc2 = 2;
                double muc3 = 4;
                double muc4 = soM - 10;
                double tien1 = muc1 * bac1;
                double tien2 = muc2 * bac2;
                double tien3 = muc3 * bac3;
                double tien4 = muc4 * bac4;
                tongTien += tien1 + tien2 + tien3 + tien4;

                HienThiListView("Bậc 1", muc1, bac1, tien1);
                HienThiListView("Bậc 2", muc2, bac2, tien2);
                HienThiListView("Bậc 3", muc3, bac3, tien3);
                HienThiListView("Bậc 4", muc4, bac4, tien4);
            }
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        private void HienThiListView(string bac, double muc, double donGia, double thanhTien)
        {
            ListViewItem item = new ListViewItem(bac);
            item.SubItems.Add(muc.ToString());
            item.SubItems.Add(donGia.ToString("N0"));
            item.SubItems.Add(thanhTien.ToString("N0"));
            lstvBangKeCT.Items.Add(item);
        }
    }
}
