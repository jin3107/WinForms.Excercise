using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tuan5.Bai1c.DAO;
using Tuan5.Bai1c.DTO;

namespace Tuan5.Bai1c.GUI
{
    public partial class Form1 : Form
    {
        private Database db;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MaSVTang();
            ClearInput();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void ClearInput()
        {
            txtTenSV.Text = "";
            txtNamSinh.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cbbNgay.Text = "";
            cbbThang.Text = "";
            cbGioiTinh.Checked = false;
        }

        private void MaSVTang()
        {
            string autoIncreaseMaSV = "SV" + db.Tim("Select Count(*) From SinhVien");
            txtMaSV.Text = autoIncreaseMaSV;
            txtMaSV.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Database("RAINY", "QLSV_Tuan5");
            dt = db.LayDL("SELECT MaLop, TenLop FROM Lop");
            DataTable dataSinhVien = db.LayDL("SELECT * FROM SINHVIEN");

            if (dt.Rows.Count > 0)
            {
                cbbLop.DataSource = dt;
                cbbLop.DisplayMember = "TenLop";
                cbbLop.ValueMember = "MaLop";
                dgvSinhVien.DataSource = dataSinhVien;
                btnLuu.Enabled = false;
                for (int i = 1; i <= 31; i++)
                    cbbNgay.Items.Add(i.ToString());
                for (int i = 1;i <= 12; i++)
                    cbbThang.Items.Add(i.ToString());
            }
            else
            {
                MessageBox.Show("Không có dữ liệu lớp.");
            }
        }

        private void LoadSinhVienTheoLop(string maLop)
        {
            string sql = "SELECT * FROM SinhVien WHERE MaLop = @MaLop";
            SqlCommand cmd = new SqlCommand(sql, db.cn);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            
            DataTable dtSinhVien = db.LayDL(sql.Replace("@MaLop", "'" + maLop + "'"));
            dgvSinhVien.DataSource = dtSinhVien;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            DateTime ngay = DateTime.Parse(cbbNgay.Text + "/" + cbbThang.Text + "/" + txtNamSinh.Text);
            bool phai = cbGioiTinh.Checked;
            SinhVien sinhVien = new SinhVien(txtMaSV.Text, txtTenSV.Text, cbbLop.SelectedValue.ToString(), txtDienThoai.Text, ngay, phai, txtDiaChi.Text);
            string sql = "Insert into SinhVien(MaSV, TenSV, Phai, NgaySinh, DiaChi, DienThoai, MaLop) Values(@MaSV, @TenSV, @Phai, @NgaySinh, @DiaChi, @DienThoai, @MaLop)";
            SqlCommand cmd = new SqlCommand(sql, db.cn);
            cmd.Parameters.AddWithValue("@MaSV", sinhVien.MaSV);
            cmd.Parameters.AddWithValue("@TenSV", sinhVien.TenSV);
            cmd.Parameters.AddWithValue("@Phai", sinhVien.Phai);
            cmd.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", sinhVien.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", sinhVien.DienThoai);
            cmd.Parameters.AddWithValue("@MaLop", sinhVien.MaLop);
            db.ThucThi(cmd);

            string maLop = cbbLop.SelectedValue.ToString();
            LoadSinhVienTheoLop(maLop);
            ClearInput();
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLop.SelectedValue != null)
            {
                string maLop = cbbLop.SelectedValue.ToString();
                LoadSinhVienTheoLop(maLop);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbLop.SelectedValue != null)
            {
                string maSinhVien = txtMaSV.Text;
                string sql = $"Delete From SinhVien Where MaSV like @MaSV";
                SqlCommand cmd = new SqlCommand(sql, db.cn);
                cmd.Parameters.AddWithValue("@MaSV", maSinhVien);
                db.ThucThi(cmd);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtTenSV.Text = row.Cells["TenSV"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();

                // Xử lý giới tính
                if (row.Cells["Phai"].Value != null)
                {
                    cbGioiTinh.Checked = Convert.ToBoolean(row.Cells["Phai"].Value);
                }

                // Xử lý ngày sinh
                if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                    cbbNgay.Text = ngaySinh.Day.ToString();
                    cbbThang.Text = ngaySinh.Month.ToString();
                    txtNamSinh.Text = ngaySinh.Year.ToString();
                }

                // Xử lý lớp
                if (row.Cells["MaLop"].Value != null)
                {
                    cbbLop.SelectedValue = row.Cells["MaLop"].Value.ToString();
                }
            }
        }
    }
}
