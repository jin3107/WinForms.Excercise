using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_Chuong3
{
    public partial class Bai3_tr76 : Form
    {
        public Bai3_tr76()
        {
            InitializeComponent();
        }

        private void Bai3_tr76_Load(object sender, EventArgs e)
        {
            txtNoiDung.Enabled = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNoiDung.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want save the current file?", "FilePad", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.No)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text File|*.txt|All Files|*.*";
                openFileDialog.Title = "Open a Text File";
                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != "")
                {
                    txtNoiDung.Text = File.ReadAllText(openFileDialog.FileName);
                    txtNoiDung.Enabled = true;
                }
            }
            else if (result == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Save a Text File";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    File.WriteAllText(saveFileDialog.FileName, txtNoiDung.Text);
                    txtNoiDung.Enabled = false;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt|All Files|*.*";
            openFileDialog.Title = "Open a Text File";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                txtNoiDung.Text = File.ReadAllText(openFileDialog.FileName);
                txtNoiDung.Enabled = true;
            }
        }
    }
}
