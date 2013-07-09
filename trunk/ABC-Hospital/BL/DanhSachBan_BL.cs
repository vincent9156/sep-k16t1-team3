using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;

namespace BL
{
    public class DanhSachBan_BL
    {
        // Hàm lấy chi tiết
        public static List<DanhSachBan_DO> LayDanhSachBan(string mactpb)
        {
            return DA.DanhSachBan_DA.LayDanhSachBan(mactpb);
        }
        // Hàm thêm
        public static void ThemBan(string maban, string mactpb, string mota, bool trangthai)
        {
            DA.DanhSachBan_DA.ThemBan(maban, mactpb, mota, trangthai);
        }
        // Hàm cập nhật
        public static void CapNhatBan(string maban, string mota, bool trangthai)
        {
            DA.DanhSachBan_DA.CapNhatBan(maban, mota, trangthai);
        }
        // Hàm lấy mã lớn nhất
        public static String MaBanLonNhat()
        {
            return DA.DanhSachBan_DA.MaBanLonNhat();
        }
    }
}
