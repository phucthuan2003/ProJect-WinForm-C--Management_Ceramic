using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private string _DienThoai;
        private string _DiaChi;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public DTO_KhachHang() { }

        public DTO_KhachHang(string maKH, string tenKH, string dienThoai, string diaChi)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.DienThoai = dienThoai;
            this.DiaChi = diaChi;
        }
    }
}
