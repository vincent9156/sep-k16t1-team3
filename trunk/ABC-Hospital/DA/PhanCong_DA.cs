using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class PhanCong_DA
    {
        // Hàm lấy thông tin từ csdl lên c#
        public static List<PhanCong_DO> LayPhanCong()
        {
            List<PhanCong_DO> dsPhancong = new List<PhanCong_DO>();
            
            using (Entities tk = new Entities())
            {
                var query = from u in tk.PhanCongs
                            select new { u.MaNguoiDung, u.VaiTro, u.PhongBan, u.Ban, u.TrangThai };
                foreach(var row in query)
                {
                    PhanCong_DO us = new PhanCong_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._VaiTro = row.VaiTro;
                    us._PhongBan = row.PhongBan;
                    us._Ban = row.Ban;
                    us._TrangThai = row.TrangThai;

                    dsPhancong.Add(us);
                }
            }
            return dsPhancong;

        }
        // Hàm thêm người dùng vào bảng phân công
        public static void ThemPhanCong(string manguoidung, int vaitro, string phongban, string ban, bool trangthaidn)
        {
            using (Entities tk = new Entities())
            {
                PhanCong pc = new PhanCong();
                pc.MaNguoiDung = manguoidung;
                pc.VaiTro = vaitro;
                pc.PhongBan = phongban;
                pc.Ban = ban;
                pc.TrangThai = trangthaidn;

                tk.AddToPhanCongs(pc);
                tk.SaveChanges();

            }
        }
        // Hàm cập nhật người dùng trong bảng phân công
        public static void CapNhatPhanCong(string manguoidung, int vaitro, string phongban, string ban, bool trangthai)
        {
            using (Entities tk = new Entities())
            {
                var query = (from u in tk.PhanCongs
                            where u.MaNguoiDung == manguoidung
                            select u).First();
                query.MaNguoiDung = manguoidung;
                query.VaiTro = vaitro;
                query.PhongBan = phongban;
                query.Ban = ban;
                query.TrangThai = trangthai;

                tk.SaveChanges();
            }
        }
        

        // Hàm lọc người dùng đã đăng nhập tại phòng nào bàn nào
        public static List<PhanCong_DO> LocNguoiDung(string phong, string ban, bool trangthai)
        {
            List<PhanCong_DO> dsPhancong = new List<PhanCong_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.PhanCongs
                            where u.PhongBan == phong &&
                                    u.Ban == ban &&
                                    u.TrangThai == trangthai
                            select u;
                foreach (var row in query)
                {
                    PhanCong_DO us = new PhanCong_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._VaiTro = row.VaiTro;
                    us._PhongBan = row.PhongBan;
                    us._Ban = row.Ban;
                    us._TrangThai = row.TrangThai;

                    dsPhancong.Add(us);
                }                     
            }
            return dsPhancong;
        }
    }
}
