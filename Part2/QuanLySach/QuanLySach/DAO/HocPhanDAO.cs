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
    public class HocPhanDAO
    {
        private readonly Database db;

        public HocPhanDAO(string serverName, string dbName)
        {
            db = new Database(serverName, dbName);
        }

        public DataTable GetAll()
        {
            return db.LayDL("Select * From HocPhan");
        }

        public DataTable GetId()
        {
            return db.LayDL("Select MaHP From HocPhan");
        }

        //public HocPhan GetById(string maHP)
        //{
        //    var dt = db.LayDL("Select MaHP, TenHP, SoTC From HocPhan WHERE MaHP = '" + maHP.Replace("'", "''") + "'");
        //    if (dt.Rows.Count == 0) return null;
        //    var r = dt.Rows[0];
        //    return new HocPhan(
        //        r["MaHP"].ToString(),
        //        r["TenHP"].ToString(),
        //       int.Parse(r["SoTC"].ToString())
        //    );
        //}

        public bool Insert(HocPhan hp)
        {
            string sql = "Insert into HocPhan(MaHP, TenHP, SoTC) values(@MaHP, @TenHP, @SoTC)";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaHP", hp.MaHP);
                cmd.Parameters.AddWithValue("@TenHP", hp.TenHP);
                cmd.Parameters.AddWithValue("@SoTC", hp.SoTC);

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

        public bool Update(HocPhan hp)
        {
            string sql = "Update HocPhan set TenHP = @TenHP, SoTC = @SoTC Where MaHP = @MaHP";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaHP", hp.MaHP);
                cmd.Parameters.AddWithValue("@TenHP", hp.TenHP);
                cmd.Parameters.AddWithValue("@SoTC", hp.SoTC);

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

        public bool Delete(string maHP)
        {
            string sql = "Delete From HocPhan Where MaHP = @MaHP";
            using (SqlCommand cmd = new SqlCommand(sql, db.cn))
            {
                cmd.Parameters.AddWithValue("@MaHP", maHP);
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
