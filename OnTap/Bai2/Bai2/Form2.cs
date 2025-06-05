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

namespace Bai2
{
    public partial class Form2 : Form
    {
        private SqlConnection cn;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=localhost;Initial Catalog=ENVIROMENT;Integrated Security=True;");
            HienThiListBoxTinh();
            HienThiCombobox();
            string dsChienDich = "select tencd from chiendich";
            HienThiListBoxChienDich(dsChienDich);
        }

        private void HienThiListBoxChienDich(string dsChienDich)
        {
            SqlDataAdapter da = new SqlDataAdapter(dsChienDich, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstbDSChienDich.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                lstbDSChienDich.Items.Add(dr[0].ToString());
        }

        private void HienThiCombobox()
        {
            string sql = "select tentc from tochuc";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTCTH.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                cbbTCTH.Items.Add(dr[0].ToString());
        }

        private void HienThiListBoxTinh()
        {
            string sql = "select tinh from diadiem";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstbDSTinh.Items.Clear();
            foreach (DataRow dr in dt.Rows)
                lstbDSTinh.Items.Add(dr[0].ToString());
        }

        private void lstbDSTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinh = lstbDSTinh.SelectedItem.ToString();
            string sql = "select hoatdongchinh, trangthai " +
                "from trienkhaichiendich tk, diadiem dd " +
                $"where tk.madd = dd.madd and dd.tinh like N'%{tinh}%'";
            HienThiListView(sql);
        }

        private void HienThiListView(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lstvHoatDong.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                lstvHoatDong.Items.Add(item);
            }
        }

        private void HienThiDataGridView(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCTCD.DataSource = null;
            dgvCTCD.DataSource = dt;
        }

        private void lstbDSChienDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chienDich = lstbDSChienDich.SelectedItem.ToString();
            string sql = "select distinct tencd, mota, ngaybd, ngaykt, matc " +
                "from chiendich cd, trienkhaichiendich tk, diadiem dd " +
                $"where cd.Macd = tk.macd and tk.madd = dd.madd and cd.tencd like N'%{chienDich}%'";
            HienThiDataGridView(sql);

            if (dgvCTCD.CurrentRow != null)
            {
                string newsql = "select distinct tk.macd, tencd, mota, ngaybd, ngaykt, " +
                    "(select tentc from tochuc where matc = cd.matc) as tentc " +
                    "from chiendich cd, trienkhaichiendich tk " +
                    $"where cd.macd = tk.macd and cd.tencd = N'{dgvCTCD.CurrentRow.Cells["tencd"].Value.ToString()}'";
                HienThiControl(newsql);
            }
        }

        private void HienThiControl(string newsql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(newsql, cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                txtMaCD.Text = item[0].ToString();
                txtTenCD.Text = item[1].ToString();
                txtMoTa.Text = item[2].ToString();
                dtpNgayBD.Text = item[3].ToString();
                dtpNgayKT.Text = item[4].ToString();
                cbbTCTH.Text = item[5].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                XoaTrangControl();
                btnThem.Text = "Ghi";
            }
            else
            {
                string tenToChuc = cbbTCTH.Text;
                int maToChuc = LayMaToChuc(tenToChuc);
                LuuDL(maToChuc);
                XoaTrangControl();
                btnThem.Text = "Thêm";
                MessageBox.Show("Ghi thành công");

                string dsChienDich = "SELECT TenCD FROM CHIENDICH";
                HienThiListBoxChienDich(dsChienDich);
            }
        }

        private int LayMaToChuc(string tenToChuc)
        {
            string toChuc = $"SELECT MATC FROM TOCHUC WHERE TENTC LIKE N'{tenToChuc}'";
            SqlCommand cmd = new SqlCommand(toChuc, cn);
            cn.Open();
            int result = (int)cmd.ExecuteScalar();
            cn.Close();
            return result;
        }

        private void LuuDL(int maToChuc)
        {
            string query = "INSERT INTO CHIENDICH (TenCD, Mota, Ngaybd, Ngaykt, MaTC) VALUES (@TenCD, @Mota, @Ngaybd, @Ngaykt, @MaTC)";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@TenCD", txtTenCD.Text);
                cmd.Parameters.AddWithValue("@Mota", txtMoTa.Text);
                cmd.Parameters.AddWithValue("@Ngaybd", dtpNgayBD.Value);
                cmd.Parameters.AddWithValue("@Ngaykt", dtpNgayKT.Value);
                cmd.Parameters.AddWithValue("@MaTC", maToChuc);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void XoaTrangControl()
        {
            txtMaCD.Text = "";
            txtTenCD.Text = "";
            txtMoTa.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
            cbbTCTH.Text = "";
            txtMaCD.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string toChuc = cbbTCTH.Text;
                int maTC = LayMaToChuc(toChuc);
                cn.Close();
                CapNhatDL(maTC);
                cn.Close();
                MessageBox.Show("Cập nhật thành công");
                string dsChienDich = "SELECT TenCD FROM CHIENDICH";
                HienThiListBoxChienDich(dsChienDich);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void CapNhatDL(int maTC)
        {
            string query = $"UPDATE CHIENDICH SET TenCD = N'{txtTenCD.Text}', Mota = N'{txtMoTa.Text}', " +
                          $"Ngaybd = '{dtpNgayBD.Value.ToShortDateString()}', Ngaykt = '{dtpNgayKT.Value.ToShortDateString()}', " +
                          $"MaTC = {maTC} WHERE MaCD = '{txtMaCD.Text}'";
            SqlCommand sqlCommand = new SqlCommand(query, cn);
            cn.Open();
            sqlCommand.ExecuteNonQuery();
            cn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCD = txtMaCD.Text;
            XoaDL(maCD);
            XoaTrangControl();

            string dsChienDich = "SELECT TenCD FROM CHIENDICH";
            HienThiListBoxChienDich(dsChienDich);
        }

        private void XoaDL(string maCD)
        {
            // Trước hết cần xóa trong bảng TRIENKHAICHIENDICH
            string queryTrienKhai = $"DELETE FROM TRIENKHAICHIENDICH WHERE MaCD = '{maCD}'";
            SqlCommand cmdTrienKhai = new SqlCommand(queryTrienKhai, cn);
            cn.Open();
            cmdTrienKhai.ExecuteNonQuery();
            cn.Close();

            // Sau đó xóa trong bảng CHIENDICH
            string queryChienDich = $"DELETE FROM CHIENDICH WHERE MaCD = '{maCD}'";
            SqlCommand cmdChienDich = new SqlCommand(queryChienDich, cn);
            cn.Open();
            cmdChienDich.ExecuteNonQuery();
            cn.Close();
        }
    }
}
