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
    public partial class Bai3_tr57 : Form
    {
        public Bai3_tr57()
        {
            InitializeComponent();
        }

        private void Bai3_tr57_Load(object sender, EventArgs e)
        {
            cbbPhanLoai.Items.Add("Thuốc bổ");
            cbbPhanLoai.Items.Add("Thuốc giảm đau");
            cbbPhanLoai.Items.Add("Thuốc kháng sinh");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lbDanhMucThuoc.SelectedItems.Count > 0)
            {
                foreach (var item in lbDanhMucThuoc.SelectedItems)
                {
                    if (!lbThuocKeToa.Items.Contains(item))
                        lbThuocKeToa.Items.Add(item);
                    else
                        MessageBox.Show("Thuốc đã có trong danh sách kê toa.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn thuốc để thêm vào danh sách đã chọn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBenhNhanMoi_Click(object sender, EventArgs e)
        {
            string fileName = Application.StartupPath + $"\\TTBN_{txtHoTen.Text}.txt";
            DateTime currentDate = DateTime.Now;
            int tuoi = currentDate.Year - int.Parse(txtNamSinh.Text);
            int ngayTaiKham = dtpTaiKham.Value.Day + currentDate.Day;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Họ tên: " + txtHoTen.Text);
                writer.WriteLine("Tuồi: " + tuoi);
                writer.WriteLine("Năm sinh: " + txtNamSinh.Text);
                writer.WriteLine("Giới tính: " + (cbGioiTinh.Checked ? "Nam" : "Nữ"));
                writer.WriteLine("Thuốc kê toa:");
                string thuoc = "";
                foreach (var item in lbThuocKeToa.Items)
                {
                    thuoc += "- " + item.ToString() + "\n";
                }
                writer.WriteLine($"Hẹn ngày tái khám sau {ngayTaiKham} ngày");
                writer.WriteLine("\n");
            }

            MessageBox.Show("Đã lưu danh sách thuốc kê toa vào file TTBN.txt", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtHoTen.Clear();
            cbbPhanLoai.SelectedIndex = -1;
            cbGioiTinh.Checked = false;
            txtNamSinh.Clear();
            lbThuocKeToa.Items.Clear();
        }

        private void cbbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhanLoai.SelectedItem == null) return;

            string selectedItem = cbbPhanLoai.SelectedItem.ToString();
            lbDanhMucThuoc.Items.Clear();

            if (selectedItem == "Thuốc bổ")
            {
                lbDanhMucThuoc.Items.Add("Vitamin C");
                lbDanhMucThuoc.Items.Add("Vitamin B");
                lbDanhMucThuoc.Items.Add("Vitamin D");
            }
            else if (selectedItem == "Thuốc giảm đau")
            {
                lbDanhMucThuoc.Items.Add("Paracetamol");
                lbDanhMucThuoc.Items.Add("Ibuprofen");
                lbDanhMucThuoc.Items.Add("Aspirin");
            }
            else if (selectedItem == "Thuốc kháng sinh")
            {
                lbDanhMucThuoc.Items.Add("Amoxicillin");
                lbDanhMucThuoc.Items.Add("Ciprofloxacin");
                lbDanhMucThuoc.Items.Add("Azithromycin");
            }
        }

        private void btnInToa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtNamSinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và năm sinh.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtNamSinh.Text, out int namSinh))
            {
                MessageBox.Show("Năm sinh không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tuoi = DateTime.Now.Year - namSinh;
            string thuoc = "";
            foreach (var item in lbThuocKeToa.Items)
            {
                thuoc += "- " + item.ToString() + "\n";
            }
            if (thuoc == "")
                thuoc = "(Không có)";
            DateTime currentDate = DateTime.Now;
            int ngayTaiKham = dtpTaiKham.Value.Day + currentDate.Day;
            MessageBox.Show($"Họ tên: {txtHoTen.Text}\n" +
                $"Tuổi: {tuoi}\n" +
                $"Năm sinh: {txtNamSinh.Text}\n" +
                $"Giới tính: {(cbGioiTinh.Checked ? "Nam" : "Nữ")}\n" +
                $"Thuốc được kê toa:\n{thuoc}\n" +
                $"Hẹn ngày tái khám sau {ngayTaiKham} ngày", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
