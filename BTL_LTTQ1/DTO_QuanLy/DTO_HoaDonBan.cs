using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_HoaDonBan
    {
        private string _MaHDB;
        private string _MaKH;
        private DateTime _NgayBan;
        private decimal _TongTien;

        public string MaHDB { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayBan { get; set; }
        public decimal TongTien { get; set; }

        public DTO_HoaDonBan() { }

        public DTO_HoaDonBan(string maHDB, string maKH, DateTime ngayBan, decimal tongTien)
        {
            this.MaHDB = maHDB;
            this.MaKH = maKH;
            this.NgayBan = ngayBan;
            this.TongTien = tongTien;
        }
    }

}
