using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Tuan5.Bai1b1.DAO;

namespace Tuan5.Bai1b1.GUI
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private Database db;
        int vt = 0;
        bool bat = false;
        BindingManagerBase mbm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Database("localhost", "QLSV_Tuan5");
            cbbTenMH.DataSource = db.LayDL("Select MaMH, TenMH From MonHoc");
            cbbTenMH.DisplayMember = "TenMH";
            cbbTenMH.ValueMember = "MaMH";
            bat = true;
        }

        private void cbbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bat)
            {
                string sql = "Select d.MaSV, TenSV, MaThi, Diem " +
                    "From Diem d, SinhVien sv " + 
                    $"Where d.MaSV = sv.MaSV and MaMH like '{cbbTenMH.SelectedValue.ToString()}'";
                dt = db.LayDL(sql);
                dtgDSSV.DataSource = dt;

                dt = db.LayDL(sql);
                mbm = BindingContext[dt];
                HienThiControl(dt);
            }
        }

        private void HienThiControl(DataTable dt)
        {
            int ts = dt.Rows.Count;
            if (ts == 0)
            {
                txtCurrent.Text = "Không có dữ liệu";
                ClearControl();
            }
            else
            {
                int vt = mbm.Position;
                txtMaSV.Text = dt.Rows[vt][0].ToString();
                txtTenSV.Text = dt.Rows[vt][1].ToString();
                txtLanThi.Text = dt.Rows[vt][2].ToString();
                txtDiem.Text = dt.Rows[vt][3].ToString();
                txtCurrent.Text = (vt + 1).ToString() + "/" + ts.ToString();
            }
        }

        private void ClearControl()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtLanThi.Text = "";
            txtDiem.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mbm.Position < mbm.Count - 1)
            {
                mbm.Position++;
                if (btnDoublePrevious.Enabled == false)
                    btnDoublePrevious.Enabled = true;
            }
            if (mbm.Position == mbm.Count - 1)
                btnDoubleNext.Enabled = false;
            
            HienThiControl(dt);
        }

        private void btnDoubleNext_Click(object sender, EventArgs e)
        {
            if (mbm.Position < mbm.Count - 1)
            {
                mbm.Position = mbm.Count - 1;
                btnDoubleNext.Enabled = false;
            }
            if (btnDoublePrevious.Enabled == false)
                btnDoublePrevious.Enabled = true;
            HienThiControl(dt);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (mbm.Position > 0)
            {
                mbm.Position--;
                if (btnDoubleNext.Enabled == false)
                    btnDoubleNext.Enabled = true;
            }
            if (mbm.Position == 0)
            {
                if (btnDoublePrevious.Enabled == true)
                    btnDoublePrevious.Enabled = false;
            }
            HienThiControl(dt);
        }

        private void btnDoublePrevious_Click(object sender, EventArgs e)
        {
            if (mbm.Position > 0)
            {
                mbm.Position = 0;
                btnDoublePrevious.Enabled = false;
            }
            if (mbm.Position == 0)
            {
                if (btnDoubleNext.Enabled == false)
                    btnDoubleNext.Enabled = true;
            }
            HienThiControl(dt);
        }
    }
}
