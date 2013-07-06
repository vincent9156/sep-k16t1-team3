using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;

namespace BL
{
    public class NhomDichVu_BL
    {
        //lay danh sach nhom dich vu tu DA sang BL
        public static List<NhomDichVu_DO> LayDanhSachNhomDichVu()
        {
            return DA.NhomDichVu_DA.LayNhomDIchVu();
        }
         // them 1 Nhom DIch Vu vao danh dach nhom dich vu
        public static void ThemNhomDichVu(string MaNhom, string TenNhom, string Mota, bool TrangThai)
        {
            DA.NhomDichVu_DA.ThemNhomDichVu(MaNhom, TenNhom, Mota, TrangThai);
        }
        // cap nhat nhom dich vu
        public static void CapNhatNhomDichVu(string MaNhom, string TenNhom, string Mota, bool TrangThai)
        {
            DA.NhomDichVu_DA.CapNhatNhomDichVu(MaNhom, TenNhom, Mota, TrangThai);
        }
    }
        
}
