using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class NhomNguoiDung_BL
    {

        // Hàm lấy danh sách nhóm người dùng
        public static List<NhomNguoiDung_DO> LayNhomNguoiDung()
        {
            return DA.NhomNguoiDung_DA.LayNhomNguoiDung();
        }
        // Thêm 1 record vào danh sách nhóm người dùng
        public static void ThemNhomNguoiDung(string maso, string tennhom, string mota, bool trangthai)
        {
            DA.NhomNguoiDung_DA.ThemNhomNguoiDung(maso, tennhom, mota, trangthai);
        }
        // Hàm cập nhật 1 record trong danh sách nhóm người dùng
        public static void CapNhatNhomNguoiDung(string maso, string tennhom, string mota, bool trangthai)
        {
            DA.NhomNguoiDung_DA.CapNhatNhomNguoiDung(maso, tennhom, mota, trangthai);
        }
        // Hàm tìm kiếm nhóm người dùng theo mã
        public static List<NhomNguoiDung_DO> TimKiemTheoMa(string maso)
        {
            return DA.NhomNguoiDung_DA.TimKiemTheoMa(maso);
        }
        // Hàm tìm kiếm tên theo nhóm người dùng
        public static List<NhomNguoiDung_DO> TimKiemTheoTen(string ten)
        {
            return DA.NhomNguoiDung_DA.TimKiemTheoTen(ten);
        }


    }
}
