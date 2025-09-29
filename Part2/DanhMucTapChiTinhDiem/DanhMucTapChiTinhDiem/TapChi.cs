using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhMucTapChiTinhDiem
{
    public class TapChi
    {
        public int STT { get; set; }
        public string TenTapChi { get; set; }
        public string Loai { get; set; }
        public string CQXuatBan { get; set; }
        public double Diem { get; set; }

        public TapChi(int sTT, string tenTapChi, string loai, string cQXuatBan, double diem)
        {
            STT = sTT;
            TenTapChi = tenTapChi;
            Loai = loai;
            CQXuatBan = cQXuatBan;
            Diem = diem;
        }

        public TapChi(TapChi tc)
        {
            STT = tc.STT;
            TenTapChi = tc.TenTapChi;
            Loai = tc.Loai;
            CQXuatBan = tc.CQXuatBan;
            Diem = tc.Diem;
        }
    }
}
