using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class DangNhap_DA
    {
        // Hàm lấy tài khoản người dùng 
        public static List<NguoiDung_DO> LayNguoiDung()
        {
            List<NguoiDung_DO> ngdung = new List<NguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NguoiDungs
                            select new { u.MaNguoiDung, u.MatKhau };
                foreach (var row in query)
                {
                    NguoiDung_DO us = new NguoiDung_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._MatKhau = row.MatKhau;
                    ngdung.Add(us);
                }
            }
            return ngdung;
        }

        // Lấy quyền theo nhóm ( đăng nhập theo tài khoản)
        public static List<ChucNangNhom_DO> LayQuyen(string manhom)
        {
            List<ChucNangNhom_DO> quyen = new List<ChucNangNhom_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.ChucNangNhoms
                            where u.MaNhom == manhom
                            select new { u.TrangThai, u.MaChucNang };
                foreach (var row in query)
                {
                    ChucNangNhom_DO us = new ChucNangNhom_DO();
                    us._TrangThai = row.TrangThai;
                    us._MaChucNang = row.MaChucNang;
                    quyen.Add(us);
                }
            }
            return quyen;
        }
    }
}
