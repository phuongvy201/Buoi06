using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_Database
{
    internal class KhoaDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public DataTable getList()
        {
            conn = kn.getConnect();
            string sql = "SELECT * FROM Khoa";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public void Insert(Khoa kh)
        {
            string sql = "INSERT INTO Khoa(MaKhoa,TenKhoa,GhiChu) ";
            sql+="VALUES('" +kh.Makhoa+"',N'"+kh.TenKhoa+"','"+kh.GhiChu+"')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Update(Khoa kh)
        {
            string sql = "UPDATE Khoa SET MaKhoa'" + kh.Makhoa + "', Tenkhoa='" + kh.TenKhoa + "',GhiChu='" + kh.GhiChu + "' ";
            sql += "WHERE MaKhoa='" + kh.Makhoa + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Delete(string makhoa)
        {
            string sql = "DELETE FROM SinhVien WHERE MASV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MAKHOA", makhoa);
            cmd.ExecuteNonQuery();
        }
    }
}
