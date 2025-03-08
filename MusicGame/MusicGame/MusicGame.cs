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

        public MusicGame()
        {
            InitializeComponent();
            KhoiTaoBaiHat();
            txtDiem.ReadOnly = true;
        }

        private void KhoiTaoBaiHat()
        {
            if (!Directory.Exists(musicFolder))
            {
                Directory.CreateDirectory(musicFolder);
                MessageBox.Show("Thư mục Music rỗng! Hãy thêm file .mp3 hoặc .mp4 vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] files = Directory.GetFiles(musicFolder, "*.mp3").Concat(Directory.GetFiles(musicFolder, "*.mp4")).ToArray();

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
            if (DanhSachBaiHat.Items.Count == 0) return;
            currentSongAlias = DanhSachBaiHat.Items[random.Next(DanhSachBaiHat.Items.Count)].ToString();
            string songRealName = mappingBaiHat[currentSongAlias];
            string filePath = danhSachFileNhac.FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).Equals(songRealName, StringComparison.OrdinalIgnoreCase));
            if (filePath != null)
            {
                player.URL = filePath;
                player.controls.play();
                Timer timer = new Timer();
                timer.Interval = thoiGianPhat * 1000;
                timer.Tick += (s, args) => {
                    player.controls.stop();
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bài hát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (baiHatDaChon.ContainsKey(currentSongAlias))
            {
                MessageBox.Show("Bài hát này đã được nhập trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            baiHatDaChon[currentSongAlias] = txtNhap.Text.Trim().ToLower();
            BaiHatDaNhap.Items.Add($"{currentSongAlias}: {txtNhap.Text.Trim()}");
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
                    diem += 10;
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

        private void ChonMucDo(object sender, EventArgs e)
        {
            if (rbtDe.Checked) thoiGianPhat = 10;
            else if (rbtVua.Checked) thoiGianPhat = 7;
            else if (rbtKho.Checked) thoiGianPhat = 4;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            RandomBaiHat();
        }
    }
}
