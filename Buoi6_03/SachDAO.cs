using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_03
{
    class SachDao
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public SachDao()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public DataTable getList(int? maLoai = null)
        {
            string sql = null;
            if (maLoai == null)
            {
                sql = "SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.GiaSach, LoaiSach.TenLoai, NhaXuatBan.TenNXB, NhanVien.TenNhanVien " +
                      "FROM Sach " +
                      "INNER JOIN LoaiSach ON LoaiSach.MaLoai = Sach.MaLoai " +
                      "INNER JOIN NhaXuatBan ON NhaXuatBan.MaNXB = Sach.MaNXB " +
                      "INNER JOIN NhanVien ON NhanVien.MaNV = Sach.MaNV";
            }
            else
            {
                sql = "SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.GiaSach, LoaiSach.TenLoai, NhaXuatBan.TenNXB, NhanVien.TenNhanVien " +
                      "FROM Sach " +
                      "INNER JOIN LoaiSach ON LoaiSach.MaLoai = Sach.MaLoai " +
                      "INNER JOIN NhaXuatBan ON NhaXuatBan.MaNXB = Sach.MaNXB " +
                      "INNER JOIN NhanVien ON NhanVien.MaNV = Sach.MaNV " +
                      "WHERE Sach.MaLoai = @maLoai";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (maLoai != null)
            {
                cmd.Parameters.AddWithValue("@maLoai", maLoai);
            }
            apt.Fill(dt);
            return dt;
        }

        public int getCount()
        {
            string sql = "SELECT COUNT(MaSach) FROM Sach";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public DataRow GetRow(string maSach)
        {
            string sql = "SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.GiaSach, LoaiSach.TenLoai, NhaXuatBan.TenNXB, NhanVien.TenNhanVien " +
                         "FROM Sach " +
                         "INNER JOIN LoaiSach ON LoaiSach.MaLoai = Sach.MaLoai " +
                         "INNER JOIN NhaXuatBan ON NhaXuatBan.MaNXB = Sach.MaNXB " +
                         "INNER JOIN NhanVien ON NhanVien.MaNV = Sach.MaNV " +
                         "WHERE Sach.MaSach = '" + maSach + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }

        public void InsertOne(Sach book)
        {
            string sql = "INSERT INTO Sach(MaSach, TenSach, TacGia, GiaSach, MaLoai, MaNXB, NamXB, MaNV) " +
                         "VALUES('" + book.MaSach + "', N'" + book.TenSach + "', N'" + book.TacGia + "', '" + book.GiaSach + "', " +
                         "'" + book.MaLoai + "', '" + book.MaNXB + "', '" + book.NamXB + "', '" + book.MaNV + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void UpdateOne(Sach book)
        {
            string sql = "UPDATE Sach SET TenSach = N'" + book.TenSach + "', TacGia = N'" + book.TacGia + "', " +
                         "GiaSach = '" + book.GiaSach + "', MaLoai = '" + book.MaLoai + "', MaNXB = '" + book.MaNXB + "', " +
                         "NamXB = '" + book.NamXB + "', MaNV = '" + book.MaNV + "' " +
                         "WHERE MaSach = '" + book.MaSach + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOne(string maSach)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = '" + maSach + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
