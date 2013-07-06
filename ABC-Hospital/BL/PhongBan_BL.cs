using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace BL
{
    public class PhongBan_BL
    {
        // Hàm lấy danh sách phong ban
        public static List<PhongBan_DO> LayPhongBan()
        {
            return DA.PhongBan_DA.LayPhongBan();
        }
        // Hàm thêm phòng ban
        public static void ThemPhongBan(string maphong, string tenphong, string maloai, string manhomdv, int soluong, string mota, bool trangthai)
        {
            DA.PhongBan_DA.ThemPhongBan(maphong, tenphong, maloai, manhomdv, soluong, mota, trangthai);
        }
        // Hàm cập nhật loại phòng ban
        public static void CapNhatPhongBan(string maphong, string tenphong, string maloai, string manhomdv, int soluong, string mota, bool trangthai)
        {
            DA.PhongBan_DA.CapNhatPhongBan(maphong, tenphong, maloai, manhomdv, soluong, mota, trangthai);
        }
        // Hàm tìm kiếm phòng ban theo mã
        public static List<PhongBan_DO> TimKiemTheoMa(string maso)
        {
            return DA.PhongBan_DA.TimKiemTheoMa(maso);
        }
        // Hàm tìm kiếm phòng ban theo tên
        public static List<PhongBan_DO> TimKiemTheoTen(string tenphong)
        {
            return DA.PhongBan_DA.TimKiemTheoTen(tenphong);
        }
    }
}
