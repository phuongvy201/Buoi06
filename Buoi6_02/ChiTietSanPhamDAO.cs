using System;
using System.Data;
using System.Data.SqlClient;
using Buoi6_02; // Đảm bảo thêm namespace phù hợp

namespace Buoi06_Database
{
    internal class ChiTietSanPhamDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();

        public ChiTietSanPhamDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void InsertOne(DonHangChiTiet ctsanpham)
        {
            string sql = "INSERT INTO DonHangChiTiet(MaChiTiet, MaSanPham, TenSanPham, DonViTinh, DonGia, SoLuong, ThanhTien) ";
            sql += "VALUES(@MaChiTiet, @MaSanPham, @TenSanPham, @DonViTinh, @DonGia, @SoLuong, @ThanhTien)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaChiTiet", ctsanpham.MaCTHD);
            cmd.Parameters.AddWithValue("@MaSanPham", ctsanpham.MaSanPham);
            cmd.Parameters.AddWithValue("@TenSanPham", ctsanpham.TenSanPham);
            cmd.Parameters.AddWithValue("@DonViTinh", ctsanpham.DonViTinh);
            cmd.Parameters.AddWithValue("@DonGia", ctsanpham.DonGia);
            cmd.Parameters.AddWithValue("@SoLuong", ctsanpham.SoLuong);
            cmd.Parameters.AddWithValue("@ThanhTien", ctsanpham.ThanhTien);
            cmd.ExecuteNonQuery();
        }

        public DataTable getList(int? maSanPham = null)
        {
            string sql = null;
            SqlCommand cmd = new SqlCommand();
            if (maSanPham == null)
            {
                sql = "SELECT DonHangChiTiet.MaChiTiet, DonHangChiTiet.MaSanPham, DonHangChiTiet.TenSanPham, ";
                sql += "DonHangChiTiet.DonViTinh, DonHangChiTiet.DonGia, DonHangChiTiet.SoLuong, DonHangChiTiet.ThanhTien ";
                sql += "FROM DonHangChiTiet INNER JOIN SanPham ON SanPham.MaSanPham = DonHangChiTiet.MaSanPham";
            }
            else
            {
                sql = "SELECT DonHangChiTiet.MaChiTiet, DonHangChiTiet.MaSanPham, DonHangChiTiet.TenSanPham, ";
                sql += "DonHangChiTiet.DonViTinh, DonHangChiTiet.DonGia, DonHangChiTiet.SoLuong, DonHangChiTiet.ThanhTien ";
                sql += "FROM DonHangChiTiet INNER JOIN SanPham ON SanPham.MaSanPham = DonHangChiTiet.MaSanPham WHERE SanPham.MaSanPham='" + maSanPham + "'";

                // Sử dụng tham số
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
            }

            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

        public int getCount()
        {
            string sql = "SELECT COUNT(DonHangChiTiet.MaChiTiet) FROM DonHangChiTiet INNER JOIN SanPham ON SanPham.MaSanPham = DonHangChiTiet.MaSanPham";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public DataRow GetRow(int maChiTiet)
        {
            string sql = "SELECT DonHangChiTiet.MaChiTiet, DonHangChiTiet.MaSanPham, DonHangChiTiet.TenSanPham, ";
            sql += "DonHangChiTiet.DonViTinh, DonHangChiTiet.DonGia, DonHangChiTiet.SoLuong, DonHangChiTiet.ThanhTien, SanPham.TenSanPham ";
            sql += "FROM DonHangChiTiet INNER JOIN SanPham ON SanPham.MaSanPham = DonHangChiTiet.MaSanPham WHERE DonHangChiTiet.MaChiTiet='" + maChiTiet + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }

        public void UpdateOne(DonHangChiTiet ctsanpham)
        {
            string sql = "UPDATE DonHangChiTiet SET MaSanPham=@MaSanPham, TenSanPham=@TenSanPham, ";
            sql += "DonViTinh=@DonViTinh, DonGia=@DonGia, SoLuong=@SoLuong, ThanhTien=@ThanhTien ";
            sql += "WHERE MaChiTiet=@MaChiTiet";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaChiTiet", ctsanpham.MaCTHD);
            cmd.Parameters.AddWithValue("@MaSanPham", ctsanpham.MaSanPham);
            cmd.Parameters.AddWithValue("@TenSanPham", ctsanpham.TenSanPham);
            cmd.Parameters.AddWithValue("@DonViTinh", ctsanpham.DonViTinh);
            cmd.Parameters.AddWithValue("@DonGia", ctsanpham.DonGia);
            cmd.Parameters.AddWithValue("@SoLuong", ctsanpham.SoLuong);
            cmd.Parameters.AddWithValue("@ThanhTien", ctsanpham.ThanhTien);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOne(int maChiTiet)
        {
            string sql = "DELETE FROM DonHangChiTiet WHERE MaChiTiet='" + maChiTiet + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
