using System;
using System.Globalization;
using System.Windows.Forms;

public class Iran_date
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
    public int[] next_months(int month,string from_date="") {
        DateTime start;
        if(from_date != "")
        {
            int[] data = Array.ConvertAll(from_date.Split('/'),Convert.ToInt32);
            start = new DateTime(data[0], data[1], data[2],pc);
            start.AddMonths(month);
        }
        else
        {
            start = today;
        }
        int persianYear = pc.GetYear(start);
        int persianMonth = pc.GetMonth(start);
        int persianDay = pc.GetDayOfMonth(start);
        int[] date = new int[3];
        date[0] = persianYear;
        date[1] = persianMonth;
        date[2] = persianDay;
        return date;
    }

    public int[] next_month_of(int months,string date)
    {
        string[] string_date_data = date.Split('/');
        int[] int_date_data = Array.ConvertAll(string_date_data,int.Parse);
        DateTime date_datetime = pc.ToDateTime(int_date_data[0], int_date_data[1], int_date_data[2],0,0,0,0);
        DateTime newdate = date_datetime.AddMonths(months);
        int persianYear = pc.GetYear(newdate);
        int persianMonth = pc.GetMonth(newdate);
        int persianDay = pc.GetDayOfMonth(newdate);
        int[] data_new_date = new int[3];
        data_new_date[0] = persianYear;
        data_new_date[1] = persianMonth;
        data_new_date[2] = persianDay;
        return data_new_date;
    }
}