using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5.Bai1c.DTO
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string MaLop { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Phai { get; set; }
        public string DiaChi { get; set; }

        public SinhVien(string maSV, string tenSV, string maLop, string dienThoai, DateTime ngaySinh, bool phai, string diaChi)
        {
            MaSV = maSV;
            TenSV = tenSV;
            MaLop = maLop;
            DienThoai = dienThoai;
            NgaySinh = ngaySinh;
            Phai = phai;
            DiaChi = diaChi;
        }
    }
}
