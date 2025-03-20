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
    public partial class Hinh2_27 : Form
    {
        public Hinh2_27()
        {
            InitializeComponent();
        }

        private void Hinh2_27_Load(object sender, EventArgs e)
        {
            tvwDSXe.Nodes.Add("Xe");
            tvwDSXe.Nodes[0].Nodes.Add("Xe máy");
            tvwDSXe.Nodes[0].Nodes[0].Nodes.Add("SH");
            tvwDSXe.Nodes[0].Nodes[0].Nodes.Add("Spacy");

            tvwDSXe.Nodes[0].Nodes.Add("Ô tô");
            tvwDSXe.Nodes[0].Nodes[1].Nodes.Add("Innova");
            tvwDSXe.Nodes[0].Nodes[1].Nodes.Add("Camry");
        }

        private void tvwDSXe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string seletedIndex = tvwDSXe.SelectedNode.Text;
            if (seletedIndex == "Xe máy")
                HienThiXeMay();
            if (seletedIndex == "Ô tô")
                HienThiOto();
        }

        private void HienThiOto()
        {
            lvwTTCT.Items.Clear();
            lvwTTCT.Items.Add("Innova");
            lvwTTCT.Items[0].SubItems.Add("2014");
            lvwTTCT.Items[0].SubItems.Add("150");
            lvwTTCT.Items[0].SubItems.Add("52000000");
            
            lvwTTCT.Items.Add("Camry");
            lvwTTCT.Items[1].SubItems.Add("2013");
            lvwTTCT.Items[1].SubItems.Add("100");
            lvwTTCT.Items[1].SubItems.Add("150000000");
        }

        private void HienThiXeMay()
        {
            lvwTTCT.Items.Clear();
            lvwTTCT.Items.Add("SH");
            lvwTTCT.Items[0].SubItems.Add("2012");
            lvwTTCT.Items[0].SubItems.Add("125");
            lvwTTCT.Items[0].SubItems.Add("40000000");
            
            lvwTTCT.Items.Add("Spacy");
            lvwTTCT.Items[1].SubItems.Add("2013");
            lvwTTCT.Items[1].SubItems.Add("125");
            lvwTTCT.Items[1].SubItems.Add("42000000");
        }
    }
}
