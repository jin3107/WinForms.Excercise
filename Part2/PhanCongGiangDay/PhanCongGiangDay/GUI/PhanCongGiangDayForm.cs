using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanCongGiangDay.DAO;
using PhanCongGiangDay.DTO;
using System.Data.SqlClient;

namespace PhanCongGiangDay.GUI
{
    public partial class PhanCongGiangDayForm : Form
    {
        Database db;

        public PhanCongGiangDayForm()
        {
            InitializeComponent();
        }

        private void PhanCongGiangDayForm_Load(object sender, EventArgs e)
        {
            db = new Database("localhost", "QLGV");
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            tvwDMGD.Nodes.Clear();
            DataTable dt = db.ExcuteQuery("Select MaGV, TenGV From GiangVien");
            cbbGV.DataSource = dt;
            cbbGV.DisplayMember = "TenGV";
            cbbGV.ValueMember = "MaGV";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TreeNode n = new TreeNode();
                n.Text = dt.Rows[i][1].ToString();
                n.Tag = dt.Rows[i][0].ToString();
                DataTable dt1 = db.ExcuteQuery("Select pc.MaHP " +
                    "From HOCPHAN hp, PHANCONG pc, GIANGVIEN gv " +
                    $"Where hp.MaHP = pc.MaHP and gv.MaGV = pc.MaGV and pc.MaGV = '{n.Tag.ToString()}'");
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    TreeNode m = new TreeNode();
                    m.Text = "Mã HP: " + dt1.Rows[j][0].ToString();
                    m.Tag = dt1.Rows[j][0].ToString();
                    n.Nodes.Add(m);
                }
                tvwDMGD.Nodes.Add(n);
            }
        }

        private void LoadControl(DataRow row)
        {
            txtMaHP.Text = row[0].ToString();
            txtTenHP.Text = row[1].ToString();
            numSoTiet.Value = int.Parse(row[2].ToString());
            cbbGV.Text = row[3].ToString();
        }

        private void tvwDMGD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode n = tvwDMGD.SelectedNode;
            if (n == null)
                return;
            if (n.Parent == null)
            {
                string maGV = n.Tag.ToString();

                DataTable dthp = db.ExcuteQuery(
                    "SELECT MaLop, pc.MaHP, TenHP, SoTiet " +
                    "FROM HOCPHAN hp, PHANCONG pc " +
                    $"WHERE hp.MaHP = pc.MaHP and pc.MaGV = '{maGV}'");
                dtgHocPhan.DataSource = dthp;

                string daDay = db.FindBy($"SELECT COUNT(*) FROM PHANCONG WHERE MaGV = '{maGV}'");
                lblHPDD.Text = "Số học phần đã dạy: " + daDay;
                string chuaDay = db.FindBy("SELECT COUNT(*)  " +
                    "FROM PHANCONG  " +
                    $"WHERE MaGV = '{maGV}' AND (TrinhTrang = 0 OR TrinhTrang IS NULL)");
                lblHPCD.Text = "Số học phần chưa dạy: " + chuaDay;
            }
            else
            {
                string maHP = n.Tag.ToString();
                string sql = "Select pc.MaHP, TenHP, SoTiet, TenGV " +
                    "From HOCPHAN hp, PHANCONG pc, GIANGVIEN gv " +
                    $"Where hp.MaHP = pc.MaHP and gv.MaGV = pc.MaGV and pc.MaHP = '{maHP}'";
                DataTable dt = db.ExcuteQuery(sql);
                if (dt.Rows.Count > 0)
                    LoadControl(dt.Rows[0]);
            }
        }

        private void MaSVTang()
        {
            int nextId = int.Parse(db.FindBy("Select Count(*) From SinhVien")) + 1;
            txtMaHP.Text = $"HP0{nextId}";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tvwDMGD.SelectedNode == null || tvwDMGD.SelectedNode.Parent != null)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên trên TreeView!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maGV = tvwDMGD.SelectedNode.Tag.ToString();
            try
            {
                string sqlHocPhanChuaPhanCong = "SELECT MaHP FROM HOCPHAN WHERE MaHP NOT IN " +
                    $"(SELECT MaHP FROM PHANCONG WHERE MaGV = '{maGV}')";

                DataTable dtHocPhan = db.ExcuteQuery(sqlHocPhanChuaPhanCong);
                if (dtHocPhan.Rows.Count == 0)
                {
                    MessageBox.Show("Không có học phần nào chưa được phân công cho giảng viên này!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int count = 0;
                foreach (DataRow row in dtHocPhan.Rows)
                {
                    string maHP = row["MaHP"].ToString();

                    // Thêm phân công mới với MaLop = DHCNTT16, TrinhTrang để trống (NULL)
                    string sqlInsert = "INSERT INTO PHANCONG (MaGV, MaHP, MaLop, TrinhTrang) " +
                        $"VALUES ('{maGV}', '{maHP}', 'DHCNTT16', NULL)";

                    SqlCommand cmd = new SqlCommand(sqlInsert, db.connection);
                    db.ExecuteNonQuery(cmd);
                    count++;
                }

                MessageBox.Show($"Đã thêm {count} học phần cho giảng viên!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTreeView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phân công: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetControl()
        {
            MaSVTang();
            txtMaHP.Enabled = false;
            txtTenHP.Text = "";
            numSoTiet.Value = 1;
            cbbGV.SelectedValue = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tvwDMGD.SelectedNode == null || tvwDMGD.SelectedNode.Parent != null)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên trên TreeView!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maGV = tvwDMGD.SelectedNode.Tag.ToString();
            try
            {
                string sqlCount = "SELECT COUNT(*) FROM PHANCONG " +
                    $"WHERE MaGV = '{maGV}' AND (TrinhTrang = 0 OR TrinhTrang IS NULL)";
                string countStr = db.FindBy(sqlCount);
                int count = int.Parse(countStr);
                if (count == 0)
                {
                    MessageBox.Show("Không có học phần chưa dạy nào để xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa {count} học phần chưa dạy của giảng viên này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlDelete = "DELETE FROM PHANCONG " +
                        $"WHERE MaGV = '{maGV}' AND (TrinhTrang = 0 OR TrinhTrang IS NULL)";
                    SqlCommand cmd = new SqlCommand(sqlDelete, db.connection);
                    db.ExecuteNonQuery(cmd);
                    MessageBox.Show($"Đã xóa {count} học phần chưa dạy!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTreeView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phân công: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (tvwDMGD.SelectedNode == null || tvwDMGD.SelectedNode.Parent != null)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên trên TreeView!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maGV = tvwDMGD.SelectedNode.Tag.ToString();
            string tenGV = tvwDMGD.SelectedNode.Text;
            try
            {
                string sql = "SELECT pc.MaLop, pc.MaHP, hp.TenHP, hp.SoTiet, " +
                    "CASE WHEN pc.TrinhTrang IS NULL THEN N'Chưa dạy' " +
                    "WHEN pc.TrinhTrang = 0 THEN N'Chưa dạy' " +
                    "ELSE N'Đã dạy' END AS TinhTrang " +
                    "FROM PHANCONG pc, HOCPHAN hp " +
                    $"WHERE pc.MaHP = hp.MaHP and pc.MaGV = '{maGV}' " +
                    "ORDER BY pc.MaLop, pc.MaHP";
                DataTable dt = db.ExcuteQuery(sql);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Giảng viên này chưa được phân công học phần nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Form frmIn = new Form();
                frmIn.Text = "Thông tin giảng dạy - " + tenGV;
                frmIn.Size = new Size(800, 600);
                frmIn.StartPosition = FormStartPosition.CenterScreen;

                // Tạo DataGridView để hiển thị
                DataGridView dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.DataSource = dt;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ReadOnly = true;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.AllowUserToAddRows = false;

                // Tạo Label tiêu đề
                Label lblTitle = new Label();
                lblTitle.Text = $"THÔNG TIN GIẢNG DẠY - {tenGV}";
                lblTitle.Font = new Font("Arial", 14, FontStyle.Bold);
                lblTitle.TextAlign = ContentAlignment.MiddleCenter;
                lblTitle.Dock = DockStyle.Top;
                lblTitle.Height = 40;
                lblTitle.BackColor = Color.LightBlue;

                // Tạo Panel chứa thông tin thống kê
                Panel pnlThongKe = new Panel();
                pnlThongKe.Dock = DockStyle.Bottom;
                pnlThongKe.Height = 80;
                pnlThongKe.BackColor = Color.WhiteSmoke;

                Label lblThongKe = new Label();
                lblThongKe.AutoSize = false;
                lblThongKe.Dock = DockStyle.Fill;
                lblThongKe.Font = new Font("Arial", 10, FontStyle.Regular);
                lblThongKe.Padding = new Padding(10);

                string daDay = db.FindBy($"SELECT COUNT(*) FROM PHANCONG WHERE MaGV = '{maGV}' AND TrinhTrang = 1");
                string chuaDay = db.FindBy($"SELECT COUNT(*) FROM PHANCONG WHERE MaGV = '{maGV}' AND (TrinhTrang = 0 OR TrinhTrang IS NULL)");

                lblThongKe.Text = $"Tổng số học phần: {dt.Rows.Count}\n" +
                    $"Số học phần đã dạy: {daDay}\n" +
                    $"Số học phần chưa dạy: {chuaDay}";

                pnlThongKe.Controls.Add(lblThongKe);

                // Thêm các control vào form
                frmIn.Controls.Add(dgv);
                frmIn.Controls.Add(lblTitle);
                frmIn.Controls.Add(pnlThongKe);

                frmIn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
