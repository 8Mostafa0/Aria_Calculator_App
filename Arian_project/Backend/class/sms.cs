
namespace Arian_project
{
    public class Sms
    {
        public int id {  get; set; }
        public int client_id { get; set; }
        public string phone_number { get; set; }

        public string sms_status { get; set; }
        public string sms_date { get; set; }

        public Sms(int id, int client_id, string phone_number, string sms_status, string sms_date)
        {
            this.id = id;
            this.client_id = client_id;
            this.phone_number = phone_number;
            this.sms_status = sms_status;
            this.sms_date = sms_date;
        }
    }
}
