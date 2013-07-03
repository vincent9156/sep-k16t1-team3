using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class LoaiPhongBan_BL
    {
          // Hàm lấy danh sách người dùng
        public static List<LoaiPhongBan_DO> LayLoaiPhongBan()
        {
            return DA.LoaiPhongBan_DA.LayLoaiPhongBan();
        }
        // Hàm thêm loại phòng ban
        public static void ThemLoaiPhongBan(string maso, string tenloai, string mota, bool trangthai)
        {
            DA.LoaiPhongBan_DA.ThemLoaiPhongBan(maso, tenloai, mota, trangthai);
        }
        // Hàm cập nhật loại phòng ban
        public static void CapNhaLoaiPhongBan(string maso, string tenloai, string mota, bool trangthai)
        {
            DA.LoaiPhongBan_DA.CapNhatLoaiPhongBan(maso, tenloai, mota, trangthai);
        }
        // Hàm tìm kiếm loại phòng ban theo mã
        public static List<LoaiPhongBan_DO> TimKiemTheoMa(string maso)
        {
            return DA.LoaiPhongBan_DA.TimKiemTheoMa(maso);
        }
        // Hàm tìm kiếm loại phòng ban theo tên
        public static List<LoaiPhongBan_DO> TimKiemTheoTen(string tenloai)
        {
            return DA.LoaiPhongBan_DA.TimKiemTheoTen(tenloai);
        }
    }
}
