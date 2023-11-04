using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_03
{
    class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }

        public NhanVien() { }
        public NhanVien(int manv, string tennv, string gioitinh, string dienthoai, string email)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.GioiTinh = gioitinh;
            this.DienThoai = dienthoai;
            this.Email = email;

        }
    }
}
