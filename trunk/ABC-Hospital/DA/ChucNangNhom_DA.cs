using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class ChucNangNhom_DA
    {
        // Lấy danh sách phân quyền của nhóm từ csdl
        public static List<ChucNangNhom_DO> LayChucNangNhom(string manhom)
        {
            List<ChucNangNhom_DO> dsChucnangnhom = new List<ChucNangNhom_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.ChucNangNhoms
                            where (u.MaNhom == manhom)
                            select u;
                foreach (var row in query)
                {
                    ChucNangNhom_DO us = new ChucNangNhom_DO();
                    us._MaChucNang = row.MaChucNang;
                    us._MaNhom = row.MaNhom;
                    us._TrangThai = row.TrangThai;
                    dsChucnangnhom.Add(us);
                }
            }
            return dsChucnangnhom;
        }
        // Thêm quyền cho nhóm
        public static void ThemQuyenChoNhom(int machucnang, string manhom, bool trangthai)
        {
            using (Entities tk = new Entities())
            {
                ChucNangNhom us = new ChucNangNhom();
                us.MaChucNang = machucnang;
                us.MaNhom = manhom;
                us.TrangThai = trangthai;
                tk.AddToChucNangNhoms(us);
                tk.SaveChanges();
            }
        }
        // Cập nhật quyền cho nhóm
        public static void CapNhatQuyenChoNhom(int machucnang, string manhom, bool trangthai)
        {
            using (Entities tk = new Entities())
            {
                var query = (from u in tk.ChucNangNhoms
                             where u.MaChucNang == machucnang
                             select u).First();
                query.MaChucNang = machucnang;
                query.MaNhom = manhom;
                query.TrangThai = trangthai;
                tk.SaveChanges();
            }
        }
    }
}
