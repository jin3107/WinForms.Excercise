using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Music
{
    public partial class MusicForm : Form
    {
        private Timer lyricTimer;
        private OpenFileDialog openFileDialog;
        private string[] filePath;
        private string[] fileName;

        public MusicForm()
        {
            InitializeComponent();
            InitLyricTimer();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, Mp4 files(*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileNames;
                fileName = openFileDialog.SafeFileNames;
                foreach (var item in fileName)
                    this.ListBoxMusic.Items.Add(item);
            }
        }

        private void listBoxMusic_DoubleClick(object sender, EventArgs e)
        {
            if (ListBoxMusic.SelectedIndex != -1)
            {
                int chon = ListBoxMusic.SelectedIndex;
                axWindowsMediaPlayer.URL = filePath[chon];
                this.textBoxDuongDan.Text = fileName[chon];

                richTextBoxLyric.Text = GetLyrics(filePath[chon]);
            }
        }

        private void textBoxDuongDan_TextChanged(object sender, EventArgs e)
        {
            this.textBoxDuongDan.ReadOnly = true;
        }

        private void richTextBoxLyric_TextChanged(object sender, EventArgs e)
        {
            this.richTextBoxLyric.ReadOnly = true;
        }

        private void lyrictimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void InitLyricTimer()
        {
            lyricTimer = new Timer();
            lyricTimer.Interval = 500;
            lyricTimer.Tick += lyrictimer_Tick!;
        }

        private string GetLyrics(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                return file.Tag.Lyrics ?? "Không có lời bài hát";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
