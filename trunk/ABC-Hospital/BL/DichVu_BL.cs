using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace BL
{
    public class DichVu_BL
    {
        // Hàm load danh sách dịch vụ từ database
        public static List<DichVu_DO> LoadDanhSachDichVu()
        {
            return DA.DichVu_DA.LoadDanhSachDichVu();
        }
        // Hàm thêm danh sách
        public static void ThemDichVu(string madichvu, string manhomdichvu, string tendichvu, string dongia, string mota, bool trangthai)
        {
            DA.DichVu_DA.ThemDichVu(madichvu, manhomdichvu, tendichvu, dongia, mota, trangthai);
        }
        // Hàm cập nhật danh sách
        public static void CapNhatDichVu(string madichvu, string manhomdichvu, string tendichvu, string dongia, string mota, bool trangthai)
        {
            DA.DichVu_DA.CapNhatDichVu(madichvu, manhomdichvu, tendichvu, dongia, mota, trangthai);
        }
        // Hàm lấy danh sách lớn nhất
        public static string LayMaDichVuLonNhat()
        {
            return DA.DichVu_DA.LayMaDichVuLonNhat();
        }
        // Hàm tìm kiếm dịch vụ theo mã
        public static List<DichVu_DO> TimKiemTheoMa(string maso)
        {
            return DA.DichVu_DA.TimKiemTheoMa(maso);
        }
        // Hàm tìm kiếm dịch vụ theo tên
        public static List<DichVu_DO> TimKiemTheoTen(string tenphong)
        {
            return DA.DichVu_DA.TimKiemTheoTen(tenphong);
        }
    }
}
