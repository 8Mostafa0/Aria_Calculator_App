using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
namespace ghest.Backend.Logs
{
    internal class log
    {


        readonly private static string directory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        readonly private static DateTime Now = DateTime.Now;

        readonly private static PersianCalendar PersianCalender = new PersianCalendar();

        readonly private static int Day = PersianCalender.GetDayOfMonth(Now);

        readonly private static int Month = PersianCalender.GetMonth(Now);

        readonly private static int Year = PersianCalender.GetYear(Now);

        readonly private static int Hour = PersianCalender.GetHour(Now);

        readonly private static int Minuts = PersianCalender.GetMinute(Now);

        readonly static string Dir = directory + "\\log";

        readonly private static string TodayLog = Dir + "\\" + Month.ToString() + " " + Day.ToString() + " LOG.txt";

        readonly private static string TimeStamp = Year.ToString() + "-" + Month.ToString() + "-" + Day.ToString() + "T" + Hour.ToString() + ":" + Minuts.ToString();

        public void init_logs()
        {

            string Firstfile = "";
            var result_log_directorys = check_log_files();

            if (result_log_directorys)
            {
                try
                {

                    Firstfile = Directory.GetFiles(Dir)[-1];

                }
                catch (Exception)
                {

                    Firstfile = "";
                }

            }
            else
            {
                check_log_files();

            }



            if (Firstfile != "")
            {
                Firstfile = Firstfile.Remove(0, Dir.Length + 1);
                var data = Firstfile.Split(' ');
                string ThisMonth = data[0];

                if (int.Parse(ThisMonth) != Month)
                {
                    string[] Files = Directory.GetFiles(Dir);

                    foreach (string FileName in Files)
                    {

                        File.Delete(FileName);

                    }

                    var f = File.Create(TodayLog);
                    f.Close();
                }
            }
            else
            {

                var f = File.Create(TodayLog);
                f.Close();
            }


        }


        private bool check_log_files()
        {
            if (!Directory.Exists(Dir))
            {

                Directory.CreateDirectory(Dir);
            }
            if (!File.Exists(TodayLog))
            {

                var f = File.Create(TodayLog);
                f.Close();

            }

            return true;
        }


        public void record_log(string Message, string TypeOfMessage)
        {
            var Sw = File.AppendText(TodayLog);
            Sw.WriteLine(TimeStamp + " " + TypeOfMessage + " " + Message);
            Sw.Close();
        }

    }
}
