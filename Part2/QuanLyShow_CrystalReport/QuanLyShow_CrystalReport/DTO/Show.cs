using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShow_CrystalReport.DTO
{
    public class Show
    {
        public Show(string maShow, DateTime ngaybd, string casichinh, string casidonghanh, string giobd, string maDD)
        {
            MaShow = maShow;
            Ngaybd = ngaybd;
            Casichinh = casichinh;
            Casidonghanh = casidonghanh;
            Giobd = giobd;
            MaDD = maDD;
        }

        public string MaShow { get; set; }
        public DateTime Ngaybd { get; set; }
        public string Casichinh { get; set; }
        public string Casidonghanh { get; set; }
        public string Giobd { get; set; }
        public string MaDD { get; set; }
    }
}
