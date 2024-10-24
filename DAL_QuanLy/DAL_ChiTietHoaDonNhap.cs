using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data.SqlClient;
using System.Data;
=======
>>>>>>> old-project/Thuan1
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
<<<<<<< HEAD
    public class DAL_ChiTietHoaDonNhap: DBConnect
    {
        public DataTable GetTotalImportedQuantity()
        {
            string query = "SELECT SUM(SoLuong) AS Bang4 FROM ChiTietHoaDonNhap";
            using (SqlCommand command = new SqlCommand(query, _conn))
            {
                DataTable result = new DataTable();
                try
                {
                    _conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(result);
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occurred while getting total imported quantity: " + ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
                return result;
            }
        }
=======
    internal class DAL_ChiTietHoaDonNhap
    {
>>>>>>> old-project/Thuan1
    }
}
