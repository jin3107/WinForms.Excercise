using QuanLyShow_CrystalReport.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShow_CrystalReport.GUI
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void crystalReportShow_Load(object sender, EventArgs e)
        {

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            Database db = new Database("localhost", "QLShow");
            string sql = "SELECT SK.TenDiaDiem, SK.Diachi, " +
                "S.Ngaybd, C.Nghedanh, C.MaCS, " +
                "CASE WHEN DAY(S.Ngaybd) = 24 AND MONTH(S.Ngaybd) = 12 THEN 700 ELSE 500 END as Giave " +
                "FROM SANKHAU SK, SHOW S, CASI C " +
                "WHERE SK.MaDD = S.MaDD AND S.Casichinh = C.MaCS " +
                "ORDER BY SK.TenDiaDiem, S.Ngaybd";
            DataTable dt = db.ExcuteQuery(sql);
            CrystalReportShow cry = new CrystalReportShow();
            cry.SetDataSource(dt);
            crystalReportShow.ReportSource = cry;
        }
    }
}
