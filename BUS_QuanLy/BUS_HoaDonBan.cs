using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dalHBD = new DAL_HoaDonBan();

        public DataTable getHoaDonBan()
        {
            return dalHBD.getHoaDonBan();
        }

        public bool themHDB(DTO_HoaDonBan hdb)
        {
            return dalHBD.themHDB(hdb);
        }
    }
}
