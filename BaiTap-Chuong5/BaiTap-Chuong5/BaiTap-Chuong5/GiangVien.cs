using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Chuong5
{
    public class GiangVien
    {
        public static DataTable ThongTinGiangVien()
        {
            string query = "SELECT * FROM GIANGVIEN";
            DataTable dataTable = new DataTable();
            dataTable = KetNoiCSDL.ExcuteQuery(query);
            return dataTable;
        }

        public static DataTable MaGiaoVien_LonNhat()
        {
            string query = "SELECT TOP 1 MAGV FROM GIANGVIEN ORDER BY MAGV DESC";
            DataTable dataTable = new DataTable();
            dataTable = KetNoiCSDL.ExcuteQuery(query);
            return dataTable;
        }

        public static void ThemGiaoVien(string maGV, string tenGV, bool gioiTinh, string ngaySinh, string diaChi, string sdt)
        {
            string query = $"INSERT INTO GIANGVIEN ([MAGV], [TENGV], [GIOITINH], [NGAYSINH], [DIACHI], [SDT]) " +
                           $"VALUES ('{maGV}', N'{tenGV}', '{gioiTinh}', '{ngaySinh}', N'{diaChi}', '{sdt}')";
            KetNoiCSDL.ExcuteNonQuery(query);
        }

        public static void CapNhatGiaoVien(string maGV, string tenGV, bool gioiTinh, string ngaySinh, string diaChi, string sdt)
        {
            string query = $"UPDATE GIANGVIEN SET TENGV = N'{tenGV}', GIOITINH = '{gioiTinh}', NGAYSINH = '{ngaySinh}', DIACHI = N'{diaChi}', SDT = '{sdt}' WHERE MAGV = '{maGV}'";
            KetNoiCSDL.ExcuteNonQuery(query);
        }

        public static void XoaGiaoVien(string maGV)
        {
            string query = $"DELETE FROM GIANGVIEN WHERE MAGV = '{maGV}'";
            KetNoiCSDL.ExcuteNonQuery(query);
        }
    }
}
