using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _023101063_Tuan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện chung cho tất cả RadioButton
            radioButtonLaptop.CheckedChanged += radioButton_CheckedChanged;
            radioButtonUSB.CheckedChanged += radioButton_CheckedChanged;
            radioButtonMouse.CheckedChanged += radioButton_CheckedChanged;
        }

        private async void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radio)) return;
            if (!radio.Checked) return;

            DanhSachSanPham.Items.Clear();
            HideAllImages();

            switch (radio.Name)
            {
                case "radioButtonLaptop":
                    DanhSachSanPham.Items.AddRange(new string[] { "HP", "Vaio", "DELL", "Lenovo" });
                    await LoadCategoryImagesAsync("Laptop");
                    break;
                case "radioButtonUSB":
                    DanhSachSanPham.Items.AddRange(new string[] { "Transcend", "KingMax", "Kingston" });
                    await LoadCategoryImagesAsync("USB");
                    break;
                case "radioButtonMouse":
                    DanhSachSanPham.Items.AddRange(new string[] { "Logitech", "Razer", "Dareu", "Raboo" });
                    await LoadCategoryImagesAsync("Mouse");
                    break;
            }
        }

        private async Task LoadCategoryImagesAsync(string category)
        {
            ShowAllImages();
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

            for (int i = 0; i < 4; i++)
            {
                string imagePath = Path.Combine(Application.StartupPath, "images", $"{category}_{i + 1}.jpg");
                pictureBoxes[i].Image = await LoadImageAsync(imagePath);
            }
        }

        private async Task<Image> LoadImageAsync(string path)
        {
            if (!File.Exists(path)) return null;

            return await Task.Run(() =>
            {
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(stream);
                }
            });
        }

        private async void DanhSachSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DanhSachSanPham.SelectedItem != null)
            {
                string selectedProduct = DanhSachSanPham.SelectedItem.ToString();
                string imagePath = Path.Combine(Application.StartupPath, "images", selectedProduct + ".jpg");

                HideAllImages();
                pictureBox1.Image = await LoadImageAsync(imagePath);

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Không tìm thấy ảnh của sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void HideAllImages()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
        }

        private void ShowAllImages()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }
    }
}
