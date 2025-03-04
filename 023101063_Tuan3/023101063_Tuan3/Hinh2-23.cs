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
    public partial class Hinh2_23 : Form
    {
        public Hinh2_23()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            lstMonHoc.Items.Insert(Convert.ToInt32(numericUpDownVT.Value), textBoxMH.Text);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int soDongDaChon = lstMonHoc.SelectedItems.Count;
            for (int i = soDongDaChon - 1; i >= 0; i--)
                lstMonHoc.Items.RemoveAt(lstMonHoc.SelectedIndices[i]);
        }

        private void lstMonHoc_Click(object sender, EventArgs e)
        {
            int soDongDaChon = lstMonHoc.SelectedItems.Count;
            string monHoc = "";
            string chiSo = "";
            for (int i = 0; i < soDongDaChon; i++)
            {
                monHoc = monHoc + lstMonHoc.SelectedItems[i]!.ToString() + "\r\n";
                chiSo = chiSo + lstMonHoc.SelectedIndices[i].ToString() + " ";
            }
            textBoxMHDuocChon.Text = monHoc;
            textBoxChiSo.Text = chiSo;
        }
    }
}
