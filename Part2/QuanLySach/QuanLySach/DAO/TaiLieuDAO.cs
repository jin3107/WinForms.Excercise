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
    public class TaiLieuDAO
    {
        private readonly Database db;

        public TaiLieuDAO(string serverName, string dbName)
        {
            db = new Database(serverName, dbName);
        }

        public DataTable GetAll()
        {
            string sql = "Select * From TaiLieu";
            return db.LayDL(sql);
        }

        public bool Insert(TaiLieu taiLieu)
        {
            string sql = @"Insert into TaiLieu(Id, MaHP, MaSach, NamTLK) values(@Id, @MaHP, @MaSach, @NamTLK)";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@Id", taiLieu.Id);
                cmd.Parameters.AddWithValue("@MaHP", taiLieu.MaHP);
                cmd.Parameters.AddWithValue("@MaSach", taiLieu.MaSach);
                cmd.Parameters.AddWithValue("@NamTLK", taiLieu.NamTK);

                try
                {
                    db.ThucThi(cmd);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm tài liệu. Cụ thể:\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        //public TaiLieu GetById(int id)
        //{
        //    var dt = db.LayDL("Select Id, MaHP, MaSach, NamTLK FROM TaiLieu Where Id = " + id);
        //    if (dt.Rows.Count == 0) return null;
        //    var r = dt.Rows[0];
        //    return new TaiLieu(
        //        int.Parse(r["Id"].ToString()),
        //        r["MaHP"].ToString(),
        //        r["MaSach"].ToString(),
        //        int.Parse(r["NamTLK"].ToString())
        //    );
        //}

        public bool Update(TaiLieu tl)
        {
            if (!ExistsInTable("HocPhan", "MaHP", tl.MaHP))
            {
                MessageBox.Show($"Không tìm thấy Học phần: {tl.MaHP}", "Lỗi FK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!ExistsInTable("Sach", "MaSach", tl.MaSach))
            {
                MessageBox.Show($"Không tìm thấy Sách: {tl.MaSach}", "Lỗi FK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string sql = @"Update TaiLieu set MaHP = @MaHP, MaSach = @MaSach, NamTLK = @NamTLK Where Id = @Id";
            using (var cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaHP", tl.MaHP);
                cmd.Parameters.AddWithValue("@MaSach", tl.MaSach);
                cmd.Parameters.AddWithValue("@NamTLK", tl.NamTK);
                cmd.Parameters.AddWithValue("@Id", tl.Id);

                try
                {
                    db.ThucThi(cmd);
                    return true;
                }
                catch (SqlException sqlex)
                {
                    if (sqlex.Number == 547)
                    {
                        MessageBox.Show("Cập nhật thất bại do ràng buộc khoá ngoại.", "Lỗi FK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    MessageBox.Show("Cập nhật lỗi: " + sqlex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool ExistsInTable(string table, string col, string value)
        {
            using (var cmd = new SqlCommand($"Select 1 From {table} Where {col} = @val", db.cn))
            {
                cmd.Parameters.AddWithValue("@val", value);
                try
                {
                    if (db.cn.State == ConnectionState.Closed) db.cn.Open();
                    var o = cmd.ExecuteScalar();
                    return o != null;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    if (db.cn.State == ConnectionState.Open) db.cn.Close();
                }
            }
        }

        public bool Delete(string id)
        {
            string sql = "Delete From TaiLieu Where Id = @Id";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    db.ThucThi(cmd);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài liệu. Cụ thể:\n " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
