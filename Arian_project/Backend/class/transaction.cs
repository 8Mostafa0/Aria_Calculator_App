
namespace Arian_project
{
    public class Transaction
    {
        public int id {  get; set; }
        public string transaction_type { get; set; }
        public string bank {  get; set; }
        public int bank_id {  get; set; }
        public decimal price { get; set; }
        public int client_id { get; set; }
        public string transaction_date { get; set; }
        public int factor_id { get; set; }
        public bool installment_factor { get; set; }

        public Transaction(int id, string transaction_type, string bank, int bank_id, decimal price, int client_id, string transaction_date,int factor_id,bool installment_factor)
        {
            this.id = id;
            this.transaction_type = transaction_type;
            this.bank = bank;
            this.bank_id = bank_id;
            this.price = price;
            this.client_id = client_id;
            this.transaction_date = transaction_date;
            this.factor_id = factor_id;
            this.installment_factor = installment_factor;
        }
    }
}
