using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class BenhNhan_BL
    {
        // Lấy danh sách bệnh nhân từ db bằng mã bệnh nhân
        public static List<BenhNhan_DO> LayBenhNhan(string mabn)
        {
            return DA.BenhNhan_DA.LayBenhNhan(mabn);
        }
    }
}
