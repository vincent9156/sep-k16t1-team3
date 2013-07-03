using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class NguoiDung_DA
    {
        // Lấy danh sách người dùng từ csdl
        public static List<NguoiDung_DO> LayNguoiDung()
        {
            List<NguoiDung_DO> dsNguoidung = new List<NguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NguoiDungs
                            select u;
                foreach (var row in query)
                {
                    NguoiDung_DO us = new NguoiDung_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._MaNhom = row.MaNhom;
                    us._TenNguoiDung = row.TenNguoiDung;
                    us._MatKhau = row.MatKhau;
                    us._TrangThai = row.TrangThai;
                    dsNguoidung.Add(us);
                }
            }
            return dsNguoidung;
        }
        // Lấy danh sách người dùng theo nhóm người dùng
        public static List<NguoiDung_DO> LayNguoiDungTheoMaNhom(string manhom)
        {
            List<NguoiDung_DO> dsNguoidung = new List<NguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NguoiDungs
                            where u.MaNhom == manhom
                            select u;
                foreach (var row in query)
                {
                    NguoiDung_DO us = new NguoiDung_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._MaNhom = row.MaNhom;
                    us._TenNguoiDung = row.TenNguoiDung;
                    us._MatKhau = row.MatKhau;
                    us._TrangThai = row.TrangThai;
                    dsNguoidung.Add(us);
                }
            }

            return dsNguoidung;
        }
        // Thêm 1 người dùng vào csdl
        public static void ThemNguoiDung(string manguoidung, string manhom, string tennguoidung, string matkhau, bool trangthai)
        {
            using (Entities tk = new Entities())
            {
                NguoiDung ng = new NguoiDung();
                ng.MaNguoiDung = manguoidung;
                ng.MaNhom = manhom;
                ng.TenNguoiDung = tennguoidung;
                ng.MatKhau = matkhau;
                ng.TrangThai = trangthai;
                tk.AddToNguoiDungs(ng);
                tk.SaveChanges();
            }
        }
        // Cập nhật người dùng đã có sẵn trong csdl
        public static void CapNhatNguoiDung(string manguoidung, string manhom, string tennguoidung, string matkhau, bool trangthai)
        {
            using (Entities tk = new Entities())
            {
                var query = (from u in tk.NguoiDungs
                             where u.MaNguoiDung == manguoidung
                             select u).First();
                query.MaNguoiDung = manguoidung;
                query.MaNhom = manhom;
                query.TenNguoiDung = tennguoidung;
                query.MatKhau = matkhau;
                query.TrangThai = trangthai;

                tk.SaveChanges();
            }
        }
        // Tìm kiếm người dùng theo mã
        public static List<NguoiDung_DO> TimKiemTheoMa(string manguoidung)
        {
            List<NguoiDung_DO> dsnguoidung = new List<NguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NguoiDungs
                            where u.MaNguoiDung.ToLower().Contains(manguoidung.ToLower())
                            select u;
                foreach (var row in query)
                {
                    NguoiDung_DO us = new NguoiDung_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._MaNhom = row.MaNhom;
                    us._TenNguoiDung = row.TenNguoiDung;
                    us._MatKhau = row.MatKhau;
                    us._TrangThai = row.TrangThai;
                    dsnguoidung.Add(us);
                }
            }
            return dsnguoidung;
        }
        // Tìm kiếm người dùng theo tên
        public static List<NguoiDung_DO> TimKiemTheoTen(string tennguoidung)
        {
            List<NguoiDung_DO> dsnguoidung = new List<NguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NguoiDungs
                            where u.TenNguoiDung.ToLower().Contains(tennguoidung.ToLower())
                            select u;
                foreach (var row in query)
                {
                    NguoiDung_DO us = new NguoiDung_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._MaNhom = row.MaNhom;
                    us._TenNguoiDung = row.TenNguoiDung;
                    us._MatKhau = row.MatKhau;
                    us._TrangThai = row.TrangThai;
                    dsnguoidung.Add(us);
                }
            }
            return dsnguoidung;
        }
    }
}
