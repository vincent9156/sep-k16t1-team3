using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class DichVu_DA
    {
        /// <summary>
        /// Hàm lấy danh sách dịch vụ từ Database
        /// </summary>
        /// <returns></returns>
        public static List<DichVu_DO> LoadDanhSachDichVu()
        {
            List<DichVu_DO> dsDichVu = new List<DichVu_DO>();
            using (Entities mh = new Entities())
            {
                var query = from u in mh.DichVus select u;
                foreach (var row in query)
                {
                DichVu_DO us = new DichVu_DO();
                us._MaDichVu = row.MaDichVu;
                us._MaNhomDichVu = row.MaNhomDichVu;
                us._TenDichVu = row.TenDichVu;
                us._DonGia = row.DonGia;
                us._MoTa = row.MoTa;
                us._TrangThai = row.TrangThai;
                dsDichVu.Add(us);
                }
            }
        return dsDichVu;
        }
        /// <summary>
        /// Tìm kiếm theo mã dịch vụ
        /// </summary>
        /// <returns></returns>
        public static List<DichVu_DO> TimKiemTheoMa(string madichvu)
        {
            List<DichVu_DO> dsDichVu = new List<DichVu_DO>();
            using (Entities mh = new Entities())
            {
                var query = from u in mh.DichVus
                            where u.MaDichVu.ToLower().Contains(madichvu.ToLower())
                            select u;
                foreach (var row in query)
                {
                    DichVu_DO us = new DichVu_DO();
                    us._MaDichVu = row.MaDichVu;
                    us._MaNhomDichVu = row.MaNhomDichVu;
                    us._TenDichVu = row.TenDichVu;
                    us._DonGia = row.DonGia;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsDichVu.Add(us);
                }
             }
            return dsDichVu;
        }
        /// <summary>
        /// Tìm kiếm theo tên dịch vụ
        /// </summary>
        /// <returns></returns>
        public static List<DichVu_DO> TimKiemTheoTen(string tenloai)
        {
            List<DichVu_DO> dsDichVu = new List<DichVu_DO>();
            using (Entities mh = new Entities())
            {
                var query = from u in mh.DichVus
                            where u.TenDichVu.ToLower().Contains(tenloai.ToLower())
                            select u;
                foreach (var row in query)
                {
                    DichVu_DO us = new DichVu_DO();
                    us._MaDichVu = row.MaDichVu;
                    us._MaNhomDichVu = row.MaNhomDichVu;
                    us._TenDichVu = row.TenDichVu;
                    us._DonGia = row.DonGia;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsDichVu.Add(us);
                }
            }
            return dsDichVu;
        }
        /// <summary>
        /// Cập nhật dịch vụ
        /// </summary>
        /// <param name="madichvu"></param>
        /// <param name="manhomdicvu"></param>
        /// <param name="tendichvu"></param>
        /// <param name="dongia"></param>
        /// <param name="mota"></param>
        /// <param name="trangthai"></param>
        public static void CapNhatDichVu(string madichvu, string manhomdichvu, string tendichvu, int dongia, string mota, bool trangthai)
        {
            using (Entities mh = new Entities())
            {
                 var query = (from u in mh.DichVus
                             where u.MaDichVu == madichvu
                             select u).First();
                query.MaDichVu = madichvu;
                query.MaNhomDichVu = manhomdichvu;
                query.TenDichVu = tendichvu;
                query.DonGia = dongia;
                query.MoTa = mota;
                query.TrangThai = trangthai;

                mh.SaveChanges();                             
            }
        }
        /// <summary>
        /// Hàm thêm loại phòng ban
        /// </summary>
        /// <returns></returns>   
        public static void ThemDichVu(string madichvu, string manhomdichvu, string tendichvu, int dongia, string mota, bool trangthai)
        {
            using (Entities mh = new Entities())
            {
                DichVu us = new DichVu();
                us.MaDichVu = madichvu;
                us.MaNhomDichVu = manhomdichvu;
                us.TenDichVu = tendichvu;
                us.DonGia = dongia;
                us.MoTa = mota;
                us.TrangThai = trangthai;

                mh.AddToDichVus(us);
                mh.SaveChanges();
            }
        }
    }
}
