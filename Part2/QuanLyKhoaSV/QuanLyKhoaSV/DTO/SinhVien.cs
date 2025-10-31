using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoaSV.DTO
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string Khoa { get; set; }

        public SinhVien(string maSV, string ho, string ten, bool phai, DateTime ngaySinh, string noiSinh, string khoa)
        {
            MaSV = maSV;
            Ho = ho;
            Ten = ten;
            Phai = phai;
            NgaySinh = ngaySinh;
            NoiSinh = noiSinh;
            Khoa = khoa;
        }
    }
}
