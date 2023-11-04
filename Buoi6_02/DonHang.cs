using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_02
{
    internal class DonHang
    {
        public int MaDonHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public string KieuDonHang { get; set; }
        public string GhiChu { get; set; }

        public DonHang() { }

        public DonHang(int maDonHang, DateTime ngayDatHang, DateTime ngayGiaoHang, string kieuDonHang, string ghiChu)
        {
            MaDonHang = maDonHang;
            NgayDatHang = ngayDatHang;
            NgayGiaoHang = ngayGiaoHang;
            KieuDonHang = kieuDonHang;
            GhiChu = ghiChu;
        }
    }
}
