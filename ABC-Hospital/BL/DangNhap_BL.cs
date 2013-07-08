using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
using System.Text.RegularExpressions;
namespace BL
{
    public class DangNhap_BL
    {
        // Hàm kiểm tính hợp lệ khi người dùng nhập vào 
        public static bool KiemTraHopLe(string username, string password)
        {
            if (Regex.IsMatch(username, "^[a-zA-Z0-9]{1,20}$")
             && Regex.IsMatch(password, "^[a-zA-Z0-9]{6,50}$"))
            {
                return true;
            }
            return false;
        }
        // Hàm kiểm tra tính đúng đắn của tài khoản
        public static bool KiemTraDungTK(string user, string pass)
        {
            List<NguoiDung_DO> ds = BL.NguoiDung_BL.LayNguoiDung();
            foreach (NguoiDung_DO line in ds)
            {
                if (line._MaNguoiDung == user && line._MatKhau == pass)
                {
                    return true;
                }
            }
            return false;
        }
        // Lấy người dùng trong danh sách người dùng để kiểm tra user vs pass
        public static List<NguoiDung_DO> LayNguoiDung()
        {
            return DA.DangNhap_DA.LayNguoiDung();
        }
        // Lấy quyền theo nhóm ( đăng nhập theo tài khoản)
        public static List<ChucNangNhom_DO> LayQuyen(string manhom)
        {
            return DA.DangNhap_DA.LayQuyen(manhom);
        }
    }
}
