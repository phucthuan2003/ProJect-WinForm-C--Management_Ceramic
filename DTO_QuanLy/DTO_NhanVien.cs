using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
<<<<<<< HEAD
=======
        private string _MaNV;
        private string _TenNV;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _DienThoai;
        private string _DiaChi;
        private string _MaCV;
        private int _SoNgayPhep;
        private int _SoNgayNghi;
        private DateTime _NgayTuyen;

>>>>>>> old-project/Thuan1
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaCV { get; set; }
<<<<<<< HEAD
        public int SoNgayPhep { get; set; } = 0;
        public int SoNgayNghi { get; set; } = 0;
        public DateTime NgayTuyen { get; set; }
        public string CCCD { get; set; }

        public DTO_NhanVien() { }

        public DTO_NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string dienThoai, string diaChi, string maCV, int soNgayPhep, int soNgayNghi, DateTime ngayTuyen, string cCCD)
=======
        public int SoNgayPhep { get; set; }
        public int SoNgayNghi { get; set; }
        public DateTime NgayTuyen { get; set; }

        public DTO_NhanVien() { }

        public DTO_NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string dienThoai, string diaChi, string maCV, int soNgayPhep, int soNgayNghi, DateTime ngayTuyen)
>>>>>>> old-project/Thuan1
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DienThoai = dienThoai;
            this.DiaChi = diaChi;
            this.MaCV = maCV;
            this.SoNgayPhep = soNgayPhep;
            this.SoNgayNghi = soNgayNghi;
            this.NgayTuyen = ngayTuyen;
<<<<<<< HEAD
            this.CCCD = cCCD;
        }
    }

}
=======
        }
    }

}
>>>>>>> old-project/Thuan1
