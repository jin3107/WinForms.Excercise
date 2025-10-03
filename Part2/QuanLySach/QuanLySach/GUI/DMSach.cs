using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.GUI
{
    public partial class DMSach : Form
    {
        private DataTable dt;
        private SachDAO sachDAO;
        private TaiLieuDAO taiLieuDAO;
        private HocPhanDAO hocPhanDAO;
        private int i = 0;

        public DMSach()
        {
            InitializeComponent();
        }

        private void DMSach_Load(object sender, EventArgs e)
        {
            sachDAO = new SachDAO("RAINY", "QLSach");
            taiLieuDAO = new TaiLieuDAO("RAINY", "QLSach");
            hocPhanDAO = new HocPhanDAO("RAINY", "QLSach");
            LoadSach();
            BatTatChucNangSach(true);
        }

        #region Điều khiển tab 
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPSach)
            {
                LoadSach();
                BatTatChucNangSach(true);
            }
            else if (tabControl.SelectedTab == tabPTaiLieu)
            {
                LoadTaiLieu();
                HienThiComboboxMaHP();
                HienThiComboboxMaSach();
                BatTatChucNangTaiLieu(true);
                cbbMaSach_TL.DropDownStyle = ComboBoxStyle.DropDownList;
                cbbMaHP_TL.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (tabControl.SelectedTab == tabPHocPhan)
            {
                LoadHocPhan();
                BatTatChucNangHP(true);
            }
        }
        #endregion

        #region Hàm lấy dữ liệu Sách
        private void LoadSach()
        {
            dt = sachDAO.GetAll();
            i = 0;
            HienThiListViewSach(dt);
        }

        private void HienThiListViewSach(DataTable dt)
        {
            lstvSach.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = CreateItemSach(dr);
                lstvSach.Items.Add(item);
            }
        }

        private ListViewItem CreateItemSach(DataRow dr)
        {
            i++;
            ListViewItem item = new ListViewItem(i.ToString());
            item.SubItems.Add(dr[0].ToString());
            item.SubItems.Add(dr[1].ToString());
            item.SubItems.Add(dr[2].ToString());
            item.SubItems.Add(dr[3].ToString());
            item.SubItems.Add(dr[4].ToString());
            return item;
        }

        private void lstvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvSach.SelectedItems[0];
                txtMaSach.Text = item.SubItems[1].Text;
                txtTenSach.Text = item.SubItems[2].Text;
                txtTacGia.Text = item.SubItems[3].Text;
                txtNhaXB.Text = item.SubItems[4].Text;
                txtNamXB.Text = item.SubItems[5].Text;
            }
        }
        #endregion

        #region Hàm lấy dữ liệu Học Phần
        private void LoadHocPhan()
        {
            dt = hocPhanDAO.GetAll();
            i = 0;
            HienThiListViewHocPhan(dt);
        }

        private void HienThiListViewHocPhan(DataTable dt)
        {
            lstvHocPhan.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = CreateItemHocPhan(dr);
                lstvHocPhan.Items.Add(item);
            }
        }

        private ListViewItem CreateItemHocPhan(DataRow dr)
        {
            i++;
            ListViewItem item = new ListViewItem(i.ToString());
            item.SubItems.Add(dr[0].ToString());
            item.SubItems.Add(dr[1].ToString());
            item.SubItems.Add(dr[2].ToString());
            return item;
        }

        private void lstvHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvHocPhan.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvHocPhan.SelectedItems[0];
                txtMaHP.Text = item.SubItems[1].Text;
                txtTenHP.Text = item.SubItems[2].Text;
                txtSoTC.Text = item.SubItems[3].Text;
            }
        }
        #endregion

        #region Hàm lấy dữ liệu Tài liệu
        private void LoadTaiLieu()
        {
            dt = taiLieuDAO.GetAll();
            i = 0;
            HienThiListViewTaiLieu(dt);
        }

        private void HienThiListViewTaiLieu(DataTable dt)
        {
            lstvTaiLieu.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = CreateItemTaiLieu(dr);
                lstvTaiLieu.Items.Add(item);
            }
        }

        private ListViewItem CreateItemTaiLieu(DataRow dr)
        {
            i++;
            ListViewItem item = new ListViewItem(i.ToString());
            item.SubItems.Add(dr[0].ToString());
            item.SubItems.Add(dr[1].ToString());
            item.SubItems.Add(dr[2].ToString());
            item.SubItems.Add(dr[3].ToString());
            return item;
        }

        private void lstvTaiLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvTaiLieu.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvTaiLieu.SelectedItems[0];
                txtMaTL.Text = item.SubItems[1].Text;
                cbbMaHP_TL.Text = item.SubItems[2].Text;
                cbbMaSach_TL.Text = item.SubItems[3].Text;
                txtNamTK.Text = item.SubItems[4].Text;
            }
        }

        #endregion

        #region Các chức năng của Sách
        private void btnThem_Sach_Click(object sender, EventArgs e)
        {
            BatTatChucNangSach(false);
            ClearSachInput();
        }

        private void ClearSachInput()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNhaXB.Text = "";
            txtNamXB.Text = "";
        }

        private void BatTatChucNangSach(bool gt)
        {
            btnGhi_Sach.Enabled = !gt;
            btnKhong_Sach.Enabled = !gt;
            btnThem_Sach.Enabled = gt;
            btnCapNhat_Sach.Enabled = gt;
            btnHuy_Sach.Enabled = gt;
        }

        private void btnKhong_Sach_Click(object sender, EventArgs e)
        {
            BatTatChucNangSach(true);
        }

        private void btnGhi_Sach_Click(object sender, EventArgs e)
        {
            try
            {
                Sach sach = new Sach(txtMaSach.Text, txtTenSach.Text, txtTacGia.Text, txtNhaXB.Text, int.Parse(txtNamXB.Text));
                if (sachDAO.Insert(sach))
                {
                    MessageBox.Show("Ghi sách thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSach();
                    ClearSachInput();
                    BatTatChucNangSach(true);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Ghi sách bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                BatTatChucNangSach(true);
            }
        }

        private void btnCapNhat_Sach_Click(object sender, EventArgs e)
        {
            try
            {
                Sach sach = new Sach(txtMaSach.Text, txtTenSach.Text, txtTacGia.Text, txtNhaXB.Text, int.Parse(txtNamXB.Text));
                if (sachDAO.Update(sach))
                {
                    MessageBox.Show("Cập nhật sách thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSach();
                    ClearSachInput();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật sách bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Sach_Click(object sender, EventArgs e)
        {
            try
            {
                if (sachDAO.Delete(txtMaSach.Text))
                {
                    MessageBox.Show("Xoá/Huỷ sách thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSach();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Xoá/Huỷ sách bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Các chức năng của Học phần
        private void btnThem_HP_Click(object sender, EventArgs e)
        {
            BatTatChucNangHP(false);
            ClearHPInput();
        }

        private void BatTatChucNangHP(bool gt)
        {
            btnGhi_HP.Enabled = !gt;
            btnKhong_HP.Enabled = !gt;
            btnThem_HP.Enabled = gt;
            btnCapNhat_HP.Enabled = gt;
            btnHuy_HP.Enabled = gt;
        }

        private void ClearHPInput()
        {
            txtMaHP.Text = "";
            txtTenHP.Text = "";
            txtSoTC.Text = "";
        }

        private void btnGhi_HP_Click(object sender, EventArgs e)
        {
            try
            {
                HocPhan hocPhan = new HocPhan(txtMaHP.Text, txtTenHP.Text, int.Parse(txtSoTC.Text));
                if (hocPhanDAO.Insert(hocPhan))
                {
                    MessageBox.Show("Ghi học phần thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHocPhan();
                    ClearHPInput();
                    BatTatChucNangHP(true);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Ghi học phần bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                BatTatChucNangHP(true);
            }
        }

        private void btnKhong_HP_Click(object sender, EventArgs e)
        {
            BatTatChucNangHP(true);
        }

        private void btnCapNhat_HP_Click(object sender, EventArgs e)
        {
            try
            {
                HocPhan hocPhan = new HocPhan(txtMaHP.Text, txtTenHP.Text, int.Parse(txtSoTC.Text));
                if (hocPhanDAO.Update(hocPhan))
                {
                    MessageBox.Show("Cập nhật học phần thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHocPhan();
                    ClearHPInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật sách bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_HP_Click(object sender, EventArgs e)
        {
            try
            {
                if (hocPhanDAO.Delete(txtMaHP.Text))
                {
                    MessageBox.Show("Xoá/Huỷ học phần thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHocPhan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá/Huỷ học phần bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        private void HienThiComboboxMaSach()
        {
            cbbMaSach_TL.Items.Clear();
            dt = sachDAO.GetId();
            foreach (DataRow r in dt.Rows)
            {
                cbbMaSach_TL.Items.Add(r["MaSach"].ToString());
            }
        }

        private void HienThiComboboxMaHP()
        {
            cbbMaHP_TL.Items.Clear();
            dt = hocPhanDAO.GetId();
            foreach(DataRow r in dt.Rows)
            {
                cbbMaHP_TL.Items.Add(r["MaHP"].ToString());
            }
        }

        private void btnThem_TaiLieu_Click(object sender, EventArgs e)
        {
            BatTatChucNangTaiLieu(false);
            ClearTaiLieuInput();
        }

        private void BatTatChucNangTaiLieu(bool gt)
        {
            btnGhi_TaiLieu.Enabled = !gt;
            btnKhong_TaiLieu.Enabled = !gt;
            btnThem_TaiLieu.Enabled = gt;
            btnCapNhat_TaiLieu.Enabled = gt;
            btnHuy_TaiLieu.Enabled = gt;
        }

        private void ClearTaiLieuInput()
        {
            txtMaTL.Text = "";
            txtNamTK.Text = "";
        }

        private void btnGhi_TaiLieu_Click(object sender, EventArgs e)
        {
            try
            {
                TaiLieu taiLieu = new TaiLieu(txtMaTL.Text, cbbMaHP_TL.Text, cbbMaSach_TL.Text, int.Parse(txtNamTK.Text));
                if (taiLieuDAO.Insert(taiLieu))
                {
                    MessageBox.Show("Ghi tài liệu thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiLieu();
                    ClearTaiLieuInput();
                    BatTatChucNangTaiLieu(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi tài liệu bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                BatTatChucNangTaiLieu(true);
            }
        }

        private void btnKhong_TaiLieu_Click(object sender, EventArgs e)
        {
            BatTatChucNangTaiLieu(true);
        }

        private void btnCapNhat_TaiLieu_Click(object sender, EventArgs e)
        {
            try
            {
                TaiLieu taiLieu = new TaiLieu(txtMaTL.Text, cbbMaHP_TL.Text, cbbMaSach_TL.Text, int.Parse(txtNamTK.Text));
                if (taiLieuDAO.Update(taiLieu))
                {
                    MessageBox.Show("Cập nhật tài liệu thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiLieu();
                    ClearTaiLieuInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tài liệu bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_TaiLieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (taiLieuDAO.Delete(txtMaTL.Text))
                {
                    MessageBox.Show("Xoá/Huỷ tài liệu thành công.", "Chi tiết",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá/Huỷ tài liệu bị lỗi.\nCụ thể: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
