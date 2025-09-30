using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Phai { get; set; }

        public SinhVien(string maSV, string hoLot, string ten, DateTime ngaySinh, bool phai)
        {
            MaSV = maSV;
            HoLot = hoLot;
            Ten = ten;
            NgaySinh = ngaySinh;
            Phai = phai;
        }
    }
}
