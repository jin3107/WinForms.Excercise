using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class TaiLieu
    {
        public TaiLieu(string id, string maHP, string maSach, int namTK)
        {
            Id = id;
            MaHP = maHP;
            MaSach = maSach;
            NamTK = namTK;
        }

        public string Id { get; set; }
        public string MaHP { get; set; }
        public string MaSach { get; set; }
        public int NamTK { get; set; }
    }
}
