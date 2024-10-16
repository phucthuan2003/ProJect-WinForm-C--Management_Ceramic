using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietHoaDonBan
    {
        private string _MaHDB;
        private string _MaHang;
        private int _SoLuong;
        private decimal _DonGiaBan;
        private decimal _ThanhTien;

        public string MaHDB { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaBan { get; set; }
        public decimal ThanhTien { get; set; }

        public DTO_ChiTietHoaDonBan() { }

        public DTO_ChiTietHoaDonBan(string maHDB, string maHang, int soLuong, decimal donGiaBan, decimal thanhTien)
        {
            this.MaHDB = maHDB;
            this.MaHang = maHang;
            this.SoLuong = soLuong;
            this.DonGiaBan = donGiaBan;
            this.ThanhTien = thanhTien;
        }
    }

}
