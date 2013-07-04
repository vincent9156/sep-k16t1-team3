using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class LoaiPhongBan_DA
    {
        /// <summary>
        /// Hàm lấy danh sách phòng ban từ db lên
        /// </summary>
        /// <returns></returns>
        public static List<LoaiPhongBan_DO> LayLoaiPhongBan()
        {
            List<LoaiPhongBan_DO> dsLoaiPhongBan = new List<LoaiPhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.LoaiPhongBans select u;
                foreach (var row in query)
                {
                    LoaiPhongBan_DO us = new LoaiPhongBan_DO();
                    us._MaLoaiPhongBan = row.MaLoaiPhongBan;
                    us._TenLoaiPhongBan= row.TenLoaiPhongBan;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsLoaiPhongBan.Add(us);
                }
            }
            return dsLoaiPhongBan;
        }
        /// <summary>
        /// Hàm lấy danh sách loại phòng ban từ db lên
        /// </summary>
        /// <returns></returns>
        public static void ThemLoaiPhongBan(string manhom, string tenloai, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                LoaiPhongBan us = new LoaiPhongBan();
                us.MaLoaiPhongBan = manhom;
                us.TenLoaiPhongBan = tenloai;
                us.MoTa = mota;
                us.TrangThai = trangthai;

                sh.AddToLoaiPhongBans(us);
                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Cập nhật nhóm loại phòng ban
        /// </summary>
        /// <param name="manhom"></param>
        /// <param name="tenloai"></param>
        /// <param name="mota"></param>
        /// <param name="trangthai"></param>
        public static void CapNhatLoaiPhongBan(string manhom, string tenloai, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                var query = (from u in sh.LoaiPhongBans
                             where u.MaLoaiPhongBan == manhom
                             select u).First();
                query.MaLoaiPhongBan = manhom;
                query.TenLoaiPhongBan = tenloai;
                query.MoTa = mota;
                query.TrangThai = trangthai;

                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Tìm kiếm theo mã nhóm loại phòng ban
        /// </summary>
        /// <param name="maso"></param>
        /// <returns></returns>
        public static List<LoaiPhongBan_DO> TimKiemTheoMa(string maso)
        {
            List<LoaiPhongBan_DO> dsNhom = new List<LoaiPhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.LoaiPhongBans
                            where u.MaLoaiPhongBan.ToLower().Contains(maso.ToLower())
                            select u;
                foreach (var row in query)
                {
                    LoaiPhongBan_DO us = new LoaiPhongBan_DO();
                    us._MaLoaiPhongBan = row.MaLoaiPhongBan;
                    us._TenLoaiPhongBan = row.TenLoaiPhongBan;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsNhom.Add(us);
                }
                return dsNhom;
            }
        }
        /// <summary>
        /// Tìm kiếm theo tên nhóm loại phòng ban
        /// </summary>
        /// <param name="ten"></param>
        /// <returns></returns>
        public static List<LoaiPhongBan_DO> TimKiemTheoTen(string tenloai)
        {
            List<LoaiPhongBan_DO> dsNhom = new List<LoaiPhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.LoaiPhongBans
                            where u.TenLoaiPhongBan.ToLower().Contains(tenloai.ToLower())
                            select u;
                foreach (var row in query)
                {
                    LoaiPhongBan_DO us = new LoaiPhongBan_DO();
                    us._MaLoaiPhongBan = row.MaLoaiPhongBan;
                    us._TenLoaiPhongBan = row.TenLoaiPhongBan;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsNhom.Add(us);
                }
            }
            return dsNhom;
        }
    }
}
