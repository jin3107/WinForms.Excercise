using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class HocPhan
    {
        public HocPhan(string maHP, string tenHP, int soTC)
        {
            MaHP = maHP;
            TenHP = tenHP;
            SoTC = soTC;
        }

        public string MaHP { get; set; }
        public string TenHP { get; set; }
        public int SoTC { get; set; }
    }
}
