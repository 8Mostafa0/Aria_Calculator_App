
namespace Arian_project.Backend {
    public class Client_Installment
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public string client_name { get; set; }
        public int factor_id { get; set; }
        public decimal installment_price { get; set; }
        public string first_installment { get; set; }
        public decimal one_installment_price { get; set; }
        public int installment_count { get; set; }
        public int installment_payed_count { get; set; }
        public bool end_instllment { get; set; }
        public int next_reminder { get; set; }
        public int sms_days { get; set; }
        public string status { get; set; }
        public Client_Installment(int id,int client_id,string client_name, int factor_id,decimal installment_price,string first_installment,decimal one_installment_price,int installment_count,int installment_payed_count = 0,bool end_installment=false,int next_reminder=0,int sms_days=0,string status="بدون بدهی")
        {
            this.id = id;
            this.client_id = client_id;
            this.client_name= client_name;
            this.factor_id = factor_id;
            this.installment_price = installment_price;
            this.first_installment = first_installment;
            this.one_installment_price = one_installment_price;
            this.installment_count = installment_count;
            this.installment_payed_count = installment_payed_count;
            this.end_instllment = end_installment;
            this.next_reminder = next_reminder;
            this.sms_days = sms_days;
            this.status = status;
        }

        public static Client_Installment Create_empty()
        {
            return new Client_Installment(0, 0, "", 0, 0, "", 0, 0, 0, false, 0, 0, "");
        }


    }
}
