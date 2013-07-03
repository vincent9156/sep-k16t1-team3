using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class NguoiDung_BL
    {
        // Hàm lấy danh sách người dùng
        public static List<NguoiDung_DO> LayNguoiDung()
        {
            return DA.NguoiDung_DA.LayNguoiDung();
        }
        //Hàm lấy mã người dùng lớn nhất
        public static String LayMaLonNhat(string manhom)
        {
            return DA.NguoiDung_DA.LayMaLonNhat(manhom);
        }
    }
}
