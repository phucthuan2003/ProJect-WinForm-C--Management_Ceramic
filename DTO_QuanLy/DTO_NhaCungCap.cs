using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhaCungCap
    {
        private string _MaNCC;
        private string _TenNCC;
        private string _DiaChi;
        private string _DienThoai;

        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        public DTO_NhaCungCap() { }

        public DTO_NhaCungCap(string maNCC, string tenNCC, string diaChi, string dienThoai)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }
    }
}
