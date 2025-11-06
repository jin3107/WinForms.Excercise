using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhMucNhanVien.DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(string maNV, string tenNV, string tenCV, string maQL, 
            DateTime ngayTuyen, bool gioiTinh, int bac, string nganh, string maPhong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            TenCV = tenCV;
            MaQL = maQL;
            NgayTuyen = ngayTuyen;
            GioiTinh = gioiTinh;
            Bac = bac;
            Nganh = nganh;
            MaPhong = maPhong;
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string TenCV { get; set; }
        public string MaQL { get; set; }
        public DateTime NgayTuyen { get; set; }
        public bool GioiTinh { get; set; }
        public int Bac { get; set; }
        public string Nganh { get; set; }
        public string MaPhong { get; set; }
    }
}
