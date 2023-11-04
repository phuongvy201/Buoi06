using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_Database
{
    internal class Khoa
    {
        public String Makhoa { get; set; }
        public String TenKhoa { get; set; }
        public String GhiChu { get; set; }
        public Khoa() { }
        public Khoa(string makhoa, string tenKhoa, string ghiChu)
        {
            Makhoa = makhoa;
            TenKhoa = tenKhoa;
            GhiChu = ghiChu;
        }
    }
}
