using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_03
{
    internal class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public double GiaSach { get; set; }
        public int MaLoai { get; set; }
        public int MaNXB { get; set; }
        public int NamXB { get; set; }
        public int MaNV { get; set; }


        public Sach() { }
        public Sach(int masach, string tensach, string tacgia, double giasach, int maloai, int manxb, int namxb, int manv)
        {
            this.MaSach = masach;
            this.TenSach = tensach;
            this.TacGia = tacgia;
            this.GiaSach = giasach;
            this.MaLoai = maloai;
            this.MaNXB = manxb;
            this.NamXB = namxb;
            this.MaNV = manv;

        }
    }
}
