using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_02
{
    internal class DonHangChiTiet
    {
        public int MaCTHD { get; set; }
        public int MaDonHang { get; set; }
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }

        public DonHangChiTiet() { }

        public DonHangChiTiet(int maCTHD, int maDonHang, int maSanPham, string tenSanPham, string donViTinh, double donGia, int soLuong, double thanhTien)
        {
            MaCTHD = maCTHD;
            MaDonHang = maDonHang;
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonViTinh = donViTinh;
            DonGia = donGia;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }
    }
}
