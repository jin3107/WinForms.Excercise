using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BS9
{
    public partial class Cau2 : Form
    {
        private SqlConnection cn;

        public Cau2()
        {
            InitializeComponent();
        }

        private void Cau2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=localhost;Initial Catalog=QLTOUR;Integrated Security=True;");
            HienThiCheckListBoxDiaDanh();
            HienThiCombobocTinhTP();
        }

        private void HienThiCombobocTinhTP()
        {
            string query = "SELECT MATINH FROM TINHTP";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTinhTP.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                cbbTinhTP.Items.Add(dr[0].ToString());
            }
        }

        private void HienThiCheckListBoxDiaDanh()
        {
            string query = "SELECT TENDD FROM DIADANH";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clbDMDD.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                clbDMDD.Items.Add(dr[0].ToString());
            }
        }

        private void clbDMDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diaDanh = clbDMDD.SelectedItem.ToString();
            string query = $"SELECT MaDD, TenDD, MaTinh FROM DIADANH WHERE TenDD LIKE N'{diaDanh}'";
            HienThiTrenControl(query);

            string newQuery = "SELECT TenTour, Songay, Giave, Phuongtien " +
                "FROM TOURDL T, CHITIET C, DIADANH D " +
                $"WHERE C.MaTour = T.MaTour and C.MaDD = D.MaDD and TenDD like N'{diaDanh}'";
            HienThiListView(newQuery);
        }

        private void HienThiListView(string newQuery)
        {
            SqlDataAdapter da = new SqlDataAdapter(newQuery, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstvTourDiaDanh.Items.Clear();
            int stt = 1;
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(PhuongTien(Convert.ToInt32(dr[3])));
                lstvTourDiaDanh.Items.Add(item);
                stt++;
            }
        }

        private string PhuongTien(int maPT)
        {
            switch (maPT)
            {
                case 0: return "Xe ghế ngã";
                case 1: return "Tàu hỏa";
                case 2: return "Máy bay";
                case 3: return "Tàu supperdong";
                default: return "Không xác định";
            }
        }

        private void HienThiTrenControl(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            XoaTrangControl();
            foreach (DataRow dr in dt.Rows)
            {
                string maDD = dr[0].ToString();
                string kq = maDD.Replace(" ", "");
                txtMaDD.Text = kq;
                txtTenDD.Text = dr[1].ToString();
                cbbTinhTP.Text = dr[2].ToString();
                string imagePath = $"{kq}.jpg";
                if (System.IO.File.Exists(imagePath))
                {
                    picAnhMinhHoa.Image = Image.FromFile(imagePath);
                    picAnhMinhHoa.SizeMode = PictureBoxSizeMode.StretchImage;
                    picAnhMinhHoa.Visible = true;
                }
                else
                {
                    picAnhMinhHoa.Image = null;
                    picAnhMinhHoa.Visible = false;
                }
            }
        }

        private void XoaTrangControl()
        {
            txtMaDD.Text = "";
            txtTenDD.Text = "";
            cbbTinhTP.Text = "";
            if (picAnhMinhHoa.Image != null)
            {
                picAnhMinhHoa.Image.Dispose();
                picAnhMinhHoa.Image = null;
            }
            picAnhMinhHoa.Visible = false;
            txtMaDD.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DIADANH (MaDD, TenDD, MaTinh) VALUES (@MaDD, @TenDD, @MaTinh)";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@MaDD", txtMaDD.Text);
                cmd.Parameters.AddWithValue("@TenDD", txtTenDD.Text);
                cmd.Parameters.AddWithValue("@MaTinh", cbbTinhTP.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                HienThiCheckListBoxDiaDanh();
                MessageBox.Show("Ghi thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lstvTourDiaDanh.Items.Clear();
            XoaTrangControl();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập nhật")
            {
                CapNhatDL();
            }
            else if (btnCapNhat.Text == "Hủy")
            {
                XoaDL();
                btnCapNhat.Text = "Cập nhật";
            }
        }

        private void XoaDL()
        {
            string diaDanh = clbDMDD.SelectedItem.ToString();
            string maDD = MaDiaDanh(diaDanh);
            string query = $"DELETE FROM DIADANH WHERE MaDD = '{maDD}'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Hủy địa danh thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiCheckListBoxDiaDanh();
        }

        private string MaDiaDanh(string diaDanh)
        {
            string query = $"SELECT MaDD FROM DIADANH WHERE TenDD like N'%{diaDanh}%'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                return dr[0].ToString();
            }
            return string.Empty;
        }

        private void CapNhatDL()
        {
            string query = @"UPDATE DIADANH SET TenDD = @TenDD, MaTinh = @MaTinh WHERE MaDD = @MaDD";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@MaDD", txtMaDD.Text);
                cmd.Parameters.AddWithValue("@TenDD", txtTenDD.Text);
                cmd.Parameters.AddWithValue("@MaTinh", cbbTinhTP.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Cập nhật địa danh thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiCheckListBoxDiaDanh();
                btnCapNhat.Text = "Hủy";
            }
        }
    }
}
