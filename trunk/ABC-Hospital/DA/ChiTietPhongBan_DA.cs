using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class ChiTietPhongBan_DA
    {
        /// <summary>
        /// Hàm lấy danh sách chi tiết phòng ban từ db lên
        /// </summary>
        /// <returns></returns>
        public static List<ChiTietPhongBan_DO> LayChiTietPhongBan(string maphong)
        {
            List<ChiTietPhongBan_DO> dsChiTietPhongBan = new List<ChiTietPhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.ChiTietPhongBans 
                            where u.MaPhongBan.ToLower().Contains(maphong.ToLower())
                            select u;
                foreach (var row in query)
                {
                    ChiTietPhongBan_DO us = new ChiTietPhongBan_DO();
                    us._MaCTPB = row.MaCTPB;
                    us._PhongSo = row.PhongSo;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsChiTietPhongBan.Add(us);
                }
            }
            return dsChiTietPhongBan;
        }
        /// Cập nhật chi tiết phòng ban
        /// </summary>
        /// <param name="manhom"></param>
        /// <param name="tenloai"></param>
        /// <param name="mota"></param>
        /// <param name="trangthai"></param>
        public static void CapNhatChiTietPhongBan(string mactpb, string phongso, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                var query = (from u in sh.ChiTietPhongBans
                             where u.MaCTPB == mactpb
                             select u).First();
                query.MaCTPB= mactpb;
                query.PhongSo = phongso;
                query.MoTa = mota;
                query.TrangThai = trangthai;
                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Hàm thêm chi tiết phòng ban
        /// </summary>
        /// <returns></returns>
        public static void ThemChiTietPhongBan(string mactpb, string phongso,string phongban, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                ChiTietPhongBan us = new ChiTietPhongBan();
                us.MaCTPB = mactpb;
                us.PhongSo = phongso;
                us.MaPhongBan = phongban;
                us.MoTa = mota;
                us.TrangThai = trangthai;

                sh.AddToChiTietPhongBans(us);
                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Hàm lấy mã ctpb lớn nhất trong database
        /// </summary>
        /// <returns></returns>
        public static String MaChiTietPhongBanLonNhat(string maphong)
        {
            string maChiTietPhongBan="";
            using (Entities sh = new Entities())
            {
                var query = from u in sh.ChiTietPhongBans
                            where u.MaCTPB.ToLower().Contains(maphong.ToLower())
                            select u;
                ChiTietPhongBan_DO us = new ChiTietPhongBan_DO();
                foreach (var row in query)
                {  
                    us._MaCTPB = row.MaCTPB;
                }
                if (us._MaCTPB != null)
                {
                    maChiTietPhongBan = us._MaCTPB.ToString();
                }
            }
            return maChiTietPhongBan;
        }
        /// <summary>
        /// Tìm kiếm theo mã 
        /// </summary>
        /// <param name="maso"></param>
        /// <returns></returns>
        public static List<ChiTietPhongBan_DO> TimKiemTheoMa(string maso,string maphong)
        {
            List<ChiTietPhongBan_DO> dsChiTietPhongBan = new List<ChiTietPhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.ChiTietPhongBans
                            where u.MaPhongBan.ToLower().Contains(maphong.ToLower()) && u.MaCTPB.ToLower().Contains(maso.ToLower())                                  
                            select u;
                foreach (var row in query)
                {
                    ChiTietPhongBan_DO us = new ChiTietPhongBan_DO();
                    us._MaCTPB = row.MaCTPB;
                    us._PhongSo = row.PhongSo;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsChiTietPhongBan.Add(us);
                }
                return dsChiTietPhongBan;
            }
        }
        /// <summary>
        /// Tìm kiếm theo tên 
        /// </summary>
        /// <param name="ten"></param>
        /// <returns></returns>
        public static List<ChiTietPhongBan_DO> TimKiemTheoTen(string tenphong,string maphong)
        {
            List<ChiTietPhongBan_DO> dsChiTietPhongBan = new List<ChiTietPhongBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.ChiTietPhongBans
                            where u.MaPhongBan.ToLower().Contains(maphong.ToLower()) && u.PhongSo.ToLower().Contains(tenphong.ToLower())  
                            select u;
                foreach (var row in query)
                {
                    ChiTietPhongBan_DO us = new ChiTietPhongBan_DO();
                    us._MaCTPB = row.MaCTPB;
                    us._PhongSo = row.PhongSo;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsChiTietPhongBan.Add(us);
                }
            }
            return dsChiTietPhongBan;
        }
    }
}
