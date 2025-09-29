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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNoiDung.Clear();
            txtNoiDung.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSSlbl.Text = "Toggle Status bar";
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSSlbl.Text = "Toggle Tool bar";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us aboutUs = new About_Us();
            aboutUs.ShowDialog();
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            txtNoiDung.Enabled = true;
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
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

        private void tsbtnSave_Click(object sender, EventArgs e)
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

        private void tsbtnHelp_Click(object sender, EventArgs e)
        {
            About_Us aboutUs = new About_Us();
            aboutUs.ShowDialog();
        }
    }
}
