using System;
using System.Globalization;

public class iran_date
{
    public int[] Today()
    {
        PersianCalendar pc = new PersianCalendar();
        DateTime today = DateTime.Now;
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