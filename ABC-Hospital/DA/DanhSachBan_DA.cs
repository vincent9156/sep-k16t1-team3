using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class DanhSachBan_DA
    {
        /// <summary>
        /// Hàm lấy danh sách bàn từ db lên
        /// </summary>
        /// <returns></returns>
        public static List<DanhSachBan_DO> LayDanhSachBan(string mactpb)
        {
            List<DanhSachBan_DO> dsBan = new List<DanhSachBan_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.Bans
                            where u.MaCTPB.ToLower().Contains(mactpb.ToLower())
                            select u;
                foreach (var row in query)
                {
                    DanhSachBan_DO us = new DanhSachBan_DO();
                    us._MaBan = row.MaBan;
                    us._MoTa= row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsBan.Add(us);
                }
            }
            return dsBan;
        }
        /// Cập nhật thông tin bàn
        /// </summary>
        public static void CapNhatBan(string maban, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                var query = (from u in sh.Bans
                             where u.MaBan == maban
                             select u).First();
                query.MaBan = maban;
                query.MoTa = mota;
                query.TrangThai = trangthai;
                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Hàm thêm bàn
        /// </summary>
        /// <returns></returns>
        public static void ThemBan(string maban, string mactpb, string mota, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                Ban us = new Ban();
                us.MaBan = maban;
                us.MaCTPB = mactpb;
                us.MoTa = mota;
                us.TrangThai = trangthai;

                sh.AddToBans(us);
                sh.SaveChanges();
            }
        }
        /// <summary>
        /// Hàm lấy mã ctpb lớn nhất trong database
        /// </summary>
        /// <returns></returns>
        public static String MaBanLonNhat()
        {
            string maBan = "";
            using (Entities sh = new Entities())
            {
                var query = from u in sh.Bans
                            select u;
                DanhSachBan_DO us = new DanhSachBan_DO();
                foreach (var row in query)
                {
                    us._MaBan = row.MaBan;
                }
                if (us._MaBan != null)
                {
                    maBan = us._MaBan.ToString();
                }
            }
            return maBan;
        }
    }
}
