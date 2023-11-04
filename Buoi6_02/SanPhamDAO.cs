using Buoi6_02;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Buoi06_Database
{
    internal class SanPhamDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();

        public SanPhamDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void InsertOne(SanPham sp)
        {
            string sql = "INSERT INTO SanPham(MaSanPham, MaLoai, TenSanPham, DonViTinh, GiaMua, GiaBan) ";
            sql += "VALUES(@MASANPHAM, @MALOAI, @TENSANPHAM, @DONVITINH, @GIAMUA, @GIABAN)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
            cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
            cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
            cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            cmd.Parameters.AddWithValue("@GiaMua", sp.GiaMua);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
            cmd.ExecuteNonQuery();
        }

        public DataTable getList(int? maLoai = null)
        {
            string sql = null;
            SqlCommand cmd = new SqlCommand();
            if (maLoai == null)
            {
                sql = "SELECT SanPham.MaSanPham, LoaiSP.TenLoai, SanPham.TenSanPham, SanPham.DonViTinh, SanPham.GiaMua, SanPham.GiaBan ";
                sql += "FROM SanPham INNER JOIN LoaiSP ON LoaiSP.MaLoai = SanPham.MaLoai";
            }
            else
            {
                sql = "SELECT SanPham.MaSanPham, LoaiSP.TenLoai, SanPham.TenSanPham, SanPham.DonViTinh, SanPham.GiaMua, SanPham.GiaBan ";
                sql += "FROM SanPham INNER JOIN LoaiSP ON LoaiSP.MaLoai = SanPham.MaLoai WHERE SanPham.MaLoai='" + maLoai + "'";

                // Sử dụng tham số
                cmd.Parameters.AddWithValue("@MaLoai", maLoai);
            }

            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }


        public int getCount()
        {
            string sql = "SELECT COUNT(SanPham.MaSanPham) FROM SanPham INNER JOIN LoaiSP ON LoaiSP.MaLoai = SanPham.MaLoai";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public DataRow GetRow(int maSanPham)
        {
            string sql = "SELECT SanPham.MaSanPham, SanPham.MaLoai, SanPham.TenSanPham, SanPham.DonViTinh, SanPham.GiaMua, SanPham.GiaBan, LoaiSP.TenLoai ";
            sql += "FROM SanPham INNER JOIN LoaiSP ON LoaiSP.MaLoai = SanPham.MaLoai WHERE SanPham.MaSanPham='" + maSanPham + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }

        public void UpdateOne(SanPham sp)
        {
            string sql = "UPDATE SanPham SET MaLoai=@MaLoai, TenSanPham=@TenSanPham, DonViTinh=@DonViTinh, GiaMua=@GiaMua, GiaBan=@GiaBan ";
            sql += "WHERE MaSanPham=@MaSanPham";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
            cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
            cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
            cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            cmd.Parameters.AddWithValue("@GiaMua", sp.GiaMua);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOne(int maSanPham)
        {
            string sql = "DELETE FROM SanPham WHERE MaSanPham='" + maSanPham + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
