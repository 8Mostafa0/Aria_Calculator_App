using Arian_project.Backend.Database;
using ghest.Backend.Logs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Arian_project.Backend
{
    public class Installment_Manager
    {
        static PersianCalendar pc = new PersianCalendar();
        Iran_date date = new Iran_date();
        Arian_project.Properties.Settings props = Properties.Settings.Default;
        Client_installment_database c_installment_db = new Client_installment_database();
        log log = new log();
        public void check_day_status()
        {
            int[] today = date.Today();
            string last_open_app_date = props.last_open_app_date;
            if (last_open_app_date != null && last_open_app_date != "") {
                string[] last_open = last_open_app_date.Split('/');
                if (last_open[0] != today[0].ToString() || last_open[1] != today[1].ToString() || last_open[2] != today[2].ToString())
                {
                    MessageBox.Show("New Date open app", "open app date");
                    bool result = Manage_Installment_by_today();
                    if (result)
                    {
                        update_app_last_open_app_date(today);
                    }
                    else
                    {
                        MessageBox.Show("در هنگام حساب رسی اقساط مشکلی بوجود امده است لطفا برنامه را مجدد باز کنید","مدیریت اقساط");
                    }
                }
            }
        }

        private void update_app_last_open_app_date(int[] today)
        {
            string today_string = today[0] + "/" + today[1] + "/" + today[2];
            props.last_open_app_date = today_string;
        }


        private bool Manage_Installment_by_today()
        {
            bool result = true;
            try
            {

                List<Client_Installment> Installments = c_installment_db.get_client_installment_list();
                int[] today = date.Today();
                foreach (Client_Installment installment in Installments)
                {
                    if (!result)
                    {
                        return result;
                    }
                    int payed = installment.installment_payed_count;
                    int[] installment_date = date.next_month_of(payed, installment.first_installment);
                    DateTime today_date_time = pc.ToDateTime(today[0], today[1], today[2], 0, 0, 0, 0);
                    DateTime installment_datetime = pc.ToDateTime(installment_date[0], installment_date[1], installment_date[2], 0, 0, 0, 0);
                    if (today_date_time >= installment_datetime)
                    {
                        result = set_installment_in_debt(installment);
                    }
                    else
                    {
                        result = get_installment_out_of_debt(installment);
                    }
                }
                result = true;
            }
            catch (Exception ex) { 
                result = false;
                log.record_log("Manage_Installment_by_today", "ERROR => "+ex.ToString());
            }
            return result;
        }

        private bool get_installment_out_of_debt(Client_Installment installment)
        {
            installment.status = "بدون بدهی";
            return c_installment_db.update_client_installment_to_database(installment);
        }
        private bool set_installment_in_debt(Client_Installment installment)
        {
            installment.status = "بدهکار";
            return c_installment_db.update_client_installment_to_database(installment);
        }
    }
}
