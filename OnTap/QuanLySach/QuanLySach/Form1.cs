using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=localhost;Initial Catalog=QLNSN;Integrated Security=True;");
            HienThiListBox();
        }

        private void HienThiListBox()
        {
            string tenTheLoai = "select TenTheLoai from THELOAI";
            SqlDataAdapter da = new SqlDataAdapter(tenTheLoai, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstbDSTLSach.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                lstbDSTLSach.Items.Add(dr[0].ToString());
            }
        }

        private void HienThiGridViewData(string newQuery)
        {
            SqlDataAdapter da = new SqlDataAdapter(newQuery, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSach.DataSource = null;
            dgvSach.DataSource = dt;
        }

        private void lstbDSTLSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenTheLoai = lstbDSTLSach.SelectedItem.ToString();
            string query = $"select MaTheLoai, TenTheLoai from THELOAI where TenTheLoai like N'%{tenTheLoai}%'";
            HienThiControl(query);

            string maTheLoai = LayMaTheLoai(tenTheLoai);
            string newQuery = $"select * from Sach where MaTheLoai like '%{maTheLoai}%'";
            HienThiGridViewData(newQuery);
        }

        private string LayMaTheLoai(string tenTheLoai)
        {
            string theLoai = $"select MaTheLoai from THELOAI where TenTheLoai like N'%{tenTheLoai}%'";
            SqlCommand cmd = new SqlCommand(theLoai, cn);
            cn.Open();
            string maTheLoai = (string)cmd.ExecuteScalar();
            cn.Close();
            return maTheLoai;
        }

        private void HienThiControl(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtMaTL.Text = dr[0].ToString();
                txtTenTL.Text = dr[1].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 1 MaTheLoai FROM THELOAI ORDER BY MaTheLoai DESC";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            string lastCode = (string)cmd.ExecuteScalar() ?? "TL00";
            cn.Close();

            string numberPart = lastCode.Substring(2);
            int nextNumber = int.Parse(numberPart) + 1;
            string newCode = $"TL{nextNumber:D2}";
            txtMaTL.Text = newCode;
            txtTenTL.Clear();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TheLoai ([MaTheLoai], [TenTheLoai]) VALUES (@MaTheLoai, @TenTheLoai)";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@MaTheLoai", txtMaTL.Text);
                cmd.Parameters.AddWithValue("@TenTheLoai", txtTenTL.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            txtMaTL.Clear();
            txtTenTL.Clear();
            MessageBox.Show("Ghi thành công", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiListBox();
        }
    }
}
