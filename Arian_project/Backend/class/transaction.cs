
namespace Arian_project
{
    public class Transaction
    {
        public int id {  get; set; }
        public string transaction_type { get; set; }
        public string bank {  get; set; }
        public int price { get; set; }
        public int client_id { get; set; }
        public string transaction_date { get; set; }
        public string transaction_status { get; set; }

        public Transaction(int id, string transaction_type, string bank, int price, int client_id, string transaction_date, string transaction_status)
        {
            this.id = id;
            this.transaction_type = transaction_type;
            this.bank = bank;
            this.price = price;
            this.client_id = client_id;
            this.transaction_date = transaction_date;
            this.transaction_status = transaction_status;
        }
    }
}
