using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;
using System.Globalization;
namespace BL
{
    public class Hamdungchung
    {
        // Hàm lấy thứ ngày tháng năm 
        public static string Updatetime()
        {

            CultureInfo cInfo = new CultureInfo("vi-VN");
            cInfo.DateTimeFormat.ShortDatePattern = "dddd-MM-yyyy";
            cInfo.DateTimeFormat.DateSeparator = "-";

            string result ="";
            string date = DateTime.Now.ToShortDateString();

            DateTime day = DateTime.Now;
            string dayS = day.DayOfWeek.ToString();
            int dayI = ((int)day.DayOfWeek);
            if (dayI == 0)
            {
                result = "Chủ nhật, Ngày " + date; 
            }
            if (dayI == 1)
            {
                result = "Thứ 2, Ngày " + date;
            }
            if (dayI == 2)
            {
                result = "Thứ 3, Ngày " + date;
            }
            if (dayI == 3)
            {
                result = "Thứ 4, Ngày " + date;
            }
            if (dayI == 4)
            {
                result = "Thứ 5, Ngày " + date;
            }
            if (dayI == 5)
            {
                result = "Thứ 6, Ngày " + date;
            }
            if (dayI == 6)
            {
                result = "Thứ 7, Ngày " + date;
            }
            return result;
        }
    }
}
