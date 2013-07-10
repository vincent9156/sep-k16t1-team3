using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class ChucNang_BL
    {
        // Hàm lấy danh sách chức năng từ csdl
        public static List<ChucNang_DO> LayChucNang()
        {
            return DA.ChucNang_DA.LayChucNang();
        }

        public static string TimKiemTheoMaLayTen(int maso)
        {
            return DA.ChucNang_DA.TimKiemTheoMaLayTen(maso);
        }

    }
}
