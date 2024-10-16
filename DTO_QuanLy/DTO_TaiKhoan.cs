using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_TaiKhoan
    {
        private string _TenDangNhap;
        private string _MatKhau;
        private string _MaNV;
        private string _Quyen;

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public string Quyen
        {
            get { return _Quyen; }
            set { _Quyen = value; }
        }

        public DTO_TaiKhoan() { }

        public DTO_TaiKhoan(string tenDangNhap, string matKhau, string maNV, string quyen)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.MaNV = maNV;
            this.Quyen = quyen;
        }
    }

}
