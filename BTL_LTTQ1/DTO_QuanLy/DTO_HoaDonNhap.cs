using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_HoaDonNhap
    {
        private string _MaHDN;
        private string _MaNCC;
        private DateTime _NgayNhap;
        private decimal _TongTien;

        public string MaHDN { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }

        public DTO_HoaDonNhap() { }

        public DTO_HoaDonNhap(string maHDN, string maNCC, DateTime ngayNhap, decimal tongTien)
        {
            this.MaHDN = maHDN;
            this.MaNCC = maNCC;
            this.NgayNhap = ngayNhap;
            this.TongTien = tongTien;
        }
    }

}
