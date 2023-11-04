using Buoi06_Database;
using Buoi6_02;
using System;
using System.Data;
using System.Data.SqlClient;

namespace YourNamespace
{
    internal class LoaiSPDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();

        public LoaiSPDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void InsertOne(LoaiSanPham loaiSP)
        {
            string sql = "INSERT INTO LoaiSP(MaLoai, TenLoai, ChiTiet) ";
            sql += "VALUES(@MaLoai, @TenLoai, @ChiTiet)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaLoai", loaiSP.MaLoai);
            cmd.Parameters.AddWithValue("@TenLoai", loaiSP.TenLoai);
            cmd.Parameters.AddWithValue("@ChiTiet", loaiSP.ChiTiet);
            cmd.ExecuteNonQuery();
        }

        public DataTable getList()
        {
            string sql = "SELECT * FROM LoaiSP";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

        public int getCount()
        {
            string sql = "SELECT COUNT(MaLoai) FROM LoaiSP";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public DataRow GetRow(int maLoai)
        {
            string sql = "SELECT * FROM LoaiSP WHERE MaLoai='" + maLoai + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }

        public void UpdateOne(LoaiSanPham loaiSP)
        {
            string sql = "UPDATE LoaiSP SET TenLoai=@TenLoai, ChiTiet=@ChiTiet ";
            sql += "WHERE MaLoai=@MaLoai";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaLoai", loaiSP.MaLoai);
            cmd.Parameters.AddWithValue("@TenLoai", loaiSP.TenLoai);
            cmd.Parameters.AddWithValue("@ChiTiet", loaiSP.ChiTiet);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOne(int maLoai)
        {
            string sql = "DELETE FROM LoaiSP WHERE MaLoai='" + maLoai + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
