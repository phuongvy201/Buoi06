﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_Database
{

    internal class SinhVienDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public SinhVienDAO()
        {
            conn = kn.getConnect();
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void InsertOne(SinhVien sv)
        {
            string sql = "INSERT INTO SinhVien(MaSV,HoTen,MaKhoa,DiemTB) VALUES(@MASV,@HOTEN,@MAKHOA,@DIEMTB)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.ExecuteNonQuery();

        }
        public DataTable getList(int? makhoa = null)
        {
            string sql = null;
            if (makhoa == null)
            {
                sql = "SELECT SinhVien.MaSV,SinhVien.HoTen,SinhVien.DiemTB,Khoa.TenKhoa ";
                sql+="FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
            }
            else
            {
                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa.TenKhoa ";
                sql+="FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaKhoa='" + makhoa + "'";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow GetRow(string masv)
        {
            string sql = "SELECT SinhVien.MaSV,SinhVien.HoTen,SinhVien.DiemTB,Khoa.TenKhoa ";
                sql+= "FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaSV='" + masv + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void UpdateTwo(SinhVien sv)
        {
            string sql = "UPDATE SinhVien SET HoTen=@HOTEN,MaKhoa=@MAKHOA,DiemTB=@DIEMTB ";
            sql += "WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.ExecuteNonQuery();
        }
        public void DeleteOne(string masv)
        {
            string sql = "DELETE FROM SinhVien WHERE MaSV='" + masv + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
