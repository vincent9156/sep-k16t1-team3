using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using DA;
namespace BL
{
    public class HoaDon_BL
    {
        // Hàm lưu hóa đơn
        public static void ThemHoaDon(string mabenhnhan, string maphongban, string manguoinhap, string manguoithu, string gioitinh, int tuoi, int tongtien, string ngaythang, bool trangthai)
        {
            DA.HoaDon_DA.ThemHoaDon(mabenhnhan, maphongban, manguoinhap, manguoithu, gioitinh, tuoi, tongtien, ngaythang, trangthai);
        }
        // Hàm lấy mã hd theo nhóm dv
        public static String LayMaHDTheoNhomDV(string mabenhnan, string mapb)
        {
            return DA.HoaDon_DA.LayMaHD(mabenhnan, mapb);
        }
        // Hàm lấy ds bệnh nhân chờ
        /*public static List<HoaDon_DO> LayDSBenhNhanCho(string manguoinhap, DateTime ngaythang, bool trangthai)
        {
            //return DA.HoaDon_DA.DSBenhNhanCho(manguoinhap, ngaythang, trangthai);
        }*/
    }
}
