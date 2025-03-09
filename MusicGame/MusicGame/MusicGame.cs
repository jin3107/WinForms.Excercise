using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace MusicGame
{
    public partial class MusicGame : Form
    {
        private List<string> danhSachFileNhac = new List<string>();
        private Dictionary<string, string> mappingBaiHat = new Dictionary<string, string>();
        private Dictionary<string, string> baiHatDaChon = new Dictionary<string, string>();
        private int diem = 0;
        private int thoiGianPhat = 10;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string musicFolder = Path.Combine(Application.StartupPath, "Music");
        private Random random = new Random();
        private string currentSongAlias = "";
        private Timer playTimer = new Timer();

        public MusicGame()
        {
            InitializeComponent();
            KhoiTaoBaiHat();
            txtDiem.ReadOnly = true;
            playTimer.Tick += DungNhac;
        }

        private void KhoiTaoBaiHat()
        {
            if (!Directory.Exists(musicFolder))
            {
                Directory.CreateDirectory(musicFolder);
                MessageBox.Show("Thư mục Music rỗng! Hãy thêm file .mp3 hoặc .mp4 vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] files = Directory.GetFiles(musicFolder, "*.mp3")
                                .Concat(Directory.GetFiles(musicFolder, "*.mp4"))
                                .OrderBy(f => random.Next()) 
                                .ToArray();
            if (files.Length == 0)
            {
                MessageBox.Show("Không tìm thấy bài hát nào trong thư mục Music!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            danhSachFileNhac = files.ToList();
            mappingBaiHat.Clear();
            DanhSachBaiHat.Items.Clear();
            for (int i = 0; i < danhSachFileNhac.Count; i++)
            {
                string alias = $"Bài hát số {i + 1}";
                mappingBaiHat[alias] = Path.GetFileNameWithoutExtension(danhSachFileNhac[i]);
                DanhSachBaiHat.Items.Add(alias);
            }
        }

        private void RandomBaiHat()
        {
            if (danhSachFileNhac.Count == 0) return;

            playTimer.Stop();
            player.controls.stop();

            int index = random.Next(danhSachFileNhac.Count);
            string filePath = danhSachFileNhac[index];
            string songRealName = Path.GetFileNameWithoutExtension(filePath);
            currentSongAlias = $"Bài hát số {index + 1}";
            if (!mappingBaiHat.ContainsKey(currentSongAlias))
            {
                mappingBaiHat[currentSongAlias] = songRealName;
            }

            player.URL = filePath;
            player.controls.play();
            playTimer.Interval = thoiGianPhat * 1000;
            playTimer.Start();
        }

        private void DungNhac(object sender, EventArgs e)
        {
            player.controls.stop();
            playTimer.Stop();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bài hát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DanhSachBaiHat.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một bài hát trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAlias = DanhSachBaiHat.SelectedItem.ToString();
            if (baiHatDaChon.ContainsKey(selectedAlias))
            {
                MessageBox.Show("Bài hát này đã được nhập trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baiHatDaChon[selectedAlias] = txtNhap.Text.Trim().ToLower();
            BaiHatDaNhap.Items.Add($"{selectedAlias}: {txtNhap.Text.Trim()}");
            txtNhap.Clear();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (BaiHatDaNhap.SelectedItem != null)
            {
                string baiHatXoa = BaiHatDaNhap.SelectedItem.ToString().Split(':')[0].Trim();
                baiHatDaChon.Remove(baiHatXoa);
                BaiHatDaNhap.Items.Remove(BaiHatDaNhap.SelectedItem);
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            diem = 0;
            BaiHatDaNhap.Items.Clear();
            foreach (var baiHat in baiHatDaChon)
            {
                string baiGoc = mappingBaiHat[baiHat.Key].ToLower();
                string baiNhap = baiHat.Value.ToLower();
                if (baiGoc == baiNhap)
                {
                    BaiHatDaNhap.Items.Add($"{baiHat.Key}: {baiHat.Value} ✅");
                    diem += 20;
                }
                else
                    BaiHatDaNhap.Items.Add($"{baiHat.Key}: {baiHat.Value} ❌");
            }
            txtDiem.Text = $"Điểm: {diem}";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChonMucDo()
        {
            if (rbtDe.Checked) thoiGianPhat = 10;
            else if (rbtVua.Checked) thoiGianPhat = 7;
            else if (rbtKho.Checked) thoiGianPhat = 4;
            RandomBaiHat();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            ChonMucDo();
        }
    }
}