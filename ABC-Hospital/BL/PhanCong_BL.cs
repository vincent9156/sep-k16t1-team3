using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class PhanCong_BL
    {
        public static List<PhanCong_DO> LayPhanCong()
        {
            return DA.PhanCong_DA.LayPhanCong();
        }
        // Hàm thêm phân công
        public static void ThemPhanCong(string manguoidung, int vaitro, string phongban, string ban, bool trangthai)
        {
            DA.PhanCong_DA.ThemPhanCong(manguoidung, vaitro, phongban, ban, trangthai);
        }
        // Hàm update phân công
        public static void CapNhatPhanCong(string manguoidung, int vaitro, string phongban, string ban, bool trangthai)
        {
            DA.PhanCong_DA.CapNhatPhanCong(manguoidung, vaitro, phongban, ban, trangthai);
        }
        // Hàm kiểm tra người dùng đã có trong bản phân công chưa
        public static bool KiemTraNguoiDungDaPhanCong(string manguoidung)
        {
            List<PhanCong_DO> us = LayPhanCong();
            foreach (PhanCong_DO row in us)
            {
                if (manguoidung == row._MaNguoiDung) { return true; }
            }
            return false;
        }
        // Hàm lọc người dùng đã đăng nhập theo phòng và bàn
        public static List<PhanCong_DO> LocNguoiDung(string phong, string ban, bool trangthaidn)
        {
            return DA.PhanCong_DA.LocNguoiDung(phong, ban, trangthaidn);
        }
    }
}
