using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_03
{
    class NhaXuatBan
    {
        public int MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public NhaXuatBan() { }
        public NhaXuatBan(int manxb, string tennxb, string diachi, string dienthoai, string email)
        {
            this.MaNXB = manxb;
            this.TenNXB = tennxb;
            this.DiaChi = diachi;
            this.DienThoai = dienthoai;
            this.Email = email;

        }
    }
}
