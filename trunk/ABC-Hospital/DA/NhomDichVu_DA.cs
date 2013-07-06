using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;


namespace DA
{
    public class NhomDichVu_DA
    {
        //lay danh sach nhom dich vu tu csdl
        public static List<NhomDichVu_DO> LayNhomDIchVu()
        {
            List<NhomDichVu_DO> dsNhomDIchVu = new List<NhomDichVu_DO>();
            using (Entities hd = new Entities())
            {
                var query = from u in hd.NhomDichVus select u;
                foreach (var row in query)
                {
                    NhomDichVu_DO us = new NhomDichVu_DO();
                    us._MaNhomDichVu = row.MaNhomDichVu;
                    us._TenNhomDichVu = row.TenNhomDichVu;
                    us._MoTa = row.MoTa;
                    us._TrangThai = row.TrangThai;
                    dsNhomDIchVu.Add(us);
                }
            }
            return dsNhomDIchVu;
        }
        // Thêm 1 nhom dich vu vào csdl
        public static void ThemNhomDichVu(string MaNhom, string TenNhom, string MoTa, bool TrangThai)
        {
            using (Entities hd = new Entities())
            {
                NhomDichVu us = new NhomDichVu();
                us.MaNhomDichVu = MaNhom;
                us.TenNhomDichVu = TenNhom;
                us.MoTa = MoTa;
                us.TrangThai = TrangThai;
                hd.AddToNhomDichVus(us);
                hd.SaveChanges();

            }
        }
        // Cập nhật nhom dich vu đã có sẵn trong csdl
        public static void CapNhatNhomDichVu(string manhom, string tennhom, string mota, bool trangthai)
        {
            using (Entities hd = new Entities())
            {
                var query = (from u in hd.NhomDichVus
                             where u.MaNhomDichVu == manhom
                             select u).First();
                query.MaNhomDichVu = manhom;
                query.TenNhomDichVu = tennhom;
                query.MoTa = mota;
                query.TrangThai = trangthai;

                hd.SaveChanges();
            }
        }
        // Tìm kiếm nhom dich vu theo mã
        // Tìm kiếm nhom dich vu theo tên
    }
}
