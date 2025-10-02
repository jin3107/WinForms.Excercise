using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NhaXB { get; set; }
        public int NamXB { get; set; }

        public Sach(string maSach, string tenSach, string tacGia, string nhaXB, int namXB)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            NhaXB = nhaXB;
            NamXB = namXB;
        }
    }
}
