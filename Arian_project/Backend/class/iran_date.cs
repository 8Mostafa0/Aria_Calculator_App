using System;
using System.Globalization;

public class iran_date
{
    static PersianCalendar pc = new PersianCalendar();
    static DateTime today = DateTime.Now;
    public int[] Today()
    {
        int persianYear = pc.GetYear(today);
        int persianMonth = pc.GetMonth(today);
        int persianDay = pc.GetDayOfMonth(today);
        int[] date = new int[3];
        date[0] = persianYear;
        date[1] = persianMonth;
        date[2] = persianDay;
        return date;
    }
    public int[] next_months(int month) {
        today.AddMonths(month);
        int persianYear = pc.GetYear(today);
        int persianMonth = pc.GetMonth(today);
        int persianDay = pc.GetDayOfMonth(today);
        int[] date = new int[3];
        date[0] = persianYear;
        date[1] = persianMonth;
        date[2] = persianDay;
        return date;
    }
}