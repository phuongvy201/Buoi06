using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_02
{
    internal class SanPham
    {
        public int MaSanPham { get; set; }
        public int MaLoai { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public double GiaMua { get; set; }
        public double GiaBan { get; set; }

        public SanPham() { }

        public SanPham(int maSanPham, int maLoai, string tenSanPham, string donViTinh, double giaMua, double giaBan)
        {
            MaSanPham = maSanPham;
            MaLoai = maLoai;
            TenSanPham = tenSanPham;
            DonViTinh = donViTinh;
            GiaMua = giaMua;
            GiaBan = giaBan;
        }
    }
}
