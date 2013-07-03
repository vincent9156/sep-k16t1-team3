using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class NhomNguoiDung_DA
    {
        /// <summary>
        /// Hàm lấy danh sách nhóm người dùng từ db lên
        /// </summary>
        /// <returns></returns>
        public static List<NhomNguoiDung_DO> LayNhomNguoiDung()
        {
            List<NhomNguoiDung_DO> dsNhom = new List<NhomNguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NhomNguoiDungs
                            select u;
                foreach (var row in query)
                {
                    NhomNguoiDung_DO us = new NhomNguoiDung_DO();
                    us._MaNhom = row.MaNhom;
                    us._TenNhom = row.TenNhom;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsNhom.Add(us);
                }
            }
            return dsNhom;
        }
        /// <summary>
        /// Hàm thêm nhóm người dùng vào csdl
        /// </summary>
        /// <param name="manhom"></param>
        /// <param name="tennhom"></param>
        /// <param name="mota"></param>
        /// <param name="trangthai"></param>
        public static void ThemNhomNguoiDung(string manhom, string tennhom, string mota, bool trangthai)
        {
            using (Entities tk = new Entities())
            {
                NhomNguoiDung us = new NhomNguoiDung();
                us.MaNhom = manhom;
                us.TenNhom = tennhom;
                us.MoTa = mota;
                us.TrangThai = trangthai;

                tk.AddToNhomNguoiDungs(us);
                tk.SaveChanges();
            }
        }
        /// <summary>
        /// Cập nhật nhóm người dùng
        /// </summary>
        /// <param name="manhom"></param>
        /// <param name="tennhom"></param>
        /// <param name="mota"></param>
        /// <param name="trangthai"></param>
        public static void CapNhatNhomNguoiDung(string manhom, string tennhom, string mota, bool trangthai)
        {
            using (Entities tk = new Entities())
            {
                var query = (from u in tk.NhomNguoiDungs
                             where u.MaNhom == manhom
                             select u).First();
                query.MaNhom = manhom;
                query.TenNhom = tennhom;
                query.MoTa = mota;
                query.TrangThai = trangthai;

                tk.SaveChanges();
            }
        }
        /// <summary>
        /// Tìm kiếm theo mã nhóm người dùng
        /// </summary>
        /// <param name="maso"></param>
        /// <returns></returns>
        public static List<NhomNguoiDung_DO> TimKiemTheoMa(string maso)
        {
            List<NhomNguoiDung_DO> dsNhom = new List<NhomNguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NhomNguoiDungs
                            where u.MaNhom.ToLower().Contains(maso.ToLower())
                            select u;
                foreach (var row in query)
                {
                    NhomNguoiDung_DO us = new NhomNguoiDung_DO();
                    us._MaNhom = row.MaNhom;
                    us._TenNhom = row.TenNhom;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsNhom.Add(us);
                }
                return dsNhom;
            }
        }
        /// <summary>
        /// Tìm kiếm theo tên nhóm người dùng
        /// </summary>
        /// <param name="ten"></param>
        /// <returns></returns>
        public static List<NhomNguoiDung_DO> TimKiemTheoTen(string ten)
        {
            List<NhomNguoiDung_DO> dsNhom = new List<NhomNguoiDung_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.NhomNguoiDungs
                            where u.TenNhom.ToLower().Contains(ten.ToLower())
                            select u;
                foreach (var row in query)
                {
                    NhomNguoiDung_DO us = new NhomNguoiDung_DO();
                    us._MaNhom = row.MaNhom;
                    us._TenNhom = row.TenNhom;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsNhom.Add(us);
                }
            }
            return dsNhom;
        }


    }
}
