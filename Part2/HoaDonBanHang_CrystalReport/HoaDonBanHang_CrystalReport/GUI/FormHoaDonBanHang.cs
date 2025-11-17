using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoaDonBanHang_CrystalReport.DAO;

namespace HoaDonBanHang_CrystalReport.GUI
{
    public partial class FormHoaDonBanHang : Form
    {
        Database db;
        DataTable dt;

        public FormHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void FormHoaDonBanHang_Load(object sender, EventArgs e)
        {
            db = new Database("localhost", "HoaDonBanHang");
            string sql = "Select H.SOHD, NGHD, N.HOTEN as HOTENNV, K.HOTEN as HOTENKH, C.MASP, TENSP, SL, S.TRIGIA " +
                "From HOADON H, NHANVIEN N, KHACHHANG K, CTHD C, SANPHAM S " +
                "Where H.MANV = N.MANV and H.MAKH = K.MAKH and C.SOHD = H.SOHD and C.MASP = S.MASP";
            dt = db.ExcuteQuery(sql);
            CrystalReportHoaDonBanHang cry = new CrystalReportHoaDonBanHang();
            cry.SetDataSource(dt);
            crystalReportHoaDon.ReportSource = cry;
        }
    }
}
