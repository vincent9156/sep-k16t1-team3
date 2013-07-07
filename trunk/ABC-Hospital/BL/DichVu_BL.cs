using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
namespace BL
{
    public class DichVu_BL
    {
            // Hàm load danh sáhc dịch vụ
        public static List<DichVu_DO> LoadDanhSachDichVu()
        {
            return DA.DichVu_DA.LoadDanhSachDichVu();
        }
            // Hàm tìm kiếm theo theo mã dịch vụ
        public static List<DichVu_DO> TimKiemTheoMa(string madichvu)
        {
            return DA.DichVu_DA.TimKiemTheoMa(madichvu);
        }
            // Hàm tìm kiếm theo tên dịch vụ
        public static List<DichVu_DO> TimKiemTheoTen(string tenloai)
        {
            return DA.DichVu_DA.TimKiemTheoTen(tenloai);
        }
            // Hàm thêm mới một dịch vụ
        public static void ThemDichVu(string maso, string manhomdichvu, string tendichvu, int dongia, string mota, bool trangthai)
        {
            DA.DichVu_DA.ThemDichVu(maso, manhomdichvu, tendichvu, dongia, mota, trangthai);
            
        }
            // Hàm cập nhật dịch vụ
        public static void CapNhatDichVu(string maso, string manhomdichvu, string tendichvu, int dongia, string mota, bool trangthai)
        {
            DA.DichVu_DA.CapNhatDichVu(maso, manhomdichvu, tendichvu, dongia, mota, trangthai);

        }
    }
}
