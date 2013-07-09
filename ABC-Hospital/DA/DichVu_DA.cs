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
        /// Hàm load danh sách dịch vụ từ Database
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
                    us._NhomDichVu = DA.NhomDichVu_DA.TimKiemTheoMaLayTen(row.MaNhomDichVu);
                    us._TenDichVu = row.TenDichVu;
                    us._MoTa = row.MoTa;
                    us._DonGia = row.DonGia;
                    us._TrangThai = row.TrangThai;
                    dsDichVu.Add(us);
                }
            }
            return dsDichVu;
        }
        /// Cập nhật dịch vụ 
        public static void CapNhatDichVu(string madichvu, string manhomdichvu, string tendichvu, string dongia, string mota, bool trangthai)
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
        /// Hàm thêm phòng ban
        public static void ThemDichVu(string madichvu, string manhomdichvu, string tendichvu, string dongia, string mota, bool trangthai)
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
        // Hàm lấy mã dịch vụ lớn nhất
        public static String LayMaDichVuLonNhat()
        {
            string maDichVu;
            using (Entities mh = new Entities())
            {
                var query = from u in mh.DichVus select u;
                DichVu_DO us = new DichVu_DO();
                foreach (var row in query)
                {
                    us._MaDichVu = row.MaDichVu;
                }
                maDichVu = us._MaDichVu.ToString();
            }
            return maDichVu;
        }
        /// <summary>
        /// Tìm kiếm theo mã dịch vụ
        public static List<DichVu_DO> TimKiemTheoMa(string maso)
        {
            List<DichVu_DO> dsDichVu = new List<DichVu_DO>();
            using (Entities mh = new Entities())
            {
                var query = from u in mh.DichVus
                            where u.MaDichVu.ToLower().Contains(maso.ToLower())
                            select u;
                foreach (var row in query)
                {
                    DichVu_DO us = new DichVu_DO();
                    us._MaDichVu = row.MaDichVu;
                    us._NhomDichVu = DA.NhomDichVu_DA.TimKiemTheoMaLayTen(row.MaNhomDichVu);
                    us._TenDichVu = row.TenDichVu;
                    us._MoTa = row.MoTa;
                    us._DonGia = row.DonGia;
                    us._TrangThai = row.TrangThai;
                    dsDichVu.Add(us);
                }
                return dsDichVu;
            }
        }
        /// <summary>
        /// Tìm kiếm theo tên dịch vụ
        public static List<DichVu_DO> TimKiemTheoTen(string tendichvu)
        {
            List<DichVu_DO> dsDichVu = new List<DichVu_DO>();
            using (Entities mh = new Entities())
            {
                var query = from u in mh.DichVus
                            where u.TenDichVu.ToLower().Contains(tendichvu.ToLower())
                            select u;
                foreach (var row in query)
                {
                    DichVu_DO us = new DichVu_DO();
                    us._MaDichVu = row.MaDichVu;
                    us._NhomDichVu = DA.NhomDichVu_DA.TimKiemTheoMaLayTen(row.MaNhomDichVu);
                    us._TenDichVu = row.TenDichVu;
                    us._MoTa = row.MoTa;
                    us._DonGia = row.DonGia;
                    us._TrangThai = row.TrangThai;
                    dsDichVu.Add(us);
                }
            }
            return dsDichVu;
        }
    }
}
