using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class PhongBan_DA
    {
        /// <summary>
        /// Hàm lấy danh sách phòng ban từ db lên
        /// </summary>
        /// <returns></returns>
        public static List<PhongBan_DO> LayPhongBan()
        {
            List<PhongBan_DO> dsPhongBan = new List<PhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.PhongBans select u;
                foreach (var row in query)
                {
                    PhongBan_DO us = new PhongBan_DO();
                    us._MaPhongBan = row.MaPhongBan;
                    us._TenPhongBan = row.TenPhongBan;
                    us._LoaiPhongBan = DA.LoaiPhongBan_DA.TimKiemTheoMaLayTen(row.MaLoaiPhongBan);
                    us._NhomDichVu = DA.NhomDichVu_DA.TimKiemTheoMaLayTen(row.MaNhomDichVu);
                    us._SoLuongPhong = row.SoLuongPhong;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsPhongBan.Add(us);
                }
            }
            return dsPhongBan;
        }
        /// Cập nhật phòng ban
        /// </summary>
        /// <param name="manhom"></param>
        /// <param name="tenloai"></param>
        /// <param name="mota"></param>
        /// <param name="trangthai"></param>
        public static void CapNhatPhongBan(string maphong, string tenphong,string maloai, string manhomdv, int soluong, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                var query = (from u in sh.PhongBans
                             where u.MaPhongBan == maphong
                             select u).First();
                query.MaPhongBan = maphong;
                query.TenPhongBan = tenphong;
                query.MaLoaiPhongBan = maloai;
                query.MaNhomDichVu = manhomdv;
                query.SoLuongPhong = soluong;
                query.MoTa = mota;
                query.TrangThai = trangthai;

                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Hàm thêm phòng ban
        /// </summary>
        /// <returns></returns>
        public static void ThemPhongBan(string maphong, string tenphong, string maloai, string manhomdv, int soluong, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                PhongBan us = new PhongBan();
                us.MaPhongBan = maphong;
                us.TenPhongBan = tenphong;
                us.MaLoaiPhongBan = maloai;
                us.MaNhomDichVu = manhomdv;
                us.SoLuongPhong = soluong;
                us.MoTa = mota;
                us.TrangThai = trangthai;

                sh.AddToPhongBans(us);
                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Tìm kiếm theo mã phòng ban
        /// </summary>
        /// <param name="maso"></param>
        /// <returns></returns>
        public static List<PhongBan_DO> TimKiemTheoMa(string maso)
        {
            List<PhongBan_DO> dsPhong = new List<PhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.PhongBans
                            where u.MaPhongBan.ToLower().Contains(maso.ToLower())
                            select u;
                foreach (var row in query)
                {
                    PhongBan_DO us = new PhongBan_DO();
                    us._MaPhongBan = row.MaPhongBan;
                    us._TenPhongBan = row.TenPhongBan;
                    us._LoaiPhongBan = DA.LoaiPhongBan_DA.TimKiemTheoMaLayTen(row.MaLoaiPhongBan);
                    us._NhomDichVu = DA.NhomDichVu_DA.TimKiemTheoMaLayTen(row.MaNhomDichVu);
                    us._SoLuongPhong = row.SoLuongPhong;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsPhong.Add(us);
                }
                return dsPhong;
            }
        }
        /// <summary>
        /// Tìm kiếm theo tên phòng ban
        /// </summary>
        /// <param name="ten"></param>
        /// <returns></returns>
        public static List<PhongBan_DO> TimKiemTheoTen(string tenphong)
        {
            List<PhongBan_DO> dsPhong = new List<PhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.PhongBans
                            where u.TenPhongBan.ToLower().Contains(tenphong.ToLower())
                            select u;
                foreach (var row in query)
                {
                    PhongBan_DO us = new PhongBan_DO();
                    us._MaPhongBan = row.MaPhongBan;
                    us._TenPhongBan = row.TenPhongBan;
                    us._LoaiPhongBan = DA.LoaiPhongBan_DA.TimKiemTheoMaLayTen(row.MaLoaiPhongBan);
                    us._NhomDichVu = DA.NhomDichVu_DA.TimKiemTheoMaLayTen(row.MaNhomDichVu);
                    us._SoLuongPhong = row.SoLuongPhong;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsPhong.Add(us);
                }
            }
            return dsPhong;
        }
    }
}
