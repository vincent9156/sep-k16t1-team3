using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class HoaDon_DA
    {
        // Hàm lưu hóa đơn 
        public static void ThemHoaDon(string mabenhnhan, string maphongban, string manguoinhap, string manguoithu, string gioitinh, int tuoi, int tongtien,string ngaythang, bool trangthai)
        {
            using (Entities sh = new Entities())
            {
                //HoaDon us = new HoaDon();

                //sh.ExecuteStoreCommand("EXEC sp_TangMa '"+mabenhnhan+"','"+maphongban+"','"+manguoinhap+"','"+manguoithu+"','"+gioitinh+"',"+tuoi+","+tongtien+","+trangthai+"");
                sh.SP_TangMa(mabenhnhan, maphongban, manguoinhap, manguoithu, gioitinh, tuoi, tongtien, ngaythang, trangthai);
                //sh.ExecuteStoreCommand("EXEC sp_TangMa 'A130000001','TN','AD00001','AD00002','NU',19,200000,TRUE");
                sh.SaveChanges();
            }
        }
        // Hàm lấy mã hóa đơn theo benh nhan va phong ban
        public static String LayMaHD(string mabenhnhan, string mapb)
        {
            string maHD;
            using (Entities sh = new Entities())
            {
                var query = from u in sh.HoaDons
                            where u.MaBenhNhan == mabenhnhan
                                && u.MaPhongBan == mapb
                            select u;
                HoaDon_DO us = new HoaDon_DO();
                foreach (var row in query)
                {
                    us._MaHoaDon = row.MaHoaDon;
                }
                maHD = us._MaHoaDon.ToString();
            }
            return maHD;
        }
        // lây danh sách bênh nhân chờ xác nhận hóa đơn
        /*public static List<HoaDon_DO> DSBenhNhanCho(string manguoinhap, DateTime ngaythang, bool trangthai)
        {
            List<HoaDon_DO> dsBenhNhanCho = new List<HoaDon_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.HoaDons
                            where u.MaNguoiNhap == manguoinhap
                            && u.NgayThang.ToString().Contains(ngaythang.ToShortDateString())
                            && u.TrangThai == trangthai
                            select u;
                foreach (var row in query)
                {
                    HoaDon_DO us = new HoaDon_DO();
                    us._MaBenhNhan = row.MaBenhNhan;
                    us._TenBenhNhan = DA.BenhNhan_DA.LayTenBenhNhan(row.MaBenhNhan);

                    dsBenhNhanCho.Add(us);
                }
                return dsBenhNhanCho;
            }*/
    }
}

