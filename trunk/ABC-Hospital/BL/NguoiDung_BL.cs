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
        // Hàm lấy danh sách người dùng theo nhóm người dùng
        public static List<NguoiDung_DO> LayNguoiDungTheoMaNhom(string manhom)
        {
            return DA.NguoiDung_DA.LayNguoiDungTheoMaNhom(manhom);
        }
        // Hàm thêm 1 người dùng vào cơ sở dữ liệu
        public static void ThemNguoiDung(string manguoidung, string manhom, string tennguoidung, string matkhau, bool trangthai)
        {
            DA.NguoiDung_DA.ThemNguoiDung(manguoidung,manhom,tennguoidung,matkhau,trangthai);
        }
        // Hàm cập nhật 1 người dùng có sẵn trong csdl
        public static void CapNhatNguoiDung(string manguoidung, string manhom, string tennguoidung, string matkhau, bool trangthai)
        {
            DA.NguoiDung_DA.CapNhatNguoiDung(manguoidung, manhom, tennguoidung, matkhau, trangthai);
        }
        // Hàm tìm kiếm theo mã tên người dùng
        public static List<NguoiDung_DO> TimKiemTheoMa(string manguoidung)
        {
            return DA.NguoiDung_DA.TimKiemTheoMa(manguoidung);
        }
        // Hàm tìm kiếm người dùng theo tên người dùng
        public static List<NguoiDung_DO> TimKiemTheoTen(string tennguoidung)
        {
            return DA.NguoiDung_DA.TimKiemTheoTen(tennguoidung);
        }
    }
}
