using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA
{
    public class NguoiDung_DA
    {
        /// <summary>
        /// Hàm lấy danh sách người dùng từ db lên
        /// </summary>
        /// <returns></returns>
        public static List<NguoiDung_DO> LayNguoiDung(){
            List<NguoiDung_DO> dsNguoiDung = new List<NguoiDung_DO>();
            using (Entities sh = new Entities())
            {
                var query = from u in sh.NguoiDungs select u;
                foreach (var row in query)
                {
                    NguoiDung_DO us = new NguoiDung_DO();
                    us._MaNguoiDung = row.MaNguoiDung;
                    us._MaNhom = row.MaNhom;
                    us._TenNguoiDung = row.TenNguoiDung;
                    us._MatKhau = row.MatKhau;
                    us._TrangThai = row.TrangThai;
                    dsNguoiDung.Add(us);
                }
            }
            return dsNguoiDung;
        }
        /// <summary>
        /// Hàm giá trị lớn nhất trong mã người dùng
        /// </summary>
        /// <returns></returns>
        public static String LayMaLonNhat(string manhom)
        {
            string maLonNhat;
            using (Entities sh = new Entities())
            {
                var query = from u in sh.NguoiDungs 
                            where u.MaNhom == manhom
                            select u;
                NguoiDung_DO us = new NguoiDung_DO();
                foreach (var row in query)
                {
                    
                    us._MaNguoiDung = row.MaNguoiDung;
                }
                maLonNhat = us._MaNguoiDung.ToString();
            }
            return maLonNhat;
        }
    }
}
