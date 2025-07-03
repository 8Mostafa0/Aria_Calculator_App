
namespace Arian_project
{
    public class Factor
    {
        public int id {  get; set; }
        public int client_id { get; set; }
        public int full_price { get; set; }
        public int profit { get; set; }
        public string factor_date { get; set; }
        public string client_group {  get; set; }

        public Factor(int id,int client_id,int full_price,int profit,string factor_date,string client_group)
        {
            this.id = id;
            this.client_id = client_id;
            this.full_price = full_price;
            this.profit = profit;
            this.factor_date = factor_date;
            this.client_group = client_group;
        }
    }
}
