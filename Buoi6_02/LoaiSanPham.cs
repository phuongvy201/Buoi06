using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_02
{
    internal class LoaiSanPham
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string ChiTiet { get; set; }

        public LoaiSanPham() { }

        public LoaiSanPham(int maLoai, string tenLoai, string chiTiet)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            ChiTiet = chiTiet;
        }
    }
}
