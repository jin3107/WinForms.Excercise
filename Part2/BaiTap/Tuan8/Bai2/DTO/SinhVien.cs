using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan8.Bai2.DTO
{
    public class SinhVien
    {
        public SinhVien(string maSV, string ho, string ten, bool gioiTinh, DateTime ngaySinh, string noiSinh, string khoa)
        {
            MaSV = maSV;
            Ho = ho;
            Ten = ten;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            NoiSinh = noiSinh;
            Khoa = khoa;
        }

        public string MaSV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string Khoa { get; set; }
    }
}
