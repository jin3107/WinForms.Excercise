using QuanLySach.DAO;
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
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPSach)
                LoadSach();
            else if (tabControl.SelectedTab == tabPTaiLieu)
                LoadTaiLieu();
            else if (tabControl.SelectedTab == tabPHocPhan)
                LoadHocPhan();
        }

        // Sách
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

        // Học Phần
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

        // Tài liệu
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
                txtMaHP_TaiLieu.Text = item.SubItems[2].Text;
                txtMaSach_TaiLieu.Text = item.SubItems[3].Text;
                txtNamTK.Text = item.SubItems[4].Text;
            }
        }
    }
}
