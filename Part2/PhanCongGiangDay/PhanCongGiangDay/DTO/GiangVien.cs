using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanCongGiangDay.DTO
{
    public class GiangVien
    {
        public GiangVien(string maGV, string tenGV, string diaChi, string sDT)
        {
            MaGV = maGV;
            TenGV = tenGV;
            DiaChi = diaChi;
            SDT = sDT;
        }

        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    }
}
