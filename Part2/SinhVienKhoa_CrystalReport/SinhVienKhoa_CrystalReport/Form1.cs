using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVienKhoa_CrystalReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database("localhost", "QLSV1");
            string sql = "Select k.MAKHOA, TENKHOA, MASV, HOSV + ' ' + TENSV as HOTEN, NGAYSINH, NOISINH, HOCBONG " +
                "From DMKHOA k, DMSV s " +
                "Where k.MAKHOA = s.MAKH";
            DataTable dt = db.ExcuteQuery(sql);
            CrystalReportSinhVien cry = new CrystalReportSinhVien();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
