using QuanLyShow_CrystalReport.DAO;
using QuanLyShow_CrystalReport.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShow_CrystalReport.GUI
{
    public partial class FormQLShow : Form
    {
        Database db;

        public FormQLShow()
        {
            InitializeComponent();
        }

        private void FormQLShow_Load(object sender, EventArgs e)
        {
            db = new Database("localhost", "QLSHOW");
            SangMo(true);
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            tvwDiaChiSanKhau.Nodes.Clear();
            DataTable dtCaSiChinh = db.ExcuteQuery("select MaCS, nghedanh from CASI");
            cbbCaSiChinh.DataSource = dtCaSiChinh;
            cbbCaSiChinh.DisplayMember = "nghedanh";
            cbbCaSiChinh.ValueMember = "macs";

            //DataTable dtCaSiDH = db.ExcuteQuery("select MaCS, nghedanh from CASI");
            //cbbCaSiDongHanh.DataSource = dtCaSiDH;
            cbbCaSiDongHanh.DataSource = dtCaSiChinh;
            cbbCaSiDongHanh.DisplayMember = "nghedanh";
            cbbCaSiDongHanh.ValueMember = "macs";

            DataTable dtTreeViewShowCSC = db.ExcuteQuery("select madd, tendiadiem from sankhau");
            for (int i = 0; i < dtTreeViewShowCSC.Rows.Count; i++)
            {
                TreeNode n = new TreeNode();
                n.Text = dtTreeViewShowCSC.Rows[i][1].ToString();
                n.Tag = dtTreeViewShowCSC.Rows[i][0].ToString();
                DataTable dtTreeViewNgayDBCSC = db.ExcuteQuery("select mashow, format(ngaybd, 'dd/MM/yyyy') + '_' + c.nghedanh " +
                    "from sankhau sk, show s, casi c " +
                    $"where sk.MaDD = s.MaDD and s.Casichinh = c.MaCS and sk.madd like '{n.Tag.ToString()}'");

                for (int j = 0; j < dtTreeViewNgayDBCSC.Rows.Count; j++)
                {
                    TreeNode m = new TreeNode();
                    m.Text = dtTreeViewNgayDBCSC.Rows[j][1].ToString();
                    m.Tag = dtTreeViewNgayDBCSC.Rows[j][0].ToString();
                    n.Nodes.Add(m);
                }
                
                tvwDiaChiSanKhau.Nodes.Add(n);
            }
        }

        private void SangMo(bool v)
        {
            btnThem.Enabled = v;
            btnXoa.Enabled = v;
            btnInBaoCao.Enabled = v;
            btnGhi.Enabled = !v;
            btnKhong.Enabled = !v;
        }

        private void tvwDiaChiSanKhau_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode n = tvwDiaChiSanKhau.SelectedNode;
            if (n == null)
                return;
            if (n.Parent == null)
            {
                string madd = n.Tag.ToString();
                DataTable dt = db.ExcuteQuery(
                    "SELECT MaCS, cs.Nghedanh, sh.Ngaybd " +
                    "FROM SHOW sh, CASI cs " +
                    $"WHERE(cs.MaCS = sh.Casichinh OR cs.MaCS = sh.CSdonghanh)  AND sh.MaDD = '{madd}'");
                dgvShow.DataSource = dt;

                DataTable dtDiaDiem = db.ExcuteQuery($"select TenDiaDiem from sankhau where madd like '%{madd}%'");
                string diadiem = string.Empty;
                if (dtDiaDiem.Rows.Count > 0)
                {
                    diadiem = dtDiaDiem.Rows[0][0].ToString();
                }
                lblDSShow.Text = "Danh sách các show tại " + diadiem;

                string sqlDem = $@"select count(DISTINCT Sh.Casichinh) as TongSoCaSi
                    from CASI C, SHOW Sh
                    where(C.MaCS = Sh.Casichinh or C.MaCS = Sh.CSdonghanh) and Sh.MaDD like '%{madd}%'";
                lblTongsoCS.Text = "Tổng số ca sĩ biểu diễn: " + db.FindBy(sqlDem);
            }
            else
            {
                string mashowcasichinh = tvwDiaChiSanKhau.SelectedNode.Tag.ToString();
                string sql = $@"
                    select sh.Mashow, c1.Nghedanh as Casichinh,
                        ISNULL((select Nghedanh from casi where MaCS = sh.CSdonghanh), '') as CSdonghanh,
                        sh.Ngaybd, sh.Giobd
                    from show sh, casi c1
                    where sh.Casichinh = c1.MaCS 
                        and sh.Mashow = '{mashowcasichinh}'";

                DataTable dt = db.ExcuteQuery(sql);
                if (dt.Rows.Count > 0)
                    HienThiDongBo(dt.Rows[0]);

            }
        }

        private void HienThiDongBo(DataRow row)
        {
            txtMaShow.Text = row[0].ToString();
            cbbCaSiChinh.Text = row[1].ToString();
            cbbCaSiDongHanh.Text = row[2].ToString();
            dtpNgayBD.Value = DateTime.Parse(row[3].ToString());
            txtGioDB.Text = row[4].ToString();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            SangMo(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTrangControl();
            SangMo(false);
            txtMaShow.Clear();
            txtMaShow.Focus();
        }

        private void XoaTrangControl()
        {
            cbbCaSiChinh.Text = "";
            cbbCaSiDongHanh.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            txtGioDB.Text = "";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            // Validation: Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaShow.Text))
            {
                MessageBox.Show("Vui lòng nhập mã show", "Thông báo");
                txtMaShow.Focus();
                return;
            }

            if (cbbCaSiChinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ca sĩ chính", "Thông báo");
                cbbCaSiChinh.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGioDB.Text))
            {
                MessageBox.Show("Vui lòng nhập giờ biểu diễn", "Thông báo");
                txtGioDB.Focus();
                return;
            }

            // Validation: Ca sĩ chính phải khác ca sĩ đồng hành
            if (cbbCaSiDongHanh.SelectedValue != null && 
                cbbCaSiChinh.SelectedValue.ToString() == cbbCaSiDongHanh.SelectedValue.ToString())
            {
                MessageBox.Show("Ca sĩ chính phải khác ca sĩ đồng hành", "Thông báo");
                cbbCaSiDongHanh.Focus();
                return;
            }

            // Kiểm tra địa điểm được chọn
            TreeNode selectedNode = tvwDiaChiSanKhau.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Vui lòng chọn địa điểm trong danh sách", "Thông báo");
                return;
            }

            // Lấy mã địa điểm từ node cha (nếu đang chọn node con) hoặc node hiện tại
            string maDD = selectedNode.Parent != null ? selectedNode.Parent.Tag.ToString() : selectedNode.Tag.ToString();

            string sql = "INSERT INTO Show(MaShow, Ngaybd, Casichinh, CSdonghanh, Giobd, MaDD) " +
                "VALUES(@mashow, @ngaybd, @casichinh, @casidonghanh, @giobd, @madd)";
            
            SqlCommand cmd = new SqlCommand(sql, db.connection);
            cmd.Parameters.AddWithValue("@mashow", txtMaShow.Text.Trim());
            cmd.Parameters.AddWithValue("@ngaybd", dtpNgayBD.Value.Date);
            cmd.Parameters.AddWithValue("@casichinh", cbbCaSiChinh.SelectedValue);
            
            // Xử lý ca sĩ đồng hành có thể null
            if (cbbCaSiDongHanh.SelectedValue != null && !string.IsNullOrWhiteSpace(cbbCaSiDongHanh.Text))
                cmd.Parameters.AddWithValue("@casidonghanh", cbbCaSiDongHanh.SelectedValue);
            else
                cmd.Parameters.AddWithValue("@casidonghanh", DBNull.Value);
            
            cmd.Parameters.AddWithValue("@giobd", txtGioDB.Text);
            cmd.Parameters.AddWithValue("@madd", maDD);
            try
            {
                db.ExecuteNonQuery(cmd);
                MessageBox.Show("Đã thêm thành công", "Thông báo");
                LoadTreeView();
                SangMo(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Show Where MaShow = @mashow";
            SqlCommand cmd = new SqlCommand(sql, db.connection);
            cmd.Parameters.AddWithValue("@mashow", txtMaShow.Text);
            try
            {
                db.ExecuteNonQuery(cmd);
                MessageBox.Show("Đã xóa thành công", "Thông báo");
                LoadTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            FormReport frm = new FormReport();
            frm.ShowDialog();
        }
    }
}
    