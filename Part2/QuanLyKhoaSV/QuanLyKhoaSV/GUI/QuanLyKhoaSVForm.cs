using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuanLyKhoaSV.DAO;
using QuanLyKhoaSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoaSV.GUI
{
    public partial class QuanLyKhoaSVForm : Form
    {
        Database db;
        DataTable dt;

        public QuanLyKhoaSVForm()
        {
            InitializeComponent();
        }

        private void QuanLyKhoaSVForm_Load(object sender, EventArgs e)
        {
            db = new Database("RAINY", "khoasv");

            cbbPhai.Items.Add("Nam");
            cbbPhai.Items.Add("Nữ");

            LoadTreeView();
            SangMo(true);
        }

        private void SangMo(bool gt)
        {
            btnThem.Enabled = gt;
            btnGhi.Enabled = !gt;
            btnKhong.Enabled = !gt;
            btnCapNhat.Enabled = gt;
            btnHuy.Enabled = gt;
        }

        private void LoadTreeView()
        {
            tvwPhongBan.Nodes.Clear();
            dt = db.ExcuteQuery("Select MaKH, TenKhoa From Khoa");
            cbbTenKhoa.DataSource = dt;
            cbbTenKhoa.DisplayMember = "TenKhoa";
            cbbTenKhoa.ValueMember = "MaKH";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TreeNode n = new TreeNode();
                n.Text = dt.Rows[i][1].ToString();
                n.Tag = dt.Rows[i][0].ToString();
                n.ImageIndex = 0;
                DataTable dt1 = db.ExcuteQuery($"Select MaSV From SinhVien Where MaKH = '{n.Tag.ToString()}'");
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    TreeNode m = new TreeNode();
                    m.Text = "Mã SV: " + dt1.Rows[j][0].ToString();
                    m.Tag = dt1.Rows[j][0].ToString();
                    m.ImageIndex = 1;
                    n.Nodes.Add(m);
                }
                tvwPhongBan.Nodes.Add(n);
            }
        }

        private void tvwPhongBan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode n = tvwPhongBan.SelectedNode;
            if (n.Parent == null)
            {
                string maKH = n.Tag.ToString();
                DataTable dtsv = db.ExcuteQuery($"Select MaSV, Ho + ' ' + Ten as HoTen, Phai, NgaySinh, NoiSinh From SinhVien Where MaKH = '{maKH}'");
                dgvDMSV.DataSource = dtsv;
                string nam = db.FindBy($"Select Count(*) From SinhVien Where MaKH = '{maKH}' and Phai = 1");
                lblTongNam.Text = "Tổng số sinh viên nam: " + nam;
                string nu = db.FindBy($"Select Count(*) From SinhVien Where MaKH = '{maKH}' and Phai = 0");
                lblTongNu.Text = "Tổng số sinh viên nữ: " + nu;
            }
            else
            {
                string selectedMaSV = tvwPhongBan.SelectedNode.Text.ToString();
                string[] paths = selectedMaSV.Split(' ');
                string maSV = paths[2];
                string sql = $"Select MaSV, Ho, Ten, " +
                    $"Case when Phai = 1 then 'Nam' else N'Nữ' end as GT, NgaySinh, NoiSinh, MaKH " +
                    $"From SinhVien Where MaSV = '{maSV}'";
                dt = db.ExcuteQuery(sql);
                if (dt.Rows.Count > 0)
                    HienThiControl(dt.Rows[0]);
            }
        }

        private void HienThiControl(DataRow row)
        {
            txtMaSV.Text = row[0].ToString();
            txtHo.Text = row[1].ToString();
            txtTen.Text = row[2].ToString();
            cbbPhai.Text = row[3].ToString();
            dtpNgaySinh.Value = DateTime.Parse(row[4].ToString());
            txtNoiSinh.Text = row[5].ToString();
            cbbTenKhoa.SelectedValue = row[6].ToString();
        }

        private void MaSVTang()
        {
            int nextId = int.Parse(db.FindBy("Select Count(*) From SinhVien")) + 1;
            txtMaSV.Text = $"SV0{nextId}";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SangMo(false);
            SetControl();
        }

        private void SetControl()
        {
            MaSVTang();
            txtMaSV.Enabled = false;
            txtHo.Text = "";
            txtTen.Text = "";
            cbbPhai.Text = "";
            txtNoiSinh.Text = "";
            cbbTenKhoa.SelectedValue = -1;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SangMo(true);
            bool phai = false;
            if (cbbPhai.Text == "Nam")
                phai = true;

            SinhVien sinhVien = new SinhVien(txtMaSV.Text, txtHo.Text, txtTen.Text, phai, dtpNgaySinh.Value, txtNoiSinh.Text, cbbTenKhoa.SelectedValue.ToString());
            string sql = "Insert into SinhVien(MaSV, Ho, Ten, Phai, NgaySinh, NoiSinh, MaKH) " +
                "values(@masv, @ho, @ten, @phai, @ngaysinh, @noisinh, @khoa)";
            SqlCommand cmd = new SqlCommand(sql, db.connection);
            cmd.Parameters.AddWithValue("@masv", sinhVien.MaSV);
            cmd.Parameters.AddWithValue("@ho", sinhVien.Ho);
            cmd.Parameters.AddWithValue("@ten", sinhVien.Ten);
            cmd.Parameters.AddWithValue("@phai", sinhVien.Phai);
            cmd.Parameters.AddWithValue("@ngaysinh", sinhVien.NgaySinh);
            cmd.Parameters.AddWithValue("@noisinh", sinhVien.NoiSinh);
            cmd.Parameters.AddWithValue("@khoa", sinhVien.Khoa);
            try
            {
                db.ExecuteNonQuery(cmd);
                MessageBox.Show("Ghi dữ liệu thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            SangMo(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bool phai = false;
            if (cbbPhai.Text == "Nam")
                phai = true;

            SinhVien sinhVien = new SinhVien(txtMaSV.Text, txtHo.Text, txtTen.Text, phai, dtpNgaySinh.Value, txtNoiSinh.Text, cbbTenKhoa.SelectedValue.ToString());
            string sql = "Delete From SinhVien Where MaSV = @masv";
            SqlCommand cmd = new SqlCommand(sql, db.connection);
            cmd.Parameters.AddWithValue("@masv", sinhVien.MaSV);
            try
            {
                db.ExecuteNonQuery(cmd);
                MessageBox.Show("Xoá thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool phai = false;
            if (cbbPhai.Text == "Nam")
                phai = true;

            SinhVien sinhVien = new SinhVien(txtMaSV.Text, txtHo.Text, txtTen.Text, phai, dtpNgaySinh.Value, txtNoiSinh.Text, cbbTenKhoa.SelectedValue.ToString());
            string sql = "Update SinhVien Set Ho = @ho, Ten = @ten, Phai = @phai, NgaySinh = @ngaysinh, NoiSinh = @noisinh, MaKH = @khoa Where MaSV = @masv";
            SqlCommand cmd = new SqlCommand(sql, db.connection);
            cmd.Parameters.AddWithValue("@masv", sinhVien.MaSV);
            cmd.Parameters.AddWithValue("@ho", sinhVien.Ho);
            cmd.Parameters.AddWithValue("@ten", sinhVien.Ten);
            cmd.Parameters.AddWithValue("@phai", sinhVien.Phai);
            cmd.Parameters.AddWithValue("@ngaysinh", sinhVien.NgaySinh);
            cmd.Parameters.AddWithValue("@noisinh", sinhVien.NoiSinh);
            cmd.Parameters.AddWithValue("@khoa", sinhVien.Khoa);
            try
            {
                db.ExecuteNonQuery(cmd);
                MessageBox.Show("Chỉnh sửa thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapFileExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file Excel";
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcelData(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImportExcelData(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            int successCount = 0;
            int errorCount = 0;
            StringBuilder errorMessages = new StringBuilder();
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                // lấy cái sheet đầu tiên
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount; row++)
                {
                    try
                    {
                        string maSV = worksheet.Cells[row, 1].Value?.ToString()?.Trim(); // cột A: Mã SV
                        string ho = worksheet.Cells[row, 2].Value?.ToString()?.Trim(); // cột B: Họ
                        string ten = worksheet.Cells[row, 3].Value?.ToString()?.Trim(); // cột C: Tên
                        string phaiText = worksheet.Cells[row, 4].Value?.ToString()?.Trim(); // cột D: Phái
                        string ngaySinhText = worksheet.Cells[row, 5].Value?.ToString()?.Trim(); // cột E: Ngày sinh
                        string noiSinh = worksheet.Cells[row, 6].Value?.ToString()?.Trim(); // cột F: Nơi sinh
                        string maKH = worksheet.Cells[row, 7].Value?.ToString()?.Trim(); // cột G: Mã KH
                        if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
                        {
                            errorMessages.AppendLine($"Dòng {row}: Thiếu thông tin bắt buộc (Mã SV, Họ, Tên)");
                            errorCount++;
                            continue;
                        }

                        bool phai = false;
                        if (!string.IsNullOrEmpty(phaiText))
                        {
                            if (phaiText.Equals("1") || phaiText.Equals("Nam", StringComparison.OrdinalIgnoreCase) ||
                                phaiText.Equals("True", StringComparison.OrdinalIgnoreCase))
                            {
                                phai = true;
                            }
                        }

                        DateTime ngaySinh = DateTime.Now.Date;
                        if (!string.IsNullOrEmpty(ngaySinhText))
                        {
                            if (!DateTime.TryParse(ngaySinhText, out ngaySinh))
                            {
                                double oaDate;
                                if (double.TryParse(ngaySinhText, out oaDate))
                                {
                                    ngaySinh = DateTime.FromOADate(oaDate);
                                }
                                else
                                {
                                    errorMessages.AppendLine($"Dòng {row}: Ngày sinh không hợp lệ");
                                    errorCount++;
                                    continue;
                                }
                            }
                            ngaySinh = ngaySinh.Date;
                        }

                        // check mã kh có tồn tại ko
                        if (string.IsNullOrEmpty(maKH))
                        {
                            errorMessages.AppendLine($"Dòng {row}: Thiếu Mã Khoa");
                            errorCount++;
                            continue;
                        }

                        // check sinh viên đã tồn tại chưa
                        string checkSql = $"SELECT COUNT(*) FROM SinhVien WHERE MaSV = '{maSV}'";
                        string exists = db.FindBy(checkSql);

                        SqlCommand cmd;
                        if (exists == "0")
                        {
                            string sql = "INSERT INTO SinhVien(MaSV, Ho, Ten, Phai, NgaySinh, NoiSinh, MaKH) " +
                                        "VALUES(@masv, @ho, @ten, @phai, @ngaysinh, @noisinh, @khoa)";
                            cmd = new SqlCommand(sql, db.connection);
                        }
                        else
                        {
                            string sql = "UPDATE SinhVien SET Ho = @ho, Ten = @ten, Phai = @phai, " +
                                        "NgaySinh = @ngaysinh, NoiSinh = @noisinh, MaKH = @khoa WHERE MaSV = @masv";
                            cmd = new SqlCommand(sql, db.connection);
                        }

                        cmd.Parameters.AddWithValue("@masv", maSV);
                        cmd.Parameters.AddWithValue("@ho", ho);
                        cmd.Parameters.AddWithValue("@ten", ten);
                        cmd.Parameters.AddWithValue("@phai", phai);
                        cmd.Parameters.AddWithValue("@ngaysinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@noisinh", string.IsNullOrEmpty(noiSinh) ? (object)DBNull.Value : noiSinh);
                        cmd.Parameters.AddWithValue("@khoa", maKH);

                        db.ExecuteNonQuery(cmd);
                        successCount++;
                    }
                    catch (Exception ex)
                    {
                        errorMessages.AppendLine($"Dòng {row}: {ex.Message}");
                        errorCount++;
                    }
                }
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Hoàn thành import dữ liệu:");
            result.AppendLine($"- Thành công: {successCount} dòng");
            result.AppendLine($"- Lỗi: {errorCount} dòng");
            if (errorCount > 0)
            {
                result.AppendLine("\nChi tiết lỗi:");
                result.Append(errorMessages.ToString());
            }

            MessageBox.Show(result.ToString(), "Kết quả Import", MessageBoxButtons.OK,
                errorCount > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
            LoadTreeView();
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveDialog.Title = "Lưu tệp Excel";
            saveDialog.FileName = "BaoCaoDuLieu.xlsx"; // Tên mặc định

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Gọi phương thức xuất dữ liệu
                    ExportDataGridViewToExcel(dgvDMSV, saveDialog.FileName);
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportDataGridViewToExcel(DataGridView dgvDMSV, string fileName)
        {
            // Đảm bảo tệp được lưu an toàn
            FileInfo fileInfo = new FileInfo(fileName);
            // Sử dụng khối 'using' cho ExcelPackage
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                // Tạo một worksheet mới (có thể đặt tên là "Data")
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Data");
                // --- BƯỚC 1: Xuất Tiêu đề Cột ---
                int colIndex = 1;
                foreach (DataGridViewColumn col in dgvDMSV.Columns)
                {
                    // Chỉ xuất những cột nhìn thấy (Visible)
                    if (col.Visible)
                    {
                        worksheet.Cells[1, colIndex].Value = col.HeaderText;
                        colIndex++;
                    }
                }
                // Định dạng tiêu đề (Tùy chọn)
                using (var range = worksheet.Cells[1, 1, 1, colIndex - 1])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                // --- BƯỚC 2: Xuất Dữ liệu Hàng ---
                int rowIndex = 2; // Bắt đầu từ hàng thứ 2 vì hàng 1 là tiêu đề
                // Lặp qua từng hàng (Rows) của DataGridView
                foreach (DataGridViewRow row in dgvDMSV.Rows)
                {
                    // Bỏ qua hàng trống (thường là hàng mới ở cuối DataGridView)
                    if (row.IsNewRow) continue;

                    colIndex = 1; // Đặt lại chỉ số cột cho mỗi hàng
                                  // Lặp qua từng ô (Cells) của hàng hiện tại
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Kiểm tra xem cột có hiển thị không
                        if (dgvDMSV.Columns[cell.ColumnIndex].Visible)
                        {
                            // Lấy giá trị của ô và gán vào ô Excel tương ứng
                            worksheet.Cells[rowIndex, colIndex].Value = cell.Value;
                            colIndex++;
                        }
                    }
                    rowIndex++;
                }
                // --- BƯỚC 3: Tự động điều chỉnh độ rộng cột và Lưu tệp ---
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                // Lưu tệp Excel
                package.Save();
            }
        }
        public string CleanStringForExcel(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            return System.Text.RegularExpressions.Regex.Replace(input, @"[\x00-\x08\x0b\x0c\x0e-\x1f]", string.Empty);
        }
    }
}
