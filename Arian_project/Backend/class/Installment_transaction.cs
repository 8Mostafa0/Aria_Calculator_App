
namespace Arian_project.Backend
{
    public class Installment_transaction
    {
        public int id { get; set; }

        public string date { get; set; }
        public decimal price { get; set; }
        public decimal  payed_price { get; set; }
        public string penalty_type { get; set; }
        public decimal penalty_price_per_day { get; set; }
        public decimal penalty { get; set; }
        public  string  status { get; set; }
        public int installment_number { get; set; }
        public  int installment_id { get; set; }
        
        public Installment_transaction(int id, string date, decimal price, decimal payed_price, string penalty_type, decimal penalty_price_per_day , decimal penalty, string status, int installment_number, int installment_id)
        {
            this.id = id;
            this.date = date;
            this.price = price;
            this.payed_price = payed_price;
            this.penalty_type = penalty_type;
            this.penalty_price_per_day = penalty_price_per_day;
            this.penalty = penalty;
            this.status = status;
            this.installment_number = installment_number;
            this.installment_id = installment_id;
        }
    }
}
