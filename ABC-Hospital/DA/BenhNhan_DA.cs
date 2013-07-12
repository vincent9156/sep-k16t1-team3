using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class BenhNhan_DA
    {
        // Lấy danh sách bệnh nhân theo tên bệnh nhân
        public static List<BenhNhan_DO> LayBenhNhan(string mabn)
        {
            List<BenhNhan_DO> dsBenhnhan = new List<BenhNhan_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.BenhNhans
                            where u.MaBenhNhan.ToLower().Contains(mabn.ToLower())
                            select u;
                foreach (var row in query)
                {
                    BenhNhan_DO us = new BenhNhan_DO();
                    us._MaBenhNhan = row.MaBenhNhan;
                    us._TenBenhNhan = row.TenBenhNhan;
                    us._GioiTinh = row.GioiTinh;
                    us._Tuoi = row.Tuoi;
                    us._DiaChi = row.DiaChi;
                    dsBenhnhan.Add(us);
                }
            }
            return dsBenhnhan;
        }
    }
}
