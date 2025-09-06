
namespace Arian_project.Backend {
    public class Client_Installment
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public int factor_id { get; set; }
        public decimal installment_price { get; set; }
        public string first_instasllment { get; set; }
        public decimal one_installment_price { get; set; }
        public int installment_count { get; set; }
        public int installment_payed_count { get; set; }
        public bool end_instllment { get; set; }
        public int next_reminder { get; set; }
        public int sms_days { get; set; }
        Client_Installment(int id,int client_id,int factor_id,decimal installment_price,string first_instamment,decimal one_installment_price,int installment_count,int installment_payed_count,bool end_installment,int next_reminder,int sms_days)
        {
            this.id = id;
            this.client_id = client_id;
            this.factor_id = factor_id;
            this.installment_price = installment_price;
            this.first_instasllment = first_instamment;
            this.one_installment_price = one_installment_price;
            this.installment_count = installment_count;
            this.installment_payed_count = installment_payed_count;
            this.end_instllment = end_installment;
            this.next_reminder = next_reminder;
            this.sms_days = sms_days;
        }


    }
}
