using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class ChucNangNhom_BL
    {
        // Hàm lấy danh sách quyền theo nhóm
        public static List<ChucNangNhom_DO> LayChucNangNhom(string manhom)
        {
            return DA.ChucNangNhom_DA.LayChucNangNhom(manhom);
        }
        // Hàm thêm quyền cho 1 nhóm mới
        public static void ThemQuyenChoNhom(int machucnang, string manhom, bool trangthai)
        {
            DA.ChucNangNhom_DA.ThemQuyenChoNhom(machucnang, manhom, trangthai);
        }
        // Hàm cập nhật quyền cho 1 nhóm có sẵn trong csdl
        public static void CapNhatQuyenChoNhom(int machucnang, string manhom, bool trangthai)
        {
            DA.ChucNangNhom_DA.CapNhatQuyenChoNhom(machucnang, manhom, trangthai);
        }
    }
}
