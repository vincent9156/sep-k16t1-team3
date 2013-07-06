using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class DichVu_BL
    {
        public static List<DichVu_DO> LoadDanhSachDichVu()
        {
            return DA.DichVu_DA.LoadDanhSachDichVu();
        }
        public static List<DichVu_DO> TimKiemTheoMa(string madichvu)
        {
            return DA.DichVu_DA.TimKiemTheoMa(madichvu);
        }
        public static List<DichVu_DO> TimKiemTheoTen(string tenloai)
        {
            return DA.DichVu_DA.TimKiemTheoTen(tenloai);
        }
    }
}
