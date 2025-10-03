using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.DAO
{
    public class SachDAO
    {
        private readonly Database db;

        public SachDAO(string serverName, string dbName)
        {
            db = new Database(serverName, dbName);
        }

        public DataTable GetAll()
        {
            return db.LayDL("Select * From Sach");
        }

        public DataTable GetId()
        {
            return db.LayDL("Select MaSach From Sach");
        }

        //public Sach GetById(string maSach)
        //{
        //    var dt = db.LayDL("SELECT MaSach, TenSach, TacGia, NhaXB, NamXB FROM Sach WHERE MaSach = '" + maSach.Replace("'", "''") + "'");
        //    if (dt.Rows.Count == 0) return null;
        //    var r = dt.Rows[0];
        //    return new Sach(
        //        r["MaSach"].ToString(),
        //        r["TenSach"].ToString(),
        //        r["TacGia"].ToString(),
        //        r["NhaXB"].ToString(),
        //        int.Parse(r["NamXB"].ToString())
        //    );
        //}

        public bool Insert(Sach sach)
        {
            string sql = "INSERT INTO Sach(MaSach, TenSach, TacGia, NhaXB, NamXB) VALUES(@MaSach, @TenSach, @TacGia, @NhaXB, @NamXB)";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                cmd.Parameters.AddWithValue("@TacGia", sach.TacGia);
                cmd.Parameters.AddWithValue("@NhaXB", sach.NhaXB);
                cmd.Parameters.AddWithValue("@namXB", sach.NamXB);

                try
                {
                    if (db.cn.State == ConnectionState.Closed) db.cn.Open();
                    db.ThucThi(cmd);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu bị lỗi. Cụ thể:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (db.cn.State == ConnectionState.Open) db.cn.Close();
                }
            }
        }

        public bool Update(Sach sach)
        {
            string sql = "UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia, NhaXB = @NhaXB, NamXB = @NamXB WHERE MaSach = @MaSach";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                cmd.Parameters.AddWithValue("@TacGia", sach.TacGia);
                cmd.Parameters.AddWithValue("@NhaXB", sach.NhaXB);
                cmd.Parameters.AddWithValue("@NamXB", sach.NamXB);

                try
                {
                    if (db.cn.State == ConnectionState.Closed) db.cn.Open();
                    db.ThucThi(cmd);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật dữ liệu bị lỗi. Cụ thể:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (db.cn.State == ConnectionState.Open) db.cn.Close();
                }
            }
        }

        public bool Delete(string maSach)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = @MaSach";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                try
                {
                    if (db.cn.State == ConnectionState.Closed) db.cn.Open();
                    //int affected = cmd.ExecuteNonQuery();
                    //return affected > 0;
                    db.ThucThi(cmd);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xoá dữ liệu bị lỗi. Cụ thể:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (db.cn.State == ConnectionState.Open) db.cn.Close();
                }
            }
        }
    }
}
