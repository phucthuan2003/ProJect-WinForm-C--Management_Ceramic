using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietHoaDonNhap
    {
        private string _MaHDN;
        private string _MaHang;
        private int _SoLuong;
        private decimal _DonGiaNhap;
        private decimal _ThanhTien;

        public string MaHDN { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal ThanhTien { get; set; }

        public DTO_ChiTietHoaDonNhap() { }

        public DTO_ChiTietHoaDonNhap(string maHDN, string maHang, int soLuong, decimal donGiaNhap, decimal thanhTien)
        {
            this.MaHDN = maHDN;
            this.MaHang = maHang;
            this.SoLuong = soLuong;
            this.DonGiaNhap = donGiaNhap;
            this.ThanhTien = thanhTien;
        }
    }

}
