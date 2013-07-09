using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace BL
{
    public class ChiTietPhongBan_BL
    {
        // Hàm lấy chi tiết phòng ban
        public static List<ChiTietPhongBan_DO> LayChiTietPhongBan(string maphong)
        {
            return DA.ChiTietPhongBan_DA.LayChiTietPhongBan(maphong);
        }
        // Hàm thêm chi tiet phòng ban
        public static void ThemChiTietPhongBan(string mactpb, string phongso,string phongban, string mota, bool trangthai)
        {
            DA.ChiTietPhongBan_DA.ThemChiTietPhongBan(mactpb, phongso, phongban, mota, trangthai);
        }
        // Hàm cập nhật loại chi tiet phòng ban
        public static void CapNhatChiTietPhongBan(string mactpb, string phongso, string mota, bool trangthai)
        {
            DA.ChiTietPhongBan_DA.CapNhatChiTietPhongBan(mactpb, phongso, mota, trangthai);
        }
        // Hàm lấy mã ctpb lớn nhất
        public static String MaChiTietPhongBanLonNhat(string maphong)
        {
            return DA.ChiTietPhongBan_DA.MaChiTietPhongBanLonNhat(maphong);
        }
        // Hàm tìm kiếm theo mã
        public static List<ChiTietPhongBan_DO> TimKiemTheoMa(string maso, string maphong)
        {
            return DA.ChiTietPhongBan_DA.TimKiemTheoMa(maso, maphong);
        }
        // Hàm tìm kiếm theo tên
        public static List<ChiTietPhongBan_DO> TimKiemTheoTen(string tenphong, string maphong)
        {
            return DA.ChiTietPhongBan_DA.TimKiemTheoTen(tenphong, maphong);
        }
    }
}
