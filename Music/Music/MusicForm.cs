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
using WMPLib;
using Timer = System.Windows.Forms.Timer;

namespace Music
{
    public partial class MusicForm : Form
    {
        private Timer lyricTimer;
        private string[] filePath;
        private string[] fileName;
        private List<(TimeSpan, string)> lyrics;
        private int currentLine;

        public MusicForm()
        {
            InitializeComponent();
            filePath = Array.Empty<string>();
            fileName = Array.Empty<string>();
            lyrics = new List<(TimeSpan, string)>();
            lyricTimer = new Timer();
            InitLyricTimer();
            InitCircleIcon();
            textBoxDuongDan.ReadOnly = true;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Thoát không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void InitCircleIcon()
        {
            Rectangle r = new Rectangle(0, 0, pictureBoxCircle.Width, pictureBoxCircle.Height);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxCircle.Width - 3, pictureBoxCircle.Height - 3);
            Region rg = new Region(gp);
            pictureBoxCircle.Region = rg;
        }

        private async void ChayChu()
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
            
        }

        private void lyrictimer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                return;
            }

            TimeSpan currentTime = TimeSpan.FromSeconds(axWindowsMediaPlayer.Ctlcontrols.currentPosition);
            var currentLyric = lyrics.FindLast(l => l.Item1 <= currentTime);
            if (currentLyric != default && currentLyric.Item2 != richTextBoxLyric.Text)
            {
                richTextBoxLyric.Text = currentLyric.Item2;
            }
        }

        private void InitLyricTimer()
        {
            lyricTimer = new Timer { Interval = 500 };
            lyricTimer.Tick += lyrictimer_Tick!;
        }

        private void LoadLyricsFromFile(string fileName)
        {
            lyrics.Clear();

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy file lyric!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBoxLyric.Text = "Không có lời";
                return;
            }

            foreach (string line in File.ReadAllLines(fileName))
            {
                Match match = Regex.Match(line, @"\[(\d+):(\d+)(?:[:.](\d+))?\](.*)");
                if (match.Success)
                {
                    int minutes = int.Parse(match.Groups[1].Value);
                    int seconds = int.Parse(match.Groups[2].Value);
                    int milliseconds = match.Groups[3].Success ? int.Parse(match.Groups[3].Value) * 10 : 0;
                    TimeSpan time = new TimeSpan(0, 0, minutes, seconds, milliseconds);
                    string lyricText = match.Groups[4].Value.Trim();
                    if (!string.IsNullOrEmpty(lyricText))
                    {
                        lyrics.Add((time, lyricText));
                    }
                }
            }
            lyrics.Sort((a, b) => a.Item1.CompareTo(b.Item1));
            currentLine = 0;
            richTextBoxLyric.Text = lyrics.Count > 0 ? lyrics[0].Item2 : "Không có lời";
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            string musicFile = Path.Combine(Application.StartupPath, "Resources",
                "Tháng tư là lời nói dối của em - Hà Anh Tuấn.mp3");
            string lyricFile = Path.Combine(Application.StartupPath, "Resources",
                "ThangTuLaLoiNoiDoiCuaEm.lrc");
            if (!File.Exists(musicFile))
            {
                MessageBox.Show("Không tìm thấy file nhạc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            filePath = new string[] { musicFile };
            fileName = new string[] { " Tháng tư là lời nói dối của em. " };
            axWindowsMediaPlayer.URL = filePath[0];
            textBoxDuongDan.Text = fileName[0];
            ChayChu();
            LoadLyricsFromFile(lyricFile);
            richTextBoxLyric.ForeColor = Color.Blue;
            lyricTimer.Start();
            axWindowsMediaPlayer.Ctlcontrols.play();
        }
    }
}