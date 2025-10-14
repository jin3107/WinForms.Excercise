using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tuan5.Bai1a.DAO;

namespace Tuan5.Bai1a.GUI
{
    public partial class Form1 : Form
    {
        private Database db;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Bai1a_Load(object sender, EventArgs e)
        {
            db = new Database("RAINY", "QLSV_Tuan5");
            dt = db.LayDL("SELECT MaLop, TenLop FROM Lop");

            if (dt.Rows.Count > 0)
            {
                dtgDS.DataSource = dt;
                cbbLop.DataSource = dt;
                cbbLop.DisplayMember = "TenLop";
                cbbLop.ValueMember = "MaLop";
            }
            else
            {
                MessageBox.Show("Không có dữ liệu lớp.");
            }
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLop = cbbLop.Text;
            lblDS.Text = "Danh sách sinh viên của lớp " + tenLop;

            string maLop = cbbLop.SelectedValue.ToString();
            dt = db.LayDL($"Select MaSV, TenSV, Phai, NgaySinh, DiaChi, DienThoai, MaLop From SinhVien Where MaLop like '{maLop}'");
            dtgDS.DataSource = dt;
        }
    }
}
