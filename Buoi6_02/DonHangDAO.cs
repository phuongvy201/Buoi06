using Buoi6_02;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Buoi06_Database
{
    internal class DonHangDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();

        public DonHangDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void InsertOne(DonHang dh)
        {
            string sql = "INSERT INTO DonHang(MaDonHang, NgayDatHang, NgayGiaoHang, KieuDonHang, GhiChu) ";
            sql += "VALUES(@MaDonHang, @NgayDatHang, @NgayGiaoHang, @KieuDonHang, @GhiChu)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDonHang", dh.MaDonHang);
            cmd.Parameters.AddWithValue("@NgayDatHang", dh.NgayDatHang);
            cmd.Parameters.AddWithValue("@NgayGiaoHang", dh.NgayGiaoHang);
            cmd.Parameters.AddWithValue("@KieuDonHang", dh.KieuDonHang);
            cmd.Parameters.AddWithValue("@GhiChu", dh.GhiChu);
            cmd.ExecuteNonQuery();
        }

        public DataTable getList()
        {
            string sql = "SELECT MaDonHang, NgayDatHang, NgayGiaoHang, KieuDonHang, GhiChu FROM DonHang";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

        public int getCount()
        {
            string sql = "SELECT COUNT(MaDonHang) FROM DonHang";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public DataRow GetRow(int maDonHang)
        {
            string sql = "SELECT MaDonHang, NgayDatHang, NgayGiaoHang, KieuDonHang, GhiChu FROM DonHang WHERE MaDonHang = @MaDonHang";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }

        public void UpdateOne(DonHang dh)
        {
            string sql = "UPDATE DonHang SET NgayDatHang = @NgayDatHang, NgayGiaoHang = @NgayGiaoHang, KieuDonHang = @KieuDonHang, GhiChu = @GhiChu ";
            sql += "WHERE MaDonHang = @MaDonHang";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDonHang", dh.MaDonHang);
            cmd.Parameters.AddWithValue("@NgayDatHang", dh.NgayDatHang);
            cmd.Parameters.AddWithValue("@NgayGiaoHang", dh.NgayGiaoHang);
            cmd.Parameters.AddWithValue("@KieuDonHang", dh.KieuDonHang);
            cmd.Parameters.AddWithValue("@GhiChu", dh.GhiChu);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOne(int maDonHang)
        {
            string sql = "DELETE FROM DonHang WHERE MaDonHang = @MaDonHang";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
            cmd.ExecuteNonQuery();
        }
    }
}
