using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private List<(TimeSpan, string)> lyrics;

        public MusicForm()
        {
            InitializeComponent();
            InitLyricTimer();
            InitCircleIcon();
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

        private void InitCircleIcon()
        {
            Rectangle r = new Rectangle(0, 0, pictureBoxCircle.Width, pictureBoxCircle.Height);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxCircle.Width - 3, pictureBoxCircle.Height - 3);
            Region rg = new Region(gp);
            pictureBoxCircle.Region = rg;
        }

        private void listBoxMusic_DoubleClick(object sender, EventArgs e)
        {
            if (ListBoxMusic.SelectedIndex != -1)
            {
                int chon = ListBoxMusic.SelectedIndex;
                axWindowsMediaPlayer.URL = filePath[chon];
                textBoxDuongDan.Text = fileName[chon];
                MarqueeText();
                lyrics = LyricMusic.ThangTuLaLoiNoiDoiCuaEm();
                labelLyric.ForeColor = Color.Blue;
                lyricTimer.Start();
            }
        }

        private async void MarqueeText()
        {
            while (true)
            {
                string text = textBoxDuongDan.Text;
                if (text.Length > 1)
                    textBoxDuongDan.Text = text.Substring(1) + text[0];
                await Task.Delay(200);
            }
        }

        private void textBoxDuongDan_TextChanged(object sender, EventArgs e)
        {
            this.textBoxDuongDan.ReadOnly = true;
        }

        private void lyrictimer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                TimeSpan currentTime = TimeSpan.FromSeconds(axWindowsMediaPlayer.Ctlcontrols.currentPosition);
                var currentLyric = lyrics.FindLast(l => l.Item1 <= currentTime);
                if (!string.IsNullOrEmpty(currentLyric.Item2))
                    labelLyric.Text = currentLyric.Item2;
            }
        }

        private void InitLyricTimer()
        {
            lyricTimer = new Timer { Interval = 500 };
            lyricTimer.Tick += lyrictimer_Tick!;
        }
    }
}
