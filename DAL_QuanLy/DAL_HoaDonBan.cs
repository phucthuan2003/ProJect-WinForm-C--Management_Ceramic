using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace DAL_QuanLy
{
    public class DAL_HoaDonBan : DBConnect
    {   
        
        public DAL_HoaDonBan() 
        {
           
        }
        // Phuong thuc tra ve toan bo danh sach hdb tu bang HDB
        public DataTable getHoaDonBan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDonBan", _conn);
            DataTable dtHDB = new DataTable();
            da.Fill(dtHDB);
            return dtHDB;

        }

        // Phương thức sinh mã hóa đơn bán
        public string GenerateMaHDB()
        {
            string maHDB = "";
            try
            {
                // Kết nối
                _conn.Open();

                // Lấy mã hóa đơn bán lớn nhất hiện có
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 MaHDB FROM HoaDonBan ORDER BY MaHDB DESC", _conn);
                object result = cmd.ExecuteScalar(); // Trả về giá trị lớn nhất

                if (result != null)
                {
                    // Tách phần số của mã hóa đơn
                    string lastMaHDB = result.ToString();
                    int lastNumber = int.Parse(lastMaHDB.Substring(3)); // Lấy số sau 'HDB'
                    int newNumber = lastNumber + 1; // Tăng số lên 1

                    // Định dạng lại mã hóa đơn mới
                    maHDB = "HDB" + newNumber.ToString("D2"); // Định dạng với 2 chữ số
                }
                else
                {
                    // Nếu chưa có hóa đơn nào, khởi tạo mã đầu tiên
                    maHDB = "HDB01";
                }
            }
            catch (Exception e)
            {
                // Xử lý lỗi (nếu cần)
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return maHDB; // Trả về mã hóa đơn bán mới
        }

        // Phuong thuc Them HDB
        public bool themHDB(DTO_HoaDonBan hdb)
        {
            try
            {
                //Ket noi
                _conn.Open();

                // Sinh mã hóa đơn bán
                hdb.MaHDB = GenerateMaHDB();


                // Query string - Chuỗi truy vấn thêm hóa đơn bán
                string SQL = "INSERT INTO HoaDonBan (MaHDB, MaKH, NgayBan, TongTien) VALUES (@MaHDB, @MaKH, @NgayBan, @TongTien)";

                // Tạo command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Thêm tham số vào command
                cmd.Parameters.AddWithValue("@MaHDB", hdb.MaHDB);
                cmd.Parameters.AddWithValue("@MaKH", hdb.MaKH);
                cmd.Parameters.AddWithValue("@NgayBan", hdb.NgayBan);
                cmd.Parameters.AddWithValue("@TongTien", hdb.TongTien);

                // Thực hiện truy vấn
                int result = cmd.ExecuteNonQuery(); // Số lượng bản ghi bị ảnh hưởng

                return result > 0; // Trả về true nếu thêm thành công
            }
            catch (Exception e)
            {
                // Xử lý lỗi (nếu cần)
                Console.WriteLine("Lỗi: " + e.Message);
            }

            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return false;
        }

        public List<DTO_ReportHD> LayDanhSachHoaDon()
        {
            List<DTO_ReportHD> danhSachHoaDon = new List<DTO_ReportHD>();

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R4RPQKD;Initial Catalog=BTL_6;Integrated Security=True;Encrypt=True"))
            {
                string query = @"
            SELECT 
                cthd.MaHang,        
                hh.TenHang AS TenSanPham,   
                kh.MaKhach AS MaKhachHang,      
                kh.TenKhach AS TenKhachHang,    
                cthd.SoLuong,         
                cthd.DonGiaBan,          
                (cthd.SoLuong * cthd.DonGiaBan) AS DoanhThu,  
                hd.NgayBan,           
                nv.TenNV AS NhanVienLapHoaDon 
            FROM 
                ChiTietHoaDonBan cthd
            JOIN 
                HoaDonBan hd ON cthd.SoHDB = hd.SoHDB
            JOIN 
                KhachHang kh ON hd.MaKhach = kh.MaKhach
            JOIN 
                HangHoa hh ON cthd.MaHang = hh.MaHang
            LEFT JOIN 
                NhanVien nv ON hd.MaNV = nv.MaNV";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DTO_ReportHD hoaDon = new DTO_ReportHD()
                    {
                        MaSanPham = reader["MaHang"].ToString(),
                        TenSanPham = reader["TenSanPham"].ToString(),
                        MaKhachHang = reader["MaKhachHang"].ToString(),
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        SoLuong = Convert.ToInt32(reader["SoLuong"]),
                        DonGia = Convert.ToDecimal(reader["DonGiaBan"]),
                        DoanhThu = Convert.ToDecimal(reader["DoanhThu"]),
                        NgayBan = Convert.ToDateTime(reader["NgayBan"]),
                        NhanVienLapHoaDon = reader["NhanVienLapHoaDon"].ToString()
                    };

                    danhSachHoaDon.Add(hoaDon);
                }

                reader.Close();
            }

            return danhSachHoaDon;
        }

    }

}
