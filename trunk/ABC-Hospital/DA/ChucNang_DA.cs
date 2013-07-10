using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
namespace DA
{
    public class ChucNang_DA
    {
        // Hàm lấy danh sách chức năng từ dưới csdl
        public static List<ChucNang_DO> LayChucNang()
        {
            List<ChucNang_DO> dsChucnang = new List<ChucNang_DO>();
            using (Entities tk = new Entities())
            {
                var query = from u in tk.ChucNangs
                            select u;

                foreach (var row in query)
                {
                    ChucNang_DO us = new ChucNang_DO();
                    //us._MaChucNang = row.MaChucNang;
                    us._TenChucNang = row.TenChucNang;
                    dsChucnang.Add(us);
                }
            }
            return dsChucnang;
        }
        public static string TimKiemTheoMaLayTen(int maso)
        {
            string tencn;
            using (Entities tk = new Entities())
            {
                var query = from u in tk.ChucNangs
                            where u.MaChucNang.Equals(maso)
                            select u;
                ChucNang_DO us = new ChucNang_DO();
                foreach (var row in query)
                {
                    us._TenChucNang = row.TenChucNang;
                }
                tencn = us._TenChucNang.ToString();
                return tencn;
            }
        }
    }
}
